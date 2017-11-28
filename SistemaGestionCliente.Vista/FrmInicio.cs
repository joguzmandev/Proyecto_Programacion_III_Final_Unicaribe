using SistemaGestionCliente.Entidades.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace SistemaGestionCliente.Vista
{
    public partial class FrmInicio : RadForm
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            radMenuItemNuevoCliente.Click += Menu_Click;
            radMenuItemListarCliente.Click += Menu_Click;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            RadMenuItem m = sender as RadMenuItem;

            switch (m.Tag.ToString())
            {
                case "NUEVO_CLIENTE":
                     RadFormCliente _nuevoCliente = new RadFormCliente(EstadoFormulario.NUEVO,m);
                    _nuevoCliente.MdiParent = this;
                    m.Enabled = false;
                    _nuevoCliente.Show();
                    break;
                case "LISTA_CLIENTES":
                    RadFormListarClientes _listarClientes = new RadFormListarClientes(m);
                    _listarClientes.MdiParent = this;
                    m.Enabled = false;
                    _listarClientes.Show();
                    break;
            }
        }

       
    }
}
