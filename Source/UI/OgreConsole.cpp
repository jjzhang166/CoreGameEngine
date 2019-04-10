#include "OgreConsole.h"
#include "Core\CGameManager.h"
#include "Core\CGameObjectManager.h"
#include "Core\CPluginManager.h"
#include "Core\CPlayer.h"
#include "Core\CTextOutput.h"
#include "Core\CUtility.h"
#include "IO/CoreLogging.h"

#include "Gorilla.h"

#include "OIS/OISKeyboard.h"

#include "OgreFont.h"
#include "OgreFontManager.h"
#include "OgreRectangle2D.h"
#include "OgreRoot.h"
#include "OgreRenderWindow.h"
#include "OgreMaterialManager.h"
#include "OgreOverlayElement.h"
#include "OgreOverlay.h"
#include "OgreOverlayManager.h"
#include "OgreOverlayContainer.h"
#include "OgreStringVector.h"

#define CONSOLE_FONT_INDEX 14
#define CONSOLE_LINE_LENGTH 85
#define CONSOLE_LINE_COUNT 15
static const unsigned char legalchars[]="ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890+!\"'#%&/()=?[]\\*-_.:,; ";

OgreConsole* OgreConsole::Console = nullptr;

OgreConsole* OgreConsole::Instance()
{
	if(!Console)
		Console = new OgreConsole();
	return Console;
}

OgreConsole::OgreConsole() : isVisible(true), isInitialised(false), m_Screen(nullptr), m_UpdateConsole(false), m_UpdatePrompt(false), m_Startline(0)
{
	//m_Parser = new CConsoleParser();
	m_GameObjectManager = Core::CGameObjectManager::Instance();

	isShowFpsInfo = false;
	isShowPos = false;
}

OgreConsole::~OgreConsole()
{
	if (isInitialised)
		Shutdown();
}

void OgreConsole::Init(Gorilla::Screen* screen)
{

	if(mIsInitialised)
		shutdown();

	Ogre::Root::getSingletonPtr()->addFrameListener(this);
	Ogre::LogManager::getSingleton().getDefaultLog()->addListener(this);

	// Create gorilla things here.
	mScreen = screen;
	mLayer = mScreen->createLayer(15);
	mGlyphData = mLayer->_getGlyphData(CONSOLE_FONT_INDEX); // Font.CONSOLE_FONT_INDEX

	mConsoleText = mLayer->createMarkupText(CONSOLE_FONT_INDEX,  10,10, Ogre::StringUtil::BLANK);
	mConsoleText->width(mScreen->getWidth() - 10);
	mPromptText = mLayer->createCaption(CONSOLE_FONT_INDEX,  10,10, "> _");
	mDecoration = mLayer->createRectangle(8,8, mScreen->getWidth() - 16, mGlyphData->mLineHeight );
	mDecoration->background_gradient(Gorilla::Gradient_NorthSouth, Gorilla::rgb(128,128,128,128), Gorilla::rgb(64,64,64,128));
	mDecoration->border(2, Gorilla::rgb(128,128,128,128));

	mIsInitialised = true;

	print("%5Ogre%R%6Console%0 Activated. Press F1 to show/hide.%R");
}

void OgreConsole::shutdown()
{
	if(!mIsInitialised)
		return;

	mIsInitialised = false;

	Ogre::Root::getSingletonPtr()->removeFrameListener(this);
	Ogre::LogManager::getSingleton().getDefaultLog()->removeListener(this);

	mScreen->destroy(mLayer);

}


void OgreConsole::onKeyPressed(const OIS::KeyEvent &arg)
{

	if(!mIsVisible)
		return;

	if (arg.key == OIS::KC_RETURN || arg.key == OIS::KC_NUMPADENTER)
	{

		print("%3> " + prompt + "%R");

		//split the parameter list
		Ogre::StringVector params = Ogre::StringUtil::split(prompt, " ");

		if (params.size())
		{
			std::map<Ogre::String, OgreConsoleFunctionPtr>::iterator i;
			for(i=commands.begin();i!=commands.end();i++){
				if((*i).first==params[0]){
					if((*i).second)
						(*i).second(params);
					break;
				}
			}
			prompt.clear();
			mUpdateConsole = true;
			mUpdatePrompt = true;
		}
	}

	else if (arg.key == OIS::KC_BACK)
	{
		if (prompt.size())
		{
			prompt.erase(prompt.end() - 1); //=prompt.substr(0,prompt.length()-1);
			mUpdatePrompt = true;
		}
	}
	else if (arg.key == OIS::KC_PGUP)
	{
		if(mStartline>0)
			mStartline--;
		mUpdateConsole = true;
	}

	else if (arg.key == OIS::KC_PGDOWN)
	{
		if(mStartline<lines.size())
			mStartline++;
		mUpdateConsole = true;
	}

	else
	{
		for(unsigned int c=0;c<sizeof(legalchars);c++){
			if(legalchars[c]==arg.text){
				prompt+=arg.text;
				break;
			}
		}
		mUpdatePrompt = true;
	}

}

bool OgreConsole::frameStarted(const Ogre::FrameEvent &evt)
{
	if(mUpdateConsole)
		updateConsole();

	if (mUpdatePrompt)
		updatePrompt();

	return true;
}

void OgreConsole::updateConsole()
{

	mUpdateConsole = false;

	std::stringstream text;
	std::list<Ogre::String>::iterator i,start,end;

	//make sure is in range
	if(mStartline>lines.size())
		mStartline=lines.size();

	int lcount=0;
	start=lines.begin();
	for(unsigned int c=0;c<mStartline;c++)
		start++;
	end=start;
	for(unsigned int c=0;c<CONSOLE_LINE_COUNT;c++){
		if(end==lines.end())
			break;
		end++;
	}

	for(i=start;i!=end;i++)
	{
		lcount++;
		text << (*i) << "\n";
	}
	mConsoleText->text(text.str());

	// Move prompt downwards.
	mPromptText->top(10 + (lcount * mGlyphData->mLineHeight));

	// Change background height so it covers the text and prompt
	mDecoration->height(((lcount+1) * mGlyphData->mLineHeight) + 4);

	mConsoleText->width(mScreen->getWidth() - 20);
	mDecoration->width(mScreen->getWidth() - 16);
	mPromptText->width(mScreen->getWidth() - 20);

}

void OgreConsole::updatePrompt()
{
	mUpdatePrompt = false;
	std::stringstream text;
	text << "> " << prompt << "_";
	mPromptText->text(text.str());
}

void OgreConsole::print(const String &text)
{
	//subdivide it into lines
	const char *str=text.c_str();
	int len=text.length();
	Ogre::String line;
	for(int c=0;c<len;c++){
		if(str[c]=='\n'||line.length()>=CONSOLE_LINE_LENGTH){
			lines.push_back(line);
			line="";
		}
		if(str[c]!='\n')
			line+=str[c];
	}
	if(line.length())
		lines.push_back(line);
	if(lines.size()>CONSOLE_LINE_COUNT)
		mStartline=lines.size()-CONSOLE_LINE_COUNT;
	else
		mStartline=0;
	mUpdateConsole=true;
}

bool OgreConsole::frameEnded(const Ogre::FrameEvent &evt)
{
	return true;
}

void OgreConsole::setVisible(bool isVisible)
{
	mIsVisible = isVisible;
	mLayer->setVisible(mIsVisible);
}

void OgreConsole::addCommand(const String &command, OgreConsoleFunctionPtr func)
{
	commands[command]=func;
}

void OgreConsole::removeCommand(const String &command)
{
	commands.erase(commands.find(command));
}
