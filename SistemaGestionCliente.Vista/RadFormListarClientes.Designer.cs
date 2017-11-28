namespace SistemaGestionCliente.Vista
{
    partial class RadFormListarClientes
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.clientesGridView = new Telerik.WinControls.UI.RadGridView();
            this.btnEditar = new Telerik.WinControls.UI.RadButton();
            this.btnEliminar = new Telerik.WinControls.UI.RadButton();
            this.btnMostrarDetalles = new Telerik.WinControls.UI.RadButton();
            this.btnActualizarLista = new Telerik.WinControls.UI.RadButton();
            this.labelSalir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrarDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizarLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // clientesGridView
            // 
            this.clientesGridView.AutoScroll = true;
            this.clientesGridView.EnableAnalytics = false;
            this.clientesGridView.EnableCodedUITests = true;
            this.clientesGridView.Font = new System.Drawing.Font("Bell MT", 12F);
            this.clientesGridView.Location = new System.Drawing.Point(12, 37);
            // 
            // 
            // 
            this.clientesGridView.MasterTemplate.AllowAddNewRow = false;
            this.clientesGridView.MasterTemplate.AllowDeleteRow = false;
            this.clientesGridView.MasterTemplate.AllowDragToGroup = false;
            this.clientesGridView.MasterTemplate.AllowEditRow = false;
            this.clientesGridView.MasterTemplate.AllowSearchRow = true;
            this.clientesGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.clientesGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.clientesGridView.Name = "clientesGridView";
            this.clientesGridView.Size = new System.Drawing.Size(1044, 641);
            this.clientesGridView.TabIndex = 1;
            this.clientesGridView.ThemeName = "Windows8";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Bell MT", 12F);
            this.btnEditar.Location = new System.Drawing.Point(12, 691);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(137, 65);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Bell MT", 12F);
            this.btnEliminar.Location = new System.Drawing.Point(155, 694);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(137, 65);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Elimiar";
            // 
            // btnMostrarDetalles
            // 
            this.btnMostrarDetalles.Font = new System.Drawing.Font("Bell MT", 12F);
            this.btnMostrarDetalles.Location = new System.Drawing.Point(298, 694);
            this.btnMostrarDetalles.Name = "btnMostrarDetalles";
            this.btnMostrarDetalles.Size = new System.Drawing.Size(160, 65);
            this.btnMostrarDetalles.TabIndex = 2;
            this.btnMostrarDetalles.Text = "Motrar Detalles";
            // 
            // btnActualizarLista
            // 
            this.btnActualizarLista.Font = new System.Drawing.Font("Bell MT", 12F);
            this.btnActualizarLista.Location = new System.Drawing.Point(464, 694);
            this.btnActualizarLista.Name = "btnActualizarLista";
            this.btnActualizarLista.Size = new System.Drawing.Size(162, 65);
            this.btnActualizarLista.TabIndex = 2;
            this.btnActualizarLista.Text = "Actualizar Lista";
            // 
            // labelSalir
            // 
            this.labelSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSalir.Image = global::SistemaGestionCliente.Vista.Properties.Resources.icon_salir;
            this.labelSalir.Location = new System.Drawing.Point(1006, 691);
            this.labelSalir.Name = "labelSalir";
            this.labelSalir.Size = new System.Drawing.Size(50, 78);
            this.labelSalir.TabIndex = 0;
            // 
            // RadFormListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 768);
            this.ControlBox = false;
            this.Controls.Add(this.btnActualizarLista);
            this.Controls.Add(this.btnMostrarDetalles);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.clientesGridView);
            this.Controls.Add(this.labelSalir);
            this.Font = new System.Drawing.Font("Bell MT", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(980, 600);
            this.Name = "RadFormListarClientes";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.ShowItemToolTips = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.RadFormListarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrarDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizarLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSalir;
        private Telerik.WinControls.UI.RadGridView clientesGridView;
        private Telerik.WinControls.UI.RadButton btnEditar;
        private Telerik.WinControls.UI.RadButton btnEliminar;
        private Telerik.WinControls.UI.RadButton btnMostrarDetalles;
        private Telerik.WinControls.UI.RadButton btnActualizarLista;
    }
}
