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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.LblFromLanguageText = new System.Windows.Forms.Label();
            this.LblToLanguageText = new System.Windows.Forms.Label();
            this.TxtFromLanguage = new System.Windows.Forms.TextBox();
            this.TxtToLangauge = new System.Windows.Forms.TextBox();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.CmdFromLangauge = new System.Windows.Forms.ComboBox();
            this.LblFromLanguage = new System.Windows.Forms.Label();
            this.LblToLangauge = new System.Windows.Forms.Label();
            this.CmdToLangauge = new System.Windows.Forms.ComboBox();
            this.LblProcess = new System.Windows.Forms.Label();
            this.PbxSetting = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFromLanguageText
            // 
            this.LblFromLanguageText.AutoSize = true;
            this.LblFromLanguageText.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFromLanguageText.Location = new System.Drawing.Point(37, 69);
            this.LblFromLanguageText.Name = "LblFromLanguageText";
            this.LblFromLanguageText.Size = new System.Drawing.Size(69, 13);
            this.LblFromLanguageText.TabIndex = 0;
            this.LblFromLanguageText.Text = "From Text:";
            // 
            // LblToLanguageText
            // 
            this.LblToLanguageText.AutoSize = true;
            this.LblToLanguageText.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblToLanguageText.Location = new System.Drawing.Point(37, 236);
            this.LblToLanguageText.Name = "LblToLanguageText";
            this.LblToLanguageText.Size = new System.Drawing.Size(53, 13);
            this.LblToLanguageText.TabIndex = 1;
            this.LblToLanguageText.Text = "To Text:";
            // 
            // TxtFromLanguage
            // 
            this.TxtFromLanguage.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFromLanguage.Location = new System.Drawing.Point(126, 66);
            this.TxtFromLanguage.Multiline = true;
            this.TxtFromLanguage.Name = "TxtFromLanguage";
            this.TxtFromLanguage.Size = new System.Drawing.Size(748, 110);
            this.TxtFromLanguage.TabIndex = 2;
            // 
            // TxtToLangauge
            // 
            this.TxtToLangauge.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtToLangauge.Location = new System.Drawing.Point(126, 236);
            this.TxtToLangauge.Multiline = true;
            this.TxtToLangauge.Name = "TxtToLangauge";
            this.TxtToLangauge.Size = new System.Drawing.Size(748, 112);
            this.TxtToLangauge.TabIndex = 3;
            // 
            // BtnConvert
            // 
            this.BtnConvert.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConvert.Location = new System.Drawing.Point(126, 192);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(108, 28);
            this.BtnConvert.TabIndex = 4;
            this.BtnConvert.Text = "Convert";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // CmdFromLangauge
            // 
            this.CmdFromLangauge.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdFromLangauge.FormattingEnabled = true;
            this.CmdFromLangauge.Location = new System.Drawing.Point(180, 24);
            this.CmdFromLangauge.Name = "CmdFromLangauge";
            this.CmdFromLangauge.Size = new System.Drawing.Size(216, 21);
            this.CmdFromLangauge.TabIndex = 5;
            // 
            // LblFromLanguage
            // 
            this.LblFromLanguage.AutoSize = true;
            this.LblFromLanguage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFromLanguage.Location = new System.Drawing.Point(126, 27);
            this.LblFromLanguage.Name = "LblFromLanguage";
            this.LblFromLanguage.Size = new System.Drawing.Size(41, 13);
            this.LblFromLanguage.TabIndex = 6;
            this.LblFromLanguage.Text = "From:";
            // 
            // LblToLangauge
            // 
            this.LblToLangauge.AutoSize = true;
            this.LblToLangauge.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblToLangauge.Location = new System.Drawing.Point(483, 27);
            this.LblToLangauge.Name = "LblToLangauge";
            this.LblToLangauge.Size = new System.Drawing.Size(25, 13);
            this.LblToLangauge.TabIndex = 7;
            this.LblToLangauge.Text = "To:";
            // 
            // CmdToLangauge
            // 
            this.CmdToLangauge.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdToLangauge.FormattingEnabled = true;
            this.CmdToLangauge.Location = new System.Drawing.Point(514, 24);
            this.CmdToLangauge.Name = "CmdToLangauge";
            this.CmdToLangauge.Size = new System.Drawing.Size(209, 21);
            this.CmdToLangauge.TabIndex = 8;
            // 
            // LblProcess
            // 
            this.LblProcess.AutoSize = true;
            this.LblProcess.Location = new System.Drawing.Point(126, 355);
            this.LblProcess.Name = "LblProcess";
            this.LblProcess.Size = new System.Drawing.Size(0, 13);
            this.LblProcess.TabIndex = 9;
            // 
            // PbxSetting
            // 
            this.PbxSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxSetting.Image = ((System.Drawing.Image)(resources.GetObject("PbxSetting.Image")));
            this.PbxSetting.Location = new System.Drawing.Point(850, 24);
            this.PbxSetting.Name = "PbxSetting";
            this.PbxSetting.Size = new System.Drawing.Size(24, 24);
            this.PbxSetting.TabIndex = 11;
            this.PbxSetting.TabStop = false;
            this.PbxSetting.Click += new System.EventHandler(this.PbxSetting_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 382);
            this.Controls.Add(this.PbxSetting);
            this.Controls.Add(this.LblProcess);
            this.Controls.Add(this.CmdToLangauge);
            this.Controls.Add(this.LblToLangauge);
            this.Controls.Add(this.LblFromLanguage);
            this.Controls.Add(this.CmdFromLangauge);
            this.Controls.Add(this.BtnConvert);
            this.Controls.Add(this.TxtToLangauge);
            this.Controls.Add(this.TxtFromLanguage);
            this.Controls.Add(this.LblToLanguageText);
            this.Controls.Add(this.LblFromLanguageText);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iTranslator";
            ((System.ComponentModel.ISupportInitialize)(this.PbxSetting)).EndInit();
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
        private System.Windows.Forms.Label LblProcess;
        private System.Windows.Forms.PictureBox PbxSetting;
    }
}

