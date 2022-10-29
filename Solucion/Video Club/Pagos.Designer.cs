namespace Video_Club
{
    partial class Pagos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textDni = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.pnl_opciones = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgPagos = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnUsRefrescar = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnUsBuscar = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtPagos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnl_opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagos)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textDni
            // 
            this.textDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(206)))), ((int)(((byte)(181)))));
            this.textDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            this.textDni.Location = new System.Drawing.Point(640, 265);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(224, 29);
            this.textDni.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.dgPagos);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.textDni);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textApellido);
            this.panel2.Controls.Add(this.textNombre);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 615);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(58)))), ((int)(((byte)(169)))));
            this.label6.Location = new System.Drawing.Point(637, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 24);
            this.label6.TabIndex = 38;
            this.label6.Text = "Dni";
            // 
            // textApellido
            // 
            this.textApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(206)))), ((int)(((byte)(181)))));
            this.textApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            this.textApellido.Location = new System.Drawing.Point(640, 182);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(224, 29);
            this.textApellido.TabIndex = 34;
            this.textApellido.TextChanged += new System.EventHandler(this.textApellido_TextChanged);
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(206)))), ((int)(((byte)(181)))));
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            this.textNombre.Location = new System.Drawing.Point(636, 104);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(224, 29);
            this.textNombre.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(58)))), ((int)(((byte)(169)))));
            this.label11.Location = new System.Drawing.Point(637, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 24);
            this.label11.TabIndex = 29;
            this.label11.Text = "Apellido";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(58)))), ((int)(((byte)(169)))));
            this.label12.Location = new System.Drawing.Point(637, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 24);
            this.label12.TabIndex = 28;
            this.label12.Text = "Nombre";
            // 
            // btn_pagar
            // 
            this.btn_pagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(58)))), ((int)(((byte)(169)))));
            this.btn_pagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pagar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(58)))), ((int)(((byte)(169)))));
            this.btn_pagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(206)))), ((int)(((byte)(181)))));
            this.btn_pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagar.ForeColor = System.Drawing.Color.White;
            this.btn_pagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pagar.Location = new System.Drawing.Point(12, 87);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(185, 32);
            this.btn_pagar.TabIndex = 9;
            this.btn_pagar.Text = "Pagar";
            this.btn_pagar.UseVisualStyleBackColor = false;
            // 
            // pnl_opciones
            // 
            this.pnl_opciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            this.pnl_opciones.Controls.Add(this.btn_pagar);
            this.pnl_opciones.Controls.Add(this.panel6);
            this.pnl_opciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_opciones.Location = new System.Drawing.Point(879, 0);
            this.pnl_opciones.Name = "pnl_opciones";
            this.pnl_opciones.Size = new System.Drawing.Size(200, 615);
            this.pnl_opciones.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(58)))), ((int)(((byte)(169)))));
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(2, 87);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 32);
            this.panel6.TabIndex = 10;
            // 
            // dgPagos
            // 
            this.dgPagos.AllowUserToAddRows = false;
            this.dgPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgPagos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgPagos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(206)))), ((int)(((byte)(181)))));
            this.dgPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(2)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPagos.EnableHeadersVisualStyles = false;
            this.dgPagos.Location = new System.Drawing.Point(12, 81);
            this.dgPagos.Name = "dgPagos";
            this.dgPagos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(58)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(206)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgPagos.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(58)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(206)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgPagos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPagos.Size = new System.Drawing.Size(544, 511);
            this.dgPagos.TabIndex = 41;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnUsRefrescar);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Controls.Add(this.btnUsBuscar);
            this.panel12.Controls.Add(this.panel14);
            this.panel12.Controls.Add(this.panel15);
            this.panel12.Location = new System.Drawing.Point(147, 14);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(409, 61);
            this.panel12.TabIndex = 40;
            // 
            // btnUsRefrescar
            // 
            this.btnUsRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(58)))), ((int)(((byte)(169)))));
            this.btnUsRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsRefrescar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(58)))), ((int)(((byte)(169)))));
            this.btnUsRefrescar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(206)))), ((int)(((byte)(181)))));
            this.btnUsRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsRefrescar.ForeColor = System.Drawing.Color.White;
            this.btnUsRefrescar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsRefrescar.Location = new System.Drawing.Point(309, 12);
            this.btnUsRefrescar.Name = "btnUsRefrescar";
            this.btnUsRefrescar.Size = new System.Drawing.Size(95, 36);
            this.btnUsRefrescar.TabIndex = 22;
            this.btnUsRefrescar.Text = "Refrescar";
            this.btnUsRefrescar.UseVisualStyleBackColor = false;
            this.btnUsRefrescar.Click += new System.EventHandler(this.btnUsRefrescar_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(58)))), ((int)(((byte)(169)))));
            this.panel13.ForeColor = System.Drawing.Color.White;
            this.panel13.Location = new System.Drawing.Point(299, 12);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(10, 36);
            this.panel13.TabIndex = 23;
            // 
            // btnUsBuscar
            // 
            this.btnUsBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(58)))), ((int)(((byte)(169)))));
            this.btnUsBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(58)))), ((int)(((byte)(169)))));
            this.btnUsBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(206)))), ((int)(((byte)(181)))));
            this.btnUsBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsBuscar.ForeColor = System.Drawing.Color.White;
            this.btnUsBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsBuscar.Location = new System.Drawing.Point(188, 12);
            this.btnUsBuscar.Name = "btnUsBuscar";
            this.btnUsBuscar.Size = new System.Drawing.Size(89, 36);
            this.btnUsBuscar.TabIndex = 20;
            this.btnUsBuscar.Text = "Buscar";
            this.btnUsBuscar.UseVisualStyleBackColor = false;
            this.btnUsBuscar.Click += new System.EventHandler(this.btnUsBuscar_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(58)))), ((int)(((byte)(169)))));
            this.panel14.ForeColor = System.Drawing.Color.White;
            this.panel14.Location = new System.Drawing.Point(178, 12);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(10, 36);
            this.panel14.TabIndex = 21;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txtPagos);
            this.panel15.Location = new System.Drawing.Point(3, 10);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(7);
            this.panel15.Size = new System.Drawing.Size(168, 43);
            this.panel15.TabIndex = 1;
            // 
            // txtPagos
            // 
            this.txtPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagos.Location = new System.Drawing.Point(7, 7);
            this.txtPagos.Name = "txtPagos";
            this.txtPagos.Size = new System.Drawing.Size(154, 22);
            this.txtPagos.TabIndex = 0;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1079, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_opciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pagos";
            this.Text = "Pagos";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_opciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPagos)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnl_opciones;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgPagos;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnUsRefrescar;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnUsBuscar;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtPagos;
    }
}