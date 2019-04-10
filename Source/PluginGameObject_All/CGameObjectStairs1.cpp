#include "CGameObjectStairs1.h"
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

CGameObjectStairs1::CGameObjectStairs1(const char* Name, Vector3& Pos) : CGameObject(Name)
{
	Node = CGameManager::Instance()->GetSceneManager()->getRootSceneNode()->createChildSceneNode(Name + String("_node"), Pos);
	Entity = CGameManager::Instance()->GetSceneManager()->createEntity(Name + String("_entity"), "Stairs1.mesh");
	Entity->setQueryFlags(SQF_GAMEOBJECT);
	Node->attachObject(Entity);
	Entity->setMaterialName("floor03_d");
MaterialManager::getSingleton().getByName("floor03_d")->load();
	//Node->setScale(1.0f, 1.0f, 1.0f);

	// TODO: Customize physics profile here
	// ===================================
	PhysicsProfile = Physics::CPhysicsManager::Instance()->GetPhysicsProfile(Physics::CPhysicsManager::DEFAULT_LIGHT_CUBE);
	if(PhysicsProfile)
	{
		Physics::CPhysicsManager::Instance()->GetStrategy()->AddShape(this);
	}
	// ===================================

	GameObjectType = "STAIRS1";
}

void CGameObjectStairs1::Update(const f32& elapsedTime)
{
}

CGameObjectStairs1::~CGameObjectStairs1()
{
	Physics::CPhysicsManager::Instance()->GetStrategy()->DestroyPhysicsBody(this);
}

CGameObjectStairs1Factory::CGameObjectStairs1Factory()
{
	GameObjectType = "STAIRS1";
}

CGameObjectStairs1Factory::~CGameObjectStairs1Factory()
{
}

Core::CGameObject* CGameObjectStairs1Factory::CreateObject(const char* Name, Vector3& Pos)
{
	return new Plugin::CGameObjectStairs1(Name, Pos);
}
}
}
