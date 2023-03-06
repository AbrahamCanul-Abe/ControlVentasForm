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


        #endregion

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Frm_AddUpdate_Productos frm = new Frm_AddUpdate_Productos();
            frm.ShowDialog();
            Refresh();
        }

        private void Refresh()
        {
            ProductoBAL = new ControlVentasFormCore.Business.ProductoBAL() { ConnectionString = ConnectionString };
            ProductosDataGridView.DataSource = ProductoBAL.GetProductos();
        }

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
    }
}
