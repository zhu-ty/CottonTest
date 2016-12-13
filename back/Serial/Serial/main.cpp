#include<iostream>
#include<mutex>
#include"MVGevSource.h"
#include"SerialBKServer.h"
#include"DataModel.h"
#include<PvPixelType.h>

#define SERVER_MODE_ENABLE

int cap_num = 0;
std::shared_ptr<mutex> mMutex;
std::shared_ptr<RawDataPack> data_pack;
int CapCallBack(PvImage* pData, void* pUserData);


unsigned int ByteToshort(unsigned char * bytes)
{
	unsigned int i = 0;
	i += (unsigned int)(bytes[0]);
	i += ((unsigned int)(bytes[1]) << 8) & 0xff00;
	return i;
}

void shortToByte(unsigned int i, unsigned char * bytes)
{
	memset(bytes, 0, sizeof(unsigned char) * 2);
	bytes[0] = (unsigned char)(0xff & i);
	bytes[1] = (unsigned char)((0xff00 & i) >> 8);
	return;
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
	unsigned int real_avg = max(min(80 * 2 * 100 / RAW_DATA_LENTH, data_pack->avg),1);
	mMutex->unlock();
	unsigned int to_avg[RAW_DATA_LENTH / 2] = { 0 };
	memset(to_avg, 0, sizeof(unsigned int) * RAW_DATA_LENTH / 2);
	for (int i = 0; i < real_avg; i++)
	{
		for (int j = 0; j < RAW_DATA_LENTH / 2; j++)
		{
			to_avg[j] += ByteToshort(lDataPtr + i * RAW_DATA_LENTH + j * 2);
		}
	}
	unsigned char avg_ans[RAW_DATA_LENTH];
	for (int j = 0; j < RAW_DATA_LENTH / 2; j++)
	{
		unsigned char tmp[2];
		to_avg[j] = to_avg[j] / real_avg;
		shortToByte(to_avg[j], tmp);
		memcpy(avg_ans + j * 2, tmp, 2);
	}
	mMutex->lock();
	memcpy(data_pack->data, avg_ans, RAW_DATA_LENTH);
	mMutex->unlock();
	return true;
}