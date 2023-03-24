using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DocumentFormat.OpenXml.Office2010.Excel;


namespace ControlVentasForm
{
    public partial class Login : Form
    {
        #region Global Variables...
        private SOLTUM.Framework.Business.UserBAL UserBAL;
        string ConnectionString = SOLTUM.Framework.Global.ProjectConnection.CredentialsConnectionString;

        //Import para mover el formulario por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        #endregion

        #region Methods
        public Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodos para Limpiar el formulario cuando se inicie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == " Usuario")
            {
                txtUsuario.Text = string.Empty;
                txtUsuario.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = " Usuario";
                txtUsuario.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == " Contraseña")
            {
                txtPass.Text = string.Empty;
                txtPass.ForeColor = System.Drawing.Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = " Contraseña";
                txtPass.ForeColor= System.Drawing.Color.DarkGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        /// <summary>
        /// Metodo para el close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Metodo para el minimize button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            //Evento Para poder mover el formulario por la pantalla
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Log_Click(object sender, EventArgs e)
        {
            UserBAL = new SOLTUM.Framework.Business.UserBAL() { ConnectionString = ConnectionString };
            try
            {
                if (UserBAL.UserExists(txtUsuario.Text, txtPass.Text))
                {
                    Frm_Menu frmProd = new Frm_Menu();
                    frmProd.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    txtPass.Text = " Contraseña";
                    txtPass.UseSystemPasswordChar = false;
                    txtUsuario.Text = " Usuario";
                }
            }
            catch (Exception ex) { MessageBox.Show("Excepcion del tipo: " + ex.Message); }
        }
        #endregion
    }
}
