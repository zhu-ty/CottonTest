#pragma once

#define RAW_DATA_LENTH 12

struct RawDataPack
{
	unsigned char data[RAW_DATA_LENTH];
	unsigned int avg;
};