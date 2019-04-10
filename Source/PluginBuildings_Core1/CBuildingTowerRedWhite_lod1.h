#ifndef __CBUILDINGTOWERREDWHITE_LOD1_H__
#define __CBUILDINGTOWERREDWHITE_LOD1_H__

#include "Defines.h"
#include "CBuilding.h"
#include "Plugins/IBuildingFactory.h"

namespace Core
{
namespace Plugin
{
	class CBuildingTowerRedWhite_lod1 : public CBuilding
	{
	public:
		CBuildingTowerRedWhite_lod1(const char* Name, Physics::IPhysicsStrategy* PhysicsStrategy);
		~CBuildingTowerRedWhite_lod1();

		void Update(const f32& elapsedTime);

	private:
		void SetupMapping();
	};

	class CBuildingTowerRedWhite_lod1Factory : public IBuildingFactory
	{
	public:
		CBuildingTowerRedWhite_lod1Factory();
		~CBuildingTowerRedWhite_lod1Factory();

		CBuilding* CreateBuilding(const char* Name, Physics::IPhysicsStrategy* PhysicsStrategy);
	};
}
}
#endif // __CBUILDINGTOWERREDWHITE_LOD1_H__
