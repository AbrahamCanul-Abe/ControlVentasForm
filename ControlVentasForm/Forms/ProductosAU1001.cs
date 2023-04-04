using SOLTUM.Framework.Presentation.Controls;
using SOLTUM.Framework.Utilities.BackgroundTask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlVentasForm.Forms
{
    public partial class ProductosAU1001 : SOLTUM.Framework.Presentation.STGeneralToolbarXtraForm
    {
        private int? ID;
        #region Global Variables
        private ControlVentasFormCore.Business.ProductoBAL ProductoBAL;
        private ControlVentasFormCore.Business.CategoriaBAL CategoriaBAL;
        string ConnectionString = SOLTUM.Framework.Global.ProjectConnection.DataConnectionString;
        private LoadingSplash LoadingSplash;
        private BackgroundCallBack Callback;
        #endregion
        public ProductosAU1001()
        {
            InitializeComponent();
        }

        public ProductosAU1001(int? ID = null)
        {
            InitializeComponent();
            this.ID = ID;

            if (this.ID != null)
                LoadData();
        }

        private void LoadData()
        {
            ProductoBAL = new ControlVentasFormCore.Business.ProductoBAL() { ConnectionString = ConnectionString };
            NombretextEdit.Text = ProductoBAL.GetProducto((int)ID).Nombre.ToString();
            DescripciontextEdit.Text = ProductoBAL.GetProducto((int)ID).Descripcion.ToString();
            PreciotextEdit.Text = ProductoBAL.GetProducto((int)ID).Precio.ToString();
            cbx_Categorias.EditValue = ProductoBAL.GetProducto((int)ID).CategoriaId.ToString();
        }

        private void GuardarbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barStatusFormName.Caption = this.Name;
            Show();

            LoadingSplash = new SOLTUM.Framework.Presentation.Controls.LoadingSplash(this, SOLTUM.Framework.Presentation.Controls.LoadingSplash.eLoadingType.ProgressBar);
            Callback = new BackgroundCallBack();
            LoadingSplash.Show();
            System.Threading.Thread.Sleep(3000);
            LoadingSplash.SetCaption("Guardando los datos");
            LoadingSplash.SetDescription("Espere...");
            Application.DoEvents();

            ControlVentasFormCore.Entity.ProductoInfo ProductoInfo = new ControlVentasFormCore.Entity.ProductoInfo();
            ProductoInfo.Nombre = NombretextEdit.Text.ToString();
            ProductoInfo.Descripcion = DescripciontextEdit.Text.ToString();
            ProductoInfo.Precio = decimal.Parse(PreciotextEdit.Text);
            ProductoInfo.CategoriaId = (int)(cbx_Categorias.EditValue);

            ProductoBAL = new ControlVentasFormCore.Business.ProductoBAL() { ConnectionString = ConnectionString };
            try
            {
                if (ID == null)
                {
                    ProductoBAL.Save(ProductoInfo);
                    MessageBox.Show("Se ha guardado el producto");
                }
                else
                {
                    ProductoInfo.Id = (int)ID;
                    ProductoBAL.Save(ProductoInfo);
                    MessageBox.Show("Se ha actualizado el registro");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al guardar: " + ex.Message);
            }
            LoadingSplash.Hide();
        }

        private void ProductosAU1001_Load(object sender, EventArgs e)
        {


            CategoriaBAL = new ControlVentasFormCore.Business.CategoriaBAL() { ConnectionString = ConnectionString };

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand comando = new SqlCommand("select Nombre from dbENC78", connection);
                connection.Open();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    cbx_Categorias.Properties.DataSource = CategoriaBAL.GetCategorias();//(registro["Nombre"].ToString());
                    cbx_Categorias.Properties.ValueMember = "Id";
                    cbx_Categorias.Properties.DisplayMember = "Nombre";
                }
                connection.Close();
            }
        }
    }
}
