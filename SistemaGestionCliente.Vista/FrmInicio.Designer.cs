namespace SistemaGestionCliente.Vista
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItemCliente = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItemNuevoCliente = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuItemListarCliente = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItemCliente});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(1192, 65);
            this.radMenu1.TabIndex = 2;
            this.radMenu1.Text = "radMenu1";
            // 
            // radMenuItemCliente
            // 
            this.radMenuItemCliente.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuItemCliente.Image = global::SistemaGestionCliente.Vista.Properties.Resources.icon_cliente;
            this.radMenuItemCliente.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.radMenuItemCliente.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItemNuevoCliente,
            this.radMenuSeparatorItem1,
            this.radMenuItemListarCliente});
            this.radMenuItemCliente.Name = "radMenuItemCliente";
            this.radMenuItemCliente.Text = "Clientes";
            this.radMenuItemCliente.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radMenuItemCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // radMenuItemNuevoCliente
            // 
            this.radMenuItemNuevoCliente.Image = global::SistemaGestionCliente.Vista.Properties.Resources.icon_nuevo_cliente;
            this.radMenuItemNuevoCliente.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radMenuItemNuevoCliente.Name = "radMenuItemNuevoCliente";
            this.radMenuItemNuevoCliente.Tag = "NUEVO_CLIENTE";
            this.radMenuItemNuevoCliente.Text = "Nuevo Cliente";
            this.radMenuItemNuevoCliente.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radMenuItemListarCliente
            // 
            this.radMenuItemListarCliente.Image = global::SistemaGestionCliente.Vista.Properties.Resources.icon_listar_clientes;
            this.radMenuItemListarCliente.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radMenuItemListarCliente.Name = "radMenuItemListarCliente";
            this.radMenuItemListarCliente.Tag = "LISTA_CLIENTES";
            this.radMenuItemListarCliente.Text = "Listar Cliente";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 870);
            this.Controls.Add(this.radMenu1);
            this.Font = new System.Drawing.Font("Bell MT", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "FrmInicio";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión de Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItemCliente;
        private Telerik.WinControls.UI.RadMenuItem radMenuItemNuevoCliente;
        private Telerik.WinControls.UI.RadMenuItem radMenuItemListarCliente;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
    }
}

