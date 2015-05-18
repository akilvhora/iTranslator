namespace iTranslator
{
    partial class FrmMain
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
            this.LblFromLanguageText = new System.Windows.Forms.Label();
            this.LblToLanguageText = new System.Windows.Forms.Label();
            this.TxtFromLanguage = new System.Windows.Forms.TextBox();
            this.TxtToLangauge = new System.Windows.Forms.TextBox();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.CmdFromLangauge = new System.Windows.Forms.ComboBox();
            this.LblFromLanguage = new System.Windows.Forms.Label();
            this.LblToLangauge = new System.Windows.Forms.Label();
            this.CmdToLangauge = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblFromLanguageText
            // 
            this.LblFromLanguageText.AutoSize = true;
            this.LblFromLanguageText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFromLanguageText.Location = new System.Drawing.Point(32, 69);
            this.LblFromLanguageText.Name = "LblFromLanguageText";
            this.LblFromLanguageText.Size = new System.Drawing.Size(68, 14);
            this.LblFromLanguageText.TabIndex = 0;
            this.LblFromLanguageText.Text = "From Text";
            // 
            // LblToLanguageText
            // 
            this.LblToLanguageText.AutoSize = true;
            this.LblToLanguageText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblToLanguageText.Location = new System.Drawing.Point(32, 207);
            this.LblToLanguageText.Name = "LblToLanguageText";
            this.LblToLanguageText.Size = new System.Drawing.Size(51, 14);
            this.LblToLanguageText.TabIndex = 1;
            this.LblToLanguageText.Text = "To Text";
            // 
            // TxtFromLanguage
            // 
            this.TxtFromLanguage.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFromLanguage.Location = new System.Drawing.Point(108, 66);
            this.TxtFromLanguage.Multiline = true;
            this.TxtFromLanguage.Name = "TxtFromLanguage";
            this.TxtFromLanguage.Size = new System.Drawing.Size(642, 110);
            this.TxtFromLanguage.TabIndex = 2;
            // 
            // TxtToLangauge
            // 
            this.TxtToLangauge.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtToLangauge.Location = new System.Drawing.Point(108, 207);
            this.TxtToLangauge.Multiline = true;
            this.TxtToLangauge.Name = "TxtToLangauge";
            this.TxtToLangauge.Size = new System.Drawing.Size(642, 112);
            this.TxtToLangauge.TabIndex = 3;
            // 
            // BtnConvert
            // 
            this.BtnConvert.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConvert.Location = new System.Drawing.Point(108, 336);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(130, 28);
            this.BtnConvert.TabIndex = 4;
            this.BtnConvert.Text = "Convert";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // CmdFromLangauge
            // 
            this.CmdFromLangauge.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdFromLangauge.FormattingEnabled = true;
            this.CmdFromLangauge.Location = new System.Drawing.Point(154, 24);
            this.CmdFromLangauge.Name = "CmdFromLangauge";
            this.CmdFromLangauge.Size = new System.Drawing.Size(186, 22);
            this.CmdFromLangauge.TabIndex = 5;
            // 
            // LblFromLanguage
            // 
            this.LblFromLanguage.AutoSize = true;
            this.LblFromLanguage.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFromLanguage.Location = new System.Drawing.Point(105, 32);
            this.LblFromLanguage.Name = "LblFromLanguage";
            this.LblFromLanguage.Size = new System.Drawing.Size(43, 14);
            this.LblFromLanguage.TabIndex = 6;
            this.LblFromLanguage.Text = "From:";
            // 
            // LblToLangauge
            // 
            this.LblToLangauge.AutoSize = true;
            this.LblToLangauge.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblToLangauge.Location = new System.Drawing.Point(412, 32);
            this.LblToLangauge.Name = "LblToLangauge";
            this.LblToLangauge.Size = new System.Drawing.Size(26, 14);
            this.LblToLangauge.TabIndex = 7;
            this.LblToLangauge.Text = "To:";
            // 
            // CmdToLangauge
            // 
            this.CmdToLangauge.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdToLangauge.FormattingEnabled = true;
            this.CmdToLangauge.Location = new System.Drawing.Point(441, 24);
            this.CmdToLangauge.Name = "CmdToLangauge";
            this.CmdToLangauge.Size = new System.Drawing.Size(180, 22);
            this.CmdToLangauge.TabIndex = 8;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 382);
            this.Controls.Add(this.CmdToLangauge);
            this.Controls.Add(this.LblToLangauge);
            this.Controls.Add(this.LblFromLanguage);
            this.Controls.Add(this.CmdFromLangauge);
            this.Controls.Add(this.BtnConvert);
            this.Controls.Add(this.TxtToLangauge);
            this.Controls.Add(this.TxtFromLanguage);
            this.Controls.Add(this.LblToLanguageText);
            this.Controls.Add(this.LblFromLanguageText);
            this.Name = "FrmMain";
            this.Text = "iTranslator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFromLanguageText;
        private System.Windows.Forms.Label LblToLanguageText;
        private System.Windows.Forms.TextBox TxtFromLanguage;
        private System.Windows.Forms.TextBox TxtToLangauge;
        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.ComboBox CmdFromLangauge;
        private System.Windows.Forms.Label LblFromLanguage;
        private System.Windows.Forms.Label LblToLangauge;
        private System.Windows.Forms.ComboBox CmdToLangauge;
    }
}

