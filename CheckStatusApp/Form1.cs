using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckStatusApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Uri> uris = new List<Uri>
            {
                new Uri("https://google.com"),
                new Uri("https://amazon.com/")
            };
            foreach (Uri site in uris)
            {
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(site);
                HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
                string[] data = { site.ToString(), (response.StatusCode).ToString()};
                ListViewItem row = new ListViewItem(data);
                row.UseItemStyleForSubItems = false;
                row.SubItems[1].BackColor = (int)response.StatusCode >= 200 && (int)response.StatusCode <= 400 ? Color.LightGreen : Color.Red;
                lstView_main.Items.Add(row);
                response.Close();
            }

        }
    }
}
