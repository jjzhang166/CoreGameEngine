#include "CGameObjectForkBig.h"
#include "CGameManager.h"
#include "CPhysicsManager.h"
#include "CPhysicsProfile.h"
#include "IPhysicsStrategy.h"

#include "OgreEntity.h"
#include "OgreSceneNode.h"
#include "OgreSceneManager.h"
#include "OgreMaterialManager.h"


using namespace Core;

namespace Core
{
namespace Plugin
{

CGameObjectForkBig::CGameObjectForkBig(const char* Name, Vector3& Pos) : CGameObject(Name)
{
	Node = CGameManager::Instance()->GetSceneManager()->getRootSceneNode()->createChildSceneNode(Name + String("_node"), Pos);
	Entity = CGameManager::Instance()->GetSceneManager()->createEntity(Name + String("_entity"), "ForkBig.mesh");
	Entity->setQueryFlags(SQF_GAMEOBJECT);
	Node->attachObject(Entity);
	Entity->setMaterialName("cutlerymat");
MaterialManager::getSingleton().getByName("cutlerymat")->load();
	//Node->setScale(1.0f, 1.0f, 1.0f);

	// TODO: Customize physics profile here
	// ===================================
	PhysicsProfile = Physics::CPhysicsManager::Instance()->GetPhysicsProfile(Physics::CPhysicsManager::DEFAULT_LIGHT_CUBE);
	if(PhysicsProfile)
	{
		Physics::CPhysicsManager::Instance()->GetStrategy()->AddShape(this);
	}
	// ===================================

	GameObjectType = "FORKBIG";
}

void CGameObjectForkBig::Update(const f32& elapsedTime)
{
}

CGameObjectForkBig::~CGameObjectForkBig()
{
	Physics::CPhysicsManager::Instance()->GetStrategy()->DestroyPhysicsBody(this);
}

CGameObjectForkBigFactory::CGameObjectForkBigFactory()
{
	GameObjectType = "FORKBIG";
}

CGameObjectForkBigFactory::~CGameObjectForkBigFactory()
{
}

Core::CGameObject* CGameObjectForkBigFactory::CreateObject(const char* Name, Vector3& Pos)
{
	return new Plugin::CGameObjectForkBig(Name, Pos);
}
}
}
