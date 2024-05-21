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
    public partial class Materiales : Form
    {
        public Materiales()
        {
            InitializeComponent();
        }

        private void Materiales_Load(object sender, EventArgs e)
        {
            CN_Crud n_Crud = new CN_Crud();
            CN_Crud cN_Crud = new CN_Crud();
            tblCategorias.DataSource = n_Crud.MostrarCategoria();
            tblMateriales.DataSource = cN_Crud.MostrarMateriales();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
