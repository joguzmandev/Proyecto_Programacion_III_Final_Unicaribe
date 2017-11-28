using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using SistemaGestionCliente.Entidades.VistaModel;
using SistemaGestionCliente.Entidades.Helpers;

namespace SistemaGestionCliente.Vista
{
    partial class RadFormClienteDetalles : Telerik.WinControls.UI.RadForm
    {
        private ClienteVM _seleccionado { get; set; }
        public RadFormClienteDetalles(ClienteVM clienteMostrar)
        {
            InitializeComponent();
            this._seleccionado = clienteMostrar;

       }


        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                // Get all Title attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                // If there is at least one Title attribute
                if (attributes.Length > 0)
                {
                    // Select the first one
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    // If it is not an empty string, return it
                    if (titleAttribute.Title != "")
                        return titleAttribute.Title;
                }
                // If there was no Title attribute, or if the Title attribute was the empty string, return the .exe name
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                // Get all Description attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                // If there aren't any Description attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                // If there is a Description attribute, return its value
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                // Get all Product attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                // If there aren't any Product attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                // If there is a Product attribute, return its value
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                // Get all Copyright attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                // If there aren't any Copyright attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                // If there is a Copyright attribute, return its value
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                // Get all Company attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                // If there aren't any Company attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                // If there is a Company attribute, return its value
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        #endregion

        private void DetallesCliente_Load(object sender, EventArgs ee)
        {
            btnOk.Click += (s,e) => {
                this.Close();
            };
            MostrarInformacionCliente();
        }

        private void MostrarInformacionCliente()
        {
            txtNombreCompleto.Text = $"{_seleccionado.Nombre} {_seleccionado.Apellido} - {_seleccionado.Cedula.FormatearCedula()}";
            txtTelefono.Text = _seleccionado.Telefono;
            txtTipoCliente.Text = _seleccionado.TipoCliente.ToString();
            txtEmail.Text = _seleccionado.Email;
            txtDireccion.Text = _seleccionado.Direccion;
            txtZona.Text = _seleccionado.ZonaMostrar;
            txtSector.Text = _seleccionado.SectorMostrar;
            txtCiudad.Text = _seleccionado.CiudadMostrar;
            txtProvincia.Text = _seleccionado.ProvinciaMostrar;
            btnOk.Focus();


        }
    }
}
