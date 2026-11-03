namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnMostrar = new Button();
            btnGuardarTxt = new Button();
            btnLeerTxt = new Button();
            btnGuardarBin = new Button();
            btnGuardar = new Button();
            btnBuscar = new Button();
            lblCodigo = new Label();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.ForeColor = SystemColors.ControlText;
            btnAgregar.Location = new Point(278, 49);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(81, 26);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = SystemColors.ControlText;
            btnEliminar.Location = new Point(278, 199);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(81, 26);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            btnMostrar.ForeColor = SystemColors.ControlText;
            btnMostrar.Location = new Point(278, 98);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(81, 26);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnGuardarTxt
            // 
            btnGuardarTxt.ForeColor = SystemColors.ControlText;
            btnGuardarTxt.Location = new Point(12, 245);
            btnGuardarTxt.Name = "btnGuardarTxt";
            btnGuardarTxt.Size = new Size(94, 26);
            btnGuardarTxt.TabIndex = 3;
            btnGuardarTxt.Text = "Guardar Text";
            btnGuardarTxt.UseVisualStyleBackColor = true;
            btnGuardarTxt.Click += btnGuardarTxt_Click;
            // 
            // btnLeerTxt
            // 
            btnLeerTxt.ForeColor = SystemColors.ControlText;
            btnLeerTxt.Location = new Point(154, 245);
            btnLeerTxt.Name = "btnLeerTxt";
            btnLeerTxt.Size = new Size(81, 26);
            btnLeerTxt.TabIndex = 4;
            btnLeerTxt.Text = "Leer";
            btnLeerTxt.UseVisualStyleBackColor = true;
            btnLeerTxt.Click += btnLeerTxt_Click;
            // 
            // btnGuardarBin
            // 
            btnGuardarBin.ForeColor = SystemColors.ControlText;
            btnGuardarBin.Location = new Point(357, 245);
            btnGuardarBin.Name = "btnGuardarBin";
            btnGuardarBin.Size = new Size(91, 26);
            btnGuardarBin.TabIndex = 5;
            btnGuardarBin.Text = "Guardar Bin";
            btnGuardarBin.UseVisualStyleBackColor = true;
            btnGuardarBin.Click += btnGuardarBin_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.ForeColor = SystemColors.ControlText;
            btnGuardar.Location = new Point(536, 245);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(81, 26);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Leer Bin";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.ForeColor = SystemColors.ControlText;
            btnBuscar.Location = new Point(278, 146);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(81, 26);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(49, 53);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 8;
            lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(49, 101);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(49, 151);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 10;
            lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(49, 203);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 11;
            lblStock.Text = "Stock";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(113, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 12;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(113, 50);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 13;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(113, 147);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 14;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(113, 195);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(12, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(442, 153);
            dataGridView1.TabIndex = 16;
            // 
            // Column1
            // 
            Column1.HeaderText = "Codigo";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Precio";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Stock";
            Column4.Name = "Column4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtCodigo);
            Controls.Add(txtNombre);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Controls.Add(btnBuscar);
            Controls.Add(btnGuardar);
            Controls.Add(btnGuardarBin);
            Controls.Add(btnLeerTxt);
            Controls.Add(btnGuardarTxt);
            Controls.Add(btnMostrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnMostrar;
        private Button btnGuardarTxt;
        private Button btnLeerTxt;
        private Button btnGuardarBin;
        private Button btnGuardar;
        private Button btnBuscar;
        private Label lblCodigo;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblStock;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
