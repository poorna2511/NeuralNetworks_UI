using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetworkUI
{
    public partial class Form1 : Form
    {
        [DllImport("NeuralNetworkDLL.dll")]
        //[DllImport("D:\\just\\NeuralNetworks_UI\\NeuralNetworkUI\\bin\\Debug\\NeuralNetworks.dll")]
        public static extern void StartTraining(
                                  String iStrPosFilePath, String iStrNegFilePath,
                                  String pNeuronsCountArr, int sizeOfArr,
                                  double iAccuracy,
                                  double iLearningRate);

        [DllImport("NeuralNetworkDLL.dll")]
        //[DllImport("D:\\just\\NeuralNetworks_UI\\NeuralNetworkUI\\bin\\Debug\\NeuralNetworks.dll")]
        public static extern IntPtr SetModelFolderPathAnTest(String iStrModelFolderPath, String iStrTestingFilePath);

        [DllImport("NeuralNetworkDLL.dll")]
        //[DllImport("D:\\just\\NeuralNetworks_UI\\NeuralNetworkUI\\bin\\Debug\\NeuralNetworks.dll")]
        public static extern IntPtr Test(String str);
        
        public Form1()
        {
            InitializeComponent();

            PopulteTheHiddenLayerTable();
        }

        private void PopulteTheHiddenLayerTable()
        {
            int numOfHiddenLayers = (int)NumOfHiddenLayers.Value;

            HiddenLayerNeuronsCount.RowCount = numOfHiddenLayers;

            for(int rowIdx = 0; rowIdx < numOfHiddenLayers; rowIdx++)
            {
                HiddenLayerNeuronsCount.Rows[rowIdx].Cells[0].Value = "Layer " + (rowIdx + 1);
            }
        }

        private void Testing_Click(object sender, EventArgs e)
        {

        }

        private void Training_Click(object sender, EventArgs e)
        {

        }

        private void PosBrowseBtn_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string strFilePath = openFileDialog1.FileName;
                PosDataFilePath.Text = strFilePath;
            }
        }

        private void NegBrowseBtn_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string strFilePath = openFileDialog1.FileName;
                NegDataFilePath.Text = strFilePath;
            }
        }

        private void AccuracyReq_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void HiddenLayerNeuronsCount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 1) // 1 should be your column index
            //{
            //    int i;

            //    if (!int.TryParse(Convert.ToString(e.), out i))
            //        return;

            //}
        }

        private void NumOfHiddenLayers_ValueChanged(object sender, EventArgs e)
        {
            PopulteTheHiddenLayerTable();
        }

        private void StartTrainingBtn_Click(object sender, EventArgs e)
        {
            String strPosDataFilePath = PosDataFilePath.Text;
            String strNegDataFilePath = NegDataFilePath.Text;

            double accurcyReq = (double)AccuracyReq.Value;
            double learningRate= (double)LearningRate.Value;

            int numOfHiddenLayers = (int)NumOfHiddenLayers.Value;
                        
            String strHidLayersNeuronsCount = "" + HiddenLayerNeuronsCount.Rows[0].Cells[1].Value;
            for(int hidLayIdx = 1; hidLayIdx < numOfHiddenLayers; hidLayIdx++)
            {
                strHidLayersNeuronsCount = strHidLayersNeuronsCount + "," + HiddenLayerNeuronsCount.Rows[hidLayIdx].Cells[1].Value;
            }

            String str = "bbb";
            String strResult = Marshal.PtrToStringAnsi(Test(str));
            //String strVal = Test(str);

            StartTraining(strPosDataFilePath, strNegDataFilePath,
                strHidLayersNeuronsCount, numOfHiddenLayers,
                accurcyReq,
                learningRate);
        }

        private void NNModelFolderBrowseBtn_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string strFilePath = openFileDialog1.FileName;
                NNModelFolderPath.Text = strFilePath;
            }
        }

        private void TestingDataFileBrowseBtn_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string strFilePath = openFileDialog1.FileName;
                TestingDataFilePath.Text = strFilePath;
            }
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            String strModelFolderPath = NNModelFolderPath.Text;
            String strTestingFilePath = TestingDataFilePath.Text;

            String strResult = Marshal.PtrToStringAnsi(SetModelFolderPathAnTest(strModelFolderPath, strTestingFilePath));

            char[] spearator = {','};
            String[] strResultlist = strResult.Split(spearator);

            TestDataResultTable.Rows.Clear();
            TestDataResultTable.RowCount = strResultlist.Length;
            for (int testIdx = 0; testIdx < strResultlist.Length; testIdx++)
            {
                TestDataResultTable.Rows[testIdx].Cells[0].Value = "Test " + (testIdx + 1);
                TestDataResultTable.Rows[testIdx].Cells[1].Value = strResultlist[testIdx];
            }
        }
    }
}
