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
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnTap = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCardID
            // 
            this.txtCardID.Location = new System.Drawing.Point(34, 45);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(204, 20);
            this.txtCardID.TabIndex = 0;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(34, 83);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(204, 20);
            this.txtLocation.TabIndex = 1;
            // 
            // btnTap
            // 
            this.btnTap.Location = new System.Drawing.Point(46, 164);
            this.btnTap.Name = "btnTap";
            this.btnTap.Size = new System.Drawing.Size(103, 46);
            this.btnTap.TabIndex = 2;
            this.btnTap.Text = "Process the Tap";
            this.btnTap.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(155, 164);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 46);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel the Operation";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmCardTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 393);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTap);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtCardID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCardTap";
            this.Text = "frmCardTap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnTap;
        private System.Windows.Forms.Button btnCancel;
    }
}