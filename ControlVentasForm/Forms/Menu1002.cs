﻿using ControlVentasForm.Forms;
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
        #region Variables...
        private DevExpress.XtraBars.Navigation.AccordionControlElement ConfiguracionaccordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement OperacionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ReportesControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ProductosaccordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement OtherOptionsaccordionControlElement1;
        #endregion

        #region Constructor...
        public Menu1002()
        {
            InitializeComponent();
        }
        #endregion

        #region Events...
        private void Menu1002_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu1002));
            this.ConfiguracionaccordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.OperacionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ReportesControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.OtherOptionsaccordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ProductosaccordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FluentImageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Pressed.Options.UseFont = true;
            this.accordionControl1.Appearance.Hint.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Pressed.Options.UseFont = true;
            this.accordionControl1.Appearance.ItemWithContainer.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.ItemWithContainer.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.ItemWithContainer.Pressed.Options.UseFont = true;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ConfiguracionaccordionControlElement1,
            this.OperacionControlElement1,
            this.ReportesControlElement1,
            this.OtherOptionsaccordionControlElement1});
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accordionControl1.Size = new System.Drawing.Size(312, 607);
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
            // ConfiguracionaccordionControlElement1
            // 
            this.ConfiguracionaccordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ProductosaccordionControlElement1});
            this.ConfiguracionaccordionControlElement1.Expanded = true;
            this.ConfiguracionaccordionControlElement1.ImageOptions.ImageIndex = 5;
            this.ConfiguracionaccordionControlElement1.Name = "ConfiguracionaccordionControlElement1";
            this.ConfiguracionaccordionControlElement1.Text = "Configuracion";
            // 
            // OperacionControlElement1
            // 
            this.OperacionControlElement1.ImageOptions.ImageIndex = 8;
            this.OperacionControlElement1.Name = "OperacionControlElement1";
            this.OperacionControlElement1.Text = "Operacion";
            // 
            // ReportesControlElement1
            // 
            this.ReportesControlElement1.ImageOptions.ImageIndex = 14;
            this.ReportesControlElement1.Name = "ReportesControlElement1";
            this.ReportesControlElement1.Text = "Reportes";
            // 
            // OtherOptionsaccordionControlElement1
            // 
            this.OtherOptionsaccordionControlElement1.ImageOptions.ImageIndex = 9;
            this.OtherOptionsaccordionControlElement1.Name = "OtherOptionsaccordionControlElement1";
            this.OtherOptionsaccordionControlElement1.Text = "Otras Opciones";
            // 
            // ProductosaccordionControlElement1
            // 
            this.ProductosaccordionControlElement1.Name = "ProductosaccordionControlElement1";
            this.ProductosaccordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ProductosaccordionControlElement1.Text = "Productos";
            this.ProductosaccordionControlElement1.Click += new System.EventHandler(this.ProductosaccordionControlElement1_Click);
            // 
            // Menu1002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1043, 710);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu1002";
            this.Text = "Control Ventas Restaurant";
            this.Load += new System.EventHandler(this.Menu1002_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FluentImageCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ProductosaccordionControlElement1_Click(object sender, EventArgs e)
        {
            PerformForm(new Productos1001() { MdiParent = this });
        }

        #endregion

        #region Methods...
        private void PerformForm(Form frm)
        {
            if(frm.MdiParent != null)
            {
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            else
                frm.ShowDialog();
            
        }
        #endregion
    }
}