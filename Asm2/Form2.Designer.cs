namespace Asm2
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lbCustomerName = new Label();
            lbLastMonthWaterMeter = new Label();
            lbThisMonthWaterMeter = new Label();
            lbConsumption = new Label();
            lbWaterBill = new Label();
            bntPayment = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 58);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(257, 24);
            label2.Name = "label2";
            label2.Size = new Size(223, 62);
            label2.TabIndex = 1;
            label2.Text = "Water Bill";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 123);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 2;
            label3.Text = "Customer Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 164);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(131, 218);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 4;
            label5.Text = "This Water Meter :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(131, 271);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 5;
            label6.Text = "Consumption : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(131, 322);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 6;
            label7.Text = "Water Bill : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(131, 164);
            label8.Name = "label8";
            label8.Size = new Size(175, 20);
            label8.TabIndex = 7;
            label8.Text = "Last Month Water Meter :";
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.BackColor = SystemColors.ButtonFace;
            lbCustomerName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCustomerName.Location = new Point(293, 123);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new Size(13, 20);
            lbCustomerName.TabIndex = 8;
            lbCustomerName.Text = "l";
            // 
            // lbLastMonthWaterMeter
            // 
            lbLastMonthWaterMeter.AutoSize = true;
            lbLastMonthWaterMeter.BackColor = SystemColors.ButtonFace;
            lbLastMonthWaterMeter.Location = new Point(336, 164);
            lbLastMonthWaterMeter.Name = "lbLastMonthWaterMeter";
            lbLastMonthWaterMeter.Size = new Size(58, 20);
            lbLastMonthWaterMeter.TabIndex = 9;
            lbLastMonthWaterMeter.Text = "label10";
            // 
            // lbThisMonthWaterMeter
            // 
            lbThisMonthWaterMeter.AutoSize = true;
            lbThisMonthWaterMeter.BackColor = SystemColors.Control;
            lbThisMonthWaterMeter.Location = new Point(293, 218);
            lbThisMonthWaterMeter.Name = "lbThisMonthWaterMeter";
            lbThisMonthWaterMeter.Size = new Size(58, 20);
            lbThisMonthWaterMeter.TabIndex = 10;
            lbThisMonthWaterMeter.Text = "label11";
            // 
            // lbConsumption
            // 
            lbConsumption.AutoSize = true;
            lbConsumption.BackColor = SystemColors.Control;
            lbConsumption.Location = new Point(293, 271);
            lbConsumption.Name = "lbConsumption";
            lbConsumption.Size = new Size(58, 20);
            lbConsumption.TabIndex = 11;
            lbConsumption.Text = "label12";
            // 
            // lbWaterBill
            // 
            lbWaterBill.AutoSize = true;
            lbWaterBill.BackColor = SystemColors.Control;
            lbWaterBill.Location = new Point(293, 322);
            lbWaterBill.Name = "lbWaterBill";
            lbWaterBill.Size = new Size(58, 20);
            lbWaterBill.TabIndex = 12;
            lbWaterBill.Text = "label13";
            // 
            // bntPayment
            // 
            bntPayment.Location = new Point(398, 374);
            bntPayment.Name = "bntPayment";
            bntPayment.Size = new Size(113, 40);
            bntPayment.TabIndex = 13;
            bntPayment.Text = "Payment";
            bntPayment.UseVisualStyleBackColor = true;
            bntPayment.Click += bntPayment_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 453);
            Controls.Add(bntPayment);
            Controls.Add(lbWaterBill);
            Controls.Add(lbConsumption);
            Controls.Add(lbThisMonthWaterMeter);
            Controls.Add(lbLastMonthWaterMeter);
            Controls.Add(lbCustomerName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lbCustomerName;
        private Label lbLastMonthWaterMeter;
        private Label lbThisMonthWaterMeter;
        private Label lbConsumption;
        private Label lbWaterBill;
        private Button bntPayment;
    }
}