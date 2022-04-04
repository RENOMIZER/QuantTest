using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace App
{
    public partial class memAdd : Form
    {

        static public string login, password, name, lastname, age, admin;

        public memAdd()
        {
            InitializeComponent();
        }

        private void memAdd_Load(object sender, EventArgs e)
        {

        }

        private void memAddButton_Click(object sender, EventArgs e)
        {
            login = loginBox.Text;
            password = passBox.Text;
            name = firstNameText.Text;
            lastname = lastNameText.Text;
            age = ageBox.Text;
            admin = Convert.ToString(adminCheck);

            register.addMember();
        }
    }
}
