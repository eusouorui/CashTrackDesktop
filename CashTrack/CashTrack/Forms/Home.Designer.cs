namespace CashTrack
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btn1 = new MaterialSkin.Controls.MaterialButton();
            this.textBoxDonationInfo = new System.Windows.Forms.TextBox();
            this.pictureBoxTheme = new System.Windows.Forms.PictureBox();
            this.comboBoxDonationCurrency = new System.Windows.Forms.ComboBox();
            this.numericUpDownDonationAmount = new System.Windows.Forms.NumericUpDown();
            this.textBoxDonationResume = new System.Windows.Forms.TextBox();
            this.groupBoxDonation = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialButtonTest = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDonationAmount)).BeginInit();
            this.groupBoxDonation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn1.Depth = 0;
            this.btn1.HighEmphasis = true;
            this.btn1.Icon = null;
            this.btn1.Location = new System.Drawing.Point(10, 175);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn1.Name = "btn1";
            this.btn1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn1.Size = new System.Drawing.Size(79, 36);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Donate";
            this.btn1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn1.UseAccentColor = false;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // textBoxDonationInfo
            // 
            this.textBoxDonationInfo.Location = new System.Drawing.Point(235, 54);
            this.textBoxDonationInfo.Multiline = true;
            this.textBoxDonationInfo.Name = "textBoxDonationInfo";
            this.textBoxDonationInfo.ReadOnly = true;
            this.textBoxDonationInfo.Size = new System.Drawing.Size(474, 112);
            this.textBoxDonationInfo.TabIndex = 2;
            this.textBoxDonationInfo.Text = "Please make a donation.";
            this.textBoxDonationInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxTheme
            // 
            this.pictureBoxTheme.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTheme.Image")));
            this.pictureBoxTheme.InitialImage = null;
            this.pictureBoxTheme.Location = new System.Drawing.Point(741, 67);
            this.pictureBoxTheme.Name = "pictureBoxTheme";
            this.pictureBoxTheme.Size = new System.Drawing.Size(53, 51);
            this.pictureBoxTheme.TabIndex = 3;
            this.pictureBoxTheme.TabStop = false;
            // 
            // comboBoxDonationCurrency
            // 
            this.comboBoxDonationCurrency.FormattingEnabled = true;
            this.comboBoxDonationCurrency.Location = new System.Drawing.Point(6, 54);
            this.comboBoxDonationCurrency.Name = "comboBoxDonationCurrency";
            this.comboBoxDonationCurrency.Size = new System.Drawing.Size(188, 21);
            this.comboBoxDonationCurrency.TabIndex = 4;
            this.comboBoxDonationCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxDonationCurrency_SelectedIndexChanged);
            // 
            // numericUpDownDonationAmount
            // 
            this.numericUpDownDonationAmount.DecimalPlaces = 10;
            this.numericUpDownDonationAmount.Location = new System.Drawing.Point(10, 100);
            this.numericUpDownDonationAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDonationAmount.Name = "numericUpDownDonationAmount";
            this.numericUpDownDonationAmount.Size = new System.Drawing.Size(187, 20);
            this.numericUpDownDonationAmount.TabIndex = 5;
            this.numericUpDownDonationAmount.ValueChanged += new System.EventHandler(this.numericUpDownDonationAmount_ValueChanged);
            // 
            // textBoxDonationResume
            // 
            this.textBoxDonationResume.Location = new System.Drawing.Point(10, 146);
            this.textBoxDonationResume.Name = "textBoxDonationResume";
            this.textBoxDonationResume.ReadOnly = true;
            this.textBoxDonationResume.Size = new System.Drawing.Size(187, 20);
            this.textBoxDonationResume.TabIndex = 6;
            // 
            // groupBoxDonation
            // 
            this.groupBoxDonation.Controls.Add(this.label4);
            this.groupBoxDonation.Controls.Add(this.label3);
            this.groupBoxDonation.Controls.Add(this.label2);
            this.groupBoxDonation.Controls.Add(this.label1);
            this.groupBoxDonation.Controls.Add(this.numericUpDownDonationAmount);
            this.groupBoxDonation.Controls.Add(this.textBoxDonationResume);
            this.groupBoxDonation.Controls.Add(this.btn1);
            this.groupBoxDonation.Controls.Add(this.textBoxDonationInfo);
            this.groupBoxDonation.Controls.Add(this.comboBoxDonationCurrency);
            this.groupBoxDonation.Location = new System.Drawing.Point(6, 67);
            this.groupBoxDonation.Name = "groupBoxDonation";
            this.groupBoxDonation.Size = new System.Drawing.Size(715, 224);
            this.groupBoxDonation.TabIndex = 7;
            this.groupBoxDonation.TabStop = false;
            this.groupBoxDonation.Text = "Donation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Your donation Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Resume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Currency";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialButtonTest);
            this.Controls.Add(this.groupBoxDonation);
            this.Controls.Add(this.pictureBoxTheme);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDonationAmount)).EndInit();
            this.groupBoxDonation.ResumeLayout(false);
            this.groupBoxDonation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn1;
        private System.Windows.Forms.TextBox textBoxDonationInfo;
        private System.Windows.Forms.PictureBox pictureBoxTheme;
        private System.Windows.Forms.ComboBox comboBoxDonationCurrency;
        private System.Windows.Forms.NumericUpDown numericUpDownDonationAmount;
        private System.Windows.Forms.TextBox textBoxDonationResume;
        private System.Windows.Forms.GroupBox groupBoxDonation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton materialButtonTest;
    }
}

