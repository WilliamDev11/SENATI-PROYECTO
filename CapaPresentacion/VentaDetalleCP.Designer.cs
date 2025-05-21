namespace CapaPresentacion
{
    partial class VentaDetalleCP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Fechatxt = new System.Windows.Forms.TextBox();
            this.IdClientetxt = new System.Windows.Forms.TextBox();
            this.IdProductotxt = new System.Windows.Forms.TextBox();
            this.BuscarClientebtn = new System.Windows.Forms.Button();
            this.BuscarProductobtn = new System.Windows.Forms.Button();
            this.ClienteNombretxt = new System.Windows.Forms.TextBox();
            this.ProductoDescripciontxt = new System.Windows.Forms.TextBox();
            this.Preciotxt = new System.Windows.Forms.TextBox();
            this.Cantidadtxt = new System.Windows.Forms.TextBox();
            this.Agregarbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDetalleVentas = new System.Windows.Forms.DataGridView();
            this.Guardarbtn = new System.Windows.Forms.Button();
            this.Totaltxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Cerrarbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto: ";
            // 
            // Fechatxt
            // 
            this.Fechatxt.Location = new System.Drawing.Point(91, 18);
            this.Fechatxt.Name = "Fechatxt";
            this.Fechatxt.Size = new System.Drawing.Size(242, 20);
            this.Fechatxt.TabIndex = 3;
            // 
            // IdClientetxt
            // 
            this.IdClientetxt.Location = new System.Drawing.Point(91, 54);
            this.IdClientetxt.Name = "IdClientetxt";
            this.IdClientetxt.Size = new System.Drawing.Size(49, 20);
            this.IdClientetxt.TabIndex = 4;
            // 
            // IdProductotxt
            // 
            this.IdProductotxt.Location = new System.Drawing.Point(91, 102);
            this.IdProductotxt.Name = "IdProductotxt";
            this.IdProductotxt.Size = new System.Drawing.Size(49, 20);
            this.IdProductotxt.TabIndex = 5;
            // 
            // BuscarClientebtn
            // 
            this.BuscarClientebtn.Location = new System.Drawing.Point(159, 52);
            this.BuscarClientebtn.Name = "BuscarClientebtn";
            this.BuscarClientebtn.Size = new System.Drawing.Size(56, 23);
            this.BuscarClientebtn.TabIndex = 6;
            this.BuscarClientebtn.Text = "Buscar";
            this.BuscarClientebtn.UseVisualStyleBackColor = true;
            this.BuscarClientebtn.Click += new System.EventHandler(this.BuscarClientebtn_Click);
            // 
            // BuscarProductobtn
            // 
            this.BuscarProductobtn.Location = new System.Drawing.Point(159, 102);
            this.BuscarProductobtn.Name = "BuscarProductobtn";
            this.BuscarProductobtn.Size = new System.Drawing.Size(56, 23);
            this.BuscarProductobtn.TabIndex = 7;
            this.BuscarProductobtn.Text = "Buscar";
            this.BuscarProductobtn.UseVisualStyleBackColor = true;
            this.BuscarProductobtn.Click += new System.EventHandler(this.BuscarProductobtn_Click);
            // 
            // ClienteNombretxt
            // 
            this.ClienteNombretxt.Location = new System.Drawing.Point(233, 54);
            this.ClienteNombretxt.Name = "ClienteNombretxt";
            this.ClienteNombretxt.Size = new System.Drawing.Size(409, 20);
            this.ClienteNombretxt.TabIndex = 8;
            // 
            // ProductoDescripciontxt
            // 
            this.ProductoDescripciontxt.Location = new System.Drawing.Point(233, 102);
            this.ProductoDescripciontxt.Name = "ProductoDescripciontxt";
            this.ProductoDescripciontxt.Size = new System.Drawing.Size(245, 20);
            this.ProductoDescripciontxt.TabIndex = 9;
            // 
            // Preciotxt
            // 
            this.Preciotxt.Location = new System.Drawing.Point(484, 102);
            this.Preciotxt.Name = "Preciotxt";
            this.Preciotxt.Size = new System.Drawing.Size(76, 20);
            this.Preciotxt.TabIndex = 10;
            // 
            // Cantidadtxt
            // 
            this.Cantidadtxt.Location = new System.Drawing.Point(566, 102);
            this.Cantidadtxt.Name = "Cantidadtxt";
            this.Cantidadtxt.Size = new System.Drawing.Size(76, 20);
            this.Cantidadtxt.TabIndex = 11;
            // 
            // Agregarbtn
            // 
            this.Agregarbtn.Location = new System.Drawing.Point(648, 100);
            this.Agregarbtn.Name = "Agregarbtn";
            this.Agregarbtn.Size = new System.Drawing.Size(75, 23);
            this.Agregarbtn.TabIndex = 12;
            this.Agregarbtn.Text = "Agregar";
            this.Agregarbtn.UseVisualStyleBackColor = true;
            this.Agregarbtn.Click += new System.EventHandler(this.Agregarbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Precio: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cantidad: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Producto: ";
            // 
            // dgvDetalleVentas
            // 
            this.dgvDetalleVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVentas.Location = new System.Drawing.Point(22, 145);
            this.dgvDetalleVentas.Name = "dgvDetalleVentas";
            this.dgvDetalleVentas.Size = new System.Drawing.Size(701, 150);
            this.dgvDetalleVentas.TabIndex = 16;
            this.dgvDetalleVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleVentas_CellContentClick);
            // 
            // Guardarbtn
            // 
            this.Guardarbtn.Location = new System.Drawing.Point(22, 311);
            this.Guardarbtn.Name = "Guardarbtn";
            this.Guardarbtn.Size = new System.Drawing.Size(101, 23);
            this.Guardarbtn.TabIndex = 17;
            this.Guardarbtn.Text = "Guardar Venta";
            this.Guardarbtn.UseVisualStyleBackColor = true;
            this.Guardarbtn.Click += new System.EventHandler(this.Guardarbtn_Click);
            // 
            // Totaltxt
            // 
            this.Totaltxt.Location = new System.Drawing.Point(623, 311);
            this.Totaltxt.Name = "Totaltxt";
            this.Totaltxt.Size = new System.Drawing.Size(100, 20);
            this.Totaltxt.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(563, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Total    S/.";
            // 
            // Cerrarbtn
            // 
            this.Cerrarbtn.Location = new System.Drawing.Point(648, 346);
            this.Cerrarbtn.Name = "Cerrarbtn";
            this.Cerrarbtn.Size = new System.Drawing.Size(75, 23);
            this.Cerrarbtn.TabIndex = 20;
            this.Cerrarbtn.Text = "Cerrar";
            this.Cerrarbtn.UseVisualStyleBackColor = true;
            this.Cerrarbtn.Click += new System.EventHandler(this.Cerrarbtn_Click);
            // 
            // VentaDetalleCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 415);
            this.Controls.Add(this.Cerrarbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Totaltxt);
            this.Controls.Add(this.Guardarbtn);
            this.Controls.Add(this.dgvDetalleVentas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Agregarbtn);
            this.Controls.Add(this.Cantidadtxt);
            this.Controls.Add(this.Preciotxt);
            this.Controls.Add(this.ProductoDescripciontxt);
            this.Controls.Add(this.ClienteNombretxt);
            this.Controls.Add(this.BuscarProductobtn);
            this.Controls.Add(this.BuscarClientebtn);
            this.Controls.Add(this.IdProductotxt);
            this.Controls.Add(this.IdClientetxt);
            this.Controls.Add(this.Fechatxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VentaDetalleCP";
            this.Text = "VentaDetalle";
            this.Load += new System.EventHandler(this.VentaDetalleCP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Fechatxt;
        private System.Windows.Forms.TextBox IdClientetxt;
        private System.Windows.Forms.TextBox IdProductotxt;
        private System.Windows.Forms.Button BuscarClientebtn;
        private System.Windows.Forms.Button BuscarProductobtn;
        private System.Windows.Forms.TextBox ClienteNombretxt;
        private System.Windows.Forms.TextBox ProductoDescripciontxt;
        private System.Windows.Forms.TextBox Preciotxt;
        private System.Windows.Forms.TextBox Cantidadtxt;
        private System.Windows.Forms.Button Agregarbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDetalleVentas;
        private System.Windows.Forms.Button Guardarbtn;
        private System.Windows.Forms.TextBox Totaltxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Cerrarbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}