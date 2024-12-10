namespace esteticaAutomotriz
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.gbPropietario = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.lblRFC = new System.Windows.Forms.Label();
            this.txtPropietario = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.picLogotipo = new System.Windows.Forms.PictureBox();
            this.gbVehiculo = new System.Windows.Forms.GroupBox();
            this.txtKilometraje = new System.Windows.Forms.TextBox();
            this.lblKM = new System.Windows.Forms.Label();
            this.txtPlacas = new System.Windows.Forms.MaskedTextBox();
            this.lblPlacas = new System.Windows.Forms.Label();
            this.numModelo = new System.Windows.Forms.NumericUpDown();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtTipoAuto = new System.Windows.Forms.TextBox();
            this.lblTipoAuto = new System.Windows.Forms.Label();
            this.comboMarcas = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.gbOrden = new System.Windows.Forms.GroupBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listaServicios = new System.Windows.Forms.ListBox();
            this.lblServiciosContratados = new System.Windows.Forms.Label();
            this.comboServicios = new System.Windows.Forms.ComboBox();
            this.lblServiciosDisponibles = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.gbPropietario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogotipo)).BeginInit();
            this.gbVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numModelo)).BeginInit();
            this.gbOrden.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(403, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(172, 34);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "El Reluciente";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(382, 42);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(214, 26);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Estética Automotriz";
            // 
            // gbPropietario
            // 
            this.gbPropietario.Controls.Add(this.txtTelefono);
            this.gbPropietario.Controls.Add(this.lblTel);
            this.gbPropietario.Controls.Add(this.txtDireccion);
            this.gbPropietario.Controls.Add(this.lblDomicilio);
            this.gbPropietario.Controls.Add(this.txtRFC);
            this.gbPropietario.Controls.Add(this.lblRFC);
            this.gbPropietario.Controls.Add(this.txtPropietario);
            this.gbPropietario.Controls.Add(this.lblNombre);
            this.gbPropietario.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPropietario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbPropietario.Location = new System.Drawing.Point(17, 162);
            this.gbPropietario.Name = "gbPropietario";
            this.gbPropietario.Size = new System.Drawing.Size(450, 265);
            this.gbPropietario.TabIndex = 2;
            this.gbPropietario.TabStop = false;
            this.gbPropietario.Text = " DATOS DEL PROPIETARIO ";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.Location = new System.Drawing.Point(119, 120);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(171, 27);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTel.Location = new System.Drawing.Point(30, 123);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(78, 22);
            this.lblTel.TabIndex = 6;
            this.lblTel.Text = "Teléfono";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDireccion.Location = new System.Drawing.Point(119, 164);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(291, 68);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDomicilio.Location = new System.Drawing.Point(24, 167);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(85, 22);
            this.lblDomicilio.TabIndex = 4;
            this.lblDomicilio.Text = "Domicilio";
            this.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRFC
            // 
            this.txtRFC.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRFC.Location = new System.Drawing.Point(119, 76);
            this.txtRFC.MaxLength = 13;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(171, 27);
            this.txtRFC.TabIndex = 3;
            this.txtRFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblRFC.Location = new System.Drawing.Point(66, 80);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(44, 22);
            this.lblRFC.TabIndex = 2;
            this.lblRFC.Text = "RFC";
            this.lblRFC.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPropietario
            // 
            this.txtPropietario.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropietario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPropietario.Location = new System.Drawing.Point(118, 32);
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Size = new System.Drawing.Size(291, 27);
            this.txtPropietario.TabIndex = 1;
            this.txtPropietario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNombre.Location = new System.Drawing.Point(36, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 22);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // picLogotipo
            // 
            this.picLogotipo.Image = ((System.Drawing.Image)(resources.GetObject("picLogotipo.Image")));
            this.picLogotipo.Location = new System.Drawing.Point(455, 71);
            this.picLogotipo.Name = "picLogotipo";
            this.picLogotipo.Size = new System.Drawing.Size(73, 61);
            this.picLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogotipo.TabIndex = 3;
            this.picLogotipo.TabStop = false;
            // 
            // gbVehiculo
            // 
            this.gbVehiculo.Controls.Add(this.txtKilometraje);
            this.gbVehiculo.Controls.Add(this.lblKM);
            this.gbVehiculo.Controls.Add(this.txtPlacas);
            this.gbVehiculo.Controls.Add(this.lblPlacas);
            this.gbVehiculo.Controls.Add(this.numModelo);
            this.gbVehiculo.Controls.Add(this.lblModelo);
            this.gbVehiculo.Controls.Add(this.txtTipoAuto);
            this.gbVehiculo.Controls.Add(this.lblTipoAuto);
            this.gbVehiculo.Controls.Add(this.comboMarcas);
            this.gbVehiculo.Controls.Add(this.lblMarca);
            this.gbVehiculo.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbVehiculo.Location = new System.Drawing.Point(514, 162);
            this.gbVehiculo.Name = "gbVehiculo";
            this.gbVehiculo.Size = new System.Drawing.Size(450, 265);
            this.gbVehiculo.TabIndex = 8;
            this.gbVehiculo.TabStop = false;
            this.gbVehiculo.Text = " DATOS DEL VEHICULO";
            // 
            // txtKilometraje
            // 
            this.txtKilometraje.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKilometraje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKilometraje.Location = new System.Drawing.Point(121, 205);
            this.txtKilometraje.Name = "txtKilometraje";
            this.txtKilometraje.Size = new System.Drawing.Size(121, 27);
            this.txtKilometraje.TabIndex = 12;
            this.txtKilometraje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKilometraje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKilometraje_KeyPress);
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblKM.Location = new System.Drawing.Point(15, 208);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(100, 22);
            this.lblKM.TabIndex = 11;
            this.lblKM.Text = "Kilometraje";
            // 
            // txtPlacas
            // 
            this.txtPlacas.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacas.Location = new System.Drawing.Point(121, 164);
            this.txtPlacas.Mask = "LLL - 0000";
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(120, 27);
            this.txtPlacas.TabIndex = 10;
            this.txtPlacas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPlacas
            // 
            this.lblPlacas.AutoSize = true;
            this.lblPlacas.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPlacas.Location = new System.Drawing.Point(55, 166);
            this.lblPlacas.Name = "lblPlacas";
            this.lblPlacas.Size = new System.Drawing.Size(60, 22);
            this.lblPlacas.TabIndex = 9;
            this.lblPlacas.Text = "Placas";
            // 
            // numModelo
            // 
            this.numModelo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numModelo.Location = new System.Drawing.Point(121, 122);
            this.numModelo.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.numModelo.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numModelo.Name = "numModelo";
            this.numModelo.Size = new System.Drawing.Size(121, 27);
            this.numModelo.TabIndex = 8;
            this.numModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numModelo.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblModelo.Location = new System.Drawing.Point(45, 123);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(70, 22);
            this.lblModelo.TabIndex = 7;
            this.lblModelo.Text = "Modelo";
            // 
            // txtTipoAuto
            // 
            this.txtTipoAuto.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipoAuto.Location = new System.Drawing.Point(121, 79);
            this.txtTipoAuto.Name = "txtTipoAuto";
            this.txtTipoAuto.Size = new System.Drawing.Size(211, 27);
            this.txtTipoAuto.TabIndex = 6;
            this.txtTipoAuto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTipoAuto
            // 
            this.lblTipoAuto.AutoSize = true;
            this.lblTipoAuto.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTipoAuto.Location = new System.Drawing.Point(71, 82);
            this.lblTipoAuto.Name = "lblTipoAuto";
            this.lblTipoAuto.Size = new System.Drawing.Size(44, 22);
            this.lblTipoAuto.TabIndex = 3;
            this.lblTipoAuto.Text = "Tipo";
            // 
            // comboMarcas
            // 
            this.comboMarcas.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMarcas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboMarcas.FormattingEnabled = true;
            this.comboMarcas.Items.AddRange(new object[] {
            "Ford",
            "Honda",
            "KIA",
            "Nissan",
            "Mazda",
            "Volkswagen"});
            this.comboMarcas.Location = new System.Drawing.Point(121, 34);
            this.comboMarcas.Name = "comboMarcas";
            this.comboMarcas.Size = new System.Drawing.Size(211, 30);
            this.comboMarcas.TabIndex = 2;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblMarca.Location = new System.Drawing.Point(55, 42);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(58, 22);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // gbOrden
            // 
            this.gbOrden.Controls.Add(this.lblCuenta);
            this.gbOrden.Controls.Add(this.btnConfirmar);
            this.gbOrden.Controls.Add(this.btnNuevo);
            this.gbOrden.Controls.Add(this.btnEliminar);
            this.gbOrden.Controls.Add(this.btnAgregar);
            this.gbOrden.Controls.Add(this.listaServicios);
            this.gbOrden.Controls.Add(this.lblServiciosContratados);
            this.gbOrden.Controls.Add(this.comboServicios);
            this.gbOrden.Controls.Add(this.lblServiciosDisponibles);
            this.gbOrden.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbOrden.Location = new System.Drawing.Point(17, 459);
            this.gbOrden.Name = "gbOrden";
            this.gbOrden.Size = new System.Drawing.Size(947, 232);
            this.gbOrden.TabIndex = 11;
            this.gbOrden.TabStop = false;
            this.gbOrden.Text = " ORDEN DE SERVICIO ";
            // 
            // lblCuenta
            // 
            this.lblCuenta.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuenta.ForeColor = System.Drawing.Color.Green;
            this.lblCuenta.Location = new System.Drawing.Point(493, 191);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(226, 23);
            this.lblCuenta.TabIndex = 12;
            this.lblCuenta.Text = "Subtotal $0";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnConfirmar.Location = new System.Drawing.Point(724, 184);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(204, 36);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "CONFIRMAR ORDEN";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNuevo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNuevo.Location = new System.Drawing.Point(116, 183);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(243, 36);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "NUEVA ORDEN";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEliminar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEliminar.Location = new System.Drawing.Point(116, 141);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(243, 36);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "RETIRAR DE LA ORDEN ";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAgregar.Location = new System.Drawing.Point(116, 99);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(243, 36);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "AGREGAR A LA ORDEN";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listaServicios
            // 
            this.listaServicios.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaServicios.ForeColor = System.Drawing.Color.Green;
            this.listaServicios.FormattingEnabled = true;
            this.listaServicios.ItemHeight = 22;
            this.listaServicios.Location = new System.Drawing.Point(497, 58);
            this.listaServicios.Name = "listaServicios";
            this.listaServicios.Size = new System.Drawing.Size(433, 114);
            this.listaServicios.TabIndex = 7;
            // 
            // lblServiciosContratados
            // 
            this.lblServiciosContratados.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiciosContratados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblServiciosContratados.Location = new System.Drawing.Point(497, 29);
            this.lblServiciosContratados.Name = "lblServiciosContratados";
            this.lblServiciosContratados.Size = new System.Drawing.Size(433, 18);
            this.lblServiciosContratados.TabIndex = 6;
            this.lblServiciosContratados.Text = "SERVICIOS CONTRATADOS";
            this.lblServiciosContratados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboServicios
            // 
            this.comboServicios.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboServicios.FormattingEnabled = true;
            this.comboServicios.Items.AddRange(new object[] {
            "Lavado de Interiores  - $120",
            "Lavado de Motor - $280",
            "Púlido y Encerado - $210",
            "Púlido de Faros - $650",
            "Lavado de Carrocería - $80",
            "Abrillantado de Pintura - $550",
            "Lavado de Vestiduras - $1,200"});
            this.comboServicios.Location = new System.Drawing.Point(28, 58);
            this.comboServicios.Name = "comboServicios";
            this.comboServicios.Size = new System.Drawing.Size(422, 30);
            this.comboServicios.TabIndex = 5;
            // 
            // lblServiciosDisponibles
            // 
            this.lblServiciosDisponibles.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiciosDisponibles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblServiciosDisponibles.Location = new System.Drawing.Point(28, 31);
            this.lblServiciosDisponibles.Name = "lblServiciosDisponibles";
            this.lblServiciosDisponibles.Size = new System.Drawing.Size(422, 18);
            this.lblServiciosDisponibles.TabIndex = 4;
            this.lblServiciosDisponibles.Text = "SERVICIOS DISPONIBLES";
            this.lblServiciosDisponibles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.Color.Gray;
            this.lblAutor.Location = new System.Drawing.Point(14, 747);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(329, 14);
            this.lblAutor.TabIndex = 12;
            this.lblAutor.Text = "DESARROLLADO POR GERARDO CASTRO | 3BP CBTis 60";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(981, 770);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.gbOrden);
            this.Controls.Add(this.gbVehiculo);
            this.Controls.Add(this.picLogotipo);
            this.Controls.Add(this.gbPropietario);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "º";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gbPropietario.ResumeLayout(false);
            this.gbPropietario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogotipo)).EndInit();
            this.gbVehiculo.ResumeLayout(false);
            this.gbVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numModelo)).EndInit();
            this.gbOrden.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.GroupBox gbPropietario;
        private System.Windows.Forms.TextBox txtPropietario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox picLogotipo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.GroupBox gbVehiculo;
        private System.Windows.Forms.Label lblPlacas;
        private System.Windows.Forms.NumericUpDown numModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtTipoAuto;
        private System.Windows.Forms.Label lblTipoAuto;
        private System.Windows.Forms.ComboBox comboMarcas;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.GroupBox gbOrden;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox listaServicios;
        private System.Windows.Forms.Label lblServiciosContratados;
        private System.Windows.Forms.ComboBox comboServicios;
        private System.Windows.Forms.Label lblServiciosDisponibles;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtKilometraje;
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.MaskedTextBox txtPlacas;
    }
}

