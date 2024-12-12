namespace Muntinlupa_Bus_E_Wallet
{
    partial class Route_FareManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Route_FareManagementForm));
            this.cmbPickupPoint = new System.Windows.Forms.ComboBox();
            this.cmbDropOffPoint = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveRoute = new System.Windows.Forms.Button();
            this.lblFare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbPickupPoint
            // 
            this.cmbPickupPoint.FormattingEnabled = true;
            this.cmbPickupPoint.Location = new System.Drawing.Point(282, 164);
            this.cmbPickupPoint.Name = "cmbPickupPoint";
            this.cmbPickupPoint.Size = new System.Drawing.Size(254, 21);
            this.cmbPickupPoint.TabIndex = 0;
            // 
            // cmbDropOffPoint
            // 
            this.cmbDropOffPoint.FormattingEnabled = true;
            this.cmbDropOffPoint.Location = new System.Drawing.Point(282, 220);
            this.cmbDropOffPoint.Name = "cmbDropOffPoint";
            this.cmbDropOffPoint.Size = new System.Drawing.Size(254, 21);
            this.cmbDropOffPoint.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(515, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 31);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSaveRoute
            // 
            this.btnSaveRoute.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSaveRoute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveRoute.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveRoute.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSaveRoute.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveRoute.Image")));
            this.btnSaveRoute.Location = new System.Drawing.Point(354, 309);
            this.btnSaveRoute.Name = "btnSaveRoute";
            this.btnSaveRoute.Size = new System.Drawing.Size(155, 31);
            this.btnSaveRoute.TabIndex = 7;
            this.btnSaveRoute.Text = "Save Route Details";
            this.btnSaveRoute.UseVisualStyleBackColor = false;
            // 
            // lblFare
            // 
            this.lblFare.AutoSize = true;
            this.lblFare.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFare.Location = new System.Drawing.Point(278, 267);
            this.lblFare.Name = "lblFare";
            this.lblFare.Size = new System.Drawing.Size(46, 21);
            this.lblFare.TabIndex = 9;
            this.lblFare.Text = "Fare";
            // 
            // Route_FareManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(835, 432);
            this.Controls.Add(this.lblFare);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveRoute);
            this.Controls.Add(this.cmbDropOffPoint);
            this.Controls.Add(this.cmbPickupPoint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Route_FareManagementForm";
            this.Text = "Route_FareManagementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPickupPoint;
        private System.Windows.Forms.ComboBox cmbDropOffPoint;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveRoute;
        private System.Windows.Forms.Label lblFare;
    }
}