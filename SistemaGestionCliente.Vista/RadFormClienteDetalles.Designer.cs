namespace SistemaGestionCliente.Vista
{
    partial class RadFormClienteDetalles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefono = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTipoCliente = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtZona = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSector = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCiudad = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProvincia = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.btnOk = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProvincia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(15, 41);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.ReadOnly = true;
            this.txtNombreCompleto.Size = new System.Drawing.Size(527, 22);
            this.txtNombreCompleto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Bell MT", 12F);
            this.txtTelefono.Location = new System.Drawing.Point(102, 84);
            this.txtTelefono.Mask = "(999)-999-9999";
            this.txtTelefono.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(156, 28);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.Text = "(___)-___-____";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo Cliente";
            // 
            // txtTipoCliente
            // 
            this.txtTipoCliente.Font = new System.Drawing.Font("Bell MT", 12F);
            this.txtTipoCliente.Location = new System.Drawing.Point(386, 84);
            this.txtTipoCliente.Name = "txtTipoCliente";
            this.txtTipoCliente.ReadOnly = true;
            this.txtTipoCliente.Size = new System.Drawing.Size(156, 28);
            this.txtTipoCliente.TabIndex = 5;
            this.txtTipoCliente.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Bell MT", 12F);
            this.txtEmail.Location = new System.Drawing.Point(77, 124);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(465, 30);
            this.txtEmail.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Bell MT", 12F);
            this.txtDireccion.Location = new System.Drawing.Point(15, 184);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(527, 84);
            this.txtDireccion.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Zona";
            // 
            // txtZona
            // 
            this.txtZona.Font = new System.Drawing.Font("Bell MT", 12F);
            this.txtZona.Location = new System.Drawing.Point(70, 289);
            this.txtZona.Name = "txtZona";
            this.txtZona.ReadOnly = true;
            this.txtZona.Size = new System.Drawing.Size(188, 28);
            this.txtZona.TabIndex = 11;
            this.txtZona.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sector";
            // 
            // txtSector
            // 
            this.txtSector.Font = new System.Drawing.Font("Bell MT", 12F);
            this.txtSector.Location = new System.Drawing.Point(342, 289);
            this.txtSector.Name = "txtSector";
            this.txtSector.ReadOnly = true;
            this.txtSector.Size = new System.Drawing.Size(200, 28);
            this.txtSector.TabIndex = 13;
            this.txtSector.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Font = new System.Drawing.Font("Bell MT", 12F);
            this.txtCiudad.Location = new System.Drawing.Point(77, 339);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.ReadOnly = true;
            this.txtCiudad.Size = new System.Drawing.Size(181, 28);
            this.txtCiudad.TabIndex = 15;
            this.txtCiudad.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Provincia";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Font = new System.Drawing.Font("Bell MT", 12F);
            this.txtProvincia.Location = new System.Drawing.Point(360, 342);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.ReadOnly = true;
            this.txtProvincia.Size = new System.Drawing.Size(182, 28);
            this.txtProvincia.TabIndex = 17;
            this.txtProvincia.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Font = new System.Drawing.Font("Bell MT", 12F);
            this.btnOk.Location = new System.Drawing.Point(463, 397);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(79, 43);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "OK";
            this.btnOk.ThemeName = "Windows8";
            // 
            // RadFormClienteDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 456);
            this.ControlBox = false;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtTipoCliente);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtSector);
            this.Controls.Add(this.txtZona);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bell MT", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RadFormClienteDetalles";
            this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.DetallesCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProvincia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadMaskedEditBox txtTelefono;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadMaskedEditBox txtTipoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private Telerik.WinControls.UI.RadMaskedEditBox txtZona;
        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadMaskedEditBox txtSector;
        private System.Windows.Forms.Label label8;
        private Telerik.WinControls.UI.RadMaskedEditBox txtCiudad;
        private System.Windows.Forms.Label label9;
        private Telerik.WinControls.UI.RadMaskedEditBox txtProvincia;
        private Telerik.WinControls.UI.RadButton btnOk;
    }
}
