
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
namespace LaCrudaY_.CRUD
{
    public partial class CRUDclientes : Form
    {
        private string idCtl = null;
        public CRUDclientes()
        {
            InitializeComponent();
        }
        CN_Crud objCN = new CN_Crud();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CRUDclientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void tblClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void limpiarForm()
        {

           
            txtNom.Clear();
            cmbImportante.SelectedItem = null;
        }
        bool Editar = false;
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string importancia = cmbImportante.Text, nom = txtNom.Text;

            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    objCN.Insertarcliente(nom, importancia);
                    MostrarClientes();
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
                    objCN.Editarcliente(nom, importancia, idCtl);
                    MessageBox.Show("se edito correctamente");
                    MostrarClientes();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }

            }
        }
        public void MostrarClientes()
        {
            CN_Crud obj = new CN_Crud();
            tblClientes.DataSource = obj.Mostrarclientes();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tblClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = tblClientes.SelectedRows[0];
                int index = currentRow.Index;
                Editar = true;
                txtNom.Text = tblClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                cmbImportante.SelectedItem = tblClientes.CurrentRow.Cells["importancia"].Value.ToString();
                idCtl = tblClientes.CurrentRow.Cells["idC"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

    private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Al eliminarlo no podras recuperarlo\n ¿Estas de acuerdo?", "eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (tblClientes.SelectedRows.Count > 0)
                {
                    idCtl = tblClientes.CurrentRow.Cells["idC"].Value.ToString();
                    objCN.EliminarEmp(idCtl);
                    MessageBox.Show("Eliminado correctamente");
                    MostrarClientes();
                }
                else
                    MessageBox.Show("seleccione una fila por favor");
            }

        }
    }
}
