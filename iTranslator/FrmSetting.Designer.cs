namespace iTranslator
{
    partial class FrmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetting));
            this.LblInformation = new System.Windows.Forms.Label();
            this.LblGoogleApiUrl = new System.Windows.Forms.Label();
            this.TxtGoogleApiUrl = new System.Windows.Forms.TextBox();
            this.LblGoogleApiKey = new System.Windows.Forms.Label();
            this.TxtGoogleApiKey = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblInformation
            // 
            this.LblInformation.AutoSize = true;
            this.LblInformation.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInformation.Location = new System.Drawing.Point(13, 13);
            this.LblInformation.Name = "LblInformation";
            this.LblInformation.Size = new System.Drawing.Size(299, 13);
            this.LblInformation.TabIndex = 0;
            this.LblInformation.Text = "Before adding please activate google translator api";
            // 
            // LblGoogleApiUrl
            // 
            this.LblGoogleApiUrl.AutoSize = true;
            this.LblGoogleApiUrl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGoogleApiUrl.Location = new System.Drawing.Point(31, 54);
            this.LblGoogleApiUrl.Name = "LblGoogleApiUrl";
            this.LblGoogleApiUrl.Size = new System.Drawing.Size(60, 13);
            this.LblGoogleApiUrl.TabIndex = 1;
            this.LblGoogleApiUrl.Text = "Base Url:";
            // 
            // TxtGoogleApiUrl
            // 
            this.TxtGoogleApiUrl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGoogleApiUrl.Location = new System.Drawing.Point(92, 51);
            this.TxtGoogleApiUrl.Name = "TxtGoogleApiUrl";
            this.TxtGoogleApiUrl.Size = new System.Drawing.Size(346, 21);
            this.TxtGoogleApiUrl.TabIndex = 2;
            // 
            // LblGoogleApiKey
            // 
            this.LblGoogleApiKey.AutoSize = true;
            this.LblGoogleApiKey.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGoogleApiKey.Location = new System.Drawing.Point(35, 90);
            this.LblGoogleApiKey.Name = "LblGoogleApiKey";
            this.LblGoogleApiKey.Size = new System.Drawing.Size(56, 13);
            this.LblGoogleApiKey.TabIndex = 3;
            this.LblGoogleApiKey.Text = "Api Key:";
            // 
            // TxtGoogleApiKey
            // 
            this.TxtGoogleApiKey.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGoogleApiKey.Location = new System.Drawing.Point(92, 87);
            this.TxtGoogleApiKey.Name = "TxtGoogleApiKey";
            this.TxtGoogleApiKey.Size = new System.Drawing.Size(346, 21);
            this.TxtGoogleApiKey.TabIndex = 4;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(282, 129);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(363, 129);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 160);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtGoogleApiKey);
            this.Controls.Add(this.LblGoogleApiKey);
            this.Controls.Add(this.TxtGoogleApiUrl);
            this.Controls.Add(this.LblGoogleApiUrl);
            this.Controls.Add(this.LblInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInformation;
        private System.Windows.Forms.Label LblGoogleApiUrl;
        private System.Windows.Forms.TextBox TxtGoogleApiUrl;
        private System.Windows.Forms.Label LblGoogleApiKey;
        private System.Windows.Forms.TextBox TxtGoogleApiKey;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
    }
}