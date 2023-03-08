namespace ControlVentasForm
{
    partial class Frm_Categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Categorias));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.CategoriasDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(547, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 39);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Categorias";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Salmon;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(469, 37);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(72, 38);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Turquoise;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(400, 37);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(63, 39);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.Location = new System.Drawing.Point(322, 36);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(72, 39);
            this.BtnNuevo.TabIndex = 7;
            this.BtnNuevo.Text = "Agregar";
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // CategoriasDataGridView
            // 
            this.CategoriasDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoriasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriasDataGridView.Location = new System.Drawing.Point(63, 89);
            this.CategoriasDataGridView.Name = "CategoriasDataGridView";
            this.CategoriasDataGridView.Size = new System.Drawing.Size(526, 312);
            this.CategoriasDataGridView.TabIndex = 6;
            this.CategoriasDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductosDataGridView_CellContentClick);
            // 
            // Frm_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 436);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.CategoriasDataGridView);
            this.Name = "Frm_Categorias";
            this.Text = "Frm_Categorias";
            this.Load += new System.EventHandler(this.Frm_Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.DataGridView CategoriasDataGridView;
    }
}