namespace Asm2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCustomerName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cboTypeOfCustomer = new ComboBox();
            txtNumberOfPeople = new TextBox();
            txtLastMonthWaterMeter = new TextBox();
            txtThisMonthWaterMeter = new TextBox();
            label5 = new Label();
            bntCaltulator = new Button();
            lvWaterBill = new ListView();
            txtSearch = new TextBox();
            label6 = new Label();
            bntSortByName = new Button();
            label7 = new Label();
            bntSortByNameZA = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(118, 79);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 0;
            label1.Text = "Customer Name ";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(64, 113);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(259, 27);
            txtCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(107, 156);
            label2.Name = "label2";
            label2.Size = new Size(161, 25);
            label2.TabIndex = 2;
            label2.Text = "Type Of Customer ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SteelBlue;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(107, 234);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 3;
            label3.Text = "Number Of people  ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SteelBlue;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(96, 318);
            label4.Name = "label4";
            label4.Size = new Size(209, 25);
            label4.TabIndex = 4;
            label4.Text = "Last Month water meter :";
            // 
            // cboTypeOfCustomer
            // 
            cboTypeOfCustomer.FormattingEnabled = true;
            cboTypeOfCustomer.Location = new Point(64, 194);
            cboTypeOfCustomer.Name = "cboTypeOfCustomer";
            cboTypeOfCustomer.Size = new Size(259, 28);
            cboTypeOfCustomer.TabIndex = 5;
            cboTypeOfCustomer.SelectedIndexChanged += cboTypeOfCustomer_SelectedIndexChanged;
            // 
            // txtNumberOfPeople
            // 
            txtNumberOfPeople.Enabled = false;
            txtNumberOfPeople.Location = new Point(64, 274);
            txtNumberOfPeople.Name = "txtNumberOfPeople";
            txtNumberOfPeople.Size = new Size(259, 27);
            txtNumberOfPeople.TabIndex = 6;
            // 
            // txtLastMonthWaterMeter
            // 
            txtLastMonthWaterMeter.Location = new Point(64, 346);
            txtLastMonthWaterMeter.Name = "txtLastMonthWaterMeter";
            txtLastMonthWaterMeter.Size = new Size(259, 27);
            txtLastMonthWaterMeter.TabIndex = 7;
            // 
            // txtThisMonthWaterMeter
            // 
            txtThisMonthWaterMeter.Location = new Point(64, 425);
            txtThisMonthWaterMeter.Name = "txtThisMonthWaterMeter";
            txtThisMonthWaterMeter.Size = new Size(259, 27);
            txtThisMonthWaterMeter.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SteelBlue;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(96, 388);
            label5.Name = "label5";
            label5.Size = new Size(209, 25);
            label5.TabIndex = 9;
            label5.Text = "This Month water meter :";
            // 
            // bntCaltulator
            // 
            bntCaltulator.BackColor = Color.SteelBlue;
            bntCaltulator.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntCaltulator.ForeColor = SystemColors.ButtonHighlight;
            bntCaltulator.Location = new Point(214, 478);
            bntCaltulator.Name = "bntCaltulator";
            bntCaltulator.Padding = new Padding(1, 0, 0, 0);
            bntCaltulator.Size = new Size(109, 52);
            bntCaltulator.TabIndex = 10;
            bntCaltulator.Text = "Caltulator";
            bntCaltulator.UseCompatibleTextRendering = true;
            bntCaltulator.UseVisualStyleBackColor = false;
            bntCaltulator.Click += bntCaltulator_Click;
            // 
            // lvWaterBill
            // 
            lvWaterBill.FullRowSelect = true;
            lvWaterBill.GridLines = true;
            lvWaterBill.Location = new Point(475, 113);
            lvWaterBill.Name = "lvWaterBill";
            lvWaterBill.Size = new Size(524, 287);
            lvWaterBill.TabIndex = 11;
            lvWaterBill.UseCompatibleStateImageBehavior = false;
            lvWaterBill.SelectedIndexChanged += lvWaterBill_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(628, 79);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(255, 27);
            txtSearch.TabIndex = 12;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SteelBlue;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(530, 81);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 13;
            label6.Text = "Search : ";
            // 
            // bntSortByName
            // 
            bntSortByName.BackColor = Color.SteelBlue;
            bntSortByName.ForeColor = SystemColors.ButtonHighlight;
            bntSortByName.Location = new Point(484, 442);
            bntSortByName.Name = "bntSortByName";
            bntSortByName.Size = new Size(102, 37);
            bntSortByName.TabIndex = 14;
            bntSortByName.Text = "From A to Z.";
            bntSortByName.UseVisualStyleBackColor = false;
            bntSortByName.Click += bntSortByName_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.SteelBlue;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(475, 419);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 15;
            label7.Text = "Sort By Name : ";
            // 
            // bntSortByNameZA
            // 
            bntSortByNameZA.BackColor = Color.SteelBlue;
            bntSortByNameZA.ForeColor = SystemColors.ButtonHighlight;
            bntSortByNameZA.Location = new Point(484, 494);
            bntSortByNameZA.Name = "bntSortByNameZA";
            bntSortByNameZA.Size = new Size(102, 36);
            bntSortByNameZA.TabIndex = 16;
            bntSortByNameZA.Text = "From Z to A";
            bntSortByNameZA.UseVisualStyleBackColor = false;
            bntSortByNameZA.Click += bntSortByNameZA_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(25, 17);
            label8.Name = "label8";
            label8.Size = new Size(349, 46);
            label8.TabIndex = 17;
            label8.Text = "Customer information";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1073, 564);
            Controls.Add(label8);
            Controls.Add(bntSortByNameZA);
            Controls.Add(label7);
            Controls.Add(bntSortByName);
            Controls.Add(label6);
            Controls.Add(txtSearch);
            Controls.Add(lvWaterBill);
            Controls.Add(bntCaltulator);
            Controls.Add(label5);
            Controls.Add(txtThisMonthWaterMeter);
            Controls.Add(txtLastMonthWaterMeter);
            Controls.Add(txtNumberOfPeople);
            Controls.Add(cboTypeOfCustomer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCustomerName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCustomerName;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cboTypeOfCustomer;
        private TextBox txtNumberOfPeople;
        private TextBox txtLastMonthWaterMeter;
        private TextBox txtThisMonthWaterMeter;
        private Label label5;
        private Button bntCaltulator;
        private ListView lvWaterBill;
        private TextBox txtSearch;
        private Label label6;
        private Button bntSortByName;
        private Label label7;
        private Button bntSortByNameZA;
        private Label label8;
    }
}
