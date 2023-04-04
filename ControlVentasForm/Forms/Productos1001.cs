using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using SOLTUM.Framework.Presentation.Controls;
using SOLTUM.Framework.Utilities.BackgroundTask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ControlVentasForm.Forms
{
    public partial class Productos1001 : SOLTUM.Framework.Presentation.STGeneralToolbarXtraForm
    {
        #region Global Variables
        private ControlVentasFormCore.Business.ProductoBAL ProductoBAL;
        private LoadingSplash LoadingSplash;
        private BackgroundCallBack Callback;
        string ConnectionString = SOLTUM.Framework.Global.ProjectConnection.DataConnectionString;
        #endregion 

        #region Constructors...
        public Productos1001()
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

                GridView gridView = ProductosGridControl.MainView as GridView;
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
            ProductoBAL = new ControlVentasFormCore.Business.ProductoBAL() { ConnectionString = ConnectionString, Callback = Callback };
            Callback.RunMethod(new Thread (() => ProductoBAL.GetProductos()));

        }
        private void Productos1001_Load(object sender, EventArgs e)
        {
            try
            {
                barStatusFormName.Caption = this.Name;
                Show();

                LoadingSplash = new SOLTUM.Framework.Presentation.Controls.LoadingSplash(this, SOLTUM.Framework.Presentation.Controls.LoadingSplash.eLoadingType.LoadingImage);
                Callback = new BackgroundCallBack();
                Callback.GralCallBack += Callback_GralCallBack;

                Cursor = Cursors.WaitCursor;

                //LoadingSplash.Show();
                //LoadingSplash.SetCaption("Cargando datos de Productos");
                //LoadingSplash.SetDescription("Espere un momento...");
                Application.DoEvents();
                Refresh();


                ProductosgridView.ShowFindPanel();

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
        /// Evento para el callback
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Callback_GralCallBack(object sender, BackgroundResponse e)
        {
            switch (e.Response.StepCustom)
            {
                case "SHOWLOADING":
                    LoadingSplash.Show();
                    break;
                case "HIDELOADING":
                    LoadingSplash.Hide();
                    break;
                case "MESSAGETOSPLASH":
                    LoadingSplash.SetCaption(e.Response.MssgGral);
                    LoadingSplash.SetDescription(e.Response.MssgDet);
                    break;
                case "CONSULTATERMINADA":
                    ProductosGridControl.DataSource = e.Response.Obj;
                    break;
                default:
                    break;
            }
        }

        private void SalirbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void AgregarbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProductosAU1001 frm = new ProductosAU1001();
            frm.ShowDialog();
            Refresh();
        }

        private void EditarbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int? ID = GetId();
            if (ID != null)
            {
                ProductosAU1001 frmEdit = new ProductosAU1001(ID);
                frmEdit.ShowDialog();
                Refresh();
            }
        }

        private void BorrarbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
        #endregion
    }
}
