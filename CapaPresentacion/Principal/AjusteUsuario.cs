using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace LaCrudaY_.Principal
{
    public partial class AjusteUsuario : Form
    {
        public AjusteUsuario()
        {
            InitializeComponent();
            txtNom.Enabled = false;
            txtApe.Enabled = false;
            txtCorreo.Enabled = false;
            txtDir.Enabled = false;
            txtUser.Enabled = false;
            txtPass.Enabled = false;
            DTNacimiento.Enabled = false;
            txtTel.Enabled = false;
            cargarDatos();
        }
        private void cargarDatos()
        {

            txtNom.Text = UserCache.nombres;
            txtApe.Text = UserCache.apellidos;
            txtDir.Text = UserCache.direccion;
                txtTel.Text = UserCache.telefono;
               txtCorreo.Text = UserCache.correo;
                txtUser.Text = UserCache.usuario;
            txtPass.Text = UserCache.contraseña;
           DTNacimiento.Text = UserCache.fhNacido.ToShortDateString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AjusteUsuario_Load(object sender, EventArgs e)
        {
            // nom, ape,fhN,tel,direccion, correo, user, pass

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.BringToFront();
            txtNom.Enabled = true;
            txtApe.Enabled = true;
            txtCorreo.Enabled = true;
            txtDir.Enabled = true;
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            DTNacimiento.Enabled = true;
            txtTel.Enabled = true;
        }
            CN_Crud objCN = new CN_Crud();
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Todos tus datos estan correctos?", "Actualizacion de datos personales", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                btnEdit.BringToFront();
                txtNom.Enabled = false;
                txtApe.Enabled = false;
                txtCorreo.Enabled = false;
                txtDir.Enabled = false;
                txtUser.Enabled = false;
                txtPass.Enabled = false;
                DTNacimiento.Enabled = false;
                txtTel.Enabled = false;
                //
                string nom = txtNom.Text, ape = txtApe.Text, dir = txtDir.Text, tel = txtTel.Text, cor = txtCorreo.Text, user = txtUser.Text, pass = txtPass.Text;
                DateTime fhN = DateTime.Parse(DTNacimiento.Text);
                string id = UserCache.IdUser.ToString();
                /// editar los datos del usuario
                try
                {
                    objCN.ActualizaMisDatos(nom, ape, fhN, dir, tel, cor, user, pass, id);
                    MessageBox.Show("se edito correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo problemas al editar, "+ex);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
