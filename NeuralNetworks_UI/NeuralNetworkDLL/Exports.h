
extern "C"
{
	__declspec(dllexport) void StartTraining(
		const char* iStrPosFilePath, const char* iStrNegFilePath,
		const char* pNeuronsCountArr, int sizeOfArr,
		double iAccuracy,
		double iLearningRate);

	__declspec(dllexport) const char* SetModelFolderPathAnTest(const char* iStrModelFolderPath, const char* iStrTestingFilePath);

	__declspec(dllexport) const char* Test(const char* str);
}
