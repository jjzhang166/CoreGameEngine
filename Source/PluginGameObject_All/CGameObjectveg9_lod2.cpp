#include "CGameObjectVeg9_lod2.h"
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

CGameObjectVeg9_lod2::CGameObjectVeg9_lod2(const char* Name, Vector3& Pos) : CGameObject(Name)
{
	Node = CGameManager::Instance()->GetSceneManager()->getRootSceneNode()->createChildSceneNode(Name + String("_node"), Pos);
	Entity = CGameManager::Instance()->GetSceneManager()->createEntity(Name + String("_entity"), "veg9_lod2.mesh");
	Entity->setQueryFlags(SQF_GAMEOBJECT);
	Node->attachObject(Entity);
	Entity->setMaterialName("_veg9_lod2palm1_trunk_df");
MaterialManager::getSingleton().getByName("_veg9_lod2palm1_trunk_df")->load();
	//Node->setScale(1.0f, 1.0f, 1.0f);

	// TODO: Customize physics profile here
	// ===================================
	PhysicsProfile = Physics::CPhysicsManager::Instance()->GetPhysicsProfile(Physics::CPhysicsManager::DEFAULT_LIGHT_CUBE);
	if(PhysicsProfile)
	{
		Physics::CPhysicsManager::Instance()->GetStrategy()->AddShape(this);
	}
	// ===================================

	GameObjectType = "VEG9_LOD2";
}

void CGameObjectVeg9_lod2::Update(const f32& elapsedTime)
{
}

CGameObjectVeg9_lod2::~CGameObjectVeg9_lod2()
{
	Physics::CPhysicsManager::Instance()->GetStrategy()->DestroyPhysicsBody(this);
}

CGameObjectVeg9_lod2Factory::CGameObjectVeg9_lod2Factory()
{
	GameObjectType = "VEG9_LOD2";
}

CGameObjectVeg9_lod2Factory::~CGameObjectVeg9_lod2Factory()
{
}

Core::CGameObject* CGameObjectVeg9_lod2Factory::CreateObject(const char* Name, Vector3& Pos)
{
	return new Plugin::CGameObjectVeg9_lod2(Name, Pos);
}
}
}
