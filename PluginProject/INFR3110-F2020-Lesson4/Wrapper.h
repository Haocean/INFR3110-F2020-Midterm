#pragma once
#ifndef __WRAPPER__
#define __WRAPPER__

#include "PluginSettings.h"
#include "Vector2D.h"
#include "CheckpointTimeLogger.h"

#ifdef __cplusplus
extern "C"
{
#endif

	PLUGIN_API int GetID();

	PLUGIN_API void SetID(int id);
	
	PLUGIN_API Vector2D GetPosition();
	
	PLUGIN_API void SetPosition(float x, float y);

	// Put your functions here
	PLUGIN_API void RestLogger();
	// Save most recent checkpoint time
	PLUGIN_API void SaveCheckpointTime(float RTBC);
	// Get total time for race
	PLUGIN_API float GetTotalTime();
	// Get checkpoint time at index
	PLUGIN_API float GetCheckPointTime(int index);
	// Get number of Checkpoints Saved
	PLUGIN_API int GetHumCheckPoint();

#ifdef __cplusplus
}
#endif

#endif