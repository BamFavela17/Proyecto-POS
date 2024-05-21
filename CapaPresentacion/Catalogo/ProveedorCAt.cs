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
namespace LaCrudaY_.Catalogo
{
    public partial class ProveedorCAt : Form
    {
        public ProveedorCAt()
        {
            InitializeComponent();
        }

        private void ProveedorCAt_Load(object sender, EventArgs e)
        {
            CN_Crud n = new CN_Crud();
            tblProveedor.DataSource = n.Mostrarproveedor();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
