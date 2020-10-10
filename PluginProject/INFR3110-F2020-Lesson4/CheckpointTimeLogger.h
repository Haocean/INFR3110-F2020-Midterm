#pragma once
#include "PluginSettings.h"

#include <vector>

class PLUGIN_API CheckpointTimeLogger
{
public:
	void ResetLogger();

	void SaveCheckPointTime(float RTBC);

	float GetTotalTime();
	float GetCheckpointTime(int index);
	int GetNumCheckPoints();

private:
	float m_TRT = 0.0f;
	std::vector<float> m_RTBC;

};

