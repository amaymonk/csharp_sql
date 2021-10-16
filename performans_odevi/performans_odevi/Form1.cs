using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace performans_odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Crimson;


            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            veri_cekme va = new veri_cekme();
            va.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            veri_aktarma vaa = new veri_aktarma();
            vaa.Show();
        }
    }
}
