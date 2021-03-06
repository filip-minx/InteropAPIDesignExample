// CPPAPI.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <vector>
#include <map>
#define DllExport extern "C" __declspec( dllexport )

using namespace std;

class Entity
{
public:
	int id;
	int value;
};

class API
{
public:
	 map<int, Entity*> entities;// = new map<int, Entity>();
	 int lastId = 0;

	int createEntity()
	{
		auto id = API::lastId++;

		Entity* entity = new Entity();
		entity->id = id;
		entities.insert(std::pair<int, Entity*>(id, entity));

		return id;
	}

	Entity* p_createEntity()
	{
		auto id = API::lastId++;

		Entity* entity = new Entity();
		entity->id = id;

		entities.insert(std::pair<int, Entity*>(id, entity));

		return entity;
	}

	int getEntityValue(int entityId)
	{
		auto entity = entities.at(entityId);
		return entity->value;
	}

	void setEntityValue(int entityId, int value)
	{
		auto entity = entities[entityId];
		entity->value = value;
	}

	int p_getEntityValue(Entity* entity)
	{
		return entity->value;
	}

	void p_setEntityValue(Entity* entity, int value)
	{
		entity->value = value;
	}

	void deleteEntity(Entity* entity)
	{
		//cout << "entity deleted" << endl;
		entities.erase(entity->id);
		delete entity;
		entity = nullptr;
	}
};

API api;

DllExport int createEntity()
{
	return api.createEntity();
}

DllExport Entity* p_createEntity()
{
	return api.p_createEntity();
}

DllExport int getEntityValue(int entityId)
{
	return api.getEntityValue(entityId);
}

DllExport void setEntityValue(int entityId, int value)
{
	return api.setEntityValue(entityId, value);
}

DllExport int p_getEntityValue(Entity* entity)
{
	return api.p_getEntityValue(entity);
}

DllExport void p_setEntityValue(Entity* entity, int value)
{
	return api.p_setEntityValue(entity, value);
}

DllExport void deleteEntity(Entity* entity)
{
	return api.deleteEntity(entity);
}

int main()
{
	
    return 0;
}

