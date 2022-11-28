using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace AntiVirus
{
    public partial class Result : Form
    {
        
        public Result()
        {
            InitializeComponent();
             statusLbl.Text = "Clean";
             statusLbl.ForeColor = Color.Green;
        }


        private void homeButtonImg_Click(object sender, EventArgs e)
        {
            DashBoard db = new DashBoard();
            this.Visible = false;
            db.Visible = true;
        }
        public void setTotalValue(int totalScan) {
            countScanLbl.Text = totalScan.ToString();
            countScanLbl.Update();
        }
        public void setVirusResult(int threadCount, string virusPath, string virusType) {

            threadCountLbl.Text = threadCount.ToString();
            threadCountLbl.Update();
            

             if (threadCount > 0) {
                statusLbl.Text = "Infected!";
                statusLbl.ForeColor = Color.Red;
                statusLbl.Update();


                ThreadList.Items.Add(virusType.ToUpper());
                ThreadList.Items.Add("found at: "+virusPath);
                ThreadList.Items.Add("\n");
                ThreadList.Update();
            }
        }

        private void quitButtonImg_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
