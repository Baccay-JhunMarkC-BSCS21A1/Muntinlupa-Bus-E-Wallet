namespace Muntinlupa_Bus_E_Wallet
{
    partial class frmAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAccountManagement = new System.Windows.Forms.Label();
            this.lblRouteManagement = new System.Windows.Forms.Label();
            this.lblCardExpirationHistory = new System.Windows.Forms.Label();
            this.lblReloadAccount = new System.Windows.Forms.Label();
            this.lblHistory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(550, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 31);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit the System";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAccountManagement
            // 
            this.lblAccountManagement.AutoSize = true;
            this.lblAccountManagement.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAccountManagement.Font = new System.Drawing.Font("Times New Roman", 12.6F, System.Drawing.FontStyle.Bold);
            this.lblAccountManagement.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAccountManagement.Location = new System.Drawing.Point(179, 184);
            this.lblAccountManagement.Name = "lblAccountManagement";
            this.lblAccountManagement.Size = new System.Drawing.Size(168, 19);
            this.lblAccountManagement.TabIndex = 8;
            this.lblAccountManagement.Text = "Account Management";
            this.lblAccountManagement.Click += new System.EventHandler(this.lblAccountManagement_Click);
            // 
            // lblRouteManagement
            // 
            this.lblRouteManagement.AutoSize = true;
            this.lblRouteManagement.BackColor = System.Drawing.Color.Transparent;
            this.lblRouteManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblRouteManagement.Font = new System.Drawing.Font("Times New Roman", 12.6F, System.Drawing.FontStyle.Bold);
            this.lblRouteManagement.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRouteManagement.Location = new System.Drawing.Point(178, 275);
            this.lblRouteManagement.Name = "lblRouteManagement";
            this.lblRouteManagement.Size = new System.Drawing.Size(152, 19);
            this.lblRouteManagement.TabIndex = 10;
            this.lblRouteManagement.Text = "Route Management";
            // 
            // lblCardExpirationHistory
            // 
            this.lblCardExpirationHistory.AutoSize = true;
            this.lblCardExpirationHistory.BackColor = System.Drawing.Color.Transparent;
            this.lblCardExpirationHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCardExpirationHistory.Font = new System.Drawing.Font("Times New Roman", 12.6F, System.Drawing.FontStyle.Bold);
            this.lblCardExpirationHistory.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCardExpirationHistory.Location = new System.Drawing.Point(475, 201);
            this.lblCardExpirationHistory.Name = "lblCardExpirationHistory";
            this.lblCardExpirationHistory.Size = new System.Drawing.Size(191, 19);
            this.lblCardExpirationHistory.TabIndex = 11;
            this.lblCardExpirationHistory.Text = "Card Expiration History";
            this.lblCardExpirationHistory.Click += new System.EventHandler(this.lblCardExpirationHistory_Click);
            // 
            // lblReloadAccount
            // 
            this.lblReloadAccount.AutoSize = true;
            this.lblReloadAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblReloadAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblReloadAccount.Font = new System.Drawing.Font("Times New Roman", 12.6F, System.Drawing.FontStyle.Bold);
            this.lblReloadAccount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReloadAccount.Location = new System.Drawing.Point(179, 226);
            this.lblReloadAccount.Name = "lblReloadAccount";
            this.lblReloadAccount.Size = new System.Drawing.Size(124, 19);
            this.lblReloadAccount.TabIndex = 13;
            this.lblReloadAccount.Text = "Reload Account";
            this.lblReloadAccount.Click += new System.EventHandler(this.lblReloadAccount_Click);
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.BackColor = System.Drawing.Color.Transparent;
            this.lblHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHistory.Font = new System.Drawing.Font("Times New Roman", 12.6F, System.Drawing.FontStyle.Bold);
            this.lblHistory.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHistory.Location = new System.Drawing.Point(475, 251);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(66, 19);
            this.lblHistory.TabIndex = 14;
            this.lblHistory.Text = "History";
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(835, 432);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.lblReloadAccount);
            this.Controls.Add(this.lblCardExpirationHistory);
            this.Controls.Add(this.lblRouteManagement);
            this.Controls.Add(this.lblAccountManagement);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAccountManagement;
        private System.Windows.Forms.Label lblRouteManagement;
        private System.Windows.Forms.Label lblCardExpirationHistory;
        private System.Windows.Forms.Label lblReloadAccount;
        private System.Windows.Forms.Label lblHistory;
    }
}