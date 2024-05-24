
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Windows.Forms;

using CapaNegocio;
using LaCrudaY_.CRUD;
using LaCrudaY_.Principal;
using CapaSoporte;

namespace LaCrudaY_
{
    public partial class CRUDempleado : Form
    {
       CN_Crud objCN = new CN_Crud();
        private string idemp = null;
        private bool Editar = false;
        public CRUDempleado()
        {
            InitializeComponent();
        }

        private void CRUDempleado_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
            
        }
        
        public void MostrarEmpleados()
        {
            CN_Crud obj = new CN_Crud();
            tblUser.DataSource = obj.MostrarEmp();
        }

        private void tblUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tblUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
           
            int tipo = (cmbPuesto.SelectedIndex + 1) ,turno= Convert.ToInt16(txtTurno.Text);
            string nom= txtNombre.Text, ape= txtApellido.Text, dir = txtDir.Text, tel=txtTel.Text,cor=txtCorreo.Text,user=txtuser.Text,pass=txtpass.Text;
            DateTime fhN = DateTime.Parse(txtFHN.Text), fhC = DateTime.Parse(txtFHC.Text);
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    objCN.InsertarEmp(nom, ape, tipo, fhN, fhC, dir, tel, cor, turno, user, pass);
                    MostrarEmpleados();
                    limpiarForm();
                    MessageBox.Show("se inserto correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (Editar == true)
            {

                try
                {
                    objCN.EditarEmp(nom, ape, tipo, fhN, fhC, dir, tel, cor, turno, user, pass, idemp);
                    MessageBox.Show("se edito correctamente");
                    MostrarEmpleados();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }

            }


        }
        public void limpiarForm()
        {
          
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtDir.Clear();

            cmbPuesto.SelectedItem = null;  
            txtTel.Clear();
            txtTurno.Clear();
            txtuser.Clear();  
            txtpass.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Al eliminarlo no podras recuperarlo\n ¿Estas de acuerdo?", "eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (tblUser.SelectedRows.Count > 0)
            {
                idemp = tblUser.CurrentRow.Cells["idU"].Value.ToString();
                objCN.EliminarEmp(idemp);
                MessageBox.Show("Eliminado correctamente");
                MostrarEmpleados();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
            }
        }
           

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tblUser.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = tblUser.SelectedRows[0];
                int index = currentRow.Index;
                Editar = true;
                txtNombre.Text = tblUser.CurrentRow.Cells["Nombres"].Value.ToString();
                txtApellido.Text = tblUser.CurrentRow.Cells["Apellidos"].Value.ToString();
                cmbPuesto.SelectedIndex = Convert.ToInt32(tblUser.Rows[index].Cells["idPuesto"].Value);
                txtFHN.Text = tblUser.CurrentRow.Cells["FhNa"].Value.ToString();
                txtFHC.Text = tblUser.CurrentRow.Cells["FhCon"].Value.ToString();
                txtDir.Text = tblUser.CurrentRow.Cells["Dir"].Value.ToString();
                txtTel.Text = tblUser.CurrentRow.Cells["Tel"].Value.ToString();
                txtCorreo.Text = tblUser.CurrentRow.Cells["Correo"].Value.ToString();
                txtTurno.Text = tblUser.CurrentRow.Cells["idTurno"].Value.ToString();
                txtuser.Text = tblUser.CurrentRow.Cells["usuario"].Value.ToString();
                txtpass.Text = tblUser.CurrentRow.Cells["contraseña"].Value.ToString();
                idemp = tblUser.CurrentRow.Cells["idU"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUDhorarios h = new CRUDhorarios();
            h.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }

}
