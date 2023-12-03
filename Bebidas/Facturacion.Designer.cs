namespace Bebidas
{
    partial class Facturacion
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
            dgvDetalle = new DataGridView();
            cboFormaPago = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            gbFormaPago = new GroupBox();
            gbEmpleado = new GroupBox();
            cboEmpleado = new ComboBox();
            gbSocio = new GroupBox();
            cboSocio = new ComboBox();
            gbCodigo = new GroupBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            Colid = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ColCantidad = new DataGridViewTextBoxColumn();
            ColSubtotal = new DataGridViewTextBoxColumn();
            ColQuitar = new DataGridViewButtonColumn();
            label3 = new Label();
            btnFinalizar = new Button();
            btnCancelar = new Button();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            gbFormaPago.SuspendLayout();
            gbEmpleado.SuspendLayout();
            gbSocio.SuspendLayout();
            gbCodigo.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { Colid, ColNombre, ColPrecio, ColCantidad, ColSubtotal, ColQuitar });
            dgvDetalle.Location = new Point(12, 71);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowTemplate.Height = 25;
            dgvDetalle.Size = new Size(629, 278);
            dgvDetalle.TabIndex = 0;
            // 
            // cboFormaPago
            // 
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(6, 22);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(156, 23);
            cboFormaPago.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(49, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 22);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 3;
            label1.Text = "Codigo:";
            // 
            // gbFormaPago
            // 
            gbFormaPago.Controls.Add(cboFormaPago);
            gbFormaPago.Location = new Point(12, 357);
            gbFormaPago.Name = "gbFormaPago";
            gbFormaPago.Size = new Size(168, 53);
            gbFormaPago.TabIndex = 4;
            gbFormaPago.TabStop = false;
            gbFormaPago.Text = "Forma de Pago";
            // 
            // gbEmpleado
            // 
            gbEmpleado.Controls.Add(cboEmpleado);
            gbEmpleado.Location = new Point(473, 14);
            gbEmpleado.Name = "gbEmpleado";
            gbEmpleado.Size = new Size(168, 53);
            gbEmpleado.TabIndex = 5;
            gbEmpleado.TabStop = false;
            gbEmpleado.Text = "Vendedor";
            // 
            // cboEmpleado
            // 
            cboEmpleado.FormattingEnabled = true;
            cboEmpleado.Location = new Point(6, 22);
            cboEmpleado.Name = "cboEmpleado";
            cboEmpleado.Size = new Size(156, 23);
            cboEmpleado.TabIndex = 1;
            // 
            // gbSocio
            // 
            gbSocio.Controls.Add(cboSocio);
            gbSocio.Location = new Point(299, 14);
            gbSocio.Name = "gbSocio";
            gbSocio.Size = new Size(168, 53);
            gbSocio.TabIndex = 6;
            gbSocio.TabStop = false;
            gbSocio.Text = "Socio";
            // 
            // cboSocio
            // 
            cboSocio.FormattingEnabled = true;
            cboSocio.Location = new Point(6, 22);
            cboSocio.Name = "cboSocio";
            cboSocio.Size = new Size(156, 23);
            cboSocio.TabIndex = 1;
            // 
            // gbCodigo
            // 
            gbCodigo.Controls.Add(textBox1);
            gbCodigo.Controls.Add(label1);
            gbCodigo.Location = new Point(12, 12);
            gbCodigo.Name = "gbCodigo";
            gbCodigo.Size = new Size(127, 55);
            gbCodigo.TabIndex = 7;
            gbCodigo.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(155, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(127, 55);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 22);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 3;
            label2.Text = "Cant.";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(49, 19);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(61, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Colid
            // 
            Colid.HeaderText = "id";
            Colid.Name = "Colid";
            Colid.ReadOnly = true;
            Colid.Width = 40;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            ColNombre.Width = 140;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "Precio";
            ColPrecio.Name = "ColPrecio";
            ColPrecio.ReadOnly = true;
            ColPrecio.Width = 120;
            // 
            // ColCantidad
            // 
            ColCantidad.HeaderText = "Cantidad";
            ColCantidad.Name = "ColCantidad";
            ColCantidad.ReadOnly = true;
            ColCantidad.Width = 80;
            // 
            // ColSubtotal
            // 
            ColSubtotal.HeaderText = "Subtotal";
            ColSubtotal.Name = "ColSubtotal";
            ColSubtotal.ReadOnly = true;
            ColSubtotal.Width = 130;
            // 
            // ColQuitar
            // 
            ColQuitar.HeaderText = "Accion";
            ColQuitar.Name = "ColQuitar";
            ColQuitar.ReadOnly = true;
            ColQuitar.Text = "Quitar";
            ColQuitar.Width = 70;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(520, 366);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 9;
            label3.Text = "Total de Factura:";
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(374, 378);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(75, 23);
            btnFinalizar.TabIndex = 10;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(232, 378);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(557, 389);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(16, 21);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "-";
            // 
            // Facturacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 423);
            Controls.Add(lblTotal);
            Controls.Add(btnCancelar);
            Controls.Add(btnFinalizar);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(gbCodigo);
            Controls.Add(gbSocio);
            Controls.Add(gbEmpleado);
            Controls.Add(gbFormaPago);
            Controls.Add(dgvDetalle);
            Name = "Facturacion";
            Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            gbFormaPago.ResumeLayout(false);
            gbEmpleado.ResumeLayout(false);
            gbSocio.ResumeLayout(false);
            gbCodigo.ResumeLayout(false);
            gbCodigo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDetalle;
        private ComboBox cboFormaPago;
        private TextBox textBox1;
        private Label label1;
        private GroupBox gbFormaPago;
        private GroupBox gbEmpleado;
        private ComboBox cboEmpleado;
        private GroupBox gbSocio;
        private ComboBox cboSocio;
        private GroupBox gbCodigo;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private DataGridViewTextBoxColumn Colid;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewTextBoxColumn ColCantidad;
        private DataGridViewTextBoxColumn ColSubtotal;
        private DataGridViewButtonColumn ColQuitar;
        private Label label3;
        private Button btnFinalizar;
        private Button btnCancelar;
        private Label lblTotal;
    }
}