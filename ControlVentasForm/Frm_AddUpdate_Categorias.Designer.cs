namespace ControlVentasForm
{
    partial class Frm_AddUpdate_Categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddUpdate_Categorias));
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(167, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 35);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Guardar";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(193, 114);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 20);
            this.txtNombre.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre de categoría";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(139, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Agregar Categoria";
            // 
            // Frm_AddUpdate_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 248);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "Frm_AddUpdate_Categorias";
            this.Text = "Frm_AddUpdate_Categorias";
            this.Load += new System.EventHandler(this.Frm_AddUpdate_Categorias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}