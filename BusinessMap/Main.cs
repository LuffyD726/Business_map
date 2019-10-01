using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessMap
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddBusiness addBusiness = new AddBusiness();
            addBusiness.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string district = textBox1.Text;
            string province = textBox2.Text;
            string country = textBox3.Text;
            StringBuilder queryaddress = new StringBuilder();
            queryaddress.Append("https://www.google.co.il/maps/@32.0331776,34.7906048,15z?hl=iw");
            if (district != string.Empty) queryaddress.Append(district + "," + "+");
            if (district != string.Empty) queryaddress.Append(province + "," + "+");
            if (district != string.Empty) queryaddress.Append(country + "," + "+");
            map.Navigate(queryaddress.ToString());


        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
          

        }
    }
}
