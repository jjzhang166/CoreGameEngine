#include "CGameObjectBench.h"
#include "CGameManager.h"
#include "CPhysicsManager.h"
#include "CPhysicsProfile.h"
#include "IPhysicsStrategy.h"

#include "OgreEntity.h"
#include "OgreSceneNode.h"
#include "OgreSceneManager.h"


using namespace Core;

namespace Core
{
namespace Plugin
{

CGameObjectBench::CGameObjectBench(const char* Name, Vector3& Pos) : CGameObject(Name)
{
	Node = CGameManager::Instance()->GetSceneManager()->getRootSceneNode()->createChildSceneNode(Name + String("_node"), Pos);
	Entity = CGameManager::Instance()->GetSceneManager()->createEntity(Name + String("_entity"), "Bench.mesh");
	Entity->setQueryFlags(SQF_GAMEOBJECT);
	Node->attachObject(Entity);
	//Node->setScale(1.0f, 1.0f, 1.0f);

	// TODO: Customize physics profile here
	// ===================================
	PhysicsProfile = Physics::CPhysicsManager::Instance()->GetPhysicsProfile(Physics::CPhysicsManager::DEFAULT_LIGHT_CUBE);
	if(PhysicsProfile)
	{
		Physics::CPhysicsManager::Instance()->GetStrategy()->AddShape(this);
	}
	// ===================================

	GameObjectType = "BENCH";
}

void CGameObjectBench::Update(const f32& elapsedTime)
{
}

CGameObjectBench::~CGameObjectBench()
{
	Physics::CPhysicsManager::Instance()->GetStrategy()->DestroyPhysicsBody(this);
}

CGameObjectBenchFactory::CGameObjectBenchFactory()
{
	GameObjectType = "BENCH";
}

CGameObjectBenchFactory::~CGameObjectBenchFactory()
{
}

Core::CGameObject* CGameObjectBenchFactory::CreateObject(const char* Name, Vector3& Pos)
{
	return new Plugin::CGameObjectBench(Name, Pos);
}
}
}
