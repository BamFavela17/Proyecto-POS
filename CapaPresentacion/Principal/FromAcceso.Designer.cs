namespace LaCrudaY_.Principal
{
    partial class FromAcceso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titulo = new System.Windows.Forms.Panel();
            this.Contenido = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.imgError = new System.Windows.Forms.PictureBox();
            this.btnOcultarContra = new System.Windows.Forms.PictureBox();
            this.btnMostrarContra = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Informacion = new System.Windows.Forms.PictureBox();
            this.Titulo.SuspendLayout();
            this.Contenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultarContra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrarContra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Informacion)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(107)))), ((int)(((byte)(142)))));
            this.Titulo.Controls.Add(this.pictureBox2);
            this.Titulo.Controls.Add(this.pictureBox1);
            this.Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titulo.Location = new System.Drawing.Point(0, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(450, 44);
            this.Titulo.TabIndex = 0;
            this.Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverVentana);
            // 
            // Contenido
            // 
            this.Contenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(127)))), ((int)(((byte)(177)))));
            this.Contenido.Controls.Add(this.Informacion);
            this.Contenido.Controls.Add(this.imgError);
            this.Contenido.Controls.Add(this.lblError);
            this.Contenido.Controls.Add(this.btnOcultarContra);
            this.Contenido.Controls.Add(this.btnMostrarContra);
            this.Contenido.Controls.Add(this.linkLabel1);
            this.Contenido.Controls.Add(this.btnIngresar);
            this.Contenido.Controls.Add(this.label2);
            this.Contenido.Controls.Add(this.txtpass);
            this.Contenido.Controls.Add(this.label1);
            this.Contenido.Controls.Add(this.txtUser);
            this.Contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenido.Location = new System.Drawing.Point(0, 44);
            this.Contenido.Name = "Contenido";
            this.Contenido.Size = new System.Drawing.Size(450, 656);
            this.Contenido.TabIndex = 1;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblError.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(215)))), ((int)(((byte)(166)))));
            this.lblError.Location = new System.Drawing.Point(78, 450);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(125, 23);
            this.lblError.TabIndex = 15;
            this.lblError.Text = "Error message";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.linkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(215)))), ((int)(((byte)(166)))));
            this.linkLabel1.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.Location = new System.Drawing.Point(96, 611);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(217, 23);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Olvidaste tu contraseña?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(71)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIngresar.Location = new System.Drawing.Point(52, 522);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(324, 61);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Iniciar sesión";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(215)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(47, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña:";
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(127)))), ((int)(((byte)(177)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtpass.Location = new System.Drawing.Point(43, 403);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(350, 36);
            this.txtpass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(215)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(40, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(127)))), ((int)(((byte)(177)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUser.Location = new System.Drawing.Point(43, 309);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(350, 36);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // imgError
            // 
            this.imgError.Image = global::LaCrudaY_.Properties.Resources.error_24dp;
            this.imgError.Location = new System.Drawing.Point(45, 445);
            this.imgError.Name = "imgError";
            this.imgError.Size = new System.Drawing.Size(30, 30);
            this.imgError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgError.TabIndex = 16;
            this.imgError.TabStop = false;
            this.imgError.Visible = false;
            // 
            // btnOcultarContra
            // 
            this.btnOcultarContra.Image = global::LaCrudaY_.Properties.Resources.visibility_off_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btnOcultarContra.Location = new System.Drawing.Point(399, 400);
            this.btnOcultarContra.Name = "btnOcultarContra";
            this.btnOcultarContra.Size = new System.Drawing.Size(40, 40);
            this.btnOcultarContra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOcultarContra.TabIndex = 9;
            this.btnOcultarContra.TabStop = false;
            this.btnOcultarContra.Click += new System.EventHandler(this.btnOcultarContra_Click);
            // 
            // btnMostrarContra
            // 
            this.btnMostrarContra.Image = global::LaCrudaY_.Properties.Resources.visibility_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btnMostrarContra.Location = new System.Drawing.Point(399, 400);
            this.btnMostrarContra.Name = "btnMostrarContra";
            this.btnMostrarContra.Size = new System.Drawing.Size(40, 40);
            this.btnMostrarContra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMostrarContra.TabIndex = 8;
            this.btnMostrarContra.TabStop = false;
            this.btnMostrarContra.Click += new System.EventHandler(this.btnMostrarContra_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LaCrudaY_.Properties.Resources.icons8_minimizar_24__1_;
            this.pictureBox2.Location = new System.Drawing.Point(381, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LaCrudaY_.Properties.Resources.icons8_cerrar_ventana_24;
            this.pictureBox1.Location = new System.Drawing.Point(417, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Informacion
            // 
            this.Informacion.Image = global::LaCrudaY_.Properties.Resources.logoredondopng;
            this.Informacion.Location = new System.Drawing.Point(52, 44);
            this.Informacion.Name = "Informacion";
            this.Informacion.Size = new System.Drawing.Size(332, 190);
            this.Informacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Informacion.TabIndex = 17;
            this.Informacion.TabStop = false;
            // 
            // FromAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 700);
            this.Controls.Add(this.Contenido);
            this.Controls.Add(this.Titulo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FromAcceso";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FromAcceso";
            this.Load += new System.EventHandler(this.FromAcceso_Load);
            this.Titulo.ResumeLayout(false);
            this.Contenido.ResumeLayout(false);
            this.Contenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultarContra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrarContra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Informacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel Contenido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox btnMostrarContra;
        private System.Windows.Forms.PictureBox btnOcultarContra;
        private System.Windows.Forms.PictureBox imgError;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox Informacion;
    }
}