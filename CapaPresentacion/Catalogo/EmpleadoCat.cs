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
    public partial class EmpleadoCat : Form
    {
        public EmpleadoCat()
        {
            InitializeComponent();
        }

        private void EmpleadoCat_Load(object sender, EventArgs e)
        {
          CN_Crud obj = new CN_Crud();
            tblEmpleado.DataSource = obj.MostrarEmp();
            CN_Crud oj = new CN_Crud();
            tblHorario.DataSource = oj.Mostrarhorario();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
