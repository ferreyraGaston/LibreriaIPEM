
namespace Video_Club
{
    partial class RepVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textStock = new System.Windows.Forms.TextBox();
            this.dgv_detalle = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dgDevolucion = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnDeRefrescar = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnDeBuscar = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtDevolver = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFechDevol = new System.Windows.Forms.RadioButton();
            this.rbFechEntrega = new System.Windows.Forms.RadioButton();
            this.rbFechSalida = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDevolucion)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(91, 49);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(32, 20);
            this.textCodigo.TabIndex = 8;
            // 
            // textStock
            // 
            this.textStock.Location = new System.Drawing.Point(225, 49);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(34, 20);
            this.textStock.TabIndex = 10;
            // 
            // dgv_detalle
            // 
            this.dgv_detalle.AllowUserToAddRows = false;
            this.dgv_detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_detalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_detalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(2)))), ((int)(((byte)(73)))));
            this.dgv_detalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_detalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle.EnableHeadersVisualStyles = false;
            this.dgv_detalle.Location = new System.Drawing.Point(26, 210);
            this.dgv_detalle.Name = "dgv_detalle";
            this.dgv_detalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_detalle.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_detalle.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_detalle.Size = new System.Drawing.Size(843, 291);
            this.dgv_detalle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.label2.Location = new System.Drawing.Point(141, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Titulo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgv_detalle);
            this.panel2.Controls.Add(this.textStock);
            this.panel2.Controls.Add(this.textCodigo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 572);
            this.panel2.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            this.panel7.Controls.Add(this.groupBox1);
            this.panel7.Controls.Add(this.dtFechaHasta);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.dtFechaDesde);
            this.panel7.Controls.Add(this.dgDevolucion);
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1089, 572);
            this.panel7.TabIndex = 13;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.CustomFormat = "yyyy/MM/dd";
            this.dtFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaHasta.Location = new System.Drawing.Point(421, 10);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Size = new System.Drawing.Size(111, 29);
            this.dtFechaHasta.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Broadway", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.label3.Location = new System.Drawing.Point(296, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "F. Hasta";
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.CustomFormat = "yyyy/MM/dd";
            this.dtFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaDesde.Location = new System.Drawing.Point(145, 6);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Size = new System.Drawing.Size(116, 29);
            this.dtFechaDesde.TabIndex = 33;
            // 
            // dgDevolucion
            // 
            this.dgDevolucion.AllowUserToAddRows = false;
            this.dgDevolucion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgDevolucion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgDevolucion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(2)))), ((int)(((byte)(73)))));
            this.dgDevolucion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDevolucion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(2)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDevolucion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDevolucion.EnableHeadersVisualStyles = false;
            this.dgDevolucion.Location = new System.Drawing.Point(9, 118);
            this.dgDevolucion.Name = "dgDevolucion";
            this.dgDevolucion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDevolucion.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgDevolucion.RowHeadersVisible = false;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.dgDevolucion.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgDevolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDevolucion.Size = new System.Drawing.Size(1042, 437);
            this.dgDevolucion.TabIndex = 27;
            this.dgDevolucion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDevolucion_CellContentClick);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnDeRefrescar);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Controls.Add(this.btnDeBuscar);
            this.panel12.Controls.Add(this.panel14);
            this.panel12.Controls.Add(this.panel15);
            this.panel12.Location = new System.Drawing.Point(645, 21);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(409, 61);
            this.panel12.TabIndex = 24;
            // 
            // btnDeRefrescar
            // 
            this.btnDeRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.btnDeRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeRefrescar.FlatAppearance.BorderSize = 0;
            this.btnDeRefrescar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            this.btnDeRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeRefrescar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeRefrescar.Location = new System.Drawing.Point(309, 12);
            this.btnDeRefrescar.Name = "btnDeRefrescar";
            this.btnDeRefrescar.Size = new System.Drawing.Size(95, 36);
            this.btnDeRefrescar.TabIndex = 22;
            this.btnDeRefrescar.Text = "Refrescar";
            this.btnDeRefrescar.UseVisualStyleBackColor = false;
            this.btnDeRefrescar.Click += new System.EventHandler(this.btnDeRefrescar_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.panel13.Location = new System.Drawing.Point(299, 11);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(10, 37);
            this.panel13.TabIndex = 23;
            // 
            // btnDeBuscar
            // 
            this.btnDeBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.btnDeBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeBuscar.FlatAppearance.BorderSize = 0;
            this.btnDeBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(87)))));
            this.btnDeBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeBuscar.Location = new System.Drawing.Point(188, 12);
            this.btnDeBuscar.Name = "btnDeBuscar";
            this.btnDeBuscar.Size = new System.Drawing.Size(89, 36);
            this.btnDeBuscar.TabIndex = 20;
            this.btnDeBuscar.Text = "Buscar";
            this.btnDeBuscar.UseVisualStyleBackColor = false;
            this.btnDeBuscar.Click += new System.EventHandler(this.btnDeBuscar_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.panel14.Location = new System.Drawing.Point(178, 11);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(10, 37);
            this.panel14.TabIndex = 21;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txtDevolver);
            this.panel15.Location = new System.Drawing.Point(3, 10);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(7);
            this.panel15.Size = new System.Drawing.Size(168, 43);
            this.panel15.TabIndex = 1;
            // 
            // txtDevolver
            // 
            this.txtDevolver.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDevolver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevolver.Location = new System.Drawing.Point(7, 7);
            this.txtDevolver.Name = "txtDevolver";
            this.txtDevolver.Size = new System.Drawing.Size(154, 22);
            this.txtDevolver.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Broadway", 15.75F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(16)))), ((int)(((byte)(121)))));
            this.label6.Location = new System.Drawing.Point(28, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "F. Desde";
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
            this.panel1.Size = new System.Drawing.Size(1089, 32);
            this.panel1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFechDevol);
            this.groupBox1.Controls.Add(this.rbFechEntrega);
            this.groupBox1.Controls.Add(this.rbFechSalida);
            this.groupBox1.Location = new System.Drawing.Point(26, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 51);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // rbFechDevol
            // 
            this.rbFechDevol.AutoSize = true;
            this.rbFechDevol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFechDevol.ForeColor = System.Drawing.Color.White;
            this.rbFechDevol.Location = new System.Drawing.Point(284, 20);
            this.rbFechDevol.Name = "rbFechDevol";
            this.rbFechDevol.Size = new System.Drawing.Size(150, 20);
            this.rbFechDevol.TabIndex = 0;
            this.rbFechDevol.TabStop = true;
            this.rbFechDevol.Text = "Fecha Devolución";
            this.rbFechDevol.UseVisualStyleBackColor = true;
            this.rbFechDevol.CheckedChanged += new System.EventHandler(this.rbFechDevol_CheckedChanged);
            // 
            // rbFechEntrega
            // 
            this.rbFechEntrega.AutoSize = true;
            this.rbFechEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFechEntrega.ForeColor = System.Drawing.Color.White;
            this.rbFechEntrega.Location = new System.Drawing.Point(130, 20);
            this.rbFechEntrega.Name = "rbFechEntrega";
            this.rbFechEntrega.Size = new System.Drawing.Size(126, 20);
            this.rbFechEntrega.TabIndex = 0;
            this.rbFechEntrega.TabStop = true;
            this.rbFechEntrega.Text = "Fecha Entrega";
            this.rbFechEntrega.UseVisualStyleBackColor = true;
            this.rbFechEntrega.CheckedChanged += new System.EventHandler(this.rbFechEntrega_CheckedChanged);
            // 
            // rbFechSalida
            // 
            this.rbFechSalida.AutoSize = true;
            this.rbFechSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFechSalida.ForeColor = System.Drawing.Color.White;
            this.rbFechSalida.Location = new System.Drawing.Point(7, 20);
            this.rbFechSalida.Name = "rbFechSalida";
            this.rbFechSalida.Size = new System.Drawing.Size(117, 20);
            this.rbFechSalida.TabIndex = 0;
            this.rbFechSalida.TabStop = true;
            this.rbFechSalida.Text = "Fecha Salida";
            this.rbFechSalida.UseVisualStyleBackColor = true;
            this.rbFechSalida.CheckedChanged += new System.EventHandler(this.rbFechSalida_CheckedChanged);
            // 
            // RepVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1089, 604);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RepVentas";
            this.Text = "RepVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDevolucion)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.DataGridView dgv_detalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DateTimePicker dtFechaDesde;
        private System.Windows.Forms.DataGridView dgDevolucion;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnDeRefrescar;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnDeBuscar;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtDevolver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtFechaHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFechDevol;
        private System.Windows.Forms.RadioButton rbFechEntrega;
        private System.Windows.Forms.RadioButton rbFechSalida;
    }
}