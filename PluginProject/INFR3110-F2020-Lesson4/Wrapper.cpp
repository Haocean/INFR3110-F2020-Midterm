#include "Wrapper.h"
#include "GameObject.h"

CheckpointTimeLogger timeLogger;

GameObject gameObject;

PLUGIN_API int GetID()
{
	return gameObject.GetID();
}

PLUGIN_API void SetID(int id)
{
	gameObject.SetID(id);
}

PLUGIN_API Vector2D GetPosition()
{
	return gameObject.GetPosition();
}

PLUGIN_API void SetPosition(float x, float y)
{
	gameObject.SetPosition(x, y);
}

PLUGIN_API void RestLogger()
{
	return timeLogger.ResetLogger();
}

PLUGIN_API void SaveCheckpointTime(float RTBC)
{
	return timeLogger.SaveCheckPointTime(RTBC);
}

PLUGIN_API float GetTotalTime()
{
	return timeLogger.GetTotalTime();
}

PLUGIN_API float GetCheckPointTime(int index)
{
	return timeLogger.GetCheckpointTime(index);
}

PLUGIN_API int GetHumCheckPoint()
{
	return timeLogger.GetNumCheckPoints();
}
