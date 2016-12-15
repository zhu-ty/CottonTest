#pragma once

#define RAW_DATA_LENTH 12

#define CAMERA_MODE_ENABLE
#define SERVER_MODE_ENABLE

struct RawDataPack
{
	unsigned char data[RAW_DATA_LENTH];
	unsigned int avg;
};