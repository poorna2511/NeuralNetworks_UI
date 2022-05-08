#include "CSVFileHandler.h"

vector<vector<double>> read_record(string iStrCSVFilePath)
{
	fstream fin;
	fin.open(iStrCSVFilePath, ios::in);

	// Read the Data from the file
	// as String Vector
	vector<vector<double>> data;
	string line, word, temp;

	while (fin >> temp) {

		vector<double> row;

		// read an entire row and
		// store it in a string variable 'line'
		getline(fin, line);

		// used for breaking words
		stringstream s(line);

		// read every column data of a row and
		// store it in a string variable, 'word'
		while (getline(s, word, ',')) {

			// add all the column data
			// of a row to a vector
			double val = stod(word);

			row.push_back(val);
		}

		data.push_back(row);
	}

	fin.close();

	return data;
}
