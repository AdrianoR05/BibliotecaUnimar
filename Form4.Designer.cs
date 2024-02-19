namespace Biblioteca_Unimar
{
    partial class formPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrestamos));
            this.volvermenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // volvermenu
            // 
            this.volvermenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(127)))), ((int)(((byte)(155)))));
            this.volvermenu.FlatAppearance.BorderSize = 0;
            this.volvermenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volvermenu.Font = new System.Drawing.Font("Leelawadee", 11.5F);
            this.volvermenu.ForeColor = System.Drawing.Color.White;
            this.volvermenu.Location = new System.Drawing.Point(283, 334);
            this.volvermenu.Name = "volvermenu";
            this.volvermenu.Size = new System.Drawing.Size(127, 30);
            this.volvermenu.TabIndex = 13;
            this.volvermenu.Text = "Volver al menú";
            this.volvermenu.UseVisualStyleBackColor = false;
            this.volvermenu.Click += new System.EventHandler(this.volvermenu_Click);
            // 
            // formPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(691, 393);
            this.Controls.Add(this.volvermenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Leelawadee", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "formPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver préstamos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button volvermenu;
    }
}