using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GÖRSEL_FİNAL
{
    public partial class Anasayfaa : Form
    {
        public Anasayfaa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriEkle musterieklefrm = new MusteriEkle();
            musterieklefrm.Show();
          
        }
    }
}
