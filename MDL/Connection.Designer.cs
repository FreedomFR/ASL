namespace MDL
{
    partial class Connection
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
            this.label15 = new System.Windows.Forms.Label();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbMdp = new System.Windows.Forms.TextBox();
            this.btnValiderConnection = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMailInscription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMdpInscription = new System.Windows.Forms.TextBox();
            this.btnValiderInscription = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNomInscription = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label15.Location = new System.Drawing.Point(268, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Mail :";
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(329, 110);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(213, 20);
            this.txbMail.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label13.Location = new System.Drawing.Point(203, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Mot de passe :";
            // 
            // txbMdp
            // 
            this.txbMdp.Location = new System.Drawing.Point(329, 150);
            this.txbMdp.Name = "txbMdp";
            this.txbMdp.Size = new System.Drawing.Size(214, 20);
            this.txbMdp.TabIndex = 9;
            // 
            // btnValiderConnection
            // 
            this.btnValiderConnection.Location = new System.Drawing.Point(329, 193);
            this.btnValiderConnection.Name = "btnValiderConnection";
            this.btnValiderConnection.Size = new System.Drawing.Size(213, 27);
            this.btnValiderConnection.TabIndex = 16;
            this.btnValiderConnection.Text = "Valider";
            this.btnValiderConnection.UseVisualStyleBackColor = true;
            this.btnValiderConnection.Click += new System.EventHandler(this.btnValiderConnection_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-4, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 460);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txbMail);
            this.tabPage1.Controls.Add(this.txbMdp);
            this.tabPage1.Controls.Add(this.btnValiderConnection);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(804, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txbNomInscription);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnValiderInscription);
            this.tabPage2.Controls.Add(this.txbMdpInscription);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txbMailInscription);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(804, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inscription";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(295, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mail :";
            // 
            // txbMailInscription
            // 
            this.txbMailInscription.Location = new System.Drawing.Point(351, 167);
            this.txbMailInscription.Name = "txbMailInscription";
            this.txbMailInscription.Size = new System.Drawing.Size(213, 20);
            this.txbMailInscription.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(225, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mot de passe :";
            // 
            // txbMdpInscription
            // 
            this.txbMdpInscription.Location = new System.Drawing.Point(351, 209);
            this.txbMdpInscription.Name = "txbMdpInscription";
            this.txbMdpInscription.Size = new System.Drawing.Size(213, 20);
            this.txbMdpInscription.TabIndex = 10;
            // 
            // btnValiderInscription
            // 
            this.btnValiderInscription.Location = new System.Drawing.Point(351, 251);
            this.btnValiderInscription.Name = "btnValiderInscription";
            this.btnValiderInscription.Size = new System.Drawing.Size(213, 27);
            this.btnValiderInscription.TabIndex = 17;
            this.btnValiderInscription.Text = "Valider";
            this.btnValiderInscription.UseVisualStyleBackColor = true;
            this.btnValiderInscription.Click += new System.EventHandler(this.btnValiderInscription_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(295, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nom :";
            // 
            // txbNomInscription
            // 
            this.txbNomInscription.Location = new System.Drawing.Point(351, 125);
            this.txbNomInscription.Name = "txbNomInscription";
            this.txbNomInscription.Size = new System.Drawing.Size(213, 20);
            this.txbNomInscription.TabIndex = 19;
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Connection";
            this.Text = "Connection";
            this.Load += new System.EventHandler(this.Connection_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbMdp;
        private System.Windows.Forms.Button btnValiderConnection;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txbNomInscription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnValiderInscription;
        private System.Windows.Forms.TextBox txbMdpInscription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMailInscription;
        private System.Windows.Forms.Label label1;
    }
}