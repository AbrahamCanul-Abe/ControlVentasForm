using ControlVentasFormCore.Business;
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
    public partial class Frm_AddUpdate_Categorias : Form
    {
        private int? ID;
        #region Global Variables
        private ControlVentasFormCore.Business.CategoriaBAL CategoriaBAL;
        string ConnectionString = "server=LENO\\SQLEXPRESS2; uid=sa; pwd=developer; database=ControlVentas";
        #endregion

        #region Methods...
        public Frm_AddUpdate_Categorias()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Solo se ejecuta si se recibe un Id
        /// </summary>
        /// <param name="ID"></param>
        public Frm_AddUpdate_Categorias(int? ID = null)
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
            CategoriaBAL = new ControlVentasFormCore.Business.CategoriaBAL() { ConnectionString = ConnectionString };
            txtNombre.Text = CategoriaBAL.GetCategoria((int)ID).Nombre.ToString();

        }

        private void Frm_AddUpdate_Categorias_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ControlVentasFormCore.Entity.CategoriaInfo CategoriaInfo = new ControlVentasFormCore.Entity.CategoriaInfo();
            CategoriaInfo.Nombre = txtNombre.Text.ToString();

            CategoriaBAL = new ControlVentasFormCore.Business.CategoriaBAL() { ConnectionString = ConnectionString };
            try
            {
                if (ID == null)
                {
                    CategoriaBAL.Save(CategoriaInfo);
                    MessageBox.Show("Se ha guardado el producto");
                }
                else
                {
                    CategoriaInfo.Id = (int)ID;
                    CategoriaBAL.Save(CategoriaInfo);
                    MessageBox.Show("Se ha actualizado el registro");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al guardar: " + ex.Message);
            }
            #endregion
        }
    }
}
