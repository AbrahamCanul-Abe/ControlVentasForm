using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlVentasForm.Forms
{
    public partial class Productos1001 : SOLTUM.Framework.Presentation.STGeneralToolbarXtraForm
    {
        #region Global Variables
        private ControlVentasFormCore.Business.ProductoBAL ProductoBAL;
        private SOLTUM.Framework.Presentation.Controls.LoadingSplash LoadingSplash;
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
        private void Productos1001_Load(object sender, EventArgs e)
        {
            try
            {
                barStatusFormName.Caption = this.Name;
                Show();

                LoadingSplash = new SOLTUM.Framework.Presentation.Controls.LoadingSplash(this, SOLTUM.Framework.Presentation.Controls.LoadingSplash.eLoadingType.LoadingImage);
                

                Cursor = Cursors.WaitCursor;

                LoadingSplash.Show();
                LoadingSplash.SetCaption("Cargando datos de Productos");
                LoadingSplash.SetDescription("Espere un momento...");
                Application.DoEvents();
                ProductoBAL = new ControlVentasFormCore.Business.ProductoBAL() { ConnectionString = ConnectionString };
                ProductosGridControl.DataSource = ProductoBAL.GetProductos();

                LoadingSplash.Hide();

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
        private void SalirbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        #endregion

        private void AgregarbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void EditarbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
