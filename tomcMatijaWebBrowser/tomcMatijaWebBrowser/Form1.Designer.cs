namespace tomcMatijaWebBrowser
{
    partial class Form1
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
            this.btnNatrag = new System.Windows.Forms.Button();
            this.BtnNaprijed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.btnIdi = new System.Windows.Forms.Button();
            this.BtnGmail = new System.Windows.Forms.Button();
            this.btnWebmail = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(13, 13);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 23);
            this.btnNatrag.TabIndex = 0;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // BtnNaprijed
            // 
            this.BtnNaprijed.Location = new System.Drawing.Point(95, 13);
            this.BtnNaprijed.Name = "BtnNaprijed";
            this.BtnNaprijed.Size = new System.Drawing.Size(75, 23);
            this.BtnNaprijed.TabIndex = 1;
            this.BtnNaprijed.Text = "Naprijed";
            this.BtnNaprijed.UseVisualStyleBackColor = true;
            this.BtnNaprijed.Click += new System.EventHandler(this.BtnNaprijed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adresa:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(225, 15);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(224, 20);
            this.txtAdresa.TabIndex = 3;
            // 
            // btnIdi
            // 
            this.btnIdi.Location = new System.Drawing.Point(455, 13);
            this.btnIdi.Name = "btnIdi";
            this.btnIdi.Size = new System.Drawing.Size(75, 23);
            this.btnIdi.TabIndex = 4;
            this.btnIdi.Text = "Idi";
            this.btnIdi.UseVisualStyleBackColor = true;
            this.btnIdi.Click += new System.EventHandler(this.btnIdi_Click);
            // 
            // BtnGmail
            // 
            this.BtnGmail.Location = new System.Drawing.Point(551, 13);
            this.BtnGmail.Name = "BtnGmail";
            this.BtnGmail.Size = new System.Drawing.Size(75, 23);
            this.BtnGmail.TabIndex = 5;
            this.BtnGmail.Text = "Gmail";
            this.BtnGmail.UseVisualStyleBackColor = true;
            this.BtnGmail.Click += new System.EventHandler(this.BtnGmail_Click);
            // 
            // btnWebmail
            // 
            this.btnWebmail.Location = new System.Drawing.Point(632, 13);
            this.btnWebmail.Name = "btnWebmail";
            this.btnWebmail.Size = new System.Drawing.Size(75, 23);
            this.btnWebmail.TabIndex = 6;
            this.btnWebmail.Text = "Webmail";
            this.btnWebmail.UseVisualStyleBackColor = true;
            this.btnWebmail.Click += new System.EventHandler(this.btnWebmail_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(713, 13);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 23);
            this.btnIspis.TabIndex = 7;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(-1, 42);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(965, 484);
            this.webBrowser.TabIndex = 8;
            this.webBrowser.Url = new System.Uri("http://web2.ss-zcrnje-rovinj.skole.hr/", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 524);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnWebmail);
            this.Controls.Add(this.BtnGmail);
            this.Controls.Add(this.btnIdi);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNaprijed);
            this.Controls.Add(this.btnNatrag);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "WebBrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button BtnNaprijed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Button btnIdi;
        private System.Windows.Forms.Button BtnGmail;
        private System.Windows.Forms.Button btnWebmail;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

