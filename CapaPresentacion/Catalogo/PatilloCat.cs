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
    public partial class PatilloCat : Form
    {
        public PatilloCat()
        {
            InitializeComponent();
        }

        private void PatilloCat_Load(object sender, EventArgs e)
        {
            CN_Crud n = new CN_Crud();
            tblPlatillo.DataSource = n.Mostrarplatillos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
