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
        #region Events...
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                refresh();
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
            refresh();
        }

        private void refresh()
        {
            ProductoBAL = new ControlVentasFormCore.Business.ProductoBAL() { ConnectionString = ConnectionString };
            ProductosDataGridView.DataSource = ProductoBAL.GetProductos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
