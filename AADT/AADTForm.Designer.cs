namespace AADT
{
    partial class AADTForm
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
            this.predictButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.minionBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.dataPathLabel = new System.Windows.Forms.Label();
            this.dataPathTextBox = new System.Windows.Forms.TextBox();
            this.browseButton2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.newDataCheckBox = new System.Windows.Forms.CheckBox();
            this.browseButton3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.parameterTextBox = new System.Windows.Forms.TextBox();
            this.browseButton4 = new System.Windows.Forms.Button();
            this.factorsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ATRListTextBox = new System.Windows.Forms.TextBox();
            this.browseButton5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.predictButton2 = new System.Windows.Forms.Button();
            this.ATRYearTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.browseButton6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ATRpyTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ATRdataTextBox = new System.Windows.Forms.TextBox();
            this.browseButton7 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // predictButton
            // 
            this.predictButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictButton.Location = new System.Drawing.Point(193, 360);
            this.predictButton.Margin = new System.Windows.Forms.Padding(2);
            this.predictButton.Name = "predictButton";
            this.predictButton.Size = new System.Drawing.Size(152, 44);
            this.predictButton.TabIndex = 5;
            this.predictButton.Text = "Predict AADT";
            this.predictButton.UseVisualStyleBackColor = true;
            this.predictButton.Click += new System.EventHandler(this.predictButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathTextBox.Location = new System.Drawing.Point(54, 49);
            this.pathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(365, 26);
            this.pathTextBox.TabIndex = 3;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.Location = new System.Drawing.Point(152, 23);
            this.pathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(188, 24);
            this.pathLabel.TabIndex = 4;
            this.pathLabel.Text = "Short-term Count File";
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(423, 51);
            this.browseButton.Margin = new System.Windows.Forms.Padding(2);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(74, 24);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(38, 418);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(492, 49);
            this.progressBar1.TabIndex = 10;
            // 
            // minionBackgroundWorker
            // 
            this.minionBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.minionBackgroundWorker_DoWork);
            this.minionBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.minionBackgroundWorker_ProgressChanged);
            this.minionBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.minionBackgroundWorker_RunWorkerCompleted);
            // 
            // dataPathLabel
            // 
            this.dataPathLabel.AutoSize = true;
            this.dataPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPathLabel.Location = new System.Drawing.Point(160, 91);
            this.dataPathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataPathLabel.Name = "dataPathLabel";
            this.dataPathLabel.Size = new System.Drawing.Size(150, 24);
            this.dataPathLabel.TabIndex = 11;
            this.dataPathLabel.Text = "ATR Data Folder";
            // 
            // dataPathTextBox
            // 
            this.dataPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPathTextBox.Location = new System.Drawing.Point(54, 117);
            this.dataPathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dataPathTextBox.Name = "dataPathTextBox";
            this.dataPathTextBox.Size = new System.Drawing.Size(365, 26);
            this.dataPathTextBox.TabIndex = 12;
            // 
            // browseButton2
            // 
            this.browseButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton2.Location = new System.Drawing.Point(423, 119);
            this.browseButton2.Margin = new System.Windows.Forms.Padding(2);
            this.browseButton2.Name = "browseButton2";
            this.browseButton2.Size = new System.Drawing.Size(74, 24);
            this.browseButton2.TabIndex = 13;
            this.browseButton2.Text = "Browse";
            this.browseButton2.UseVisualStyleBackColor = true;
            this.browseButton2.Click += new System.EventHandler(this.browseButton2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AADT.Properties.Resources.Flat_Folder_icon;
            this.pictureBox2.Location = new System.Drawing.Point(14, 104);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // newDataCheckBox
            // 
            this.newDataCheckBox.AutoSize = true;
            this.newDataCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDataCheckBox.Location = new System.Drawing.Point(193, 306);
            this.newDataCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.newDataCheckBox.Name = "newDataCheckBox";
            this.newDataCheckBox.Size = new System.Drawing.Size(106, 19);
            this.newDataCheckBox.TabIndex = 15;
            this.newDataCheckBox.Text = "New ATR Data";
            this.newDataCheckBox.UseVisualStyleBackColor = true;
            // 
            // browseButton3
            // 
            this.browseButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton3.Location = new System.Drawing.Point(423, 276);
            this.browseButton3.Margin = new System.Windows.Forms.Padding(2);
            this.browseButton3.Name = "browseButton3";
            this.browseButton3.Size = new System.Drawing.Size(74, 24);
            this.browseButton3.TabIndex = 18;
            this.browseButton3.Text = "Browse";
            this.browseButton3.UseVisualStyleBackColor = true;
            this.browseButton3.Click += new System.EventHandler(this.browseButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Model Parameter File";
            // 
            // parameterTextBox
            // 
            this.parameterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parameterTextBox.Location = new System.Drawing.Point(54, 276);
            this.parameterTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.parameterTextBox.Name = "parameterTextBox";
            this.parameterTextBox.Size = new System.Drawing.Size(365, 26);
            this.parameterTextBox.TabIndex = 16;
            // 
            // browseButton4
            // 
            this.browseButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton4.Location = new System.Drawing.Point(423, 196);
            this.browseButton4.Margin = new System.Windows.Forms.Padding(2);
            this.browseButton4.Name = "browseButton4";
            this.browseButton4.Size = new System.Drawing.Size(74, 24);
            this.browseButton4.TabIndex = 21;
            this.browseButton4.Text = "Browse";
            this.browseButton4.UseVisualStyleBackColor = true;
            this.browseButton4.Click += new System.EventHandler(this.browseButton4_Click);
            // 
            // factorsTextBox
            // 
            this.factorsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorsTextBox.Location = new System.Drawing.Point(54, 194);
            this.factorsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.factorsTextBox.Name = "factorsTextBox";
            this.factorsTextBox.Size = new System.Drawing.Size(365, 26);
            this.factorsTextBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Functional Classification Factor File";
            // 
            // ATRListTextBox
            // 
            this.ATRListTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATRListTextBox.Location = new System.Drawing.Point(48, 48);
            this.ATRListTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ATRListTextBox.Name = "ATRListTextBox";
            this.ATRListTextBox.Size = new System.Drawing.Size(365, 26);
            this.ATRListTextBox.TabIndex = 22;
            // 
            // browseButton5
            // 
            this.browseButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton5.Location = new System.Drawing.Point(417, 50);
            this.browseButton5.Margin = new System.Windows.Forms.Padding(2);
            this.browseButton5.Name = "browseButton5";
            this.browseButton5.Size = new System.Drawing.Size(74, 24);
            this.browseButton5.TabIndex = 23;
            this.browseButton5.Text = "Browse";
            this.browseButton5.UseVisualStyleBackColor = true;
            this.browseButton5.Click += new System.EventHandler(this.browseButton5_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "ATR list File";
            // 
            // predictButton2
            // 
            this.predictButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictButton2.Location = new System.Drawing.Point(150, 266);
            this.predictButton2.Margin = new System.Windows.Forms.Padding(2);
            this.predictButton2.Name = "predictButton2";
            this.predictButton2.Size = new System.Drawing.Size(176, 44);
            this.predictButton2.TabIndex = 5;
            this.predictButton2.Text = "Get Data";
            this.predictButton2.UseVisualStyleBackColor = true;
            this.predictButton2.Click += new System.EventHandler(this.predictButton2_Click);
            // 
            // ATRYearTextBox
            // 
            this.ATRYearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATRYearTextBox.Location = new System.Drawing.Point(150, 202);
            this.ATRYearTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ATRYearTextBox.Name = "ATRYearTextBox";
            this.ATRYearTextBox.Size = new System.Drawing.Size(176, 26);
            this.ATRYearTextBox.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(210, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "Year";
            // 
            // browseButton6
            // 
            this.browseButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton6.Location = new System.Drawing.Point(412, 48);
            this.browseButton6.Margin = new System.Windows.Forms.Padding(2);
            this.browseButton6.Name = "browseButton6";
            this.browseButton6.Size = new System.Drawing.Size(74, 24);
            this.browseButton6.TabIndex = 31;
            this.browseButton6.Text = "Browse";
            this.browseButton6.UseVisualStyleBackColor = true;
            this.browseButton6.Click += new System.EventHandler(this.browseButton6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(146, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Data Collector File";
            // 
            // ATRpyTextBox
            // 
            this.ATRpyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATRpyTextBox.Location = new System.Drawing.Point(43, 46);
            this.ATRpyTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ATRpyTextBox.Name = "ATRpyTextBox";
            this.ATRpyTextBox.Size = new System.Drawing.Size(365, 26);
            this.ATRpyTextBox.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(137, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 24);
            this.label9.TabIndex = 33;
            this.label9.Text = "Data Collection Folder";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AADT.Properties.Resources.Flat_Folder_icon;
            this.pictureBox1.Location = new System.Drawing.Point(501, 147);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // ATRdataTextBox
            // 
            this.ATRdataTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATRdataTextBox.Location = new System.Drawing.Point(43, 118);
            this.ATRdataTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ATRdataTextBox.Name = "ATRdataTextBox";
            this.ATRdataTextBox.Size = new System.Drawing.Size(365, 26);
            this.ATRdataTextBox.TabIndex = 36;
            // 
            // browseButton7
            // 
            this.browseButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton7.Location = new System.Drawing.Point(412, 118);
            this.browseButton7.Margin = new System.Windows.Forms.Padding(2);
            this.browseButton7.Name = "browseButton7";
            this.browseButton7.Size = new System.Drawing.Size(74, 24);
            this.browseButton7.TabIndex = 37;
            this.browseButton7.Text = "Browse";
            this.browseButton7.UseVisualStyleBackColor = true;
            this.browseButton7.Click += new System.EventHandler(this.browseButton7_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(572, 515);
            this.tabControl1.TabIndex = 38;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pathLabel);
            this.tabPage1.Controls.Add(this.pathTextBox);
            this.tabPage1.Controls.Add(this.browseButton);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.dataPathTextBox);
            this.tabPage1.Controls.Add(this.predictButton);
            this.tabPage1.Controls.Add(this.dataPathLabel);
            this.tabPage1.Controls.Add(this.browseButton2);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.factorsTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.browseButton4);
            this.tabPage1.Controls.Add(this.parameterTextBox);
            this.tabPage1.Controls.Add(this.newDataCheckBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.browseButton3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(564, 489);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AADT Estimation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.browseButton7);
            this.tabPage2.Controls.Add(this.predictButton2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.ATRpyTextBox);
            this.tabPage2.Controls.Add(this.ATRdataTextBox);
            this.tabPage2.Controls.Add(this.ATRYearTextBox);
            this.tabPage2.Controls.Add(this.browseButton6);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(564, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ATR Data Collection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.ATRListTextBox);
            this.tabPage3.Controls.Add(this.browseButton5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(564, 489);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ATR List";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AADT.Properties.Resources.Flat_Folder_icon;
            this.pictureBox3.Location = new System.Drawing.Point(4, 107);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // AADTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 527);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AADTForm";
            this.Text = "EstimAADTion";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AADTForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button predictButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker minionBackgroundWorker;
        private System.Windows.Forms.Label dataPathLabel;
        private System.Windows.Forms.TextBox dataPathTextBox;
        private System.Windows.Forms.Button browseButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox newDataCheckBox;
        private System.Windows.Forms.Button browseButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox parameterTextBox;
        private System.Windows.Forms.Button browseButton4;
        private System.Windows.Forms.TextBox factorsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ATRListTextBox;
        private System.Windows.Forms.Button browseButton5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button predictButton2;
        private System.Windows.Forms.TextBox ATRYearTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button browseButton6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ATRpyTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ATRdataTextBox;
        private System.Windows.Forms.Button browseButton7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}