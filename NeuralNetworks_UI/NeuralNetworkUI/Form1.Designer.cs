namespace NeuralNetworkUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Main = new System.Windows.Forms.TabControl();
            this.Training = new System.Windows.Forms.TabPage();
            this.StartTrainingBtn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.InputLayerNeuron = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.HiddenLayerNeuronsCount = new System.Windows.Forms.DataGridView();
            this.HiddenLayers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NeuronsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumOfHiddenLayers = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.LearningRate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.AccuracyReq = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.NegBrowseBtn = new System.Windows.Forms.Button();
            this.NegDataFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PosBrowseBtn = new System.Windows.Forms.Button();
            this.PosDataFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Testing = new System.Windows.Forms.TabPage();
            this.TestBtn = new System.Windows.Forms.Button();
            this.TestDataResultTable = new System.Windows.Forms.DataGridView();
            this.TestData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestingDataFileBrowseBtn = new System.Windows.Forms.Button();
            this.TestingDataFilePath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NNModelFolderBrowseBtn = new System.Windows.Forms.Button();
            this.NNModelFolderPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Main.SuspendLayout();
            this.Training.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputLayerNeuron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HiddenLayerNeuronsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfHiddenLayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearningRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccuracyReq)).BeginInit();
            this.Testing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestDataResultTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.Controls.Add(this.Training);
            this.Main.Controls.Add(this.Testing);
            this.Main.Location = new System.Drawing.Point(13, 13);
            this.Main.Name = "Main";
            this.Main.SelectedIndex = 0;
            this.Main.Size = new System.Drawing.Size(773, 477);
            this.Main.TabIndex = 0;
            // 
            // Training
            // 
            this.Training.Controls.Add(this.StartTrainingBtn);
            this.Training.Controls.Add(this.numericUpDown1);
            this.Training.Controls.Add(this.label7);
            this.Training.Controls.Add(this.InputLayerNeuron);
            this.Training.Controls.Add(this.label6);
            this.Training.Controls.Add(this.HiddenLayerNeuronsCount);
            this.Training.Controls.Add(this.NumOfHiddenLayers);
            this.Training.Controls.Add(this.label5);
            this.Training.Controls.Add(this.LearningRate);
            this.Training.Controls.Add(this.label4);
            this.Training.Controls.Add(this.AccuracyReq);
            this.Training.Controls.Add(this.label3);
            this.Training.Controls.Add(this.NegBrowseBtn);
            this.Training.Controls.Add(this.NegDataFilePath);
            this.Training.Controls.Add(this.label2);
            this.Training.Controls.Add(this.PosBrowseBtn);
            this.Training.Controls.Add(this.PosDataFilePath);
            this.Training.Controls.Add(this.label1);
            this.Training.Location = new System.Drawing.Point(4, 22);
            this.Training.Name = "Training";
            this.Training.Padding = new System.Windows.Forms.Padding(3);
            this.Training.Size = new System.Drawing.Size(765, 451);
            this.Training.TabIndex = 0;
            this.Training.Text = "Training";
            this.Training.UseVisualStyleBackColor = true;
            this.Training.Click += new System.EventHandler(this.Training_Click);
            // 
            // StartTrainingBtn
            // 
            this.StartTrainingBtn.Location = new System.Drawing.Point(684, 422);
            this.StartTrainingBtn.Name = "StartTrainingBtn";
            this.StartTrainingBtn.Size = new System.Drawing.Size(75, 23);
            this.StartTrainingBtn.TabIndex = 20;
            this.StartTrainingBtn.Text = "Start";
            this.StartTrainingBtn.UseVisualStyleBackColor = true;
            this.StartTrainingBtn.Click += new System.EventHandler(this.StartTrainingBtn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(583, 114);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(93, 20);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "output layer neurons :";
            // 
            // InputLayerNeuron
            // 
            this.InputLayerNeuron.Location = new System.Drawing.Point(348, 114);
            this.InputLayerNeuron.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.InputLayerNeuron.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.InputLayerNeuron.Name = "InputLayerNeuron";
            this.InputLayerNeuron.Size = new System.Drawing.Size(93, 20);
            this.InputLayerNeuron.TabIndex = 17;
            this.InputLayerNeuron.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Input layer neurons :";
            // 
            // HiddenLayerNeuronsCount
            // 
            this.HiddenLayerNeuronsCount.AllowUserToAddRows = false;
            this.HiddenLayerNeuronsCount.BackgroundColor = System.Drawing.SystemColors.Control;
            this.HiddenLayerNeuronsCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HiddenLayerNeuronsCount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HiddenLayers,
            this.NeuronsCount});
            this.HiddenLayerNeuronsCount.Location = new System.Drawing.Point(10, 154);
            this.HiddenLayerNeuronsCount.Name = "HiddenLayerNeuronsCount";
            this.HiddenLayerNeuronsCount.Size = new System.Drawing.Size(245, 253);
            this.HiddenLayerNeuronsCount.TabIndex = 15;
            this.HiddenLayerNeuronsCount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HiddenLayerNeuronsCount_CellContentClick);
            // 
            // HiddenLayers
            // 
            this.HiddenLayers.Frozen = true;
            this.HiddenLayers.HeaderText = "Hidden Layers";
            this.HiddenLayers.Name = "HiddenLayers";
            // 
            // NeuronsCount
            // 
            this.NeuronsCount.HeaderText = "Neurons Count";
            this.NeuronsCount.Name = "NeuronsCount";
            this.NeuronsCount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NumOfHiddenLayers
            // 
            this.NumOfHiddenLayers.Location = new System.Drawing.Point(136, 114);
            this.NumOfHiddenLayers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumOfHiddenLayers.Name = "NumOfHiddenLayers";
            this.NumOfHiddenLayers.Size = new System.Drawing.Size(75, 20);
            this.NumOfHiddenLayers.TabIndex = 11;
            this.NumOfHiddenLayers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumOfHiddenLayers.ValueChanged += new System.EventHandler(this.NumOfHiddenLayers_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Num of hidden layers :";
            // 
            // LearningRate
            // 
            this.LearningRate.DecimalPlaces = 5;
            this.LearningRate.Location = new System.Drawing.Point(321, 79);
            this.LearningRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LearningRate.Name = "LearningRate";
            this.LearningRate.Size = new System.Drawing.Size(86, 20);
            this.LearningRate.TabIndex = 9;
            this.LearningRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Learning rate :";
            // 
            // AccuracyReq
            // 
            this.AccuracyReq.DecimalPlaces = 2;
            this.AccuracyReq.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.AccuracyReq.Location = new System.Drawing.Point(136, 80);
            this.AccuracyReq.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AccuracyReq.Name = "AccuracyReq";
            this.AccuracyReq.Size = new System.Drawing.Size(75, 20);
            this.AccuracyReq.TabIndex = 7;
            this.AccuracyReq.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.AccuracyReq.ValueChanged += new System.EventHandler(this.AccuracyReq_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Accuracy required :";
            // 
            // NegBrowseBtn
            // 
            this.NegBrowseBtn.Location = new System.Drawing.Point(684, 40);
            this.NegBrowseBtn.Name = "NegBrowseBtn";
            this.NegBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.NegBrowseBtn.TabIndex = 5;
            this.NegBrowseBtn.Text = "Browse";
            this.NegBrowseBtn.UseVisualStyleBackColor = true;
            this.NegBrowseBtn.Click += new System.EventHandler(this.NegBrowseBtn_Click);
            // 
            // NegDataFilePath
            // 
            this.NegDataFilePath.Location = new System.Drawing.Point(136, 42);
            this.NegDataFilePath.Name = "NegDataFilePath";
            this.NegDataFilePath.Size = new System.Drawing.Size(540, 20);
            this.NegDataFilePath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Negetive data file path :";
            // 
            // PosBrowseBtn
            // 
            this.PosBrowseBtn.Location = new System.Drawing.Point(684, 12);
            this.PosBrowseBtn.Name = "PosBrowseBtn";
            this.PosBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.PosBrowseBtn.TabIndex = 2;
            this.PosBrowseBtn.Text = "Browse";
            this.PosBrowseBtn.UseVisualStyleBackColor = true;
            this.PosBrowseBtn.Click += new System.EventHandler(this.PosBrowseBtn_Click);
            // 
            // PosDataFilePath
            // 
            this.PosDataFilePath.Location = new System.Drawing.Point(136, 14);
            this.PosDataFilePath.Name = "PosDataFilePath";
            this.PosDataFilePath.Size = new System.Drawing.Size(540, 20);
            this.PosDataFilePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Positive data file path :";
            // 
            // Testing
            // 
            this.Testing.Controls.Add(this.TestBtn);
            this.Testing.Controls.Add(this.TestDataResultTable);
            this.Testing.Controls.Add(this.TestingDataFileBrowseBtn);
            this.Testing.Controls.Add(this.TestingDataFilePath);
            this.Testing.Controls.Add(this.label9);
            this.Testing.Controls.Add(this.NNModelFolderBrowseBtn);
            this.Testing.Controls.Add(this.NNModelFolderPath);
            this.Testing.Controls.Add(this.label8);
            this.Testing.Location = new System.Drawing.Point(4, 22);
            this.Testing.Name = "Testing";
            this.Testing.Padding = new System.Windows.Forms.Padding(3);
            this.Testing.Size = new System.Drawing.Size(765, 451);
            this.Testing.TabIndex = 1;
            this.Testing.Text = "Testing";
            this.Testing.UseVisualStyleBackColor = true;
            this.Testing.Click += new System.EventHandler(this.Testing_Click);
            // 
            // TestBtn
            // 
            this.TestBtn.Location = new System.Drawing.Point(684, 422);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(75, 23);
            this.TestBtn.TabIndex = 7;
            this.TestBtn.Text = "Test";
            this.TestBtn.UseVisualStyleBackColor = true;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // TestDataResultTable
            // 
            this.TestDataResultTable.AllowUserToAddRows = false;
            this.TestDataResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestDataResultTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestData,
            this.Result});
            this.TestDataResultTable.Location = new System.Drawing.Point(26, 107);
            this.TestDataResultTable.Name = "TestDataResultTable";
            this.TestDataResultTable.Size = new System.Drawing.Size(443, 303);
            this.TestDataResultTable.TabIndex = 6;
            // 
            // TestData
            // 
            this.TestData.Frozen = true;
            this.TestData.HeaderText = "Test data number";
            this.TestData.Name = "TestData";
            this.TestData.ReadOnly = true;
            this.TestData.Width = 200;
            // 
            // Result
            // 
            this.Result.Frozen = true;
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Width = 200;
            // 
            // TestingDataFileBrowseBtn
            // 
            this.TestingDataFileBrowseBtn.Location = new System.Drawing.Point(669, 54);
            this.TestingDataFileBrowseBtn.Name = "TestingDataFileBrowseBtn";
            this.TestingDataFileBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.TestingDataFileBrowseBtn.TabIndex = 5;
            this.TestingDataFileBrowseBtn.Text = "Browse";
            this.TestingDataFileBrowseBtn.UseVisualStyleBackColor = true;
            this.TestingDataFileBrowseBtn.Click += new System.EventHandler(this.TestingDataFileBrowseBtn_Click);
            // 
            // TestingDataFilePath
            // 
            this.TestingDataFilePath.Location = new System.Drawing.Point(197, 56);
            this.TestingDataFilePath.Name = "TestingDataFilePath";
            this.TestingDataFilePath.Size = new System.Drawing.Size(466, 20);
            this.TestingDataFilePath.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Testing Data file path :";
            // 
            // NNModelFolderBrowseBtn
            // 
            this.NNModelFolderBrowseBtn.Location = new System.Drawing.Point(669, 13);
            this.NNModelFolderBrowseBtn.Name = "NNModelFolderBrowseBtn";
            this.NNModelFolderBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.NNModelFolderBrowseBtn.TabIndex = 2;
            this.NNModelFolderBrowseBtn.Text = "Browse";
            this.NNModelFolderBrowseBtn.UseVisualStyleBackColor = true;
            this.NNModelFolderBrowseBtn.Click += new System.EventHandler(this.NNModelFolderBrowseBtn_Click);
            // 
            // NNModelFolderPath
            // 
            this.NNModelFolderPath.Location = new System.Drawing.Point(197, 15);
            this.NNModelFolderPath.Name = "NNModelFolderPath";
            this.NNModelFolderPath.Size = new System.Drawing.Size(466, 20);
            this.NNModelFolderPath.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Neural Networks model folder path :";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 495);
            this.Controls.Add(this.Main);
            this.Name = "Form1";
            this.Text = "NeuralNetworkUI";
            this.Main.ResumeLayout(false);
            this.Training.ResumeLayout(false);
            this.Training.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputLayerNeuron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HiddenLayerNeuronsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfHiddenLayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearningRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccuracyReq)).EndInit();
            this.Testing.ResumeLayout(false);
            this.Testing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestDataResultTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Main;
        private System.Windows.Forms.TabPage Training;
        private System.Windows.Forms.TabPage Testing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NegBrowseBtn;
        private System.Windows.Forms.TextBox NegDataFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PosBrowseBtn;
        private System.Windows.Forms.TextBox PosDataFilePath;
        private System.Windows.Forms.NumericUpDown AccuracyReq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown LearningRate;
        private System.Windows.Forms.NumericUpDown NumOfHiddenLayers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView HiddenLayerNeuronsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn HiddenLayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn NeuronsCount;
        private System.Windows.Forms.NumericUpDown InputLayerNeuron;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button StartTrainingBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NNModelFolderPath;
        private System.Windows.Forms.Button NNModelFolderBrowseBtn;
        private System.Windows.Forms.Button TestingDataFileBrowseBtn;
        private System.Windows.Forms.TextBox TestingDataFilePath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button TestBtn;
        private System.Windows.Forms.DataGridView TestDataResultTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
    }
}

