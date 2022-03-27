namespace CashTrack
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn1.Depth = 0;
            this.btn1.DrawShadows = true;
            this.btn1.HighEmphasis = true;
            this.btn1.Icon = null;
            this.btn1.Location = new System.Drawing.Point(68, 106);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(120, 36);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "LOOKS LIT BOI";
            this.btn1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn1.UseAccentColor = false;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(364, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 110);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

