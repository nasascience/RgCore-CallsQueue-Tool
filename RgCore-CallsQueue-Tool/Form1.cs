using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RgCore_CallsQueue_Tool.Services;

namespace RgCore_CallsQueue_Tool
{
    public partial class Form1 : Form
    {
        public CentralCommsService centralCommsService = new CentralCommsService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var d = DateTime.UtcNow.Date;
            //var formatted = d.Year + "-" + d.Month + "-" + d.Day; //'2020-07-06'
            totalCountLabel.Visible = false;
            CallsCountLabel.Visible = false;
            status.Text = "Starting...";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            totalCountLabel.Visible = true;
            CallsCountLabel.Visible = true;
            //status.Text = "Querying...";
            var CallCount = GetCallQueues();
            CallsCountLabel.Text = CallCount.Result.ToString();
            status.Visible = false;
        }

        private async Task<int> GetCallQueues()
        {
           
            var calls = await centralCommsService.GetCallQueues();
            return calls.Count;
        }

        private void CallsCountLabel_Click(object sender, EventArgs e)
        {

        }

        private void status_Click(object sender, EventArgs e)
        {

        }
    }
}
