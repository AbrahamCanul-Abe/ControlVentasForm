
namespace ControlVentasForm.Forms
{
    partial class ProductosAU1001
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductosAU1001));
            this.GuardarbarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FluentImageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Location = new System.Drawing.Point(0, 29);
            this.layoutControl1.Size = new System.Drawing.Size(878, 433);
            // 
            // Root
            // 
            this.Root.Size = new System.Drawing.Size(878, 433);
            // 
            // barManager
            // 
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.GuardarbarButtonItem});
            this.barManager.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.GuardarbarButtonItem)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            // 
            // FluentImageCollection
            // 
            this.FluentImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("FluentImageCollection.ImageStream")));
            this.FluentImageCollection.Images.SetKeyName(0, "Salir.png");
            this.FluentImageCollection.Images.SetKeyName(1, "Guardar-X.png");
            // 
            // barStatusFormName
            // 
            this.barStatusFormName.Caption = "";
            // 
            // GuardarbarButtonItem
            // 
            this.GuardarbarButtonItem.Caption = "Guardar";
            this.GuardarbarButtonItem.Id = 4;
            this.GuardarbarButtonItem.ImageOptions.ImageIndex = 1;
            this.GuardarbarButtonItem.Name = "GuardarbarButtonItem";
            this.GuardarbarButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.GuardarbarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GuardarbarButtonItem_ItemClick);
            // 
            // ProductosAU1001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(878, 481);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("ProductosAU1001.IconOptions.Image")));
            this.Name = "ProductosAU1001";
            this.Text = "Agregar o actualizar productos";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FluentImageCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarButtonItem GuardarbarButtonItem;
    }
}
