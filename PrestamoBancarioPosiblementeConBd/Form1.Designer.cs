namespace PrestamoBancarioPosiblementeConBd
{
    partial class PrestamoBanc
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
            this.cedLabel = new System.Windows.Forms.Label();
            this.cedCliente = new System.Windows.Forms.TextBox();
            this.nomCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.capitalLabel = new System.Windows.Forms.Label();
            this.capitalPrestamo = new System.Windows.Forms.TextBox();
            this.plazoPrestamoLabel = new System.Windows.Forms.Label();
            this.agregarPrestamo = new System.Windows.Forms.Button();
            this.tablaAmortizacion = new System.Windows.Forms.DataGridView();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intereses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amortizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoPrestamoPanel = new System.Windows.Forms.Panel();
            this.plazoPrestamo = new System.Windows.Forms.NumericUpDown();
            this.tasaPrestamo = new System.Windows.Forms.TextBox();
            this.labelTasa = new System.Windows.Forms.Label();
            this.bsClientePanel = new System.Windows.Forms.Panel();
            this.bsClienteLabelNom = new System.Windows.Forms.Label();
            this.bsClienteBtn = new System.Windows.Forms.Button();
            this.bsCliente = new System.Windows.Forms.TextBox();
            this.buscarCliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.infoClientePrestamo = new System.Windows.Forms.Label();
            this.desaparecer = new System.Windows.Forms.Button();
            this.infoPrestamoClientePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAmortizacion)).BeginInit();
            this.infoPrestamoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plazoPrestamo)).BeginInit();
            this.bsClientePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.infoPrestamoClientePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cedLabel
            // 
            this.cedLabel.AutoSize = true;
            this.cedLabel.Location = new System.Drawing.Point(13, 36);
            this.cedLabel.Name = "cedLabel";
            this.cedLabel.Size = new System.Drawing.Size(52, 17);
            this.cedLabel.TabIndex = 0;
            this.cedLabel.Text = "Cedula";
            // 
            // cedCliente
            // 
            this.cedCliente.Location = new System.Drawing.Point(77, 33);
            this.cedCliente.Name = "cedCliente";
            this.cedCliente.Size = new System.Drawing.Size(100, 22);
            this.cedCliente.TabIndex = 1;
            // 
            // nomCliente
            // 
            this.nomCliente.Location = new System.Drawing.Point(77, 61);
            this.nomCliente.Name = "nomCliente";
            this.nomCliente.Size = new System.Drawing.Size(100, 22);
            this.nomCliente.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Informacion del Cliente";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(13, 64);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(58, 17);
            this.nombreLabel.TabIndex = 4;
            this.nombreLabel.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Informacion del prestamo";
            // 
            // capitalLabel
            // 
            this.capitalLabel.AutoSize = true;
            this.capitalLabel.Location = new System.Drawing.Point(2, 43);
            this.capitalLabel.Name = "capitalLabel";
            this.capitalLabel.Size = new System.Drawing.Size(49, 17);
            this.capitalLabel.TabIndex = 6;
            this.capitalLabel.Text = "capital";
            // 
            // capitalPrestamo
            // 
            this.capitalPrestamo.Location = new System.Drawing.Point(60, 43);
            this.capitalPrestamo.Name = "capitalPrestamo";
            this.capitalPrestamo.Size = new System.Drawing.Size(100, 22);
            this.capitalPrestamo.TabIndex = 7;
            // 
            // plazoPrestamoLabel
            // 
            this.plazoPrestamoLabel.AutoSize = true;
            this.plazoPrestamoLabel.Location = new System.Drawing.Point(5, 75);
            this.plazoPrestamoLabel.Name = "plazoPrestamoLabel";
            this.plazoPrestamoLabel.Size = new System.Drawing.Size(43, 17);
            this.plazoPrestamoLabel.TabIndex = 9;
            this.plazoPrestamoLabel.Text = "Plazo";
            this.plazoPrestamoLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // agregarPrestamo
            // 
            this.agregarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agregarPrestamo.Location = new System.Drawing.Point(153, 160);
            this.agregarPrestamo.Name = "agregarPrestamo";
            this.agregarPrestamo.Size = new System.Drawing.Size(87, 29);
            this.agregarPrestamo.TabIndex = 10;
            this.agregarPrestamo.Text = "agregar";
            this.agregarPrestamo.UseVisualStyleBackColor = true;
            this.agregarPrestamo.Click += new System.EventHandler(this.agregarPrestamo_Click);
            // 
            // tablaAmortizacion
            // 
            this.tablaAmortizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAmortizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mes,
            this.pago,
            this.intereses,
            this.amortizacion,
            this.saldo});
            this.tablaAmortizacion.Location = new System.Drawing.Point(72, 43);
            this.tablaAmortizacion.Name = "tablaAmortizacion";
            this.tablaAmortizacion.RowTemplate.Height = 24;
            this.tablaAmortizacion.Size = new System.Drawing.Size(521, 150);
            this.tablaAmortizacion.TabIndex = 11;
            // 
            // mes
            // 
            this.mes.HeaderText = "Mes";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            // 
            // pago
            // 
            this.pago.HeaderText = "pago";
            this.pago.Name = "pago";
            this.pago.ReadOnly = true;
            // 
            // intereses
            // 
            this.intereses.HeaderText = "Intereses";
            this.intereses.Name = "intereses";
            this.intereses.ReadOnly = true;
            // 
            // amortizacion
            // 
            this.amortizacion.HeaderText = "Amortizacion";
            this.amortizacion.Name = "amortizacion";
            this.amortizacion.ReadOnly = true;
            // 
            // saldo
            // 
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            // 
            // infoPrestamoPanel
            // 
            this.infoPrestamoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPrestamoPanel.Controls.Add(this.plazoPrestamo);
            this.infoPrestamoPanel.Controls.Add(this.tasaPrestamo);
            this.infoPrestamoPanel.Controls.Add(this.labelTasa);
            this.infoPrestamoPanel.Controls.Add(this.label2);
            this.infoPrestamoPanel.Controls.Add(this.capitalLabel);
            this.infoPrestamoPanel.Controls.Add(this.agregarPrestamo);
            this.infoPrestamoPanel.Controls.Add(this.capitalPrestamo);
            this.infoPrestamoPanel.Controls.Add(this.plazoPrestamoLabel);
            this.infoPrestamoPanel.Location = new System.Drawing.Point(12, 124);
            this.infoPrestamoPanel.Name = "infoPrestamoPanel";
            this.infoPrestamoPanel.Size = new System.Drawing.Size(243, 192);
            this.infoPrestamoPanel.TabIndex = 13;
            this.infoPrestamoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.infoPrestamoPanel_Paint);
            // 
            // plazoPrestamo
            // 
            this.plazoPrestamo.Location = new System.Drawing.Point(60, 75);
            this.plazoPrestamo.Name = "plazoPrestamo";
            this.plazoPrestamo.Size = new System.Drawing.Size(100, 22);
            this.plazoPrestamo.TabIndex = 20;
            // 
            // tasaPrestamo
            // 
            this.tasaPrestamo.Location = new System.Drawing.Point(60, 103);
            this.tasaPrestamo.Name = "tasaPrestamo";
            this.tasaPrestamo.Size = new System.Drawing.Size(100, 22);
            this.tasaPrestamo.TabIndex = 19;
            // 
            // labelTasa
            // 
            this.labelTasa.AutoSize = true;
            this.labelTasa.Location = new System.Drawing.Point(5, 102);
            this.labelTasa.Name = "labelTasa";
            this.labelTasa.Size = new System.Drawing.Size(40, 17);
            this.labelTasa.TabIndex = 13;
            this.labelTasa.Text = "Tasa";
            // 
            // bsClientePanel
            // 
            this.bsClientePanel.BackColor = System.Drawing.SystemColors.Control;
            this.bsClientePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bsClientePanel.Controls.Add(this.bsClienteLabelNom);
            this.bsClientePanel.Controls.Add(this.bsClienteBtn);
            this.bsClientePanel.Controls.Add(this.bsCliente);
            this.bsClientePanel.Controls.Add(this.buscarCliente);
            this.bsClientePanel.Location = new System.Drawing.Point(341, 248);
            this.bsClientePanel.Name = "bsClientePanel";
            this.bsClientePanel.Size = new System.Drawing.Size(295, 105);
            this.bsClientePanel.TabIndex = 14;
            // 
            // bsClienteLabelNom
            // 
            this.bsClienteLabelNom.AutoSize = true;
            this.bsClienteLabelNom.Location = new System.Drawing.Point(23, 44);
            this.bsClienteLabelNom.Name = "bsClienteLabelNom";
            this.bsClienteLabelNom.Size = new System.Drawing.Size(58, 17);
            this.bsClienteLabelNom.TabIndex = 3;
            this.bsClienteLabelNom.Text = "Nombre";
            // 
            // bsClienteBtn
            // 
            this.bsClienteBtn.Location = new System.Drawing.Point(193, 44);
            this.bsClienteBtn.Name = "bsClienteBtn";
            this.bsClienteBtn.Size = new System.Drawing.Size(75, 23);
            this.bsClienteBtn.TabIndex = 2;
            this.bsClienteBtn.Text = "buscar";
            this.bsClienteBtn.UseVisualStyleBackColor = true;
            this.bsClienteBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // bsCliente
            // 
            this.bsCliente.Location = new System.Drawing.Point(87, 44);
            this.bsCliente.Name = "bsCliente";
            this.bsCliente.Size = new System.Drawing.Size(100, 22);
            this.bsCliente.TabIndex = 1;
            // 
            // buscarCliente
            // 
            this.buscarCliente.AutoSize = true;
            this.buscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.buscarCliente.Location = new System.Drawing.Point(114, 13);
            this.buscarCliente.Name = "buscarCliente";
            this.buscarCliente.Size = new System.Drawing.Size(97, 17);
            this.buscarCliente.TabIndex = 0;
            this.buscarCliente.Text = "Buscar cliente";
            this.buscarCliente.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = "";
            this.panel1.AccessibleName = "";
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cedLabel);
            this.panel1.Controls.Add(this.cedCliente);
            this.panel1.Controls.Add(this.nomCliente);
            this.panel1.Controls.Add(this.nombreLabel);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 15;
            this.panel1.Tag = "";
            // 
            // infoClientePrestamo
            // 
            this.infoClientePrestamo.AutoSize = true;
            this.infoClientePrestamo.Location = new System.Drawing.Point(248, 12);
            this.infoClientePrestamo.Name = "infoClientePrestamo";
            this.infoClientePrestamo.Size = new System.Drawing.Size(168, 17);
            this.infoClientePrestamo.TabIndex = 16;
            this.infoClientePrestamo.Text = "Informacion del Prestamo";
            this.infoClientePrestamo.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // desaparecer
            // 
            this.desaparecer.Location = new System.Drawing.Point(611, 135);
            this.desaparecer.Name = "desaparecer";
            this.desaparecer.Size = new System.Drawing.Size(112, 45);
            this.desaparecer.TabIndex = 17;
            this.desaparecer.Text = "Desaparecer";
            this.desaparecer.UseVisualStyleBackColor = true;
            this.desaparecer.Click += new System.EventHandler(this.desaparecer_Click);
            // 
            // infoPrestamoClientePanel
            // 
            this.infoPrestamoClientePanel.Controls.Add(this.tablaAmortizacion);
            this.infoPrestamoClientePanel.Controls.Add(this.infoClientePrestamo);
            this.infoPrestamoClientePanel.Controls.Add(this.desaparecer);
            this.infoPrestamoClientePanel.Location = new System.Drawing.Point(52, 370);
            this.infoPrestamoClientePanel.Name = "infoPrestamoClientePanel";
            this.infoPrestamoClientePanel.Size = new System.Drawing.Size(735, 205);
            this.infoPrestamoClientePanel.TabIndex = 18;
            // 
            // PrestamoBanc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 587);
            this.Controls.Add(this.infoPrestamoClientePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bsClientePanel);
            this.Controls.Add(this.infoPrestamoPanel);
            this.Name = "PrestamoBanc";
            this.Text = "Prestamo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaAmortizacion)).EndInit();
            this.infoPrestamoPanel.ResumeLayout(false);
            this.infoPrestamoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plazoPrestamo)).EndInit();
            this.bsClientePanel.ResumeLayout(false);
            this.bsClientePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.infoPrestamoClientePanel.ResumeLayout(false);
            this.infoPrestamoClientePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cedLabel;
        private System.Windows.Forms.TextBox cedCliente;
        private System.Windows.Forms.TextBox nomCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label capitalLabel;
        private System.Windows.Forms.TextBox capitalPrestamo;
        private System.Windows.Forms.Label plazoPrestamoLabel;
        private System.Windows.Forms.Button agregarPrestamo;
        private System.Windows.Forms.DataGridView tablaAmortizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn intereses;
        private System.Windows.Forms.DataGridViewTextBoxColumn amortizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.Panel infoPrestamoPanel;
        private System.Windows.Forms.Panel bsClientePanel;
        private System.Windows.Forms.Label buscarCliente;
        private System.Windows.Forms.Button bsClienteBtn;
        private System.Windows.Forms.TextBox bsCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label infoClientePrestamo;
        private System.Windows.Forms.Button desaparecer;
        private System.Windows.Forms.Panel infoPrestamoClientePanel;
        private System.Windows.Forms.NumericUpDown plazoPrestamo;
        private System.Windows.Forms.TextBox tasaPrestamo;
        private System.Windows.Forms.Label labelTasa;
        private System.Windows.Forms.Label bsClienteLabelNom;
    }
}

