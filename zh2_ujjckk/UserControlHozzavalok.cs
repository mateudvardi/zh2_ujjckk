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
    public partial class UserControlHozzavalok : UserControl
    {
        EtkezesContext context = new EtkezesContext();
        public UserControlHozzavalok()
        {
            InitializeComponent();
            NyersanyagSzures();

        }

        private void textBoxHozzavalok_TextChanged(object sender, EventArgs e)
        {
            NyersanyagSzures();
        }

        private void NyersanyagSzures()
        {
            var hozzavalok = from x in context.Nyersanyagok where x.NyersanyagNev.Contains(textBoxHozzavalok.Text) select x;
            listBoxHozzavalok.DataSource = hozzavalok.ToList();
            listBoxHozzavalok.DisplayMember = "NyersanyagNev";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
