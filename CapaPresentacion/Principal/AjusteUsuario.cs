using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            tstPass.Enabled = false;
            DTNacimiento.Enabled = false;
            txtTel.Enabled = false;
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
            tstPass.Enabled = true;
            DTNacimiento.Enabled = true;
            txtTel.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnEdit.BringToFront();
            txtNom.Enabled = false;
            txtApe.Enabled = false;
            txtCorreo.Enabled = false;
            txtDir.Enabled = false;
            txtUser.Enabled = false;
            tstPass.Enabled = false;
            DTNacimiento.Enabled = false;
            txtTel.Enabled = false;
            /// editar los datos del usuario
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
