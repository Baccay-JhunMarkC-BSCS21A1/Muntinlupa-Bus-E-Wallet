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
            this.accmanage = new System.Windows.Forms.Button();
            this.reloadacc = new System.Windows.Forms.Button();
            this.routemanage = new System.Windows.Forms.Button();
            this.cardexpi = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accmanage
            // 
            this.accmanage.Location = new System.Drawing.Point(25, 35);
            this.accmanage.Name = "accmanage";
            this.accmanage.Size = new System.Drawing.Size(267, 70);
            this.accmanage.TabIndex = 0;
            this.accmanage.Text = "Account Management";
            this.accmanage.UseVisualStyleBackColor = true;
            this.accmanage.Click += new System.EventHandler(this.button1_Click);
            // 
            // reloadacc
            // 
            this.reloadacc.Location = new System.Drawing.Point(25, 111);
            this.reloadacc.Name = "reloadacc";
            this.reloadacc.Size = new System.Drawing.Size(267, 70);
            this.reloadacc.TabIndex = 1;
            this.reloadacc.Text = "Reload Account";
            this.reloadacc.UseVisualStyleBackColor = true;
            // 
            // routemanage
            // 
            this.routemanage.Location = new System.Drawing.Point(25, 263);
            this.routemanage.Name = "routemanage";
            this.routemanage.Size = new System.Drawing.Size(267, 70);
            this.routemanage.TabIndex = 2;
            this.routemanage.Text = "Route Management";
            this.routemanage.UseVisualStyleBackColor = true;
            // 
            // cardexpi
            // 
            this.cardexpi.Location = new System.Drawing.Point(25, 187);
            this.cardexpi.Name = "cardexpi";
            this.cardexpi.Size = new System.Drawing.Size(267, 70);
            this.cardexpi.TabIndex = 3;
            this.cardexpi.Text = "Card Expiration and Renewal";
            this.cardexpi.UseVisualStyleBackColor = true;
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(25, 339);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(267, 70);
            this.history.TabIndex = 4;
            this.history.Text = "History";
            this.history.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(827, 589);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(161, 70);
            this.exit.TabIndex = 5;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.history);
            this.Controls.Add(this.cardexpi);
            this.Controls.Add(this.routemanage);
            this.Controls.Add(this.reloadacc);
            this.Controls.Add(this.accmanage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminDashboard";
            this.Text = "dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button accmanage;
        private System.Windows.Forms.Button reloadacc;
        private System.Windows.Forms.Button routemanage;
        private System.Windows.Forms.Button cardexpi;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.Button exit;
    }
}