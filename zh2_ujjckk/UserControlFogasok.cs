using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh2_ujjckk.Models;

namespace zh2_ujjckk
{
    public partial class UserControlFogasok : UserControl
    {
        EtkezesContext context = new EtkezesContext();
        public UserControlFogasok()
        {
            InitializeComponent();
            FogasSzures();
        }

        private void textBoxFogasok_TextChanged(object sender, EventArgs e)
        {
            FogasSzures();
        }

        private void FogasSzures()
        {
            var fogasok = from x in context.Fogasok where x.FogasNev.Contains(textBoxFogasok.Text) select x;
            listBoxFogasok.DataSource = fogasok.ToList();
            listBoxFogasok.DisplayMember = "FogasNev";
        }

        private void listBoxFogasok_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = ((Fogasok)listBoxFogasok.SelectedItem).FogasId;
            var a = from x in context.Receptek
                    where x.FogasId == id
                    select new
                    {
                        x.Nyersanyag.NyersanyagNev,
                        x.Mennyiseg4fo,
                        x.Nyersanyag.MennyisegiEgyseg.EgysegNev,
                    };
            dataGridViewFogasok.DataSource = a.ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
