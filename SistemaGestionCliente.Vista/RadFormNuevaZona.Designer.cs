namespace SistemaGestionCliente.Vista
{
    partial class RadFormNuevaZona
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
            this.labelTituloVentana = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtNombreZona = new Telerik.WinControls.UI.RadTextBox();
            this.CBSectores = new System.Windows.Forms.ComboBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtCiudad = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.txtProvincia = new Telerik.WinControls.UI.RadTextBox();
            this.btnNuevaZona = new Telerik.WinControls.UI.RadButton();
            this.btnGuardar = new Telerik.WinControls.UI.RadButton();
            this.labelSalirZona = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.labelTituloVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreZona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProvincia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevaZona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTituloVentana
            // 
            this.labelTituloVentana.AutoSize = false;
            this.labelTituloVentana.BackColor = System.Drawing.Color.Gainsboro;
            this.labelTituloVentana.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTituloVentana.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.labelTituloVentana.Location = new System.Drawing.Point(0, 0);
            this.labelTituloVentana.Name = "labelTituloVentana";
            this.labelTituloVentana.Size = new System.Drawing.Size(819, 47);
            this.labelTituloVentana.TabIndex = 0;
            this.labelTituloVentana.Text = "ZONA";
            this.labelTituloVentana.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Bell MT", 12F);
            this.radLabel2.Location = new System.Drawing.Point(12, 71);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(62, 27);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Zona :";
            // 
            // txtNombreZona
            // 
            this.txtNombreZona.Font = new System.Drawing.Font("Bell MT", 12F);
            this.txtNombreZona.Location = new System.Drawing.Point(80, 72);
            this.txtNombreZona.MaxLength = 50;
            this.txtNombreZona.Name = "txtNombreZona";
            this.txtNombreZona.Size = new System.Drawing.Size(319, 28);
            this.txtNombreZona.TabIndex = 2;
            // 
            // CBSectores
            // 
            this.CBSectores.DisplayMember = "adfa";
            this.CBSectores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSectores.Font = new System.Drawing.Font("Bell MT", 12F);
            this.CBSectores.FormattingEnabled = true;
            this.CBSectores.Location = new System.Drawing.Point(499, 67);
            this.CBSectores.Name = "CBSectores";
            this.CBSectores.Size = new System.Drawing.Size(294, 31);
            this.CBSectores.TabIndex = 4;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Bell MT", 12F);
            this.radLabel3.Location = new System.Drawing.Point(421, 70);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(72, 27);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "Sector :";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Bell MT", 12F);
            this.radLabel4.Location = new System.Drawing.Point(12, 131);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(78, 27);
            this.radLabel4.TabIndex = 5;
            this.radLabel4.Text = "Ciudad :";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Font = new System.Drawing.Font("Bell MT", 12F);
            this.txtCiudad.Location = new System.Drawing.Point(96, 130);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.ReadOnly = true;
            this.txtCiudad.Size = new System.Drawing.Size(276, 28);
            this.txtCiudad.TabIndex = 6;
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Bell MT", 12F);
            this.radLabel5.Location = new System.Drawing.Point(378, 131);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(99, 27);
            this.radLabel5.TabIndex = 7;
            this.radLabel5.Text = "Provincia :";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Font = new System.Drawing.Font("Bell MT", 12F);
            this.txtProvincia.Location = new System.Drawing.Point(483, 130);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.ReadOnly = true;
            this.txtProvincia.Size = new System.Drawing.Size(310, 28);
            this.txtProvincia.TabIndex = 8;
            // 
            // btnNuevaZona
            // 
            this.btnNuevaZona.Font = new System.Drawing.Font("Bell MT", 12F);
            this.btnNuevaZona.Image = global::SistemaGestionCliente.Vista.Properties.Resources.icon_crear;
            this.btnNuevaZona.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevaZona.Location = new System.Drawing.Point(111, 239);
            this.btnNuevaZona.Name = "btnNuevaZona";
            this.btnNuevaZona.Size = new System.Drawing.Size(122, 93);
            this.btnNuevaZona.TabIndex = 10;
            this.btnNuevaZona.Text = "Nueva Zona";
            this.btnNuevaZona.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Bell MT", 12F);
            this.btnGuardar.Image = global::SistemaGestionCliente.Vista.Properties.Resources.icon_guardar;
            this.btnGuardar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Location = new System.Drawing.Point(12, 239);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 93);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelSalirZona
            // 
            this.labelSalirZona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSalirZona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSalirZona.Font = new System.Drawing.Font("Bell MT", 12F);
            this.labelSalirZona.Image = global::SistemaGestionCliente.Vista.Properties.Resources.icon_salir;
            this.labelSalirZona.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSalirZona.Location = new System.Drawing.Point(764, 254);
            this.labelSalirZona.Name = "labelSalirZona";
            this.labelSalirZona.Size = new System.Drawing.Size(55, 57);
            this.labelSalirZona.TabIndex = 11;
            this.labelSalirZona.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // RadFormNuevaZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 341);
            this.ControlBox = false;
            this.Controls.Add(this.labelSalirZona);
            this.Controls.Add(this.btnNuevaZona);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.CBSectores);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtNombreZona);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.labelTituloVentana);
            this.Font = new System.Drawing.Font("Bell MT", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RadFormNuevaZona";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Zona";
            this.Load += new System.EventHandler(this.RadFormNuevaZona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.labelTituloVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreZona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProvincia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevaZona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel labelTituloVentana;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtNombreZona;
        private System.Windows.Forms.ComboBox CBSectores;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox txtCiudad;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox txtProvincia;
        private Telerik.WinControls.UI.RadButton btnNuevaZona;
        private Telerik.WinControls.UI.RadButton btnGuardar;
        private System.Windows.Forms.Label labelSalirZona;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
