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
        memList mem = new memList();

        Random rnd = new Random();

        public memAdd()
        {
            InitializeComponent();
        }

        private void memAdd_Load(object sender, EventArgs e)
        {

        }

        private void memAddButton_Click(object sender, EventArgs e)
        {
            mem.firstName = firstNameText.Text;
            mem.lastName = lastNameText.Text;
            mem.admin = adminCheck.Checked;
            mem.password = passBox.Text;
            mem.id = rnd.Next(100000000, 999999999);


            string memListJSON = JsonConvert.SerializeObject(mem);
            string path = @"..\Members\members.json";

            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(memListJSON.ToString());
                tw.Close();
            }
        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
