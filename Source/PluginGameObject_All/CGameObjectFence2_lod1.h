#ifndef __CGAMEOBJECTFENCE2_LOD1_H__
#define __CGAMEOBJECTFENCE2_LOD1_H__

#include "CGameObject.h"
#include "Plugins/IGameObjectFactory.h"

namespace Core
{
namespace Plugin
{
	class CGameObjectFence2_lod1 : public CGameObject
	{
	public:
		CGameObjectFence2_lod1(const char* Name, Vector3& Pos);
		~CGameObjectFence2_lod1();

		void Update(const f32& elapsedTime);

	};

	class CGameObjectFence2_lod1Factory : public IGameObjectFactory
	{
	public:
		CGameObjectFence2_lod1Factory();
		~CGameObjectFence2_lod1Factory();

		CGameObject* CreateObject(const char* Name, Vector3& Pos);
	};
}
}

#endif // __CGAMEOBJECTFENCE2_LOD1_H__
