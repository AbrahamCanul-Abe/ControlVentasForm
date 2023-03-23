using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentasForm
{
    public partial class Frm_AddUpdate_Productos : Form
    {
        private int? ID;
        #region Global Variables
        private ControlVentasFormCore.Business.ProductoBAL ProductoBAL;
        private ControlVentasFormCore.Business.CategoriaBAL CategoriaBAL;
        string ConnectionString = SOLTUM.Framework.Global.ProjectConnection.DataConnectionString;
        #endregion

        #region Methods...
        public Frm_AddUpdate_Productos()
        {
            InitializeComponent();
        }
        public Frm_AddUpdate_Productos(int? ID = null)
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
            txt_Nombre.Text = ProductoBAL.GetProducto((int)ID).Nombre.ToString();
            txt_Descripcion.Text = ProductoBAL.GetProducto((int)ID).Descripcion.ToString();
            txt_Precio.Text = ProductoBAL.GetProducto((int)ID).Precio.ToString();
            cbx_Categorias.EditValue = ProductoBAL.GetProducto((int)ID).CategoriaId.ToString();
        }
        private void Frm_AddUpdate_Productos_Load(object sender, EventArgs e)
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
                    //cbx_Categorias.Properties.ValueMember = "id";
                    cbx_Categorias.Properties.DisplayMember = "Nombre";
                }
                connection.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            #endregion
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ControlVentasFormCore.Entity.ProductoInfo ProductoInfo = new ControlVentasFormCore.Entity.ProductoInfo();
            ProductoInfo.Nombre = txt_Nombre.Text.ToString();
            ProductoInfo.Descripcion = txt_Descripcion.Text.ToString();
            ProductoInfo.Precio = decimal.Parse(txt_Precio.Text);
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
        }
    }
}
