using SistemaGestionCliente.Entidades.Helpers;
using SistemaGestionCliente.LogicaNegocio.ZonaServicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using SistemaGestionCliente.Entidades.VistaModel;
using SistemaGestionCliente.LogicaNegocio.ClienteServicios;

namespace SistemaGestionCliente.Vista
{
    public partial class RadFormCliente : Telerik.WinControls.UI.RadForm
    {
        private IZonaServicios _zonaServicio;
        private IClienteServicios _clienteServicio;
        private EstadoFormulario miEstado;
        private ClienteVM _clienteEditar;

        public RadMenuItem menu { get; set; }

        public RadFormCliente(EstadoFormulario estadoForm,RadMenuItem menuCliente=null,ClienteVM cliente = null)
        {
            InitializeComponent();
            
            this.miEstado = estadoForm;

            #region Instanciar los servicios
            _zonaServicio = new ZonaServicios();
            _clienteServicio = new ClienteServicios();
            #endregion

            #region Configuración Estado Formulario

            switch (miEstado)
            {
                case EstadoFormulario.NUEVO:
                    var text = "Nuevo Cliente";
                    this.Text = text;
                    this.radLabelTituloBannerForm.Text = text;
                    this.menu = menuCliente;
                    btnNuevo.Enabled = true;
                    break;
                case EstadoFormulario.EDITANDO:
                    if (cliente == null) return;
                    _clienteEditar = cliente;
                    var textedit = "Editando Cliente";
                    this.Text = textedit;
                    this.radLabelTituloBannerForm.Text = textedit;
                    btnNuevo.Hide();
                    break;
            }


            #endregion
        }

        private void RadFormCliente_Load(object sender, EventArgs ev)
        {
            CargarZona();
            CargarTiposClientes();
            SetEventos();
            txtCedulaRNC.Focus();

            if (miEstado == EstadoFormulario.EDITANDO)
                CargarClienteEditar();
            }

        private async void CargarClienteEditar()
        {

            var result =await _clienteServicio.BuscarClientePorId(this._clienteEditar.Cedula);
            txtCedulaRNC.Text = result.Cedula;
            txtNombre.Text = result.Nombre;
            txtApellido.Text = result.Apellido;
            txtTelefono.Text = result.Telefono;
            txtContacto.Text = result.Contacto;
            txtEmail.Text = result.Email;
            txtDireccion.Text = result.Direccion;
            CBTipoCliente.SelectedItem = result.TipoCliente;
            CBZona.SelectedValue = result.CodigoZonaPK;
            txtSector.Text = result.SectorMostrar;
            txtCiudad.Text = result.CiudadMostrar;
            txtProvincia.Text = result.ProvinciaMostrar;

          
        }

        private void SetEventos()
        {
            labelSalir.Click += (s, e) =>
            {
                DialogResult rs = MessageBox.Show("¿Está seguro de salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (rs == DialogResult.Yes)
                {
                    if(miEstado == EstadoFormulario.NUEVO)
                         menu.Enabled = true;

                    this.Close();
                }
            };

            radLabelCrearZona.Click += (s, e) =>
            {
                RadFormNuevaZona _zona = new RadFormNuevaZona();
                _zona.ShowDialog();
                CargarZona();
            };

            btnGuardar.Click += (s, e) =>
            {
                if (ValidarForm())
                {
                    var _cliente = new ClienteVM()
                    {
                        Cedula = txtCedulaRNC.Value.ToString(),
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Direccion = txtDireccion.Text,
                        Telefono = txtTelefono.Value.ToString(),
                        Email = txtEmail.Text,
                        Contacto = txtContacto.Text,
                        TipoCliente = (TipoCliente)CBTipoCliente.SelectedItem,
                        CodigoZonaPK = int.Parse(CBZona.SelectedValue.ToString()),
                        Estado = true

                    };

                    switch (miEstado)
                    {
                        case EstadoFormulario.NUEVO:
                            _clienteServicio.Agregar(_cliente);
                            MessageBox.Show($"Cliente {txtNombre.Text} {txtApellido.Text} se ha creado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            break;
                        case EstadoFormulario.EDITANDO:
                            _clienteServicio.Actualizar(_cliente);
                            MessageBox.Show($"Cliente {txtNombre.Text} {txtApellido.Text} actualizado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                }


            };

            btnNuevo.Click += (s, e) =>
            {
                LimpiarControles();
            };
        }

        private void LimpiarControles()
        {
            txtCedulaRNC.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtContacto.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            CBTipoCliente.SelectedIndex = -1;
            CBZona.SelectedIndex = -1;
            txtSector.Clear();
            txtCiudad.Clear();
            txtProvincia.Clear();
            txtCedulaRNC.Focus();

        }

        private async void CargarZona()
        {
            CBZona.SelectedValueChanged -= CBZona_SelectedValueChanged;
            var result =await _zonaServicio.ObtenerToda();
            CBZona.DataSource = result;
            CBZona.DisplayMember = "NombreZona";
            CBZona.ValueMember = "CodigoZona";
            CBZona.SelectedIndex = -1;
            CBZona.SelectedValueChanged += CBZona_SelectedValueChanged;
            txtSector.Clear();
            txtCiudad.Clear();
            txtProvincia.Clear();
        }

        private async void CargarSectorCiudadyProvincia(int codigoZona)
        {
            var result = await _zonaServicio.BuscarZonaSectorCiudadProvincia(codigoZona);
            txtSector.Text = result.SectorMostrar;
            txtCiudad.Text = result.CiudadMostrar;
            txtProvincia.Text = result.ProvinciaMostrar;
           
        }
        
        private void CargarTiposClientes()
        {
            CBTipoCliente.DataSource = Enum.GetValues(typeof(TipoCliente))  ;
            CBTipoCliente.SelectedIndex = -1;
        }

        private  void CBZona_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CBZona.SelectedIndex == -1) return;
            ZonaVM _z = CBZona.SelectedItem as ZonaVM;
            CargarSectorCiudadyProvincia(_z.CodigoZona);

        }

        private bool ValidarForm()
        {
            
            if (string.IsNullOrEmpty(txtCedulaRNC.Value.ToString()))
            {
                errorProvider.SetError(txtCedulaRNC, "Campo Requerido");
                txtCedulaRNC.Focus();
                return false;
            }
            errorProvider.Clear();

            if (txtCedulaRNC.Value.ToString().Length < 11)
            {
                errorProvider.SetError(txtCedulaRNC, "Cédula y/o RNC invalido");
                txtCedulaRNC.Focus();
                return false;
            }
            errorProvider.Clear();

            if(miEstado == EstadoFormulario.NUEVO)
            {
                if (_clienteServicio.ValidarCedula(txtCedulaRNC.Value.ToString()))
                {
                    errorProvider.SetError(txtCedulaRNC, "Cédula y/o RNC ya existe");
                    txtCedulaRNC.Focus();
                    return false;
                }
                errorProvider.Clear();
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "Campo Requerido");
                txtNombre.Focus();
                return false;
            }
            errorProvider.Clear();

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                errorProvider.SetError(txtApellido, "Campo Requerido");
                txtApellido.Focus();
                return false;
            }
            errorProvider.Clear();

            if (string.IsNullOrEmpty(txtTelefono.Value.ToString()))
            {
                errorProvider.SetError(txtTelefono, "Campo Requerido");
                txtTelefono.Focus();
                return false;
            }
            errorProvider.Clear();

            if (txtTelefono.Value.ToString().Length < 10)
            {
                errorProvider.SetError(txtTelefono, "Teléfono invalido");
                txtTelefono.Focus();
                return false;
            }
            errorProvider.Clear();

            if (string.IsNullOrEmpty(txtContacto.Text))
            {
                errorProvider.SetError(txtContacto, "Campo Requerido");
                txtContacto.Focus();
                return false;
            }
            errorProvider.Clear();

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Campo Requerido");
                txtEmail.Focus();
                return false;
            }
            errorProvider.Clear();

            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                errorProvider.SetError(txtDireccion, "Campo Requerido");
                txtDireccion.Focus();
                return false;
            }
            errorProvider.Clear();

            if (CBTipoCliente.SelectedIndex < 0)
            {
                errorProvider.SetError(CBTipoCliente, "Seleccione un Tipo Cliente");
                CBTipoCliente.Focus();
                return false;
            }
            errorProvider.Clear();

            if(CBZona.SelectedIndex < 0)
            {
                errorProvider.SetError(CBZona, "Seleccione una Zona");
                CBZona.Focus();
                return false;
            }
            errorProvider.Clear();
            return true;
        }
    }
}
