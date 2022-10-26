
namespace Video_Club
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.PicRestaurar = new System.Windows.Forms.PictureBox();
            this.PicMin = new System.Windows.Forms.PictureBox();
            this.PicMax = new System.Windows.Forms.PictureBox();
            this.PicSalir = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.Panel_SubMenu = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_RepPagos = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_RepALquiler = new System.Windows.Forms.Button();
            this.btn_RepVentas = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_Reportes = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Prestamo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_devolucion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelSalir = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSalir)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.Panel_SubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            this.BarraTitulo.Controls.Add(this.PicRestaurar);
            this.BarraTitulo.Controls.Add(this.PicMin);
            this.BarraTitulo.Controls.Add(this.PicMax);
            this.BarraTitulo.Controls.Add(this.PicSalir);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 35);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // PicRestaurar
            // 
            this.PicRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("PicRestaurar.Image")));
            this.PicRestaurar.Location = new System.Drawing.Point(1232, 7);
            this.PicRestaurar.Name = "PicRestaurar";
            this.PicRestaurar.Size = new System.Drawing.Size(25, 25);
            this.PicRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicRestaurar.TabIndex = 0;
            this.PicRestaurar.TabStop = false;
            this.PicRestaurar.Visible = false;
            this.PicRestaurar.Click += new System.EventHandler(this.PicRestaurar_Click);
            // 
            // PicMin
            // 
            this.PicMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicMin.Image = ((System.Drawing.Image)(resources.GetObject("PicMin.Image")));
            this.PicMin.Location = new System.Drawing.Point(1201, 7);
            this.PicMin.Name = "PicMin";
            this.PicMin.Size = new System.Drawing.Size(25, 25);
            this.PicMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicMin.TabIndex = 0;
            this.PicMin.TabStop = false;
            this.PicMin.Click += new System.EventHandler(this.PicMin_Click);
            // 
            // PicMax
            // 
            this.PicMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicMax.Image = ((System.Drawing.Image)(resources.GetObject("PicMax.Image")));
            this.PicMax.Location = new System.Drawing.Point(1232, 7);
            this.PicMax.Name = "PicMax";
            this.PicMax.Size = new System.Drawing.Size(25, 25);
            this.PicMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicMax.TabIndex = 0;
            this.PicMax.TabStop = false;
            this.PicMax.Click += new System.EventHandler(this.PicMax_Click);
            // 
            // PicSalir
            // 
            this.PicSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicSalir.Image = ((System.Drawing.Image)(resources.GetObject("PicSalir.Image")));
            this.PicSalir.Location = new System.Drawing.Point(1263, 7);
            this.PicSalir.Name = "PicSalir";
            this.PicSalir.Size = new System.Drawing.Size(25, 25);
            this.PicSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicSalir.TabIndex = 0;
            this.PicSalir.TabStop = false;
            this.PicSalir.Click += new System.EventHandler(this.PicSalir_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.MenuVertical.Controls.Add(this.Panel_SubMenu);
            this.MenuVertical.Controls.Add(this.panel5);
            this.MenuVertical.Controls.Add(this.btn_Reportes);
            this.MenuVertical.Controls.Add(this.panel4);
            this.MenuVertical.Controls.Add(this.btn_Prestamo);
            this.MenuVertical.Controls.Add(this.panel3);
            this.MenuVertical.Controls.Add(this.btn_devolucion);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.btn_Clientes);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.btn_ventas);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 35);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(221, 615);
            this.MenuVertical.TabIndex = 2;
            // 
            // Panel_SubMenu
            // 
            this.Panel_SubMenu.Controls.Add(this.panel9);
            this.Panel_SubMenu.Controls.Add(this.panel8);
            this.Panel_SubMenu.Controls.Add(this.btn_RepPagos);
            this.Panel_SubMenu.Controls.Add(this.panel7);
            this.Panel_SubMenu.Controls.Add(this.btn_RepALquiler);
            this.Panel_SubMenu.Controls.Add(this.btn_RepVentas);
            this.Panel_SubMenu.Location = new System.Drawing.Point(45, 426);
            this.Panel_SubMenu.Name = "Panel_SubMenu";
            this.Panel_SubMenu.Size = new System.Drawing.Size(175, 145);
            this.Panel_SubMenu.TabIndex = 0;
            this.Panel_SubMenu.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.panel9.Location = new System.Drawing.Point(3, 97);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 32);
            this.panel9.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.panel8.Location = new System.Drawing.Point(3, 50);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 32);
            this.panel8.TabIndex = 7;
            // 
            // btn_RepPagos
            // 
            this.btn_RepPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.btn_RepPagos.FlatAppearance.BorderSize = 0;
            this.btn_RepPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            this.btn_RepPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RepPagos.Font = new System.Drawing.Font("Broadway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RepPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RepPagos.Location = new System.Drawing.Point(13, 97);
            this.btn_RepPagos.Name = "btn_RepPagos";
            this.btn_RepPagos.Size = new System.Drawing.Size(162, 32);
            this.btn_RepPagos.TabIndex = 6;
            this.btn_RepPagos.Text = "Conexion";
            this.btn_RepPagos.UseVisualStyleBackColor = false;
            this.btn_RepPagos.Click += new System.EventHandler(this.btn_RepPagos_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 32);
            this.panel7.TabIndex = 5;
            // 
            // btn_RepALquiler
            // 
            this.btn_RepALquiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.btn_RepALquiler.FlatAppearance.BorderSize = 0;
            this.btn_RepALquiler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            this.btn_RepALquiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RepALquiler.Font = new System.Drawing.Font("Broadway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RepALquiler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RepALquiler.Location = new System.Drawing.Point(13, 50);
            this.btn_RepALquiler.Name = "btn_RepALquiler";
            this.btn_RepALquiler.Size = new System.Drawing.Size(162, 32);
            this.btn_RepALquiler.TabIndex = 6;
            this.btn_RepALquiler.Text = "Reserva";
            this.btn_RepALquiler.UseVisualStyleBackColor = false;
            this.btn_RepALquiler.Click += new System.EventHandler(this.btn_RepALquiler_Click);
            // 
            // btn_RepVentas
            // 
            this.btn_RepVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.btn_RepVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RepVentas.FlatAppearance.BorderSize = 0;
            this.btn_RepVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            this.btn_RepVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RepVentas.Font = new System.Drawing.Font("Broadway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RepVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RepVentas.Location = new System.Drawing.Point(13, 3);
            this.btn_RepVentas.Name = "btn_RepVentas";
            this.btn_RepVentas.Size = new System.Drawing.Size(162, 32);
            this.btn_RepVentas.TabIndex = 4;
            this.btn_RepVentas.Text = "Rep. Prestamos";
            this.btn_RepVentas.UseVisualStyleBackColor = false;
            this.btn_RepVentas.Click += new System.EventHandler(this.btn_RepVentas_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.panel5.Location = new System.Drawing.Point(22, 390);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 32);
            this.panel5.TabIndex = 10;
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.btn_Reportes.FlatAppearance.BorderSize = 0;
            this.btn_Reportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            this.btn_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reportes.Font = new System.Drawing.Font("Broadway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reportes.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reportes.Image")));
            this.btn_Reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reportes.Location = new System.Drawing.Point(32, 390);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Size = new System.Drawing.Size(188, 32);
            this.btn_Reportes.TabIndex = 9;
            this.btn_Reportes.Text = "Acciones";
            this.btn_Reportes.UseVisualStyleBackColor = false;
            this.btn_Reportes.Click += new System.EventHandler(this.btn_Reportes_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.panel4.Location = new System.Drawing.Point(22, 291);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 32);
            this.panel4.TabIndex = 8;
            // 
            // btn_Prestamo
            // 
            this.btn_Prestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.btn_Prestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Prestamo.FlatAppearance.BorderSize = 0;
            this.btn_Prestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            this.btn_Prestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Prestamo.Font = new System.Drawing.Font("Broadway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prestamo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Prestamo.Image")));
            this.btn_Prestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Prestamo.Location = new System.Drawing.Point(32, 291);
            this.btn_Prestamo.Name = "btn_Prestamo";
            this.btn_Prestamo.Size = new System.Drawing.Size(188, 32);
            this.btn_Prestamo.TabIndex = 7;
            this.btn_Prestamo.Text = "Prestamo";
            this.btn_Prestamo.UseVisualStyleBackColor = false;
            this.btn_Prestamo.Click += new System.EventHandler(this.btn_Prestamo_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.panel3.Location = new System.Drawing.Point(23, 338);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 32);
            this.panel3.TabIndex = 6;
            // 
            // btn_devolucion
            // 
            this.btn_devolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.btn_devolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_devolucion.FlatAppearance.BorderSize = 0;
            this.btn_devolucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            this.btn_devolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_devolucion.Font = new System.Drawing.Font("Broadway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_devolucion.Image = ((System.Drawing.Image)(resources.GetObject("btn_devolucion.Image")));
            this.btn_devolucion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_devolucion.Location = new System.Drawing.Point(33, 338);
            this.btn_devolucion.Name = "btn_devolucion";
            this.btn_devolucion.Size = new System.Drawing.Size(188, 32);
            this.btn_devolucion.TabIndex = 5;
            this.btn_devolucion.Text = "Devolución";
            this.btn_devolucion.UseVisualStyleBackColor = false;
            this.btn_devolucion.Click += new System.EventHandler(this.btn_devolucion_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.panel2.Location = new System.Drawing.Point(22, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 32);
            this.panel2.TabIndex = 4;
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.btn_Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clientes.FlatAppearance.BorderSize = 0;
            this.btn_Clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            this.btn_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clientes.Font = new System.Drawing.Font("Broadway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clientes.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clientes.Image")));
            this.btn_Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clientes.Location = new System.Drawing.Point(32, 242);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(188, 32);
            this.btn_Clientes.TabIndex = 3;
            this.btn_Clientes.Text = "Usuario";
            this.btn_Clientes.UseVisualStyleBackColor = false;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.panel1.Location = new System.Drawing.Point(22, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 32);
            this.panel1.TabIndex = 2;
            // 
            // btn_ventas
            // 
            this.btn_ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.btn_ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ventas.FlatAppearance.BorderSize = 0;
            this.btn_ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            this.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventas.Font = new System.Drawing.Font("Broadway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ventas.Image = ((System.Drawing.Image)(resources.GetObject("btn_ventas.Image")));
            this.btn_ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ventas.Location = new System.Drawing.Point(32, 191);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(188, 32);
            this.btn_ventas.TabIndex = 1;
            this.btn_ventas.Text = "Libro";
            this.btn_ventas.UseVisualStyleBackColor = false;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PanelSalir
            // 
            this.PanelSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSalir.Location = new System.Drawing.Point(221, 35);
            this.PanelSalir.Name = "PanelSalir";
            this.PanelSalir.Size = new System.Drawing.Size(1079, 615);
            this.PanelSalir.TabIndex = 3;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(2)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.PanelSalir);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSalir)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.Panel_SubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox PicMin;
        private System.Windows.Forms.PictureBox PicMax;
        private System.Windows.Forms.PictureBox PicSalir;
        private System.Windows.Forms.Panel PanelSalir;
        private System.Windows.Forms.PictureBox PicRestaurar;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_Reportes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Prestamo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_devolucion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Panel Panel_SubMenu;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_RepPagos;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_RepALquiler;
        private System.Windows.Forms.Button btn_RepVentas;
    }
}

