namespace Som_Bank
{
    partial class Withdraw
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
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.withdrawBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountXT = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addressXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fullnameXT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sach = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.accountXT = new System.Windows.Forms.TextBox();
            this.descriptionXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label5.Location = new System.Drawing.Point(73, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(352, 49);
            this.label5.TabIndex = 140;
            this.label5.Text = "Make A withdraw";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.descriptionXT);
            this.groupBox2.Controls.Add(this.withdrawBTN);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.AmountXT);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.groupBox2.Location = new System.Drawing.Point(48, 511);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 239);
            this.groupBox2.TabIndex = 141;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deposite Amount";
            // 
            // withdrawBTN
            // 
            this.withdrawBTN.BackColor = System.Drawing.Color.Transparent;
            this.withdrawBTN.BackgroundImage = global::Som_Bank.Properties.Resources.button1;
            this.withdrawBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.withdrawBTN.FlatAppearance.BorderSize = 0;
            this.withdrawBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.withdrawBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.withdrawBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdrawBTN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.withdrawBTN.Location = new System.Drawing.Point(214, 173);
            this.withdrawBTN.Name = "withdrawBTN";
            this.withdrawBTN.Size = new System.Drawing.Size(163, 60);
            this.withdrawBTN.TabIndex = 145;
            this.withdrawBTN.Text = "Withdraw";
            this.withdrawBTN.UseVisualStyleBackColor = false;
            this.withdrawBTN.Click += new System.EventHandler(this.withdrawBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(62, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 33);
            this.label1.TabIndex = 118;
            this.label1.Text = "Withdraw Amount:";
            // 
            // AmountXT
            // 
            this.AmountXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.AmountXT.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountXT.Location = new System.Drawing.Point(299, 34);
            this.AmountXT.Name = "AmountXT";
            this.AmountXT.Size = new System.Drawing.Size(197, 39);
            this.AmountXT.TabIndex = 117;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.addressXT);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.PhoneXT);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.fullnameXT);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.groupBox3.Location = new System.Drawing.Point(745, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(816, 385);
            this.groupBox3.TabIndex = 142;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(326, 35);
            this.label7.TabIndex = 123;
            this.label7.Text = "Customer Personal Info:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(138, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 32);
            this.label4.TabIndex = 122;
            this.label4.Text = "Address:";
            // 
            // addressXT
            // 
            this.addressXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.addressXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressXT.Location = new System.Drawing.Point(279, 282);
            this.addressXT.Name = "addressXT";
            this.addressXT.ReadOnly = true;
            this.addressXT.Size = new System.Drawing.Size(393, 38);
            this.addressXT.TabIndex = 121;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label3.Location = new System.Drawing.Point(159, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 32);
            this.label3.TabIndex = 120;
            this.label3.Text = "Phone:";
            // 
            // PhoneXT
            // 
            this.PhoneXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.PhoneXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneXT.Location = new System.Drawing.Point(279, 199);
            this.PhoneXT.Name = "PhoneXT";
            this.PhoneXT.ReadOnly = true;
            this.PhoneXT.Size = new System.Drawing.Size(393, 38);
            this.PhoneXT.TabIndex = 119;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(113, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 32);
            this.label2.TabIndex = 118;
            this.label2.Text = "Full Name:";
            // 
            // fullnameXT
            // 
            this.fullnameXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.fullnameXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameXT.Location = new System.Drawing.Point(279, 118);
            this.fullnameXT.Name = "fullnameXT";
            this.fullnameXT.ReadOnly = true;
            this.fullnameXT.Size = new System.Drawing.Size(393, 38);
            this.fullnameXT.TabIndex = 117;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Sach);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.accountXT);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.groupBox1.Location = new System.Drawing.Point(37, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 237);
            this.groupBox1.TabIndex = 143;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search For Accounts";
            // 
            // Sach
            // 
            this.Sach.BackColor = System.Drawing.Color.Transparent;
            this.Sach.BackgroundImage = global::Som_Bank.Properties.Resources.button1;
            this.Sach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sach.FlatAppearance.BorderSize = 0;
            this.Sach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Sach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.Sach.Location = new System.Drawing.Point(494, 104);
            this.Sach.Name = "Sach";
            this.Sach.Size = new System.Drawing.Size(111, 39);
            this.Sach.TabIndex = 140;
            this.Sach.Text = "Search";
            this.Sach.UseVisualStyleBackColor = false;
            this.Sach.Click += new System.EventHandler(this.Sach_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 26);
            this.label6.TabIndex = 118;
            this.label6.Text = "Account Number:";
            // 
            // accountXT
            // 
            this.accountXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.accountXT.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountXT.Location = new System.Drawing.Point(213, 104);
            this.accountXT.Name = "accountXT";
            this.accountXT.Size = new System.Drawing.Size(275, 39);
            this.accountXT.TabIndex = 117;
            // 
            // descriptionXT
            // 
            this.descriptionXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.descriptionXT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionXT.Location = new System.Drawing.Point(299, 79);
            this.descriptionXT.Multiline = true;
            this.descriptionXT.Name = "descriptionXT";
            this.descriptionXT.Size = new System.Drawing.Size(197, 71);
            this.descriptionXT.TabIndex = 146;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label8.Location = new System.Drawing.Point(135, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 33);
            this.label8.TabIndex = 147;
            this.label8.Text = "Description:";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1775, 808);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button withdrawBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AmountXT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PhoneXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullnameXT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Sach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox accountXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox descriptionXT;
    }
}