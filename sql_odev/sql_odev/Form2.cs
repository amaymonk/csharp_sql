using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sql_odev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-JSTETRK;Initial Catalog=performans_o;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void aktarmabutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                {

                    connect.Open();


                             string login = "insert into Kisiler (ad,soyad) values(@ad,@soyad)";

                             SqlCommand command = new SqlCommand(login, connect);


                    command.Parameters.AddWithValue("@ad", name_textbox.Text);
                    command.Parameters.AddWithValue("@soyad", surname_textbox.Text);


                    command.ExecuteNonQuery();

                    connect.Close();


                    DialogResult message = MessageBox.Show("Kayıt işleminiz başarıyla tamamlandı.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    if (message == DialogResult.OK)
                    {
                        DialogResult message2 = MessageBox.Show("Veri Çekme işlemine dönmek ister misiniz ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (message2 == DialogResult.OK)
                        {
                            Form3 frm3 = new Form3();
                            frm3.Show();

                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Hata Meydana geldi." + error.Message);
            }
        }
    }
}
