using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Demo_crud_vendedor.Forms
{
    public partial class Menu1002 : SOLTUM.Framework.Presentation.STGeneralMenuMDIForm
    {
        public Menu1002()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu1002));
            ((System.ComponentModel.ISupportInitialize)(this.FluentImageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // FluentImageCollection
            // 
            this.FluentImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("FluentImageCollection.ImageStream")));
            this.FluentImageCollection.Images.SetKeyName(0, "Factura-FacturasCanceladas.png");
            this.FluentImageCollection.Images.SetKeyName(1, "Factura-FacturasEmitidas.png");
            this.FluentImageCollection.Images.SetKeyName(2, "Factura-NuevaFactura.png");
            this.FluentImageCollection.Images.SetKeyName(3, "Factura-PendienteEmitir.png");
            this.FluentImageCollection.Images.SetKeyName(4, "Factura-PendienteEnviar.png");
            this.FluentImageCollection.Images.SetKeyName(5, "Iconos-Modulo-Valida-Conf.png");
            this.FluentImageCollection.Images.SetKeyName(6, "Iconos-Modulo-Valida-ConfCancela-LN.png");
            this.FluentImageCollection.Images.SetKeyName(7, "Iconos-Modulo-Valida-logo-55-55.png");
            this.FluentImageCollection.Images.SetKeyName(8, "Iconos-Modulo-Valida-Operacion.png");
            this.FluentImageCollection.Images.SetKeyName(9, "Iconos-Modulo-Valida-OtrasOpc.png");
            this.FluentImageCollection.Images.SetKeyName(10, "Iconos-Recibo-Nomina.png");
            this.FluentImageCollection.Images.SetKeyName(11, "Iconos-Recibo-Procesos.png");
            this.FluentImageCollection.Images.SetKeyName(12, "Menu-DescargaMasiva.png");
            this.FluentImageCollection.Images.SetKeyName(13, "Menu-Importaciones.png");
            this.FluentImageCollection.Images.SetKeyName(14, "Menu-Reportes.png");
            // 
            // Menu1002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1045, 578);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Menu1002";
            this.Text = "Plataforma ReviSAT";
            this.Load += new System.EventHandler(this.Menu1002_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FluentImageCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Menu1002_Load(object sender, EventArgs e)
        {

        }
    }
}
