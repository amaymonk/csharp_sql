using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D; 

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

        private void button1_Click(object sender, EventArgs e)
        {
            veri_aktarma vaa = new veri_aktarma();
            vaa.Show();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);


            GraphicsPath gp = new GraphicsPath();

            gp.AddEllipse(new Rectangle(Point.Empty, this.Size));

            this.Region = new Region();
        }

        private void veriaktarmabutton_Click(object sender, EventArgs e)
        {
            veri_cekme va = new veri_cekme();
            va.Show();
        }

        private void vericekmebutton_Click(object sender, EventArgs e)
        {
            veri_aktarma vaa = new veri_aktarma();
            vaa.Show();

            
        }

     
    }
}
