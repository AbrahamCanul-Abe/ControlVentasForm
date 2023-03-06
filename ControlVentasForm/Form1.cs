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
//using ControlVentasFormCore;

namespace ControlVentasForm
{   
    public partial class Form1 : Form
    {
        #region Global Variables
        private ControlVentasFormCore.Business.ProductoBAL ProductoBAL;
        string ConnectionString = "server=LENO\\SQLEXPRESS2; uid=sa; pwd=developer; database=ControlVentas";
        #endregion 
        #region Constructors...
        public Form1()
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
                     ProductosDataGridView.Rows[ProductosDataGridView.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }

        }
        #endregion
        #region Events...
        /// <summary>
        /// Metodo de inicio del Formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        /// <summary>
        /// Metodo del boton para agregar un nuevo producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Frm_AddUpdate_Productos frm = new Frm_AddUpdate_Productos();
            frm.ShowDialog();
            Refresh();
        }
        /// <summary>
        /// Metodo para refrescar los datos del datagrid
        /// </summary>
        private void Refresh()
        {
            ProductoBAL = new ControlVentasFormCore.Business.ProductoBAL() { ConnectionString = ConnectionString };
            ProductosDataGridView.DataSource = ProductoBAL.GetProductos();
        }
        /// <summary>
        /// Metodo del boton para editar un producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? ID = GetId();
            if (ID != null)
            {
                Frm_AddUpdate_Productos frmEdit = new Frm_AddUpdate_Productos(ID);
                frmEdit.ShowDialog();
                Refresh();
            }
        }
        /// <summary>
        /// Metodo para elminar un producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        ProductoBAL = new ControlVentasFormCore.Business.ProductoBAL() { ConnectionString = ConnectionString };
                        ProductoBAL.Delete((int)ID);
                        Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
