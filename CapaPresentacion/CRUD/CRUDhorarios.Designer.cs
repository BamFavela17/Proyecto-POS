namespace LaCrudaY_.CRUD
{
    partial class CRUDhorarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tblHorarios = new System.Windows.Forms.DataGridView();
            this.btnM = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblHorarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tblHorarios);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 390);
            this.panel2.TabIndex = 1;
            // 
            // tblHorarios
            // 
            this.tblHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblHorarios.Location = new System.Drawing.Point(363, 45);
            this.tblHorarios.Name = "tblHorarios";
            this.tblHorarios.RowHeadersWidth = 51;
            this.tblHorarios.RowTemplate.Height = 24;
            this.tblHorarios.Size = new System.Drawing.Size(676, 317);
            this.tblHorarios.TabIndex = 0;
            // 
            // btnM
            // 
            this.btnM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnM.Image = global::LaCrudaY_.Properties.Resources.icons8_minimizar_24__1_;
            this.btnM.Location = new System.Drawing.Point(1003, 0);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(40, 40);
            this.btnM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnM.TabIndex = 3;
            this.btnM.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = global::LaCrudaY_.Properties.Resources.icons8_cerrar_ventana_24;
            this.btnExit.Location = new System.Drawing.Point(1049, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            // 
            // CRUDhorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 765);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUDhorarios";
            this.Text = "CRUDhorarios";
            this.Load += new System.EventHandler(this.CRUDhorarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblHorarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tblHorarios;
        private System.Windows.Forms.PictureBox btnM;
        private System.Windows.Forms.PictureBox btnExit;
    }
}