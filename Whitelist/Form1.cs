using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whitelist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string whitelist = new System.Net.WebClient() { Proxy = null }.DownloadString("https://pastebin.com/raw/0ysn9yFw");//Whitelist 
            string blacklist = new System.Net.WebClient() { Proxy = null }.DownloadString("https://pastebin.com/raw/QdBStAPz");//Blacklisted
            if (blacklist.Contains(email.Text))
            {
                MessageBox.Show("Blacklisted! Closing...");
                Application.Exit();
            }
            if (whitelist.Contains(email.Text))
            {
                MessageBox.Show("Whitelisted!");
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Put valid key bruhh.");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
