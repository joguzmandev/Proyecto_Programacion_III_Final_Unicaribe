using SistemaGestionCliente.Entidades.VistaModel;
using SistemaGestionCliente.LogicaNegocio.ClienteServicios;
using SistemaGestionCliente.Vista.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace SistemaGestionCliente.Vista
{
    public partial class RadFormListarClientes : Telerik.WinControls.UI.RadForm
    {
        public RadMenuItem m;
        private IClienteServicios _clienteServicio;
        private string clienteSeleccionadoCedula;
        
        public RadFormListarClientes(RadMenuItem m)
        {
            InitializeComponent();
            this.m = m;
            this._clienteServicio = new ClienteServicios();
        }

        private void RadFormListarClientes_Load(object sender, EventArgs e)
        {
            CargarListaClientes();
            SetearColumnaGridView();
            SetEventos();
            CambiarEstadoBoton(false);
            clienteSeleccionadoCedula = string.Empty;
            if (clientesGridView.RowCount == 0)
            {
                clientesGridView.TableElement.Text = "Cargando data, por favor espere";
            }
        }


        private async void CargarListaClientes()
        {
            clientesGridView.CellClick -= ClientesGridView_CellClick;
            var result = await _clienteServicio.ObtenerTodos();
            clientesGridView.DataSource = result;
            if(result == null || result.Count == 0)
            {
                clientesGridView.TableElement.Text = "No Hay Datos";
            }
            clientesGridView.CellClick += ClientesGridView_CellClick;

        }

        private void ClientesGridView_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var row = e.Row;
            CambiarEstadoBoton(true);
            clienteSeleccionadoCedula = row.Cells[0].Value.ToString();
            
        }

        private void SetearColumnaGridView()
        {
            GridViewTextBoxColumn _cedula = new GridViewTextBoxColumn()
            {
                Name = "txtCedula",
                HeaderText = "Cédula / RNC",
                FieldName = "Cedula",
                MaxLength = 11,
                TextAlignment = ContentAlignment.MiddleCenter,
                Width = 50,
                DataType = typeof(string),
                FormatInfo = CultureInfo.CreateSpecificCulture("es-ES"),
                FormatString = "{0:###-#######-#}",
                NullValue = "Vacio"
                
            };
            GridViewTextBoxColumn _nombre = new GridViewTextBoxColumn()
            {
                Name = "txtNombre",
                HeaderText = "Nombre",
                FieldName = "Nombre",
                MaxLength = 50,
                TextAlignment = ContentAlignment.MiddleLeft,
                Width = 60,
                DataType = typeof(string)

            };
            GridViewTextBoxColumn _apellido = new GridViewTextBoxColumn()
            {
                Name = "txtApellido",
                HeaderText = "Apellido",
                FieldName = "Apellido",
                MaxLength = 50,
                TextAlignment = ContentAlignment.MiddleLeft,
                Width = 60,
                DataType = typeof(string)

            };

            GridViewTextBoxColumn _contacto = new GridViewTextBoxColumn()
            {
                Name = "txtContacto",
                HeaderText = "Contacto",
                FieldName = "Contacto",
                MaxLength = 50,
                TextAlignment = ContentAlignment.MiddleLeft,
                Width = 60,
                DataType = typeof(string)
            };


            clientesGridView.Columns.Add(_cedula);
            clientesGridView.Columns.Add(_nombre);
            clientesGridView.Columns.Add(_apellido);
            clientesGridView.Columns.Add(_contacto);
        }

        private void SetEventos()
        {
            labelSalir.Click += (s, e) =>
            {
                this.Close();
                m.Enabled = true;
            };

            btnMostrarDetalles.Click += async (s, e) =>
            {
                var result = await _clienteServicio.BuscarClientePorId(clienteSeleccionadoCedula);

                RadFormClienteDetalles _detalles = new RadFormClienteDetalles(result);
                _detalles.ShowDialog();

            };

            btnActualizarLista.Click += (s, e) =>
            {
                ActualizarLista();
            };

            btnEliminar.Click += (s, e) =>
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _clienteServicio.Eliminar(new ClienteVM() { Cedula = clienteSeleccionadoCedula });
                    ActualizarLista();
                    MessageBox.Show("Registro eliminado correctamente", "Confirmación",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }

                
            };

            btnEditar.Click += (s, e) =>
            {
                RadFormCliente _clienteEditar = new RadFormCliente(Entidades.Helpers.EstadoFormulario.EDITANDO,null, new ClienteVM() { Cedula = clienteSeleccionadoCedula });
                _clienteEditar.ShowDialog();
            };
        }

        private void CambiarEstadoBoton(bool estado)
        {
            btnEditar.Enabled = estado;
            btnEliminar.Enabled = estado;
            btnMostrarDetalles.Enabled = estado;
        }

        private void ActualizarLista()
        {
            CargarListaClientes();
            CambiarEstadoBoton(false);
            clienteSeleccionadoCedula = string.Empty;
            clientesGridView.ClearSelection();
        }

    }
}
