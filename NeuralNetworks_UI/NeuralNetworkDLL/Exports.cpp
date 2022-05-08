#include "CNeuralNetwork.h"
#include "CSVFileHandler.h"

#include <iostream>
#include <vector>

#include "Exports.h"

using namespace std;

void StartTraining(
	const char* iStrPosFilePath, const char* iStrNegFilePath,
	const char* pNeuronsCountArr, int sizeOfArr,
	double iAccuracy,
	double iLearningRate)
{
	string strPosFilePath(iStrPosFilePath);
	vector<vector<double>> posData = read_record(strPosFilePath);

	string strNegFilePath(iStrNegFilePath);
	vector<vector<double>> negData = read_record(strNegFilePath);
	
	vector<int> hiddenLayerNeuronCount;
	for (int hidLayerIdx = 0; hidLayerIdx < sizeOfArr; hidLayerIdx++)
		hiddenLayerNeuronCount.push_back(pNeuronsCountArr[hidLayerIdx]);

	CNeuralNetwork nnObj(posData, negData,
						hiddenLayerNeuronCount,
						iAccuracy,
						iLearningRate);

	nnObj.StartTraining();
}

const char* SetModelFolderPathAnTest(const char* iStrModelFolderPath, const char* iStrTestingFilePath)
{
	string strModelFolderPath(iStrModelFolderPath);
	CNeuralNetwork nnObj(strModelFolderPath);

	string strTestingFilePath(iStrTestingFilePath);
	vector<vector<double>> allTestData = read_record(strTestingFilePath);

	string strResults = "";
	for (int testIdx = 0; testIdx < allTestData.size(); testIdx++)
	{
		vector<double> testData = allTestData[testIdx];

		nnObj.SetInputLayerData(testData);
		nnObj.PropagateForwardFrom(1);

		double output = nnObj.GetOutput();

		strResults = strResults + to_string(output);
	}

	int len = strResults.length() + 1;
	char *strTemp = new char[len];
	strcpy(strTemp, strResults.c_str());

	return strTemp;

	//return strResults.c_str();
}

const char* Test(const char* str)
{
	string str1(str);
	string str2 = str1 + "_dfffeess";

	int len = str2.length() + 1;
	char *strTemp = new char[len];
	strcpy(strTemp, str2.c_str());

	//const char *strRet = new char[len];
	//strRet = strTemp;

	return strTemp;
}
