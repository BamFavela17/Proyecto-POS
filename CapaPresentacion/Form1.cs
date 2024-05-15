using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCrudaY_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Acceso();
        }
        private void Acceso()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=BAMFAVELA\ABRAHAM_A_F_F;Initial Catalog=PuntoVentaCahuamanta;Integrated Security=True;TrustServerCertificate=True");
            try
            {
            cn.Open();
            SqlCommand cm = new SqlCommand("select usuario, contraseña from Usuarios where usuario = '" + txtUser.Text + "' and contraseña = '" + txtPass.Text + "'", cn);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Acceso concedido", "Sistema");
                    main m = new main();
                    m.ShowDialog();
                    this.Hide();
            }
            else
            {
                MessageBox.Show("Acceso denegado", "Sistema");
            }
            }catch(Exception e)
            {
                MessageBox.Show("error: " + e.Message);
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void fechaHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
