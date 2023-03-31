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
        string ConnectionString = SOLTUM.Framework.Global.ProjectConnection.DataConnectionString;
        #endregion 

        #region Constructors...
        public Productos1001()
        {
            InitializeComponent();
        }
        #endregion

        #region Events...
        private void Productos1001_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                ProductoBAL = new ControlVentasFormCore.Business.ProductoBAL() { ConnectionString = ConnectionString };
                ProductosGridControl.DataSource = ProductoBAL.GetProductos();
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

        
    }
}
