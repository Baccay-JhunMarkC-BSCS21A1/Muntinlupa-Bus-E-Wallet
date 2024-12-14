namespace Muntinlupa_Bus_E_Wallet
{
    partial class frmCardTap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCardTap));
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.lblActionType = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTap = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtCardID
            // 
            this.txtCardID.Location = new System.Drawing.Point(278, 160);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(297, 20);
            this.txtCardID.TabIndex = 0;
            // 
            // lblActionType
            // 
            this.lblActionType.AutoSize = true;
            this.lblActionType.BackColor = System.Drawing.Color.Transparent;
            this.lblActionType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActionType.ForeColor = System.Drawing.SystemColors.Control;
            this.lblActionType.Location = new System.Drawing.Point(275, 204);
            this.lblActionType.Name = "lblActionType";
            this.lblActionType.Size = new System.Drawing.Size(108, 22);
            this.lblActionType.TabIndex = 2;
            this.lblActionType.Text = "Action Type";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(509, 308);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 31);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Log Out";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnTap
            // 
            this.btnTap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnTap.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTap.Image = ((System.Drawing.Image)(resources.GetObject("btnTap.Image")));
            this.btnTap.Location = new System.Drawing.Point(348, 308);
            this.btnTap.Name = "btnTap";
            this.btnTap.Size = new System.Drawing.Size(155, 31);
            this.btnTap.TabIndex = 7;
            this.btnTap.Text = "Process the Tap";
            this.btnTap.UseVisualStyleBackColor = true;
            this.btnTap.Click += new System.EventHandler(this.btnTap_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.FormattingEnabled = true;
            this.txtLocation.Items.AddRange(new object[] {
            "Cupang",
            "Alabang",
            "Bayanan",
            "Putatan",
            "Poblacion",
            "Tunasan"});
            this.txtLocation.Location = new System.Drawing.Point(279, 246);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(296, 21);
            this.txtLocation.TabIndex = 9;
            // 
            // frmCardTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(835, 432);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTap);
            this.Controls.Add(this.lblActionType);
            this.Controls.Add(this.txtCardID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCardTap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CardTap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.Label lblActionType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTap;
        private System.Windows.Forms.ComboBox txtLocation;
    }
}