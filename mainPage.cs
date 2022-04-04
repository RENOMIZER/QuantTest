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
        int curSess;

        bool admin = false;

        bool wasCalled = false;

        public List<string> quant = new List<string>();

        public mainPage()
        {
            InitializeComponent();
        }

        private void Fill()
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

                tabAdmin.Columns.Add("Имя", 80, HorizontalAlignment.Left);
                tabAdmin.Columns.Add("Фамилия", 80, HorizontalAlignment.Left);
                tabAdmin.Columns.Add("Возраст", 80, HorizontalAlignment.Left);
                tabAdmin.Columns.Add("Администратор", 80, HorizontalAlignment.Left);

                tabMain.Columns.Add("Курс", 80, HorizontalAlignment.Left);
                tabMain.Columns.Add("Кол-во учеников", 80, HorizontalAlignment.Left);

                wasCalled = true;
            }
        }

        private void Check()
        {
            Fill();

            curSess = register.curSess;

            if (register.loginList[curSess][5] == "true")
            {
                admin = true;
            }

            if (admin)
            {                
                addButton.Text = "Управление пользователями";
                
                tabMain.Size = new Size(288, tabMain.Size.Height);

                tabAdmin.Visible = true;
            }
            else
            {                
                addButton.Text = "Выбрать курс";
                
                edtButton.Visible = false;
            }
        }

        private void updateList()
        {
            if (admin)
            {
                for (int i = 0; tabAdmin.Items.Count != 0;)
                {
                    tabAdmin.Items.RemoveAt(i);
                }

                for (int i = 0; register.loginList.Count != i; i++)
                {
                    //new register();

                    string isAdmin;
                    if (register.loginList[i][5] == "true")
                    {
                        isAdmin = "Да";
                    }
                    else
                    {
                        isAdmin = "Нет";
                    }

                    var item = new ListViewItem(new[] { register.loginList[i][2], register.loginList[i][3], register.loginList[i][4], isAdmin });
                    tabAdmin.Items.Add(item);
                }

                for (int i = 0; tabMain.Items.Count != 0;)
                {
                    tabMain.Items.RemoveAt(i);
                }

                for (int i = 0; quant.Count != i; i++)
                {
                    tabMain.Items.Add(quant[i]);    
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
            Check();

            updateList();

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
                memAdd memAdd = new memAdd();
                memAdd.Show();
            }
            else
            {
                MessageBox.Show("В разработке");
            }
        }

        private void updButton_Click(object sender, EventArgs e)
        {
            updateList();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginPage loginPage = new loginPage();
            loginPage.Show();
        }

        private void edtButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке");
        }
    }
}
