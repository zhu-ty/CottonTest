#include<iostream>
#include<mutex>
#include"MVGevSource.h"
#include"SerialBKServer.h"
#include"DataModel.h"
#include<PvPixelType.h>

#define SERVER_MODE_ENABLE

typedef unsigned int uint;

uint cap_num = 0;
std::shared_ptr<mutex> mMutex;
std::shared_ptr<RawDataPack> data_pack;
int CapCallBack(PvImage* pData, void* pUserData);


uint ByteToshort(unsigned char * bytes)
{
	uint i = 0;
	i += (uint)(bytes[0]);
	i += ((uint)(bytes[1]) << 8) & 0xff00;
	return i;
}

void shortToByte(uint i, unsigned char * bytes)
{
	memset(bytes, 0, sizeof(unsigned char) * 2);
	bytes[0] = (unsigned char)(0xff & i);
	bytes[1] = (unsigned char)((0xff00 & i) >> 8);
	return;
}


//Remember data will be split into pack(s), each pack contains 12 bytes and they will represent 6 ShortInts.
//So the data lenth must be more than (12 * avg_count) bytes.
//The returned bytes will contain 6 ShortInts as 12 bytes, low byte first.
void avg_function(unsigned char *data, unsigned char *avg_ans, uint avg_count)
{
	uint to_avg[RAW_DATA_LENTH / 2] = { 0 };
	memset(to_avg, 0, sizeof(uint) * RAW_DATA_LENTH / 2);
	for (uint i = 0; i < avg_count; i++)
	{
		for (uint j = 0; j < RAW_DATA_LENTH / 2; j++)
		{
			to_avg[j] += ByteToshort(data + i * RAW_DATA_LENTH + j * 2);
		}
	}
	for (uint j = 0; j < RAW_DATA_LENTH / 2; j++)
	{
		unsigned char tmp[2];
		to_avg[j] = to_avg[j] / avg_count;
		shortToByte(to_avg[j], tmp);
		memcpy(avg_ans + j * 2, tmp, 2);
	}
}

int main()
{
	printf("HelloWorld!\n");
	std::shared_ptr<CMvGevSource> mCamera;

	mCamera.reset(new CMvGevSource());
	mMutex.reset(new mutex());
	data_pack.reset(new RawDataPack());
	data_pack->avg = 100;


	if (mCamera->Open(NULL, NULL, 0))
	{
		mCamera->ip[2];
		mCamera->SetCallback(CapCallBack, nullptr);
	}
	else
	{
		printf("Camera open failed\n");
		system("pause");
		return 0;
	}
	auto para = mCamera->lDevice->GetParameters();
	para->SetEnumValue("PixelFormat", PvPixelMono12);
	para->SetIntegerValue("Height", 100);
	para->SetIntegerValue("Width", 80);
	mCamera->mSerial->SetRegValue(0, 0xff79, 100);
	mCamera->mSerial->SetRegValue(0, 0xff80, 80);
	mCamera->Start(0, 1);
	
#ifdef SERVER_MODE_ENABLE
	SerialBKServer server(mCamera, mMutex, data_pack);
	server.start();
#endif
	char command[100] = { 0 };
	while (true)
	{
		memset(command, 0, sizeof(command));
		scanf_s("%s", command, 99);
		if (memcmp(command, "exit", 4) == 0)
			break;
	}
	mCamera->Stop(0, 1);
	printf("system ended\n");
	system("pause");
	return 0;
}

int CapCallBack(PvImage* pData, void* pUserData)
{
	cap_num++;
	PBYTE lDataPtr = pData->GetDataPointer();
	if (cap_num % 31 == 0)
	{
		for (int i = 0; i < RAW_DATA_LENTH; i++)
			printf("0x%02x ", *(lDataPtr + i));
		printf("\n");
	}
	mMutex->lock();
	uint real_avg = max(min(80 * 2 * 100 / RAW_DATA_LENTH, data_pack->avg),1);
	mMutex->unlock();
	unsigned char avg_ans[RAW_DATA_LENTH];

	avg_function(lDataPtr, avg_ans, real_avg);
	mMutex->lock();
	memcpy(data_pack->data, avg_ans, RAW_DATA_LENTH);
	mMutex->unlock();
	return true;
}


/*

unsigned char x[] = {
0x5D,0x21,0x5D,0x21,
0x5D,0x21,0x5D,0x21,
0x5D,0x21,0x5D,0x21,

0xFA,0x04,0xFA,0x04,
0xFA,0x04,0xFA,0x04,
0xFA,0x04,0xFA,0x04,

0xBC,0x19,0xBC,0x19,
0xBC,0x19,0xBC,0x19,
0xBC,0x19,0xBC,0x19,
};

//return will be 0x5B 0x15


unsigned char aaaa[12] = { 0 };
avg_function(x, aaaa, 3);
for (int i = 0; i < 12; i ++ )
{
printf("%#02x ", aaaa[i]);
}

system("pause");
return 0;
*/