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
    public partial class Frm_Categorias : Form
    {

        #region Global Variables
        private ControlVentasFormCore.Business.CategoriaBAL CategoriaBAL;
        string ConnectionString = "server=LENO\\SQLEXPRESS2; uid=sa; pwd=developer; database=ControlVentas";
        #endregion 
        #region Constructors...
        public Frm_Categorias()
        {
            InitializeComponent();
        }
        #endregion
        /// <summary>
        /// Ayuda a obtener el ID del item seleccionado en el DataGridView
        /// </summary>
        /// <returns></returns>

        #region HELPER

        //Obtiene el id de la Fila/Producto seleccionado actualmente
        private int? GetId()
        {
            try
            {
                return int.Parse(
                     CategoriasDataGridView.Rows[CategoriasDataGridView.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }

        }
        #endregion
        /// <summary>
        /// Metodo para refrescar los datos del datagrid
        /// </summary>
        private void Refresh()
        {
            CategoriaBAL = new ControlVentasFormCore.Business.CategoriaBAL() { ConnectionString = ConnectionString };
            CategoriasDataGridView.DataSource = CategoriaBAL.GetCategorias();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? ID = GetId();
            try
            {
                if (ID != null)
                {
                    // Mostrar un cuadro de mensaje para confirmar la eliminación del producto
                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        CategoriaBAL = new ControlVentasFormCore.Business.CategoriaBAL() { ConnectionString = ConnectionString };
                        CategoriaBAL.Delete((int)ID);
                        Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? ID = GetId();
            if (ID != null)
            {
                Frm_AddUpdate_Categorias frmEdit = new Frm_AddUpdate_Categorias(ID);
                frmEdit.ShowDialog();
                Refresh();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Frm_AddUpdate_Categorias frm = new Frm_AddUpdate_Categorias();
            frm.ShowDialog();
            Refresh();
        }

        private void ProductosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_Categorias_Load(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
