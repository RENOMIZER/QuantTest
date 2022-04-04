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
        public loginPage()
        {
            InitializeComponent();
        }

        private void login()
        {
            for (int i = 0; register.loginList.Count != i; i++)
            {
                if (register.loginList[i][0] == loginBox.Text)
                {
                    if (passBox.Text == register.loginList[i][1])
                    {
                        register.curSess = i;

                        this.Hide();
                        mainPage mainPage = new mainPage();
                        mainPage.Show();
                    }
                }
            }
        }

        private void loginPage_Load(object sender, EventArgs e)
        {
            if (!register.loginList.ContainsKey(1) || !register.loginList.ContainsKey(2) || !register.loginList.ContainsKey(3) || !register.loginList.ContainsKey(0))
            {
                register.loginList.Add(0, new List<string> { "admin", "admin", "Константин", "Суходолин", "15", "true" });
                register.loginList.Add(1, new List<string> { "usr1", "usr1", "Егор", "Осипов", "16", "false" });
                register.loginList.Add(2, new List<string> { "usr2", "usr2", "Мирон", "Беляев", "13", "false" });
                register.loginList.Add(3, new List<string> { "usr3", "usr3", "Арина", "Ковалева", "14", "false" });
                register.loginList.Add(4, new List<string> { "usr4", "usr4", "Кирилл", "Петрищев", "17", "true" });
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
