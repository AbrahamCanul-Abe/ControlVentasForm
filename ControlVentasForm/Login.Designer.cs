namespace ControlVentasForm
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.linkPass = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btn_Log = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(333, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.Location = new System.Drawing.Point(192, 130);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(380, 27);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = " Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPass.Location = new System.Drawing.Point(192, 199);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(380, 27);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = " Contraseña";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // linkPass
            // 
            this.linkPass.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkPass.AutoSize = true;
            this.linkPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPass.LinkColor = System.Drawing.Color.DimGray;
            this.linkPass.Location = new System.Drawing.Point(189, 330);
            this.linkPass.Name = "linkPass";
            this.linkPass.Size = new System.Drawing.Size(140, 16);
            this.linkPass.TabIndex = 0;
            this.linkPass.TabStop = true;
            this.linkPass.Text = "Olvidó su contraseña?";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(752, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(726, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(20, 20);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 6;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btn_Log
            // 
            this.btn_Log.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btn_Log.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.btn_Log.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log.Appearance.Options.UseBackColor = true;
            this.btn_Log.Appearance.Options.UseFont = true;
            this.btn_Log.Appearance.Options.UseTextOptions = true;
            this.btn_Log.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_Log.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_Log.AppearanceHovered.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Log.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log.AppearanceHovered.Options.UseBackColor = true;
            this.btn_Log.AppearanceHovered.Options.UseFont = true;
            this.btn_Log.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Log.ImageOptions.Image")));
            this.btn_Log.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Log.Location = new System.Drawing.Point(192, 266);
            this.btn_Log.Name = "btn_Log";
            this.btn_Log.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_Log.Size = new System.Drawing.Size(380, 42);
            this.btn_Log.TabIndex = 7;
            this.btn_Log.Text = "Ingresar";
            this.btn_Log.Click += new System.EventHandler(this.btn_Log_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.btn_Log);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.linkPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.LinkLabel linkPass;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMin;
        private DevExpress.XtraEditors.SimpleButton btn_Log;
    }
}