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
        memAdd memAdd = new memAdd();

        Random random = new Random();

        int curSess;

        bool admin = false;

        bool wasCalled = false;

        public List<string> quant = new List<string>();

        public mainPage()
        {
            InitializeComponent();
        }

        private void quantFill()
        {
            if (!wasCalled)
            {
                quant.Add("Робоквантум");
                quant.Add("Биоквантум");
                quant.Add("Геоквантум");
                quant.Add("IT-Квантум");
                quant.Add("Энерджиквантум");
                quant.Add("Хайтек Цех");
                quant.Add("Шахматы");

                wasCalled = true;
            }
        }

        private void adminCheck()
        {
            curSess = register.curSess;

            if (register.loginList[curSess][5] == "true")
            {
                addButton.Text = "Добавить пользователя";

                admin = true;

            }
            else
            {
                addButton.Text = "Выбрать курс";
            }

            if (admin)
            {

                for (int i = 0; tabMain.Items.Count != 0;)
                {
                    tabMain.Items.RemoveAt(i);
                }

                for (int i = 0; register.loginList.Count != i; i++)
                {
                    new register();
                    tabMain.Items.Add(register.loginList[i][2]);
                }
            }
            else
            {
                for (int i = 0; tabMain.Items.Count != 0;)
                {
                    tabMain.Items.RemoveAt(i);
                }

                switch (curSess)
                {
                    case 1:
                        tabMain.Items.Add(quant[2]);
                        tabMain.Items.Add(quant[0]);
                        break;
                    case 2:
                        tabMain.Items.Add(quant[4]);
                        tabMain.Items.Add(quant[1]);
                        break;
                    case 3:
                        tabMain.Items.Add(quant[5]);
                        tabMain.Items.Add(quant[6]);
                        break;
                }
                
            }
        }

        private void mainPage_Load(object sender, EventArgs e)
        {
            quantFill();

            adminCheck();

            firstnameLabel.Text = register.loginList[curSess][2];

            lastnameLabel.Text = register.loginList[curSess][3];

            ageText.Text = register.loginList[curSess][4];
        }

        private void mainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (admin)
            {
                memAdd.Show();
            }
            else
            {
                MessageBox.Show("В разработке");
            }
        }

        private void updButton_Click(object sender, EventArgs e)
        {
            adminCheck();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginPage loginPage = new loginPage();
            loginPage.Show();
        }
    }
}
