using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkTesting.Classes;

namespace WorkTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMSN_Click(object sender, EventArgs e)
        {
            labelMSN.Text = GetInfo.FindMachineSerialNumber();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMBSN_Click(object sender, EventArgs e)
        {
            labelMBSN.Text = GetInfo.FindMotherboardSerialNumber();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPSN_Click(object sender, EventArgs e)
        {
            labelPSN.Text = GetInfo.FindProcessorSerialNumber();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            labelUUID.Text = GetInfo.CombineFound().ToString();
        }

    }
}
