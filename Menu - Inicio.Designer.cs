
namespace Gleaming_Car
{
    partial class FrmMenuInicio
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btnCliente;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuInicio));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnBase = new System.Windows.Forms.Button();
            this.panelBaseSubMenu = new System.Windows.Forms.Panel();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.btnGaleria = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnNavegador = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            btnCliente = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panelBaseSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            btnCliente.CausesValidation = false;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCliente.ForeColor = System.Drawing.Color.White;
            btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCliente.Location = new System.Drawing.Point(0, 0);
            btnCliente.Name = "btnCliente";
            btnCliente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            btnCliente.Size = new System.Drawing.Size(299, 37);
            btnCliente.TabIndex = 7;
            btnCliente.Text = "                     TABLAS";
            btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.DarkGray;
            this.sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.btnBase);
            this.sidebar.Controls.Add(this.panelBaseSubMenu);
            this.sidebar.Controls.Add(this.btnCalculadora);
            this.sidebar.Controls.Add(this.btnGaleria);
            this.sidebar.Controls.Add(this.button1);
            this.sidebar.Controls.Add(this.button2);
            this.sidebar.Controls.Add(this.btnConfiguracion);
            this.sidebar.Controls.Add(this.btnNavegador);
            this.sidebar.Controls.Add(this.button3);
            this.sidebar.ForeColor = System.Drawing.Color.Black;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(292, 740);
            this.sidebar.MinimumSize = new System.Drawing.Size(70, 482);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(70, 740);
            this.sidebar.TabIndex = 0;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebarcontainer_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 92);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(9, 22);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(46, 41);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnBase
            // 
            this.btnBase.BackColor = System.Drawing.Color.Gray;
            this.btnBase.FlatAppearance.BorderSize = 0;
            this.btnBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBase.ForeColor = System.Drawing.Color.White;
            this.btnBase.Image = ((System.Drawing.Image)(resources.GetObject("btnBase.Image")));
            this.btnBase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBase.Location = new System.Drawing.Point(3, 101);
            this.btnBase.Name = "btnBase";
            this.btnBase.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBase.Size = new System.Drawing.Size(299, 48);
            this.btnBase.TabIndex = 3;
            this.btnBase.Text = "                     BASE DE DATOS";
            this.btnBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBase.UseVisualStyleBackColor = false;
            this.btnBase.Click += new System.EventHandler(this.button4_Click);
            // 
            // panelBaseSubMenu
            // 
            this.panelBaseSubMenu.Controls.Add(this.btnInventario);
            this.panelBaseSubMenu.Controls.Add(this.btnEmpleado);
            this.panelBaseSubMenu.Controls.Add(btnCliente);
            this.panelBaseSubMenu.Location = new System.Drawing.Point(3, 155);
            this.panelBaseSubMenu.Name = "panelBaseSubMenu";
            this.panelBaseSubMenu.Size = new System.Drawing.Size(283, 147);
            this.panelBaseSubMenu.TabIndex = 4;
            this.panelBaseSubMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBaseSubMenu_Paint);
            // 
            // btnInventario
            // 
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.Image")));
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 105);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInventario.Size = new System.Drawing.Size(283, 37);
            this.btnInventario.TabIndex = 9;
            this.btnInventario.Text = "                     INFORMES";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleado.Image")));
            this.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.Location = new System.Drawing.Point(0, 54);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmpleado.Size = new System.Drawing.Size(283, 37);
            this.btnEmpleado.TabIndex = 8;
            this.btnEmpleado.Text = "                     FORMULARIOS";
            this.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.BackColor = System.Drawing.Color.Gray;
            this.btnCalculadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCalculadora.FlatAppearance.BorderSize = 0;
            this.btnCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculadora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadora.ForeColor = System.Drawing.Color.White;
            this.btnCalculadora.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculadora.Image")));
            this.btnCalculadora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculadora.Location = new System.Drawing.Point(3, 308);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCalculadora.Size = new System.Drawing.Size(299, 48);
            this.btnCalculadora.TabIndex = 3;
            this.btnCalculadora.Text = "                    CALCULOS";
            this.btnCalculadora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculadora.UseVisualStyleBackColor = false;
            this.btnCalculadora.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGaleria
            // 
            this.btnGaleria.BackColor = System.Drawing.Color.Gray;
            this.btnGaleria.FlatAppearance.BorderSize = 0;
            this.btnGaleria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGaleria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGaleria.ForeColor = System.Drawing.Color.White;
            this.btnGaleria.Image = ((System.Drawing.Image)(resources.GetObject("btnGaleria.Image")));
            this.btnGaleria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGaleria.Location = new System.Drawing.Point(3, 362);
            this.btnGaleria.Name = "btnGaleria";
            this.btnGaleria.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGaleria.Size = new System.Drawing.Size(299, 48);
            this.btnGaleria.TabIndex = 3;
            this.btnGaleria.Text = "                     GALERIA";
            this.btnGaleria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGaleria.UseVisualStyleBackColor = false;
            this.btnGaleria.Click += new System.EventHandler(this.btnGaleria_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 416);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(299, 48);
            this.button1.TabIndex = 12;
            this.button1.Text = "                     VENTAS";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 470);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(14);
            this.button2.Size = new System.Drawing.Size(299, 55);
            this.button2.TabIndex = 12;
            this.button2.Text = "                     FACTURAS";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.Gray;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracion.Image")));
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(3, 531);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Padding = new System.Windows.Forms.Padding(7, 0, 2, 0);
            this.btnConfiguracion.Size = new System.Drawing.Size(299, 48);
            this.btnConfiguracion.TabIndex = 6;
            this.btnConfiguracion.Text = "                     CALENDARIO";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnNavegador
            // 
            this.btnNavegador.BackColor = System.Drawing.Color.Gray;
            this.btnNavegador.FlatAppearance.BorderSize = 0;
            this.btnNavegador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavegador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavegador.ForeColor = System.Drawing.Color.White;
            this.btnNavegador.Image = ((System.Drawing.Image)(resources.GetObject("btnNavegador.Image")));
            this.btnNavegador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavegador.Location = new System.Drawing.Point(3, 585);
            this.btnNavegador.Name = "btnNavegador";
            this.btnNavegador.Padding = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.btnNavegador.Size = new System.Drawing.Size(289, 48);
            this.btnNavegador.TabIndex = 3;
            this.btnNavegador.Text = "                     NAVEGADOR";
            this.btnNavegador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavegador.UseVisualStyleBackColor = false;
            this.btnNavegador.Click += new System.EventHandler(this.btnNavegador_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 639);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(299, 45);
            this.button3.TabIndex = 13;
            this.button3.Text = "                     INFORMACIONES";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1161, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1221, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(169, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1233, 687);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(70, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 680);
            this.panel2.TabIndex = 15;
            // 
            // FrmMenuInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(1300, 740);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GLEAMING CAR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu___Inicio_Load);
            this.Click += new System.EventHandler(this.FrmMenuInicio_Click);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panelBaseSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnGaleria;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.Button btnBase;
        private System.Windows.Forms.Button btnNavegador;
        private System.Windows.Forms.Panel panelBaseSubMenu;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
    }
}