namespace Winforms_musicstation
{
    partial class formlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formlogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(204, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNome.Location = new System.Drawing.Point(254, 232);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(243, 31);
            this.txtNome.TabIndex = 58;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSenha.Location = new System.Drawing.Point(254, 293);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(243, 31);
            this.txtSenha.TabIndex = 59;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.BorderColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.BorderRadius = 10;
            this.btnCadastrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadastrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadastrar.FillColor = System.Drawing.Color.Indigo;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(316, 330);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.PressedColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Size = new System.Drawing.Size(110, 33);
            this.btnCadastrar.TabIndex = 62;
            this.btnCadastrar.Text = "ENTRAR";
            this.btnCadastrar.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formlogin";
            this.Text = "formlogin";
            this.Load += new System.EventHandler(this.formlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2Button btnCadastrar;
    }
}