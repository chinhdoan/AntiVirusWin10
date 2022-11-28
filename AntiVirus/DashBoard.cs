using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using Ganss.Excel;
using System.Diagnostics;

namespace AntiVirus
{


    public partial class DashBoard : Form
    {


        public string getHashValue;
        public string getPath;
        public int getFilePathLength;
        public string status;
        Result rs = new Result();
        Result singleFileResult = new Result();
        Heuristic heu = new Heuristic();
        public int count;
        public int countFileinPath;
        public static int countCheck;
        public string myListPath;
        public string myResultPath;
        public Boolean checkDuplicate,hasCalled;
        public class dataModel {
            public string virusType { get; set; }
            public string md5 { get; set; }
            public string sha1 { get; set; }
        }

        public DashBoard()
        {
            InitializeComponent();

        }
        private void DashBoard_Load(object sender, EventArgs e)
        {
            myListPath = Directory.GetParent(Application.ExecutablePath).FullName + "\\list.txt";
            myResultPath = Directory.GetParent(Application.ExecutablePath).FullName + "\\result.txt";
        }
        private void scanButton_Click(object sender, EventArgs e)
        {
            statusScanLbl.Visible = true;
            OpenFileDialog ofd = new OpenFileDialog();
            countCheck = 0;
            ofd.Filter = "Application (*.exe)|*.exe| All files|*.exe;*.dll";
            StreamWriter sw = new StreamWriter(myListPath);
            if (ofd.ShowDialog() == DialogResult.OK) {
                getPath = ofd.FileName;
                sw.WriteLine(getPath);
                sw.Close();
                getHashValue = fileToMd5(getPath);
                if (heuristicSwitch.Checked == false)
                    checkMd5Data(getHashValue, getPath);
                if (heuristicSwitch.Checked == true)
                    checkHeuristicResults();
                setScanValue(getHashValue, getPath, 1, 1, 1);
            }
            //singleFileResult.setResultValue(1,1,status);
            singleFileResult.setTotalValue(1);
            Thread.Sleep(1000);
            singleFileResult.Show();
            this.Visible = false;
            statusScanLbl.Visible = false;
        }

        public string md5ToHex(byte[] md5) {
            string hexString = "";
            foreach (byte b in md5) {

                hexString += b.ToString("x2").ToUpper();
            }
            return hexString;
        }
        private string fileToMd5(string filePath)
        {
            byte[] getDataBytes = File.ReadAllBytes(filePath);
            MD5 md5 = MD5.Create();
            byte[] myMd5 = md5.ComputeHash(getDataBytes);
            return md5ToHex(myMd5);
        }
  
        private void folderScanButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            countCheck = 0;
            count = 0;
            statusScanLbl.Visible = true;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(myListPath, "");
                string rootpath = fbd.SelectedPath;
                if (heuristicSwitch.Value == true)
                {
                    savePathList(rootpath);
                    heu.getResults();
                }
                getFilePath(rootpath);
                string[] dirs = Directory.GetDirectories(rootpath, "*", SearchOption.AllDirectories);
                checkDuplicate = false;
                foreach (string dir in dirs) {
                    countFileinPath = 0;
                    if (heuristicSwitch.Value == true)
                    {
                        savePathList(dir);      
                    }
                    if(checkDuplicate == false)
                    {
                        hasCalled = false;
                        heu.getResults();
                    }    
                    getFilePath(dir);
                }
                
                Thread.Sleep(1000);
                this.Visible = false;
                statusScanLbl.Visible = false;
                rs.Show();
            }

        }
        public void savePathList(string directory) {
            string[] filePaths = Directory.GetFiles(directory);
            File.AppendAllLines(myListPath, filePaths);
        }
        public void getFilePath(string directory)
        {
            string[] filePaths = Directory.GetFiles(directory);
            foreach (string filePath in filePaths) {
                getHashValue = fileToMd5(filePath);
                if (heuristicSwitch.Checked == false)
                    checkMd5Data(getHashValue, filePath);
                if (heuristicSwitch.Value == true && hasCalled == false)
                    checkHeuristicResults();
                hasCalled = true;
                getPath = filePath;
                getFilePathLength = filePaths.Length;
                count++;
                countFileinPath++;
                setScanValue(getHashValue, getPath, countFileinPath * 100 / getFilePathLength, getFilePathLength * 100 / getFilePathLength, count);
                rs.setTotalValue(count);
            }
            checkDuplicate = true;
        }

        public void setScanValue(string md5, string currentFilePath, int scanProgressCount = 0, int scanProgressMaxCount = 1, int totalScan = 0)
        {
            md5Lbl.Text = md5;
            md5Lbl.Update();

            fileScanLbl.Text = currentFilePath;
            fileScanLbl.Update();

            scanProgress.Minimum = 0;
            scanProgress.Maximum = scanProgressMaxCount;
            scanProgress.Value = scanProgressCount;
            scanProgress.SubScriptText = totalScan.ToString() + "\n files";
        }
        public void checkMd5Data(string md5, string currentFilePath) {
            string parentPath = Directory.GetParent(Application.ExecutablePath).FullName;
            string dataPath = parentPath + "\\MalwareData.xlsx";
            var virusData = new ExcelMapper(dataPath).Fetch<dataModel>();
            foreach (var virus in virusData) {
                if (md5 == virus.md5)
                {
                    countCheck++;
                    rs.setVirusResult(countCheck, currentFilePath, virus.virusType);
                    singleFileResult.setVirusResult(countCheck, currentFilePath, virus.virusType);
                }
            }   
        }
        public void checkHeuristicResults()
        {
            string[] result = File.ReadAllLines(myResultPath);
            string[] path = File.ReadAllLines(myListPath);
            Console.WriteLine("check:" + result);
            for (int i = 0; i < result.Length; i ++){
                if (result[i] == "malicious")
                {
                    countCheck++;
                    Console.WriteLine(countCheck);
                    rs.setVirusResult(countCheck, path[i], "Suspicious");
                    singleFileResult.setVirusResult(countCheck, path[i], "Suspicious");
                }
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            Process.Start("https://github.com/chinhdoan");
            Process.Start("https://www.facebook.com/Eagle.TeamCFVNno1");
        }
        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void homeButtonImg_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            homePanel.Visible = true;
        }
        private void settingButtonImg_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            settingPanel.Visible = true;
        }
        private void infoButtonImg_Click(object sender, EventArgs e)
        {
            settingPanel.Visible = false;
            panel2.Visible = true;
        }

      
    }
}
