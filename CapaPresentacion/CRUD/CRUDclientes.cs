
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
        public CRUDclientes()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CRUDclientes_Load(object sender, EventArgs e)
        {
           CN_Crud clientes = new CN_Crud();
            tblClientes.DataSource = clientes.Mostrarclientes();
        }

        private void tblClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
