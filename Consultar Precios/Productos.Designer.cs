namespace Consultar_Precios
{
    partial class Productos
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtunidad = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbcodigo = new System.Windows.Forms.RadioButton();
            this.rbnombre = new System.Windows.Forms.RadioButton();
            this.btnsave = new System.Windows.Forms.Button();
            this.bteditar = new System.Windows.Forms.Button();
            this.btcargar = new System.Windows.Forms.Button();
            this.txtcod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1010, 253);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 65);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(191, 292);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(770, 26);
            this.txtbuscar.TabIndex = 5;
            // 
            // dgvproductos
            // 
            this.dgvproductos.AllowUserToAddRows = false;
            this.dgvproductos.AllowUserToDeleteRows = false;
            this.dgvproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvproductos.BackgroundColor = System.Drawing.Color.Black;
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Location = new System.Drawing.Point(17, 331);
            this.dgvproductos.Margin = new System.Windows.Forms.Padding(8);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.ReadOnly = true;
            this.dgvproductos.Size = new System.Drawing.Size(1277, 318);
            this.dgvproductos.TabIndex = 4;
            this.dgvproductos.Click += new System.EventHandler(this.dgvproductos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Unidad de medida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio de venta";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(193, 11);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(457, 26);
            this.txtcantidad.TabIndex = 13;
            // 
            // txtunidad
            // 
            this.txtunidad.Location = new System.Drawing.Point(193, 61);
            this.txtunidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtunidad.Name = "txtunidad";
            this.txtunidad.Size = new System.Drawing.Size(457, 26);
            this.txtunidad.TabIndex = 14;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(193, 112);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(457, 26);
            this.txtcodigo.TabIndex = 15;
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(193, 168);
            this.txtdesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(457, 26);
            this.txtdesc.TabIndex = 16;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(193, 223);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(457, 26);
            this.txtprecio.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbcodigo);
            this.groupBox1.Controls.Add(this.rbnombre);
            this.groupBox1.Location = new System.Drawing.Point(1066, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(276, 152);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de busquedas";
            // 
            // rbcodigo
            // 
            this.rbcodigo.AutoSize = true;
            this.rbcodigo.Location = new System.Drawing.Point(22, 97);
            this.rbcodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbcodigo.Name = "rbcodigo";
            this.rbcodigo.Size = new System.Drawing.Size(77, 24);
            this.rbcodigo.TabIndex = 1;
            this.rbcodigo.TabStop = true;
            this.rbcodigo.Text = "Codigo";
            this.rbcodigo.UseVisualStyleBackColor = true;
            // 
            // rbnombre
            // 
            this.rbnombre.AutoSize = true;
            this.rbnombre.Location = new System.Drawing.Point(16, 46);
            this.rbnombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbnombre.Name = "rbnombre";
            this.rbnombre.Size = new System.Drawing.Size(83, 24);
            this.rbnombre.TabIndex = 0;
            this.rbnombre.TabStop = true;
            this.rbnombre.Text = "Nombre";
            this.rbnombre.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Enabled = false;
            this.btnsave.Location = new System.Drawing.Point(803, 11);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(212, 65);
            this.btnsave.TabIndex = 19;
            this.btnsave.Text = "Guardar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // bteditar
            // 
            this.bteditar.Location = new System.Drawing.Point(803, 105);
            this.bteditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(212, 65);
            this.bteditar.TabIndex = 20;
            this.bteditar.Text = "Editar";
            this.bteditar.UseVisualStyleBackColor = true;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // btcargar
            // 
            this.btcargar.Location = new System.Drawing.Point(1153, 253);
            this.btcargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btcargar.Name = "btcargar";
            this.btcargar.Size = new System.Drawing.Size(123, 65);
            this.btcargar.TabIndex = 21;
            this.btcargar.Text = "Cargar Datos";
            this.btcargar.UseVisualStyleBackColor = true;
            this.btcargar.Click += new System.EventHandler(this.btcargar_Click);
            // 
            // txtcod
            // 
            this.txtcod.Enabled = false;
            this.txtcod.Location = new System.Drawing.Point(672, 12);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(60, 26);
            this.txtcod.TabIndex = 22;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.btcargar);
            this.Controls.Add(this.bteditar);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtunidad);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dgvproductos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Productos";
            this.Text = "Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dgvproductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtunidad;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbcodigo;
        private System.Windows.Forms.RadioButton rbnombre;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.Button btcargar;
        private System.Windows.Forms.TextBox txtcod;
    }
}