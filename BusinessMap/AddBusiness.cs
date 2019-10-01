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

namespace BusinessMap
{
    public partial class AddBusiness : Form
    {
        public AddBusiness()
        {
            InitializeComponent();
        }

        private void AddBusiness_Load(object sender, EventArgs e)
        {
            this.TopMost = true; 
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter(@"C:\Users\user\source\repos\BusinessMap v0.2\Places.txt", true);
            txt.WriteLine(textBox1.Text);
            txt.Close();
            this.Close();
        }
    }
}
