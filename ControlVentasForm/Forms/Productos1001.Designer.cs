
namespace ControlVentasForm.Forms
{
    partial class Productos1001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos1001));
            this.ProductosGridControl = new DevExpress.XtraGrid.GridControl();
            this.ProductosgridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.AgregarbarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.EditarbarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.BorrarbarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.IdgridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombregridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescripciongridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PreciogridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SalirbarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FluentImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosgridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ProductosGridControl);
            this.layoutControl1.Location = new System.Drawing.Point(0, 35);
            this.layoutControl1.Size = new System.Drawing.Size(1024, 534);
            // 
            // Root
            // 
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Size = new System.Drawing.Size(1024, 534);
            // 
            // barManager
            // 
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.AgregarbarButtonItem,
            this.barCheckItem1,
            this.EditarbarButtonItem,
            this.BorrarbarButtonItem,
            this.SalirbarButtonItem});
            this.barManager.MaxItemId = 9;
            // 
            // bar2
            // 
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.AgregarbarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.EditarbarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.BorrarbarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.SalirbarButtonItem)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            // 
            // FluentImageCollection
            // 
            this.FluentImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("FluentImageCollection.ImageStream")));
            this.FluentImageCollection.Images.SetKeyName(0, "Salir.png");
            this.FluentImageCollection.Images.SetKeyName(1, "Agregar.png");
            this.FluentImageCollection.Images.SetKeyName(2, "Editar.png");
            this.FluentImageCollection.Images.SetKeyName(3, "Eliminar.png");
            // 
            // barStatusFormName
            // 
            this.barStatusFormName.Caption = "";
            // 
            // ProductosGridControl
            // 
            this.ProductosGridControl.Location = new System.Drawing.Point(10, 10);
            this.ProductosGridControl.MainView = this.ProductosgridView;
            this.ProductosGridControl.MenuManager = this.barManager;
            this.ProductosGridControl.Name = "ProductosGridControl";
            this.ProductosGridControl.Size = new System.Drawing.Size(1004, 514);
            this.ProductosGridControl.TabIndex = 4;
            this.ProductosGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ProductosgridView});
            // 
            // ProductosgridView
            // 
            this.ProductosgridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdgridColumn,
            this.NombregridColumn,
            this.DescripciongridColumn,
            this.PreciogridColumn});
            this.ProductosgridView.GridControl = this.ProductosGridControl;
            this.ProductosgridView.GroupPanelText = "Arrastra una columna aqui para agrupar en base a esa columna";
            this.ProductosgridView.Name = "ProductosgridView";
            this.ProductosgridView.OptionsBehavior.Editable = false;
            this.ProductosgridView.OptionsBehavior.ReadOnly = true;
            this.ProductosgridView.OptionsSelection.MultiSelect = true;
            this.ProductosgridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.ProductosgridView.OptionsView.ColumnAutoWidth = false;
            this.ProductosgridView.OptionsView.ShowFooter = true;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ProductosGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1008, 518);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // AgregarbarButtonItem
            // 
            this.AgregarbarButtonItem.Caption = "Agregar";
            this.AgregarbarButtonItem.Id = 4;
            this.AgregarbarButtonItem.ImageOptions.ImageIndex = 1;
            this.AgregarbarButtonItem.Name = "AgregarbarButtonItem";
            this.AgregarbarButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 5;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // EditarbarButtonItem
            // 
            this.EditarbarButtonItem.Caption = "Editar";
            this.EditarbarButtonItem.Id = 6;
            this.EditarbarButtonItem.ImageOptions.ImageIndex = 2;
            this.EditarbarButtonItem.Name = "EditarbarButtonItem";
            this.EditarbarButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // BorrarbarButtonItem
            // 
            this.BorrarbarButtonItem.Caption = "Borrar";
            this.BorrarbarButtonItem.Id = 7;
            this.BorrarbarButtonItem.ImageOptions.ImageIndex = 3;
            this.BorrarbarButtonItem.Name = "BorrarbarButtonItem";
            this.BorrarbarButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // IdgridColumn
            // 
            this.IdgridColumn.Caption = "Id";
            this.IdgridColumn.FieldName = "Id";
            this.IdgridColumn.MinWidth = 25;
            this.IdgridColumn.Name = "IdgridColumn";
            this.IdgridColumn.Visible = true;
            this.IdgridColumn.VisibleIndex = 1;
            this.IdgridColumn.Width = 70;
            // 
            // NombregridColumn
            // 
            this.NombregridColumn.Caption = "Nombre";
            this.NombregridColumn.FieldName = "Nombre";
            this.NombregridColumn.MinWidth = 25;
            this.NombregridColumn.Name = "NombregridColumn";
            this.NombregridColumn.Visible = true;
            this.NombregridColumn.VisibleIndex = 2;
            this.NombregridColumn.Width = 123;
            // 
            // DescripciongridColumn
            // 
            this.DescripciongridColumn.Caption = "Descripcion";
            this.DescripciongridColumn.FieldName = "Descripcion";
            this.DescripciongridColumn.MinWidth = 25;
            this.DescripciongridColumn.Name = "DescripciongridColumn";
            this.DescripciongridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Descripcion", "Registros {0}")});
            this.DescripciongridColumn.Visible = true;
            this.DescripciongridColumn.VisibleIndex = 3;
            this.DescripciongridColumn.Width = 274;
            // 
            // PreciogridColumn
            // 
            this.PreciogridColumn.Caption = "Precio";
            this.PreciogridColumn.FieldName = "Precio";
            this.PreciogridColumn.MinWidth = 25;
            this.PreciogridColumn.Name = "PreciogridColumn";
            this.PreciogridColumn.Visible = true;
            this.PreciogridColumn.VisibleIndex = 4;
            this.PreciogridColumn.Width = 94;
            // 
            // SalirbarButtonItem
            // 
            this.SalirbarButtonItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.SalirbarButtonItem.Caption = "Salir";
            this.SalirbarButtonItem.Id = 8;
            this.SalirbarButtonItem.ImageOptions.ImageIndex = 0;
            this.SalirbarButtonItem.Name = "SalirbarButtonItem";
            this.SalirbarButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.SalirbarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SalirbarButtonItem_ItemClick);
            // 
            // Productos1001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1024, 592);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Productos1001.IconOptions.Image")));
            this.Name = "Productos1001";
            this.Text = "Configuracion de Productos";
            this.Load += new System.EventHandler(this.Productos1001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FluentImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosgridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl ProductosGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ProductosgridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem AgregarbarButtonItem;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarButtonItem EditarbarButtonItem;
        private DevExpress.XtraBars.BarButtonItem BorrarbarButtonItem;
        private DevExpress.XtraGrid.Columns.GridColumn IdgridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NombregridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn DescripciongridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn PreciogridColumn;
        private DevExpress.XtraBars.BarButtonItem SalirbarButtonItem;
    }
}
