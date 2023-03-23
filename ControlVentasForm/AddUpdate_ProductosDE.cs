using ControlVentasFormCore.Business;
using DevExpress.XtraEditors;
using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentasForm
{
    public partial class AddUpdate_ProductosDE : DevExpress.XtraEditors.XtraUserControl
    {
        private int? ID;
        #region Global Variables
        private ControlVentasFormCore.Business.ProductoBAL ProductoBAL;
        string ConnectionString = SOLTUM.Framework.Global.ProjectConnection.DataConnectionString;
        #endregion
        public AddUpdate_ProductosDE()
        {
            InitializeComponent();
        }

        public AddUpdate_ProductosDE(int? ID = null)
        {
            InitializeComponent();
            this.ID = ID;

            if (this.ID != null)
                LoadData();
        }
        /// <summary>
        /// Metodo que carga los valores obtenidos en los TextBox solo si se regreso algun ID
        /// </summary>
        private void LoadData()
        {
            ProductoBAL = new ControlVentasFormCore.Business.ProductoBAL() { ConnectionString = ConnectionString };
            txtNombre.Text = ProductoBAL.GetProducto((int)ID).Nombre.ToString();
            txtDescripcion.Text = ProductoBAL.GetProducto((int)ID).Descripcion.ToString();
            txtPrecio.Text = ProductoBAL.GetProducto((int)ID).Precio.ToString();
            cbxCategorias.SelectedItem = ProductoBAL.GetProducto((int)ID).CategoriaId.ToString();



        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
