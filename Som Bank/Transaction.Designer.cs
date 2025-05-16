namespace Som_Bank
{
    partial class Transaction
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
            this.label2 = new System.Windows.Forms.Label();
            this.searchXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.dateXT = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.typeXT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rpt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(427, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 33);
            this.label2.TabIndex = 117;
            this.label2.Text = "Account Number:";
            // 
            // searchXT
            // 
            this.searchXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.searchXT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchXT.Location = new System.Drawing.Point(658, 140);
            this.searchXT.Name = "searchXT";
            this.searchXT.Size = new System.Drawing.Size(181, 30);
            this.searchXT.TabIndex = 116;
            this.searchXT.Tag = "search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(768, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 45);
            this.label1.TabIndex = 115;
            this.label1.Text = "Transactions";
            // 
            // Table
            // 
            this.Table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.GridColor = System.Drawing.Color.White;
            this.Table.Location = new System.Drawing.Point(23, 183);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 51;
            this.Table.RowTemplate.Height = 24;
            this.Table.Size = new System.Drawing.Size(1691, 686);
            this.Table.TabIndex = 114;
            this.Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label9.Location = new System.Drawing.Point(872, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 26);
            this.label9.TabIndex = 125;
            this.label9.Text = "From:";
            // 
            // dateXT
            // 
            this.dateXT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateXT.Location = new System.Drawing.Point(947, 142);
            this.dateXT.Name = "dateXT";
            this.dateXT.Size = new System.Drawing.Size(275, 27);
            this.dateXT.TabIndex = 124;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label12.Location = new System.Drawing.Point(18, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 26);
            this.label12.TabIndex = 133;
            this.label12.Text = "Transaction Type:";
            // 
            // typeXT
            // 
            this.typeXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.typeXT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeXT.FormattingEnabled = true;
            this.typeXT.Items.AddRange(new object[] {
            "All",
            "Withdrawals",
            "Deposits",
            "Transfers"});
            this.typeXT.Location = new System.Drawing.Point(212, 141);
            this.typeXT.Name = "typeXT";
            this.typeXT.Size = new System.Drawing.Size(185, 30);
            this.typeXT.TabIndex = 132;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label3.Location = new System.Drawing.Point(1228, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 26);
            this.label3.TabIndex = 135;
            this.label3.Text = "To:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1285, 143);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(270, 27);
            this.dateTimePicker1.TabIndex = 134;
            // 
            // rpt
            // 
            this.rpt.BackColor = System.Drawing.Color.Transparent;
            this.rpt.BackgroundImage = global::Som_Bank.Properties.Resources.button1;
            this.rpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rpt.FlatAppearance.BorderSize = 0;
            this.rpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rpt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rpt.Location = new System.Drawing.Point(1611, 134);
            this.rpt.Name = "rpt";
            this.rpt.Size = new System.Drawing.Size(103, 39);
            this.rpt.TabIndex = 146;
            this.rpt.Text = "Report";
            this.rpt.UseVisualStyleBackColor = false;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1775, 808);
            this.Controls.Add(this.rpt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.typeXT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Table);
            this.Name = "Transaction";
            this.Text = "Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateXT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox typeXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button rpt;
    }
}