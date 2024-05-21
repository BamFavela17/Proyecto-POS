using LaCrudaY_.Catalogo;
using LaCrudaY_.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using LaCrudaY_.Catalogo;
using CapaDatos;
using CapaNegocio;

namespace LaCrudaY_.Principal
{
    public partial class FromPrincipal : Form
    {
        public FromPrincipal()
        {
            InitializeComponent();
        }

        private void FromPrincipal_Load(object sender, EventArgs e)
        {
            
            lblUsuario.Text = UserCache.nombres + " "+ UserCache.apellidos;
            UserModel m = new UserModel();
            m.Cargo(UserCache.idpuesto);
            lblCargo.Text = UserCache.Cargousuario;

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRelize.Visible = true;

        }

        private void btnM_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRelize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRelize.Visible = false;
        }
        private void Informacion_Click_1(object sender, EventArgs e)
        {

        }
        // mover ventana

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void BarrTitulo_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCsesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas cerrar esta sesión?", "Cierre de sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                 FromAcceso l = new FromAcceso();
            l.ShowDialog();  
            }
          
           
        }
        public void abrirFormHijo(object Pantalla2)
        {
            if (this.Contenido.Controls.Count > 0)
                this.Contenido.Controls.RemoveAt(0);
            Form fh = Pantalla2 as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenido.Controls.Add(fh);
            this.Contenido.Tag = fh;
            fh.Show();
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            subMenuAdmin.Visible = true;
            subMenuCat.Visible = false;
            subMenuMov.Visible = false;
            subMenuRep.Visible = false;
            BarOpc.Size = new System.Drawing.Size(420, 750);
        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void opc1_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new CRUDempleado());
            subMenuAdmin.Visible = false;
            BarOpc.Size = new System.Drawing.Size(260, 750);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new CRUDclientes());
            subMenuAdmin.Visible = false;
            BarOpc.Size = new System.Drawing.Size(260, 750);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new CRUDmaterial());
            subMenuAdmin.Visible = false;
            BarOpc.Size = new System.Drawing.Size(260, 750);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new CRUDplatillos());
            subMenuAdmin.Visible = false;
            BarOpc.Size = new System.Drawing.Size(260, 750);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new CRUDproveedor());
            subMenuAdmin.Visible = false;
            BarOpc.Size = new System.Drawing.Size(260, 750);
        }

        private void btnCatalogos_Click(object sender, EventArgs e)
        {
            subMenuAdmin.Visible = false;
            subMenuCat.Visible = true;
            subMenuMov.Visible = false;
            subMenuRep.Visible = false;
            BarOpc.Size = new System.Drawing.Size(420, 750);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            subMenuAdmin.Visible = false;
            subMenuCat.Visible = false;
            subMenuMov.Visible = false;
            subMenuRep.Visible = true;
            BarOpc.Size = new System.Drawing.Size(420, 750);
        }

        private void btnVentasPunto_Click(object sender, EventArgs e)
        {
            subMenuAdmin.Visible = false;
            subMenuCat.Visible = false;
            subMenuMov.Visible = true;
            subMenuRep.Visible = false;
            BarOpc.Size = new System.Drawing.Size(420, 750);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new EmpleadoCat());
            BarOpc.Size = new System.Drawing.Size(260, 750);
            subMenuCat.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new LaCrudaY_.Catalogo.Materiales());
            BarOpc.Size = new System.Drawing.Size(260, 750);
            subMenuCat.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new LaCrudaY_.Catalogo.PatilloCat());
            BarOpc.Size = new System.Drawing.Size(260, 750);
            subMenuCat.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new LaCrudaY_.Catalogo.ProveedorCAt());
            BarOpc.Size = new System.Drawing.Size(260, 750);
            subMenuCat.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new LaCrudaY_.Reportes.RepVentas());
            BarOpc.Size = new System.Drawing.Size(260, 750);
            subMenuRep.Visible = false;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new LaCrudaY_.Reportes.RepGastos());
            BarOpc.Size = new System.Drawing.Size(260, 750);
            subMenuRep.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new LaCrudaY_.Reportes.RepClientes());
            BarOpc.Size = new System.Drawing.Size(260, 750);
            subMenuRep.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new LaCrudaY_.Reportes.RepCorte());
            BarOpc.Size = new System.Drawing.Size(260, 750);
            subMenuRep.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new LaCrudaY_.Reportes.RepInventario());
            BarOpc.Size = new System.Drawing.Size(260, 750);
            subMenuRep.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new LaCrudaY_.Reportes.RepPagos());
            BarOpc.Size = new System.Drawing.Size(260, 750);
            subMenuRep.Visible = false;
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new LaCrudaY_.PuntoVenta.Caja());
            BarOpc.Size = new System.Drawing.Size(260, 750);
            subMenuMov.Visible = false;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new LaCrudaY_.PuntoVenta.MovCompras());
            subMenuMov.Visible = false;
            BarOpc.Size = new System.Drawing.Size(260, 750);
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new LaCrudaY_.PuntoVenta.RetiroCaja());
            subMenuMov.Visible = false;
            BarOpc.Size = new System.Drawing.Size(260, 750);
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new LaCrudaY_.PuntoVenta.Movpagos());
            subMenuMov.Visible = false;
            BarOpc.Size = new System.Drawing.Size(260, 750);
        }

        private void btnCortecias_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new LaCrudaY_.PuntoVenta.CorteciasMov());
            subMenuMov.Visible = false;
            BarOpc.Size = new System.Drawing.Size(260, 750);
        }

        private void btnEditarDatos_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new AjusteUsuario());
        }

        private void Contenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void subMenuAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new CRUDhorarios());
            subMenuAdmin.Visible = false;
            BarOpc.Size = new System.Drawing.Size(260, 750);
        }
    }
}
