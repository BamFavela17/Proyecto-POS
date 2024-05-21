
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
    public partial class CRUDhorarios : Form
    {
        public CRUDhorarios()
        {
            InitializeComponent();
        }

        private void CRUDhorarios_Load(object sender, EventArgs e)
        {
           CN_Crud n = new CN_Crud();
            tblHorarios.DataSource = n.Mostrarhorario();
        }
    }
}
