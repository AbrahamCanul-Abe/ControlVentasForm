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
        string ConnectionString = "server=LENO\\SQLEXPRESS2; uid=sa; pwd=developer; database=ControlVentas";
        #endregion 
        public Frm_AddUpdate_Productos()
        {
            InitializeComponent();
        }

        private void Frm_AddUpdate_Productos_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand comando = new SqlCommand("select nombre from categorias", connection);
                connection.Open();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    cbxCategorias.Items.Add(registro["Nombre"].ToString());
                }
                connection.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ControlVentasFormCore.Entity.ProductoInfo ProductoInfo = new ControlVentasFormCore.Entity.ProductoInfo();
            ProductoInfo.Nombre = txtNombre.Text.ToString();
            ProductoInfo.Descripcion = txtDescripcion.Text.ToString();
            ProductoInfo.Precio = decimal.Parse(txtPrecio.Text);
            ProductoInfo.CategoriaId = (int)(cbxCategorias.SelectedIndex);

            ProductoBAL = new ControlVentasFormCore.Business.ProductoBAL() { ConnectionString = ConnectionString};
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
