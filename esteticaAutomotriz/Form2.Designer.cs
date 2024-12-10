namespace esteticaAutomotriz
{
    partial class frmOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrden));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblRFC = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblSubTitulo1 = new System.Windows.Forms.Label();
            this.lblSubTitulo2 = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblPlacas = new System.Windows.Forms.Label();
            this.lblSubTitulo3 = new System.Windows.Forms.Label();
            this.listaContratados = new System.Windows.Forms.ListBox();
            this.lblPagoTotal = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblKilometraje = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(89, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(192, 26);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Resumen de Orden";
            // 
            // lblCliente
            // 
            this.lblCliente.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCliente.Location = new System.Drawing.Point(25, 114);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(334, 22);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Nombre del Cliente";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDomicilio.Location = new System.Drawing.Point(25, 136);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(330, 46);
            this.lblDomicilio.TabIndex = 4;
            this.lblDomicilio.Text = "Domicilio";
            this.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRFC
            // 
            this.lblRFC.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblRFC.Location = new System.Drawing.Point(25, 182);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(182, 43);
            this.lblRFC.TabIndex = 5;
            this.lblRFC.Text = "Datos de RFC";
            this.lblRFC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTelefono.Location = new System.Drawing.Point(211, 182);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(156, 43);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubTitulo1
            // 
            this.lblSubTitulo1.AutoSize = true;
            this.lblSubTitulo1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo1.Location = new System.Drawing.Point(116, 36);
            this.lblSubTitulo1.Name = "lblSubTitulo1";
            this.lblSubTitulo1.Size = new System.Drawing.Size(138, 20);
            this.lblSubTitulo1.TabIndex = 7;
            this.lblSubTitulo1.Text = "Datos del Cliente";
            // 
            // lblSubTitulo2
            // 
            this.lblSubTitulo2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo2.Location = new System.Drawing.Point(25, 229);
            this.lblSubTitulo2.Name = "lblSubTitulo2";
            this.lblSubTitulo2.Size = new System.Drawing.Size(330, 20);
            this.lblSubTitulo2.TabIndex = 8;
            this.lblSubTitulo2.Text = "Datos del Vehiculo";
            this.lblSubTitulo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMarca
            // 
            this.lblMarca.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblMarca.Location = new System.Drawing.Point(29, 262);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(178, 19);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "Marca";
            this.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTipo
            // 
            this.lblTipo.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTipo.Location = new System.Drawing.Point(215, 262);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(140, 19);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo ";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModelo
            // 
            this.lblModelo.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblModelo.Location = new System.Drawing.Point(21, 316);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(130, 19);
            this.lblModelo.TabIndex = 11;
            this.lblModelo.Text = "Modelo";
            this.lblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlacas
            // 
            this.lblPlacas.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPlacas.Location = new System.Drawing.Point(143, 289);
            this.lblPlacas.Name = "lblPlacas";
            this.lblPlacas.Size = new System.Drawing.Size(90, 19);
            this.lblPlacas.TabIndex = 12;
            this.lblPlacas.Text = "Placas";
            this.lblPlacas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubTitulo3
            // 
            this.lblSubTitulo3.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTitulo3.Location = new System.Drawing.Point(101, 346);
            this.lblSubTitulo3.Name = "lblSubTitulo3";
            this.lblSubTitulo3.Size = new System.Drawing.Size(177, 20);
            this.lblSubTitulo3.TabIndex = 13;
            this.lblSubTitulo3.Text = "Servicios Contratados";
            this.lblSubTitulo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listaContratados
            // 
            this.listaContratados.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaContratados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listaContratados.FormattingEnabled = true;
            this.listaContratados.ItemHeight = 21;
            this.listaContratados.Location = new System.Drawing.Point(25, 371);
            this.listaContratados.Name = "listaContratados";
            this.listaContratados.Size = new System.Drawing.Size(330, 151);
            this.listaContratados.TabIndex = 14;
            // 
            // lblPagoTotal
            // 
            this.lblPagoTotal.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPagoTotal.Location = new System.Drawing.Point(105, 608);
            this.lblPagoTotal.Name = "lblPagoTotal";
            this.lblPagoTotal.Size = new System.Drawing.Size(250, 20);
            this.lblPagoTotal.TabIndex = 15;
            this.lblPagoTotal.Text = "Total a Pagar";
            this.lblPagoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(158, 66);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(49, 45);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 16;
            this.picLogo.TabStop = false;
            // 
            // lblKilometraje
            // 
            this.lblKilometraje.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilometraje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblKilometraje.Location = new System.Drawing.Point(225, 316);
            this.lblKilometraje.Name = "lblKilometraje";
            this.lblKilometraje.Size = new System.Drawing.Size(130, 19);
            this.lblKilometraje.TabIndex = 17;
            this.lblKilometraje.Text = "Kilometraje";
            this.lblKilometraje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIVA
            // 
            this.lblIVA.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIVA.Location = new System.Drawing.Point(105, 585);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(250, 20);
            this.lblIVA.TabIndex = 18;
            this.lblIVA.Text = "IVA";
            this.lblIVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubtotal.Location = new System.Drawing.Point(105, 562);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(250, 20);
            this.lblSubtotal.TabIndex = 19;
            this.lblSubtotal.Text = "Sub Total";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGuardar.Location = new System.Drawing.Point(25, 658);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(330, 46);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "GUARDAR 👌🏻";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 716);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblKilometraje);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblPagoTotal);
            this.Controls.Add(this.listaContratados);
            this.Controls.Add(this.lblSubTitulo3);
            this.Controls.Add(this.lblPlacas);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblSubTitulo2);
            this.Controls.Add(this.lblSubTitulo1);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblRFC);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmOrden";
            this.Text = "Confirmación de Orden";
            this.Load += new System.EventHandler(this.frmOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubTitulo1;
        private System.Windows.Forms.Label lblSubTitulo2;
        private System.Windows.Forms.Label lblSubTitulo3;
        public System.Windows.Forms.Label lblCliente;
        public System.Windows.Forms.Label lblDomicilio;
        public System.Windows.Forms.Label lblRFC;
        public System.Windows.Forms.Label lblTelefono;
        public System.Windows.Forms.Label lblMarca;
        public System.Windows.Forms.Label lblTipo;
        public System.Windows.Forms.Label lblModelo;
        public System.Windows.Forms.Label lblPlacas;
        public System.Windows.Forms.ListBox listaContratados;
        private System.Windows.Forms.PictureBox picLogo;
        public System.Windows.Forms.Label lblKilometraje;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblPagoTotal;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}