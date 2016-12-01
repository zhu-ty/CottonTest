#include<iostream>
#include<mutex>
#include"MVGevSource.h"
#include"SerialBKServer.h"

int main()
{
	printf("HelloWorld!\n");
	std::shared_ptr<CMvGevSource> mCamera;
	std::shared_ptr<mutex> mMutex;

	mCamera.reset(new CMvGevSource());
	mMutex.reset(new mutex());

	if (mCamera->Open(NULL, NULL, 0))
	{
		mCamera->ip[2];
		//unsigned int x;
		//mCamera->mSerial->SetRegValue(0, 0xff0e, 99);
		//mCamera->mSerial->GetRegValue(0, 0xff0e, x);
		//printf("0x%x\n", x);
	}
	else
	{
		printf("Camera open failed\n");
		system("pause");
		return 0;
	}

	SerialBKServer server(mCamera, mMutex);
	server.start();

	char command[100] = { 0 };
	while (true)
	{
		memset(command, 0, sizeof(command));
		scanf_s("%s", command, 99);
		if (memcmp(command, "exit", 4) == 0)
			break;
	}
	printf("system ended\n");
	system("pause");
	return 0;
}