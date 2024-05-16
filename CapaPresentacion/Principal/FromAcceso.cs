using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LaCrudaY_.Principal
{
    public partial class FromAcceso : Form
    {
        public FromAcceso()
        {
            InitializeComponent();
        }
        
        private void FromAcceso_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // mover ventana

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MoverVentana(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // obtener el valor de los campos
            string user = txtUser.Text;
            string pass = txtpass.Text;
            // evaluar si exixten o no
            if(user != "")
            {
                if (pass != "")
                {
                    UserModel usuario = new UserModel();
                    var validLogin = usuario.LoginUser(user, pass);
                    if (validLogin == true)
                    {
                        FromPrincipal mainMenu = new FromPrincipal();
                        MessageBox.Show("Bienvenido " + UserCache.nombres + " " + UserCache.apellidos);
                        mainMenu.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        error("Usuario y/o contraseña incorrectos. \n por favor intente de nuevo.");
                        
                        txtUser.Focus();
                    }
                }
                else error("Favor de ingresar su contraseña.");
            }
            else error("Favor de ingresar su usuario.");


        }
        private void error(string msj)
        {
         lblError.Text = msj;
            lblError.Visible = true;
           imgError.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOcultarContra_Click(object sender, EventArgs e)
        {
           btnMostrarContra.BringToFront();
            txtpass.PasswordChar = '\0';
        }

        private void btnMostrarContra_Click(object sender, EventArgs e)
        {
            btnOcultarContra.BringToFront();
            txtpass.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Pos valistes verga mi chavo");
        }
    }
}

