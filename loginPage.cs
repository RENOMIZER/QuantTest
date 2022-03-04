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
    public partial class loginPage : Form
    {
        Dictionary<string, string> members;

        public loginPage()
        {
            InitializeComponent();
            memAdd mem = new memAdd();
            mem.Show();

        }

        private async Task loginButton_ClickAsync(object sender, EventArgs e)
        {
            string path = @"..\Members\members.json";

            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    members = new Dictionary<string, string>() { line };
                }
            }

            for (int i = 0, id = 0; id == Convert.ToInt32(profileText); i++)
            {
                int memID = 
            }
        }
    }
}
