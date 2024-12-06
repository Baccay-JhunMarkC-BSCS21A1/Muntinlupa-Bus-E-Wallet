namespace Muntinlupa_Bus_E_Wallet
{
    partial class frmReloadAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReloadAccount));
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.txtReloadAmount = new System.Windows.Forms.TextBox();
            this.btnReloadCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAccountID
            // 
            this.txtAccountID.Location = new System.Drawing.Point(299, 162);
            this.txtAccountID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.Size = new System.Drawing.Size(263, 20);
            this.txtAccountID.TabIndex = 1;
            this.txtAccountID.TextChanged += new System.EventHandler(this.txtAccountID_TextChanged);
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentBalance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCurrentBalance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalance.ForeColor = System.Drawing.Color.White;
            this.lblCurrentBalance.Location = new System.Drawing.Point(296, 216);
            this.lblCurrentBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(45, 22);
            this.lblCurrentBalance.TabIndex = 2;
            this.lblCurrentBalance.Text = "0.00";
            this.lblCurrentBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCurrentBalance.Click += new System.EventHandler(this.lblCurrentBalance_Click);
            // 
            // btnReload
            // 
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnReload.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(352, 315);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(106, 25);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "Confirm Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtReloadAmount
            // 
            this.txtReloadAmount.Location = new System.Drawing.Point(299, 271);
            this.txtReloadAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReloadAmount.Name = "txtReloadAmount";
            this.txtReloadAmount.Size = new System.Drawing.Size(238, 20);
            this.txtReloadAmount.TabIndex = 7;
            this.txtReloadAmount.TextChanged += new System.EventHandler(this.txtReloadAmount_TextChanged);
            // 
            // btnReloadCancel
            // 
            this.btnReloadCancel.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnReloadCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReloadCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReloadCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnReloadCancel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnReloadCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnReloadCancel.Image")));
            this.btnReloadCancel.Location = new System.Drawing.Point(463, 314);
            this.btnReloadCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReloadCancel.Name = "btnReloadCancel";
            this.btnReloadCancel.Size = new System.Drawing.Size(74, 25);
            this.btnReloadCancel.TabIndex = 8;
            this.btnReloadCancel.Text = "Cancel";
            this.btnReloadCancel.UseVisualStyleBackColor = false;
            this.btnReloadCancel.Click += new System.EventHandler(this.btnReloadCancel_Click);
            // 
            // frmReloadAccount
            // 
            this.AccessibleDescription = "Allows the admin to add balance to an existing account.";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(835, 432);
            this.Controls.Add(this.btnReloadCancel);
            this.Controls.Add(this.txtReloadAmount);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.lblCurrentBalance);
            this.Controls.Add(this.txtAccountID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmReloadAccount";
            this.Text = "ReloadAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.TextBox txtReloadAmount;
        private System.Windows.Forms.Button btnReloadCancel;
    }
}