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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-JSTETRK;Initial Catalog=performans_o;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);

        private void vericekme_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    vericekme_listbox.Items.Clear();


                    connect.Open();

                    SqlCommand command = new SqlCommand("select * from Kisiler", connect);
                    SqlDataReader read = command.ExecuteReader();



                                        while (read.Read())
                                        {
                                              vericekme_listbox.Items.Add(read[1] + " " + read[2] + " ");
                                        }
                                        connect.Close();

                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Hata Meydana geldi." + error.Message);
            }
        }
    }
}


