
namespace Video_Club
{
    partial class ventas
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
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.dgv_detalle = new System.Windows.Forms.DataGridView();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.textStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.pnl_opciones = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).BeginInit();
            this.pnl_opciones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "PRECIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "STOCK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "DESCRIPCIÓN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CÓDIGO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            this.panel2.Controls.Add(this.textPrecio);
            this.panel2.Controls.Add(this.dgv_detalle);
            this.panel2.Controls.Add(this.textCantidad);
            this.panel2.Controls.Add(this.textStock);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textDescripcion);
            this.panel2.Controls.Add(this.textCodigo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 418);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(120, 77);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(100, 20);
            this.textPrecio.TabIndex = 11;
            // 
            // dgv_detalle
            // 
            this.dgv_detalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(2)))), ((int)(((byte)(73)))));
            this.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle.Location = new System.Drawing.Point(18, 115);
            this.dgv_detalle.Name = "dgv_detalle";
            this.dgv_detalle.Size = new System.Drawing.Size(843, 291);
            this.dgv_detalle.TabIndex = 3;
            this.dgv_detalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_detalle_CellContentClick);
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(364, 45);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(100, 20);
            this.textCantidad.TabIndex = 8;
            // 
            // textStock
            // 
            this.textStock.Location = new System.Drawing.Point(120, 45);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(100, 20);
            this.textStock.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "CANTIDAD";
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(364, 16);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(100, 20);
            this.textDescripcion.TabIndex = 9;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(120, 16);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(100, 20);
            this.textCodigo.TabIndex = 8;
            // 
            // pnl_opciones
            // 
            this.pnl_opciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(2)))), ((int)(((byte)(73)))));
            this.pnl_opciones.Controls.Add(this.panel4);
            this.pnl_opciones.Controls.Add(this.btn_agregar);
            this.pnl_opciones.Controls.Add(this.btn_nuevo);
            this.pnl_opciones.Controls.Add(this.panel6);
            this.pnl_opciones.Controls.Add(this.panel3);
            this.pnl_opciones.Controls.Add(this.btn_modificar);
            this.pnl_opciones.Controls.Add(this.btn_eliminar);
            this.pnl_opciones.Controls.Add(this.panel5);
            this.pnl_opciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_opciones.Location = new System.Drawing.Point(884, 32);
            this.pnl_opciones.Name = "pnl_opciones";
            this.pnl_opciones.Size = new System.Drawing.Size(200, 418);
            this.pnl_opciones.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.panel4.Location = new System.Drawing.Point(2, 236);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 32);
            this.panel4.TabIndex = 16;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.Location = new System.Drawing.Point(12, 87);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(185, 32);
            this.btn_agregar.TabIndex = 9;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo.Location = new System.Drawing.Point(12, 236);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(185, 32);
            this.btn_nuevo.TabIndex = 15;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.panel6.Location = new System.Drawing.Point(2, 87);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 32);
            this.panel6.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.panel3.Location = new System.Drawing.Point(2, 187);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 32);
            this.panel3.TabIndex = 14;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.btn_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificar.Location = new System.Drawing.Point(12, 138);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(185, 32);
            this.btn_modificar.TabIndex = 11;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(12, 187);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(185, 32);
            this.btn_eliminar.TabIndex = 13;
            this.btn_eliminar.Text = "ELiminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.panel5.Location = new System.Drawing.Point(2, 138);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 32);
            this.panel5.TabIndex = 12;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(361, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(97, 13);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Ventas o Alquileres";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 32);
            this.panel1.TabIndex = 1;
            // 
            // ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.pnl_opciones);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ventas";
            this.Text = "ventas";
            this.Load += new System.EventHandler(this.ventas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).EndInit();
            this.pnl_opciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.DataGridView dgv_detalle;
        private System.Windows.Forms.Panel pnl_opciones;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel panel1;
    }
}