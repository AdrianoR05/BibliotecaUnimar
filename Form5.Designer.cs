namespace Biblioteca_Unimar
{
    partial class formLibrosDispo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLibrosDispo));
            this.volvermenu = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnLibrosDisp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // volvermenu
            // 
            this.volvermenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(127)))), ((int)(((byte)(155)))));
            this.volvermenu.FlatAppearance.BorderSize = 0;
            this.volvermenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volvermenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.volvermenu.ForeColor = System.Drawing.Color.White;
            this.volvermenu.Location = new System.Drawing.Point(418, 517);
            this.volvermenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.volvermenu.Name = "volvermenu";
            this.volvermenu.Size = new System.Drawing.Size(190, 46);
            this.volvermenu.TabIndex = 13;
            this.volvermenu.Text = "Volver al menú";
            this.volvermenu.UseVisualStyleBackColor = false;
            this.volvermenu.Click += new System.EventHandler(this.volvermenu_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(244, 112);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(528, 304);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnLibrosDisp
            // 
            this.btnLibrosDisp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(127)))), ((int)(((byte)(155)))));
            this.btnLibrosDisp.FlatAppearance.BorderSize = 0;
            this.btnLibrosDisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrosDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btnLibrosDisp.ForeColor = System.Drawing.Color.White;
            this.btnLibrosDisp.Location = new System.Drawing.Point(418, 445);
            this.btnLibrosDisp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLibrosDisp.Name = "btnLibrosDisp";
            this.btnLibrosDisp.Size = new System.Drawing.Size(190, 46);
            this.btnLibrosDisp.TabIndex = 13;
            this.btnLibrosDisp.Text = "Mostrar libros \r\n";
            this.btnLibrosDisp.UseVisualStyleBackColor = false;
            this.btnLibrosDisp.Click += new System.EventHandler(this.btnLibrosDisp_Click);
            // 
            // formLibrosDispo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1036, 605);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnLibrosDisp);
            this.Controls.Add(this.volvermenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "formLibrosDispo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros Diponibles";
            this.Load += new System.EventHandler(this.formLibrosDispo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button volvermenu;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnLibrosDisp;
    }
}