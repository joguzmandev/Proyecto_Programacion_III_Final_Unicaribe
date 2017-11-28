namespace SistemaGestionCliente.Vista
{
    partial class RadFormCliente
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
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radLabelTituloBannerForm = new Telerik.WinControls.UI.RadLabel();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.txtCedulaRNC = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new Telerik.WinControls.UI.RadTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new Telerik.WinControls.UI.RadTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContacto = new Telerik.WinControls.UI.RadTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccion = new Telerik.WinControls.UI.RadTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new Telerik.WinControls.UI.RadTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CBTipoCliente = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CBZona = new System.Windows.Forms.ComboBox();
            this.radLabelCrearZona = new Telerik.WinControls.UI.RadLabel();
            this.labelSalir = new System.Windows.Forms.Label();
            this.btnNuevo = new Telerik.WinControls.UI.RadButton();
            this.btnGuardar = new Telerik.WinControls.UI.RadButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSector = new Telerik.WinControls.UI.RadTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCiudad = new Telerik.WinControls.UI.RadTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProvincia = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelTituloBannerForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedulaRNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCrearZona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProvincia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.SystemColors.Menu;
            this.radPanel1.Controls.Add(this.radLabelTituloBannerForm);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1108, 102);
            this.radPanel1.TabIndex = 0;
            this.radPanel1.ThemeName = "Windows8";
            // 
            // radLabelTituloBannerForm
            // 
            this.radLabelTituloBannerForm.AutoSize = false;
            this.radLabelTituloBannerForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radLabelTituloBannerForm.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabelTituloBannerForm.Location = new System.Drawing.Point(0, 0);
            this.radLabelTituloBannerForm.Name = "radLabelTituloBannerForm";
            this.radLabelTituloBannerForm.Size = new System.Drawing.Size(1108, 102);
            this.radLabelTituloBannerForm.TabIndex = 0;
            this.radLabelTituloBannerForm.Text = "radLabel1";
            this.radLabelTituloBannerForm.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCedulaRNC
            // 
            this.txtCedulaRNC.Font = new System.Drawing.Font("Bell MT", 12F);
            this.txtCedulaRNC.Location = new System.Drawing.Point(157, 128);
            this.txtCedulaRNC.Mask = "999-9999999-9";
            this.txtCedulaRNC.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.txtCedulaRNC.Name = "txtCedulaRNC";
            this.txtCedulaRNC.Size = new System.Drawing.Size(146, 28);
            this.txtCedulaRNC.TabIndex = 1;
            this.txtCedulaRNC.TabStop = false;
            this.txtCedulaRNC.Text = "___-_______-_";
            this.txtCedulaRNC.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula / RNC :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre(s) :";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Bell MT", 12F);
            this.txtNombre.Location = new System.Drawing.Point(443, 128);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 28);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(719, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido(s) :";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Bell MT", 12F);
            this.txtApellido.Location = new System.Drawing.Point(830, 128);
            this.txtApellido.MaxLength = 25;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(253, 28);
            this.txtApellido.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teléfono :";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Bell MT", 12F);
            this.txtTelefono.Location = new System.Drawing.Point(113, 185);
            this.txtTelefono.Mask = "(999) - 999-9999";
            this.txtTelefono.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(159, 28);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.Text = "(___) - ___-____";
            this.txtTelefono.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(295, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contacto:";
            // 
            // txtContacto
            // 
            this.txtContacto.Font = new System.Drawing.Font("Bell MT", 12F);
            this.txtContacto.Location = new System.Drawing.Point(390, 185);
            this.txtContacto.MaxLength = 50;
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(258, 28);
            this.txtContacto.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dirección :";
            // 
            // txtDireccion
            // 
            this.txtDireccion.AutoSize = false;
            this.txtDireccion.Font = new System.Drawing.Font("Bell MT", 12F);
            this.txtDireccion.Location = new System.Drawing.Point(16, 260);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(672, 81);
            this.txtDireccion.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(668, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Bell MT", 12F);
            this.txtEmail.Location = new System.Drawing.Point(743, 185);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 28);
            this.txtEmail.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(701, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tipo Cliente :";
            // 
            // CBTipoCliente
            // 
            this.CBTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipoCliente.Font = new System.Drawing.Font("Bell MT", 12F);
            this.CBTipoCliente.FormattingEnabled = true;
            this.CBTipoCliente.Location = new System.Drawing.Point(704, 260);
            this.CBTipoCliente.Name = "CBTipoCliente";
            this.CBTipoCliente.Size = new System.Drawing.Size(379, 31);
            this.CBTipoCliente.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Zona :";
            // 
            // CBZona
            // 
            this.CBZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBZona.Font = new System.Drawing.Font("Bell MT", 12F);
            this.CBZona.FormattingEnabled = true;
            this.CBZona.Location = new System.Drawing.Point(81, 358);
            this.CBZona.Name = "CBZona";
            this.CBZona.Size = new System.Drawing.Size(272, 31);
            this.CBZona.TabIndex = 17;
            // 
            // radLabelCrearZona
            // 
            this.radLabelCrearZona.AutoSize = false;
            this.radLabelCrearZona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radLabelCrearZona.Image = global::SistemaGestionCliente.Vista.Properties.Resources.icon_crear;
            this.radLabelCrearZona.Location = new System.Drawing.Point(373, 347);
            this.radLabelCrearZona.Name = "radLabelCrearZona";
            this.radLabelCrearZona.Size = new System.Drawing.Size(52, 50);
            this.radLabelCrearZona.TabIndex = 18;
            // 
            // labelSalir
            // 
            this.labelSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSalir.Font = new System.Drawing.Font("Bell MT", 12F);
            this.labelSalir.Image = global::SistemaGestionCliente.Vista.Properties.Resources.icon_salir;
            this.labelSalir.Location = new System.Drawing.Point(1041, 485);
            this.labelSalir.Name = "labelSalir";
            this.labelSalir.Size = new System.Drawing.Size(55, 76);
            this.labelSalir.TabIndex = 27;
            this.labelSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Bell MT", 12F);
            this.btnNuevo.Image = global::SistemaGestionCliente.Vista.Properties.Resources.icon_nuevo_cliente2;
            this.btnNuevo.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevo.Location = new System.Drawing.Point(113, 480);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(93, 76);
            this.btnNuevo.TabIndex = 26;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Bell MT", 12F);
            this.btnGuardar.Image = global::SistemaGestionCliente.Vista.Properties.Resources.icon_guardar;
            this.btnGuardar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Location = new System.Drawing.Point(14, 480);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 76);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtSector
            // 
            this.txtSector.Font = new System.Drawing.Font("Bell MT", 12F);
            this.txtSector.Location = new System.Drawing.Point(503, 362);
            this.txtSector.MaxLength = 25;
            this.txtSector.Name = "txtSector";
            this.txtSector.ReadOnly = true;
            this.txtSector.Size = new System.Drawing.Size(250, 28);
            this.txtSector.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(431, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Sector:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 418);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 23);
            this.label11.TabIndex = 21;
            this.label11.Text = "Ciudad:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Font = new System.Drawing.Font("Bell MT", 12F);
            this.txtCiudad.Location = new System.Drawing.Point(91, 418);
            this.txtCiudad.MaxLength = 25;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.ReadOnly = true;
            this.txtCiudad.Size = new System.Drawing.Size(250, 28);
            this.txtCiudad.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(357, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 23);
            this.label12.TabIndex = 23;
            this.label12.Text = "Provincia:";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Font = new System.Drawing.Font("Bell MT", 12F);
            this.txtProvincia.Location = new System.Drawing.Point(455, 418);
            this.txtProvincia.MaxLength = 25;
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.ReadOnly = true;
            this.txtProvincia.Size = new System.Drawing.Size(296, 28);
            this.txtProvincia.TabIndex = 24;
            // 
            // RadFormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 570);
            this.ControlBox = false;
            this.Controls.Add(this.radLabelCrearZona);
            this.Controls.Add(this.labelSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.CBZona);
            this.Controls.Add(this.CBTipoCliente);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtSector);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCedulaRNC);
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("Bell MT", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(980, 600);
            this.Name = "RadFormCliente";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowItemToolTips = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "NUEVO_CLIENTE";
            this.Text = "";
            this.Load += new System.EventHandler(this.RadFormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radLabelTituloBannerForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedulaRNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCrearZona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProvincia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabelTituloBannerForm;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RadMaskedEditBox txtCedulaRNC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadTextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadTextBox txtApellido;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadMaskedEditBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadTextBox txtContacto;
        private System.Windows.Forms.Label label6;
        private Telerik.WinControls.UI.RadTextBox txtDireccion;
        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadTextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CBTipoCliente;
        private Telerik.WinControls.UI.RadButton btnGuardar;
        private Telerik.WinControls.UI.RadButton btnNuevo;
        private System.Windows.Forms.Label labelSalir;
        private Telerik.WinControls.UI.RadLabel radLabelCrearZona;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CBZona;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Telerik.WinControls.UI.RadTextBox txtSector;
        private System.Windows.Forms.Label label10;
        private Telerik.WinControls.UI.RadTextBox txtCiudad;
        private System.Windows.Forms.Label label11;
        private Telerik.WinControls.UI.RadTextBox txtProvincia;
        private System.Windows.Forms.Label label12;
    }
}
