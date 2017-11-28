using SistemaGestionCliente.Entidades.VistaModel;
using SistemaGestionCliente.LogicaNegocio.SectorServicios;
using SistemaGestionCliente.LogicaNegocio.ZonaServicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;

namespace SistemaGestionCliente.Vista
{
    public partial class RadFormNuevaZona : Telerik.WinControls.UI.RadForm
    {
        private ISectorServicios _sectorServicios;
        private IZonaServicios _zonaServicios;
        private List<SectorVM> listaSectores;


        public RadFormNuevaZona()
        {
            InitializeComponent();
            _sectorServicios = new SectorServicios();
            _zonaServicios = new ZonaServicios();
            listaSectores = new List<SectorVM>();
        }

        private void RadFormNuevaZona_Load(object sender, EventArgs ev)
        {
            SetEventos();
            CargarSectores();
        }

        private async void CargarSectores()
        {
            var _listaSectores = await _sectorServicios.ObtenerTodos();
       
            CBSectores.DataSource = _listaSectores;
            listaSectores = _listaSectores; //Buscar otra logica
            CBSectores.DisplayMember = "NombreSector";
            CBSectores.ValueMember = "CodigoCiudadFK";
            CBSectores.SelectedIndex = -1;
            CBSectores.SelectedValueChanged += CBSectores_SelectedValueChanged;
        }

        public void SetEventos()
        {
            //Evento Cerrar Formulario
            labelSalirZona.Click += (s, e) =>
            {
                this.Close();
            };
            //Evento Boton btnNuevaZona
            btnNuevaZona.Click += (s, e) =>
            {
                LimpiarControles();

            };

            btnGuardar.Click += (s, e) =>
            {
                var _zonaVM = new ZonaVM();
                try
                {
                    //Validaciones
                    if (ValidarFormulario())
                    {
                        
                        _zonaVM.NombreZona = txtNombreZona.Text;
                        var codSector = (CBSectores.SelectedItem as SectorVM).CodigoSector;
                        _zonaVM.CodigoSectorFK = codSector ;
                        GuardarRegistro(_zonaVM);

                        MessageBox.Show("Zona creada satisfactoriamente", "Registro Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Hubo un error al procesar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            };
        }

        private async void CBSectores_SelectedValueChanged(object sender, EventArgs e)
        {

            if (CBSectores.SelectedIndex == -1) return;
            CiudadVM ciudiad = await _sectorServicios.ObtenerCiudadProvincia(int.Parse(CBSectores.SelectedValue.ToString()));
            txtCiudad.Text = ciudiad.NombreCiudad;
            txtProvincia.Text = ciudiad.NombreProvincia;
        }
        private async void GuardarRegistro(ZonaVM zona)
        {
            await _zonaServicios.Agregar(zona);
        }
        private bool ValidarFormulario()
        {
            if (String.IsNullOrEmpty(txtNombreZona.Text))
            {
                errorProvider.SetError(txtNombreZona, "Campo requerido");
                txtNombreZona.Focus();
                return false;
            }
            errorProvider.Clear();
            if(CBSectores.SelectedIndex == -1)
            {
                errorProvider.SetError(CBSectores, "Campo requerido");
                CBSectores.Focus();
                return false;
            }
            errorProvider.Clear();
            return true;
        }
        private void LimpiarControles()
        {
            txtNombreZona.Clear();
            txtCiudad.Clear();
            txtProvincia.Clear();
            txtNombreZona.Focus();
            CBSectores.SelectedIndex = -1;
            
        }
    }
}
