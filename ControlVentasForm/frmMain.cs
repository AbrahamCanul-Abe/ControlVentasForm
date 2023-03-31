using DevExpress.XtraBars;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlVentasForm
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        #region Global Variables
        private ControlVentasFormCore.Business.ProductoBAL ProductoBAL;
        string ConnectionString = SOLTUM.Framework.Global.ProjectConnection.DataConnectionString;
        //string ConnectionString = "server=LENO\\SQLEXPRESS2; uid=sa; pwd=developer; database=dbRestaurantventas_data";
        #endregion 
        #region Constructors...
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region HELPER

        //Obtiene el id de la Fila/Producto seleccionado actualmente
        private int? GetId()
        {
            try
            {

                GridView gridView = gridControlMenu.MainView as GridView;
                GridColumn column = gridView.Columns[0];

                return Convert.ToInt32(gridView.GetFocusedRowCellValue(column));
                //ProductosDataGridView.Rows[ProductosDataGridView.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }

        }
        #endregion
        #region Events...
        /// <summary>
        /// Metodo para refrescar los datos del datagrid
        /// </summary>
        private void Refresh()
        {
            ProductoBAL = new ControlVentasFormCore.Business.ProductoBAL() { ConnectionString = ConnectionString };
            gridControlMenu.DataSource = ProductoBAL.GetProductos();

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            Frm_AddUpdate_Productos frm = new Frm_AddUpdate_Productos();
            frm.ShowDialog();
            Refresh();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int? ID = GetId();
            if (ID != null)
            {
                Frm_AddUpdate_Productos frmEdit = new Frm_AddUpdate_Productos(ID);
                frmEdit.ShowDialog();
                Refresh();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int? ID = GetId();
            try
            {
                if (ID != null)
                {
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        #endregion

        private void gridControlMenu_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
