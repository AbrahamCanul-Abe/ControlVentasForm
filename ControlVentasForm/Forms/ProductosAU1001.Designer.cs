
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
            this.NombretextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Nombre = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.DescripciontextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Descripcion = new DevExpress.XtraLayout.LayoutControlItem();
            this.PreciotextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Precio = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbx_Categorias = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FluentImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombretextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescripciontextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Descripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreciotextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Categorias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.PreciotextEdit);
            this.layoutControl1.Controls.Add(this.DescripciontextEdit);
            this.layoutControl1.Controls.Add(this.NombretextEdit);
            this.layoutControl1.Controls.Add(this.cbx_Categorias);
            this.layoutControl1.Location = new System.Drawing.Point(0, 29);
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(926, 201, 650, 400);
            this.layoutControl1.Size = new System.Drawing.Size(878, 120);
            // 
            // Root
            // 
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Nombre,
            this.emptySpaceItem1,
            this.Descripcion,
            this.Precio,
            this.layoutControlItem4});
            this.Root.Size = new System.Drawing.Size(878, 120);
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
            // NombretextEdit
            // 
            this.NombretextEdit.Location = new System.Drawing.Point(81, 8);
            this.NombretextEdit.MenuManager = this.barManager;
            this.NombretextEdit.Name = "NombretextEdit";
            this.NombretextEdit.Size = new System.Drawing.Size(789, 20);
            this.NombretextEdit.StyleController = this.layoutControl1;
            this.NombretextEdit.TabIndex = 4;
            // 
            // Nombre
            // 
            this.Nombre.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.Nombre.AppearanceItemCaption.Options.UseFont = true;
            this.Nombre.AppearanceItemCaption.Options.UseForeColor = true;
            this.Nombre.Control = this.NombretextEdit;
            this.Nombre.Location = new System.Drawing.Point(0, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(864, 22);
            this.Nombre.TextSize = new System.Drawing.Size(65, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 88);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(864, 18);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // DescripciontextEdit
            // 
            this.DescripciontextEdit.Location = new System.Drawing.Point(81, 30);
            this.DescripciontextEdit.MenuManager = this.barManager;
            this.DescripciontextEdit.Name = "DescripciontextEdit";
            this.DescripciontextEdit.Size = new System.Drawing.Size(789, 20);
            this.DescripciontextEdit.StyleController = this.layoutControl1;
            this.DescripciontextEdit.TabIndex = 5;
            // 
            // Descripcion
            // 
            this.Descripcion.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.Descripcion.AppearanceItemCaption.Options.UseFont = true;
            this.Descripcion.AppearanceItemCaption.Options.UseForeColor = true;
            this.Descripcion.Control = this.DescripciontextEdit;
            this.Descripcion.Location = new System.Drawing.Point(0, 22);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(864, 22);
            this.Descripcion.TextSize = new System.Drawing.Size(65, 13);
            // 
            // PreciotextEdit
            // 
            this.PreciotextEdit.Location = new System.Drawing.Point(81, 52);
            this.PreciotextEdit.MenuManager = this.barManager;
            this.PreciotextEdit.Name = "PreciotextEdit";
            this.PreciotextEdit.Size = new System.Drawing.Size(789, 20);
            this.PreciotextEdit.StyleController = this.layoutControl1;
            this.PreciotextEdit.TabIndex = 6;
            // 
            // Precio
            // 
            this.Precio.Control = this.PreciotextEdit;
            this.Precio.Location = new System.Drawing.Point(0, 44);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(864, 22);
            this.Precio.TextSize = new System.Drawing.Size(65, 13);
            // 
            // cbx_Categorias
            // 
            this.cbx_Categorias.EditValue = "Categorias";
            this.cbx_Categorias.Location = new System.Drawing.Point(81, 74);
            this.cbx_Categorias.Name = "cbx_Categorias";
            this.cbx_Categorias.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_Categorias.Properties.NullText = "";
            this.cbx_Categorias.Properties.PopupSizeable = false;
            this.cbx_Categorias.Properties.PopupView = this.gridLookUpEdit1View;
            this.cbx_Categorias.Size = new System.Drawing.Size(789, 20);
            this.cbx_Categorias.StyleController = this.layoutControl1;
            this.cbx_Categorias.TabIndex = 7;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Categoria";
            this.gridColumn11.FieldName = "Nombre";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbx_Categorias;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "Categoría";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 66);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(864, 22);
            this.layoutControlItem4.Text = "Categoría";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(65, 13);
            // 
            // ProductosAU1001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(878, 168);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("ProductosAU1001.IconOptions.Image")));
            this.Name = "ProductosAU1001";
            this.Text = "Agregar o actualizar productos";
            this.Load += new System.EventHandler(this.ProductosAU1001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FluentImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombretextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescripciontextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Descripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreciotextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Categorias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarButtonItem GuardarbarButtonItem;
        private DevExpress.XtraEditors.TextEdit PreciotextEdit;
        private DevExpress.XtraEditors.TextEdit DescripciontextEdit;
        private DevExpress.XtraEditors.TextEdit NombretextEdit;
        private DevExpress.XtraLayout.LayoutControlItem Nombre;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem Descripcion;
        private DevExpress.XtraLayout.LayoutControlItem Precio;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_Categorias;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}
