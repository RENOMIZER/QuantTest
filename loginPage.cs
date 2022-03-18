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
    public partial class loginPage : Form
    {
        public static Dictionary<int, List<string>> loginList = new Dictionary<int, List<string>>();

        public static int curSess;

        public loginPage()
        {
            InitializeComponent();
        }

        private void login()
        {
            for (int i = 0; loginList.Count - 1 >= i; i++)
            {
                if (loginList[i][0] == loginBox.Text)
                {
                    if (passBox.Text == loginList[i][1])
                    {
                        curSess = i;

                        this.Hide();
                        mainPage mainPage = new mainPage();
                        mainPage.Show();
                    }
                }
            }
        }

        private void loginPage_Load(object sender, EventArgs e)
        {
            if (!loginList.ContainsKey(1) || !loginList.ContainsKey(0))
            {
                loginList.Add(0, new List<string> { "admin", "admin", "Константин", "Суходолин", "IT", "true" });
                loginList.Add(1, new List<string> { "def", "def", "Константин", "Суходолин", "IT", "false" });
            }
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            login();
        }

        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
