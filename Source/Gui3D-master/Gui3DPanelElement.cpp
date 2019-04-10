/*
    Gui3D
    -------
    
    Copyright (c) 2012 Valentin Frechaud
                                                                                  
    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:
                                                                                  
    The above copyright notice and this permission notice shall be included in
    all copies or substantial portions of the Software.
                                                                                  
    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
    THE SOFTWARE.
*/


#include "Gui3DPanelElement.h"
#include "CInputEvent.h"

namespace Gui3D
{

PanelElement::PanelElement(Container* parentContainer)
    : mHasFocus(false), mOvered(false),
      mParentContainer(parentContainer)
{
}


PanelElement::~PanelElement()
{
}


bool PanelElement::getOvered()
{
    return mOvered;
}


bool PanelElement::getFocus()
{
    return mHasFocus;
}


PanelColors* PanelElement::getColors()
{
    return mParentContainer->getPanelColors();
}


void PanelElement::setFocus(bool hasFocus)
{
    mHasFocus = hasFocus;
    _actualize();
}


void PanelElement::setOvered(bool overed)
{
    mOvered = overed;
    _actualize();
}


void PanelElement::resetState()
{
    mOvered = false;
    mHasFocus = false;
    _actualize();
}

void PanelElement::injectKeyPressed(const Core::CInputKeyEvent& evt)
{
	OIS::KeyEvent event(nullptr, (OIS::KeyCode)evt.KeyCode, evt.Text);
	injectKeyPressed(event);
}

void PanelElement::injectKeyReleased(const Core::CInputKeyEvent& evt)
{
	OIS::KeyEvent event(nullptr, (OIS::KeyCode)evt.KeyCode, evt.Text);
	this->injectKeyReleased(event);
}

void PanelElement::injectMousePressed(const Core::CInputMouseEvent& evt, Core::MouseButtonID id)
{
	OIS::MouseState ms;
	GetMouseState(evt, ms);
	OIS::MouseEvent event(nullptr, ms);
	injectMousePressed(event, (OIS::MouseButtonID)id);
}

void PanelElement::injectMouseReleased(const Core::CInputMouseEvent& evt, Core::MouseButtonID id)
{
	OIS::MouseState ms;
	GetMouseState(evt, ms);
	OIS::MouseEvent event(nullptr, ms);
	injectMouseReleased(event, (OIS::MouseButtonID)id);
}

void PanelElement::GetMouseState(const Core::CInputMouseEvent& CoreMouseEvent, OIS::MouseState& MouseEvent)
{
	MouseEvent.buttons = CoreMouseEvent.buttons;
	MouseEvent.X.abs = CoreMouseEvent.absX;
	MouseEvent.Y.abs = CoreMouseEvent.absY;
	MouseEvent.Z.abs = CoreMouseEvent.absZ;
	MouseEvent.X.absOnly = CoreMouseEvent.absOnlyX;
	MouseEvent.Y.absOnly = CoreMouseEvent.absOnlyY;
	MouseEvent.Z.absOnly = CoreMouseEvent.absOnlyZ;
	MouseEvent.X.rel = CoreMouseEvent.relX;
	MouseEvent.Y.rel = CoreMouseEvent.relY;
	MouseEvent.Z.rel = CoreMouseEvent.relZ;
	MouseEvent.height = CoreMouseEvent.height;
	MouseEvent.width = CoreMouseEvent.width;
	MouseEvent.buttons = CoreMouseEvent.buttons;
}

}