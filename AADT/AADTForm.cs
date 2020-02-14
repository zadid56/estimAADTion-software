using System;
using System.Windows.Forms;
using LibSVMsharp;
using LibSVMsharp.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using System.Collections;
using System.Text.RegularExpressions;
using LibSVMsharp.Extensions;
using System.Data;

namespace AADT
{
    public partial class AADTForm : Form
    {
        public AADTForm()
        {
            InitializeComponent();
            //name = this.nameLabel.Text;
            //dataSelected = this.roadWayComboBox.Items.ToString();
        }
        public string name
        {
            get;
            set;
        }
        public static string path
        {
            get;
            set;
        }
        public static string opPath
        {
            get;
            set;
        }
        public static string dataPath
        {
            get;
            set;
        }

        public static string parameterPath
        {
            get;
            set;
        }

        public static string factorsPath
        {
            get;
            set;
        }

        public static bool newDataFlag
        {
            get;
            set;
        }

        public string dataSelected
        {
            get;
            set;
        }

        public static string ATRlistPath
        {
            get;
            set;
        }

        public static string ATRYear
        {
            get;
            set;
        }

        public static string ATRpyPath
        {
            get;
            set;
        }

        public static string ATRdataPath
        {
            get;
            set;
        }

        private void predictButton_Click(object sender, EventArgs e)
        {
            progressBar1.Show();
            path = pathTextBox.Text;
            dataPath = dataPathTextBox.Text;
            parameterPath = parameterTextBox.Text;
            factorsPath = factorsTextBox.Text;
            ATRlistPath = ATRListTextBox.Text;
            ATRYear = ATRYearTextBox.Text;
            newDataFlag = newDataCheckBox.Checked;
            minionBackgroundWorker.WorkerReportsProgress = true;
            minionBackgroundWorker.RunWorkerAsync();

        }

        private void predictButton2_Click(object sender, EventArgs e)
        {
            ATRYear = ATRYearTextBox.Text;
            ATRpyPath = ATRpyTextBox.Text;
            ATRdataPath = ATRdataTextBox.Text;
            ATRlistPath = ATRListTextBox.Text;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.WorkingDirectory = ATRdataPath;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C python " + ATRpyPath + " " + ATRYear + " " + ATRlistPath;
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            Application.OpenForms["AADTForm"].Hide();
            DoneForm done = new DoneForm();
            done.Controls["doneLabel"].Text = "Data Collection Complete!";
            done.Controls["outputLocationLabel"].Text = "";
            done.ShowDialog();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.CheckFileExists = true;
                // Show the FolderBrowserDialog.
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pathTextBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void browseButton2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDlg = new FolderBrowserDialog())
            {
                folderDlg.ShowNewFolderButton = true;
                // Show the FolderBrowserDialog.
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    dataPathTextBox.Text = folderDlg.SelectedPath;
                    Environment.SpecialFolder root = folderDlg.RootFolder;
                }
            }
        }

        private void browseButton3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.CheckFileExists = true;
                // Show the FolderBrowserDialog.
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    parameterTextBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void browseButton4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.CheckFileExists = true;
                // Show the FolderBrowserDialog.
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    factorsTextBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void browseButton5_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.CheckFileExists = true;
                // Show the FolderBrowserDialog.
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ATRListTextBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void browseButton6_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.CheckFileExists = true;
                // Show the FolderBrowserDialog.
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ATRpyTextBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void browseButton7_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDlg = new FolderBrowserDialog())
            {
                folderDlg.ShowNewFolderButton = true;
                // Show the FolderBrowserDialog.
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ATRdataTextBox.Text = folderDlg.SelectedPath;
                    Environment.SpecialFolder root = folderDlg.RootFolder;
                }
            }
        }

        private void minionBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string[] todelete = { "Train.txt", "Test.txt", "Result.txt", "Output.csv", "AADT_model.txt", "AADTVal.txt" };
            //UI
            System.IO.Directory.CreateDirectory(@"C:\temp\");
            string ip = AADTForm.path;
            path = @"C:\temp\";
            opPath = ip.Replace(@"\Input.csv", "");
            dataPath = AADTForm.dataPath;
            factorsPath = AADTForm.factorsPath;
            parameterPath = AADTForm.parameterPath;
            ATRlistPath = AADTForm.ATRlistPath;
            ATRYear = AADTForm.ATRYear;
            newDataFlag = AADTForm.newDataFlag;
            foreach (string s in todelete)
            {
                if (File.Exists(path + @"\" + s))
                {
                    File.Delete(path + @"\" + s);
                }
            }

            Dictionary<int, int> modelDict = new Dictionary<int, int> {
                { 1, 1 },
                { 11, 1 },
                { 12, 1 },
                { 2, 2},
                { 3, 2},
                { 6, 2},
                { 13, 2},
                { 14, 2},
                { 4, 3},
                { 5, 3},
                { 9, 3},
                { 15, 3},
                { 18, 3}
                };

            Dictionary<int, int> modelDict2 = new Dictionary<int, int>
            {
                { 2, 1 },
                { 3, 2 },
                { 4, 3 },
                { 5, 4 },
                { 9, 5 },
                { 12, 6 },
                { 13, 7 },
                { 14, 8 },
                { 15, 9 },
                { 18, 10 }
            };

            var ATRlist = File.ReadAllLines(ATRlistPath).Select(l => l.Split(',').ToArray()).ToArray();
            
            int mod = 0;
            int ic = 0;
            int ac = 0;
            int cc = 0;
            int ATRlength = ATRlist.GetLength(0)-1;
            int[] allATR = new int[ATRlength];
            int[] interstate = new int[ATRlength];
            int[] arterial = new int[ATRlength];
            int[] collector = new int[ATRlength];

            for (int i = 0; i < ATRlength; i++)
            {
                allATR[i] = Convert.ToInt32(ATRlist[i+1][0]); // Create inner array
                mod = modelDict[Convert.ToInt32(ATRlist[i+1][1])];
                if (mod == 1)
                {
                    interstate[ic] = allATR[i];
                    ic++;
                }
                if (mod == 2)
                {
                    arterial[ac] = allATR[i];
                    ac++;
                }
                if (mod == 3)
                {
                    collector[cc] = allATR[i];
                    cc++;
                }
            }

            Array.Resize(ref interstate, ic);
            Array.Resize(ref arterial, ac);
            Array.Resize(ref collector, cc);

            int[] allmodel = Enumerable.Range(1, 3).ToArray();
            int[] AADT = new int[ATRlength];
            int[] ATR = new int[ATRlength];
            int[] trainingSet = new int[] { };

            int[] range_c = Enumerable.Range(0, 9).ToArray();
            int[] range_gamma = Enumerable.Range(-3, 7).ToArray();

            ip = File.ReadAllText(ip);
            string[] ipArray = ip.Replace("County,Station,Date,FClass,GF,Hour1,Hour2,Hour3,Hour4,Hour5,Hour6,Hour7,Hour8,Hour9,Hour10,Hour11,Hour12,Hour13,Hour14,Hour15,Hour16,Hour17,Hour18,Hour19,Hour20,Hour21,Hour22,Hour23,Hour24\r\n", "").Replace(',', ' ').Replace("\n", "").Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            string basePath = dataPath + @"\";
            AADTForm p = new AADTForm();
            minionBackgroundWorker.ReportProgress(10);

            string currentATR = "";
            int mycount = 0;
            int[] vol = new int[ipArray.Length];
            string resultString = "";
            StreamWriter testWriter = new StreamWriter(path + @"Test.txt");
            List<int> county = new List<int>();
            List<int> station = new List<int>();
            List<int> fClass = new List<int>();
            List<int> model_no = new List<int>();
            List<int> stc_month = new List<int>();

            SVMModel model1 = null;
            SVMModel model2 = null;
            SVMModel model3 = null;

            foreach (string ss in ipArray)
            {
                string[] tempy = ss.Split(new char[] { ' ' }, 6);

                county.Add(Convert.ToInt32(tempy[0]));
                station.Add(Convert.ToInt32(tempy[1]));
                fClass.Add(Convert.ToInt32(tempy[3]));
                model_no.Add(modelDict[Convert.ToInt32(tempy[3])]);

                DateTime date = DateTime.ParseExact(tempy[2], "d", CultureInfo.InvariantCulture);
                stc_month.Add(Convert.ToInt32(date.Month));
                int stc_year = Convert.ToInt32(date.Year);
                string binaryMonth = Convert.ToString(date.Month, 2);
                binaryMonth = binaryMonth.PadLeft(4, '0');
                binaryMonth = Regex.Replace(binaryMonth, ".{1}", "$0-");
                resultString += binaryMonth;
                string binaryDayOfWeek = Convert.ToString(Convert.ToInt32(date.DayOfWeek) + 1, 2);
                binaryDayOfWeek = binaryDayOfWeek.PadLeft(3, '0');
                binaryDayOfWeek = Regex.Replace(binaryDayOfWeek, ".{1}", "$0-");
                resultString += binaryDayOfWeek;
                resultString = resultString.Remove(resultString.Length - 1);

                currentATR += tempy[1] + "-";
                int dayVolumeSum = Convert.ToInt32(tempy[5].Split(' ').Select(int.Parse).ToArray().Sum() * Math.Pow(Convert.ToDouble(tempy[4]),(2017-stc_year)));
                vol[mycount] = dayVolumeSum;
                mycount++;
                foreach (string s in tempy[5].Split(' '))
                {
                    resultString += "-" + Math.Round(Convert.ToDecimal(s) / dayVolumeSum, 5);
                }
                string result = "0 ";
                int itemCount = 1;
                foreach (string s in resultString.Split('-'))
                {
                    result += itemCount + ":" + s + " ";
                    itemCount++;
                }
                testWriter.WriteLine(result);
                resultString = "";


            }

            testWriter.Flush();
            testWriter.Close();

            minionBackgroundWorker.ReportProgress(30);

            var param = File.ReadAllLines(parameterPath).Select(l => l.Split(',').ToArray()).ToArray();
            var factors = File.ReadAllLines(factorsPath).Select(l => l.Split(',').ToArray()).ToArray();

            //StreamWriter outputWriter2 = new StreamWriter(parameterPath);
            //outputWriter2.WriteLine("C" + "," + "Gamma");

            foreach (int q in allmodel)
            {
                File.Delete(path + "Train.txt");
                File.Delete(path + "Result.txt");
                if (q == 1)
                {
                    trainingSet = interstate;
                }
                if (q == 2)
                {
                    trainingSet = arterial;
                }
                if (q == 3)
                {
                    trainingSet = collector;
                }

                foreach (int i in trainingSet)
                {
                    p.ExtractData(basePath + i.ToString() + ".txt");
                }

                List<int> inputATR = new List<int>();
                List<int> trainATR = new List<int>();

                StreamReader streamReader = new StreamReader(path + "Result.txt");

                string line = streamReader.ReadLine();
                while (line != null)
                {
                    if (!inputATR.Contains(Convert.ToInt32(line.Substring(0, line.IndexOf('-')).ToString())))
                    {
                        inputATR.Add(Convert.ToInt32(line.Substring(0, line.IndexOf('-')).ToString()));
                    }
                    line = streamReader.ReadLine();
                }
                streamReader.Close();
                int x = inputATR.Count();
                int trainIndex = Convert.ToInt32(x * (1));
                StreamWriter trainWriter = new StreamWriter(path + "Train.txt");

                foreach (int i in Enumerable.Range(0, trainIndex))
                {
                    trainATR.Add(inputATR[i]);
                }
                streamReader = new StreamReader(path + "Result.txt");
                line = streamReader.ReadLine();
                while (line != null)
                {
                    string atr = line.Substring(0, line.IndexOf('-'));
                    int colonCount = 1;
                    if (trainATR.Contains(Convert.ToInt32(line.Substring(0, line.IndexOf('-')).ToString())))
                    {
                        string temp = String.Empty;
                        line = line.Remove(0, line.IndexOf('-') + 1);
                        temp = atr;
                        string[] tempArr = line.Split('-');
                        foreach (string s in tempArr)
                        {
                            temp += " " + colonCount++.ToString() + ":" + s;
                        }
                        string v = temp.Remove(0, temp.IndexOf("32:") + 3) + " " + temp.Remove(0, temp.IndexOf(' ') + 1).Remove(temp.IndexOf("32:") - 4);
                        trainWriter.WriteLine(v);
                    }
                    line = streamReader.ReadLine();
                }
                streamReader.Close();
                trainWriter.Flush();
                trainWriter.Close();

                SVMProblem trainData = SVMProblemHelper.Load(path + "Train.txt");

                trainData = trainData.Normalize(SVMNormType.L1);
                //string[] parameterData = File.ReadAllText(parameterPath).Replace("\r", "").Split('\n');
                SVMParameter parameter = new SVMParameter();
                parameter.Type = SVMType.EPSILON_SVR;
                parameter.Kernel = SVMKernelType.RBF;
                parameter.Degree = 1;
                parameter.Eps = 0.0001;

                double[] target = new double[] { };
                double corr = 0;
                double MSE = 0;
                double best_MSE = 100;
                int best_c = 0;
                int best_gamma = 0;

                if (q == 1)
                {
                    if (!newDataFlag)
                    {
                        parameter.C = Convert.ToDouble(param[1][0]);
                        parameter.Gamma = Convert.ToDouble(param[1][1]);
                        model1 = SVM.Train(trainData, parameter);
                    }
                    else
                    {
                        foreach (int i in range_c)
                        {
                            foreach (int j in range_gamma)
                            {
                                parameter.C = Math.Pow(2, i);
                                parameter.Gamma = Math.Pow(2, j);
                                SVM.CrossValidation(trainData, parameter, 3, out target);
                                MSE = trainData.EvaluateRegressionProblem(target, out corr);
                                if (MSE < best_MSE)
                                {
                                    best_MSE = MSE;
                                    best_c = i;
                                    best_gamma = j;
                                }
                            }
                        }
                        parameter.C = Math.Pow(2, best_c);
                        parameter.Gamma = Math.Pow(2, best_gamma);
                        model1 = SVM.Train(trainData, parameter);
                        //outputWriter2.WriteLine(Convert.ToString(Math.Pow(2, best_c)) + "," + Convert.ToString(Math.Pow(2, best_gamma)));
                    }
                    minionBackgroundWorker.ReportProgress(50);
                }
                if (q == 2)
                {
                    if (!newDataFlag)
                    {
                        parameter.C = Convert.ToDouble(param[2][0]);
                        parameter.Gamma = Convert.ToDouble(param[2][1]);
                        model2 = SVM.Train(trainData, parameter);
                    }
                    else
                    {
                        foreach (int i in range_c)
                        {
                            foreach (int j in range_gamma)
                            {
                                parameter.C = Math.Pow(2, i);
                                parameter.Gamma = Math.Pow(2, j);
                                SVM.CrossValidation(trainData, parameter, 3, out target);
                                MSE = trainData.EvaluateRegressionProblem(target, out corr);
                                if (MSE < best_MSE)
                                {
                                    best_MSE = MSE;
                                    best_c = i;
                                    best_gamma = j;
                                }
                            }
                        }
                        parameter.C = Math.Pow(2, best_c);
                        parameter.Gamma = Math.Pow(2, best_gamma);
                        model2 = SVM.Train(trainData, parameter);
                        //outputWriter2.WriteLine(Convert.ToString(Math.Pow(2, best_c)) + "," + Convert.ToString(Math.Pow(2, best_gamma)));
                    }
                    minionBackgroundWorker.ReportProgress(70);
                }
                if (q == 3)
                {
                    if (!newDataFlag)
                    {
                        parameter.C = Convert.ToDouble(param[3][0]);
                        parameter.Gamma = Convert.ToDouble(param[3][1]);
                        model3 = SVM.Train(trainData, parameter);
                    }
                    else
                    {
                        foreach (int i in range_c)
                        {
                            foreach (int j in range_gamma)
                            {
                                parameter.C = Math.Pow(2, i);
                                parameter.Gamma = Math.Pow(2, j);
                                SVM.CrossValidation(trainData, parameter, 3, out target);
                                MSE = trainData.EvaluateRegressionProblem(target, out corr);
                                if (MSE < best_MSE)
                                {
                                    best_MSE = MSE;
                                    best_c = i;
                                    best_gamma = j;
                                }
                            }
                        }
                        parameter.C = Math.Pow(2, best_c);
                        parameter.Gamma = Math.Pow(2, best_gamma);
                        model3 = SVM.Train(trainData, parameter);
                        //outputWriter2.WriteLine(Convert.ToString(Math.Pow(2, best_c)) + "," + Convert.ToString(Math.Pow(2, best_gamma)));
                    }
                    minionBackgroundWorker.ReportProgress(90);
                }
                
            }

            //outputWriter2.Flush();
            //outputWriter2.Close();

            SVMProblem testData = SVMProblemHelper.Load(path + "Test.txt");
            testData = testData.Normalize(SVMNormType.L1);

            double[] testResults1 = testData.Predict(model1);
            double[] testResults2 = testData.Predict(model2);
            double[] testResults3 = testData.Predict(model3);

            string tempdate = DateTime.Now.ToString(@"MM.dd.yyyy_HH.mm");
            StreamWriter outputWriter = new StreamWriter(opPath + @"\" + "Output_" + tempdate + ".csv");
            outputWriter.WriteLine("    County    " + "," + "    Station    " + "," + "    Functional_Class    " + "," + "    AADT-AI    " + "," + "    AADT-Factor    ");

            var distinct_station = station.Distinct().ToArray();
            double[] AADT_AI = new double[distinct_station.Length];
            double[] AADT_factor = new double[distinct_station.Length];
            int[] distinct_county = new int[distinct_station.Length];
            int[] distinct_fclass = new int[distinct_station.Length];
            int AADTcount = 0;

            for (int j = 0; j < distinct_station.Length; j++)
            {
                AADTcount = 0;
                for (int i = 0; i < testData.Length; i++)
                {
                    if (model_no[i] == 1 && distinct_station[j] == station[i])
                    {
                        AADT_AI[j] = AADT_AI[j] + Math.Round(vol[i] / testResults1[i]);
                        AADT_factor[j] = AADT_factor[j] + vol[i] * Convert.ToDouble(factors[1][modelDict2[fClass[i]]]) * Convert.ToDouble(factors[stc_month[i]+1][modelDict2[fClass[i]]]);
                        distinct_county[j] = county[i];
                        distinct_fclass[j] = fClass[i];
                        AADTcount++;
                    }
                    if (model_no[i] == 2 && distinct_station[j] == station[i])
                    {
                        AADT_AI[j] = AADT_AI[j] + Math.Round(vol[i] / testResults2[i]);
                        AADT_factor[j] = AADT_factor[j] + vol[i] * Convert.ToDouble(factors[1][modelDict2[fClass[i]]]) * Convert.ToDouble(factors[stc_month[i] + 1][modelDict2[fClass[i]]]);
                        distinct_county[j] = county[i];
                        distinct_fclass[j] = fClass[i];
                        AADTcount++;
                    }
                    if (model_no[i] == 3 && distinct_station[j] == station[i])
                    {
                        AADT_AI[j] = AADT_AI[j] + Math.Round(vol[i] / testResults3[i]);
                        AADT_factor[j] = AADT_factor[j] + vol[i] * Convert.ToDouble(factors[1][modelDict2[fClass[i]]]) * Convert.ToDouble(factors[stc_month[i] + 1][modelDict2[fClass[i]]]);
                        distinct_county[j] = county[i];
                        distinct_fclass[j] = fClass[i];
                        AADTcount++;
                    }
                }
                outputWriter.WriteLine(distinct_county[j] + "," + distinct_station[j] + "," + distinct_fclass[j] + "," + Math.Round(AADT_AI[j] / AADTcount) + "," + Math.Round(AADT_factor[j] / AADTcount));
            }
            //outputWriter.WriteLine(DateTime.Now.ToString("yyyy/dd/MM HH:mm"));
            outputWriter.Flush();
            outputWriter.Close();
            minionBackgroundWorker.ReportProgress(100);
        }

        private void roadWayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dataSelected = roadWayComboBox.SelectedItem.ToString();
        }

        private void minionBackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Application.OpenForms["AADTForm"].Hide();
            DoneForm done = new DoneForm();
            done.Controls["outputLinkLabel"].Text = opPath + @"\" + "Output_" + DateTime.Now.ToString(@"MM.dd.yyyy_HH.mm") + ".csv";
            done.ShowDialog();
        }

        private void AADTForm_Load(object sender, EventArgs e)
        {
            progressBar1.Hide();
        }
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        public static double totalSum { get; set; }
        public Hashtable countHash = new Hashtable();
        StreamReader reader;
        //static string path { get; set; }
        public List<string> GetLineData(StreamReader reader)
        {
            List<double> factorList = new List<double>();
            int sumVal = 0;
            int numVal = 0;
            string resultString = string.Empty;
            int dayVolumeCount = 0;
            string line = reader.ReadToEnd();
            //Console.WriteLine(line);
            line = line.Replace("\r", "");
            line = line.Replace("Time Northbound Southbound", "");
            line = line.Replace("Vehicle Count Average Speed (MPH) Vehicle Count Average Speed (MPH)", "");
            line = line.Replace("Current Historical Current Historical", "");
            string[] res = line.Split('\n');
            List<string> resultStrings = new List<string>();
            foreach (string str in res)
            {
                line = str;
                //Console.WriteLine(line);
                if (line == null || line.Contains("No"))
                {
                    if (line.Contains("No"))
                    {
                        resultString = "Skip!";
                    }
                    continue;
                }
                if (line.Contains("/2016"))
                {
                    DateTime date = DateTime.ParseExact(line, "d", CultureInfo.InvariantCulture);
                    string binaryMonth = Convert.ToString(date.Month, 2);
                    binaryMonth = binaryMonth.PadLeft(4, '0');
                    binaryMonth = Regex.Replace(binaryMonth, ".{1}", "$0-");
                    resultString += binaryMonth;
                    string binaryDayOfWeek = Convert.ToString(Convert.ToInt32(date.DayOfWeek) + 1, 2);
                    binaryDayOfWeek = binaryDayOfWeek.PadLeft(3, '0');
                    binaryDayOfWeek = Regex.Replace(binaryDayOfWeek, ".{1}", "$0-");
                    resultString += binaryDayOfWeek;
                    dayVolumeCount = 0;
                    sumVal = 0;
                    numVal = 0;
                    factorList = new List<double>();
                }
                if (line.Contains(":"))
                {
                    if (line.Split(' ').Length < 5)
                    {
                        line += line + " 0";
                    }
                    numVal = (line.Split(' ')[1] == "N/A" ? 0 : Convert.ToInt32(line.Split(' ')[1])) + (line.Split(' ')[4] == "N/A" ? 0 : Convert.ToInt32(line.Split(' ')[4]));
                    if (numVal != 0)
                    {
                        factorList.Add(numVal);
                        sumVal += numVal;
                    }
                    else
                    {
                        resultString = "Skip!";
                        continue;
                    }
                }

                dayVolumeCount = sumVal;
                totalSum += numVal;
                if (factorList.Count > 23)
                {
                    foreach (double i in factorList)
                    {
                        double factor = Math.Round(i / sumVal, 3);
                        resultString += factor.ToString("0.###") + "-";
                    }

                    resultStrings.Add(resultString + "#" + dayVolumeCount.ToString());
                    resultString = "";
                }
                else
                {
                    if (resultString.Contains("Skip!"))
                    {
                        //resultString = "";
                    }
                }
            }
            if (resultStrings.Count != 0)
            {
                resultStrings.RemoveAt(resultStrings.Count - 1);
            }

            return resultStrings;
        }
        private void ExtractData(string fileLocation)
        {
            string line = string.Empty;
            totalSum = 0;
            string currentATR = fileLocation.Replace(dataPath + @"\", "").Replace(".txt", "");
            reader = new StreamReader(fileLocation);
            List<string> resultList = new List<string>();
            Hashtable aadtVal = new Hashtable();
            int count = 0;
            //Program p = new Program();
            AADTForm p = new AADTForm();
            List<string> writeList = new List<string>();
            resultList = p.GetLineData(reader);
            if (currentATR == "80")
            {
                Console.WriteLine(totalSum);
            }
            foreach (string resultString in resultList)
            {
                string tempStr = currentATR + "-" + resultString;
                if (tempStr.Length > 10 && !tempStr.Contains("Skip!"))
                {
                    //resultList.Add(resultString);
                    count++;
                    aadtVal.Add(currentATR.ToString() + "->" + count.ToString(), tempStr.Substring(tempStr.IndexOf('#') + 1));
                    tempStr = Convert.ToInt32(tempStr.Split('-')[0]) < 9 ? tempStr.Remove(resultString.IndexOf('#') + 3) : Convert.ToInt32(tempStr.Split('-')[0]) < 100 ? tempStr.Remove(resultString.IndexOf('#') + 4) : tempStr.Remove(resultString.IndexOf('#') + 5);
                    writeList.Add(tempStr);
                }
            }

            TextWriter writer = File.AppendText(path + "Result.txt");
            TextWriter aadtWriter = File.AppendText(path + "AADTVal.txt");
            aadtWriter.WriteLine(currentATR + " - " + Math.Round(totalSum / count));
            if (count >= 180)
            {
                int decr = 1;
                foreach (string s in writeList)
                {
                    double AADTFactor = Math.Round(Convert.ToInt32(aadtVal[currentATR.ToString() + "->" + (decr++).ToString()]) / Math.Round(totalSum / count), 3);
                    writer.WriteLine(s.Remove(s.IndexOf('#')) + AADTFactor.ToString());
                }
            }
            else
            {
                Console.WriteLine(currentATR);
            }
            writer.Flush();
            aadtWriter.Flush();
            reader.Close();
            writer.Close();
            aadtWriter.Close();
        }

        private void minionBackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            Text = "Progress: " + e.ProgressPercentage.ToString() + "%";
        }
    }
}