using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class mainPage : Form
    {
        loginPage lp = new loginPage();

        memAdd ma = new memAdd();

        int curSess;

        public mainPage()
        {
            InitializeComponent();

            testAdd.Hide();
        }

        private void adminCheck()
        {
            if (loginPage.loginList[curSess][5] == "true")
            {
                testAdd.Show();
            }
        }

        private void mainPage_Load(object sender, EventArgs e)
        {
            new loginPage();
            curSess = loginPage.curSess;
            testLabel.Text = curSess.ToString();
            adminCheck();
        }
        
        private void mainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            lp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ma.Show();
        }
    }
}
