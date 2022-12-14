using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zh2_ujjckk
{
    public partial class Alkalmazas : Form
    {
        public Alkalmazas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlFogasok userControlFogasok = new UserControlFogasok();
            panel1.Controls.Add(userControlFogasok);
            userControlFogasok.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlHozzavalok UserControlHozzavalok = new UserControlHozzavalok();
            panel1.Controls.Add(UserControlHozzavalok);
            UserControlHozzavalok.Dock = DockStyle.Fill;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlFogasok userControlFogasok = new UserControlFogasok();
            panel1.Controls.Add(userControlFogasok);
            userControlFogasok.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 userControl3 = new UserControl3();
            panel1.Controls.Add(userControl3);
            userControl3.Dock = DockStyle.Fill;
        }
    }
}
