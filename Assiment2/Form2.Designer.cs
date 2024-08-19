namespace Assiment2
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
            txtNameOfCustomer = new TextBox();
            txtLastMonthWater = new TextBox();
            txtThisMonthWater = new TextBox();
            txtConsumption = new TextBox();
            txtWaterMoney = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtNameOfCustomer
            // 
            txtNameOfCustomer.Location = new Point(229, 100);
            txtNameOfCustomer.Name = "txtNameOfCustomer";
            txtNameOfCustomer.Size = new Size(341, 27);
            txtNameOfCustomer.TabIndex = 0;
            // 
            // txtLastMonthWater
            // 
            txtLastMonthWater.Location = new Point(229, 152);
            txtLastMonthWater.Name = "txtLastMonthWater";
            txtLastMonthWater.Size = new Size(341, 27);
            txtLastMonthWater.TabIndex = 1;
            // 
            // txtThisMonthWater
            // 
            txtThisMonthWater.Location = new Point(229, 212);
            txtThisMonthWater.Name = "txtThisMonthWater";
            txtThisMonthWater.Size = new Size(341, 27);
            txtThisMonthWater.TabIndex = 2;
            // 
            // txtConsumption
            // 
            txtConsumption.Location = new Point(229, 264);
            txtConsumption.Name = "txtConsumption";
            txtConsumption.Size = new Size(341, 27);
            txtConsumption.TabIndex = 3;
            // 
            // txtWaterMoney
            // 
            txtWaterMoney.Location = new Point(229, 323);
            txtWaterMoney.Name = "txtWaterMoney";
            txtWaterMoney.Size = new Size(341, 27);
            txtWaterMoney.TabIndex = 4;
            txtWaterMoney.TextChanged += textBox5_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 107);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 5;
            label1.Text = "Name Of Customer:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 159);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 6;
            label2.Text = "Last Month Water:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 212);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 7;
            label3.Text = "This Month Water:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 271);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 8;
            label4.Text = "Consumption:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 330);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 9;
            label5.Text = "Water Money:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label6.Location = new Point(314, 23);
            label6.Name = "label6";
            label6.Size = new Size(162, 46);
            label6.TabIndex = 11;
            label6.Text = "Water Bill";
            // 
            // button1
            // 
            button1.Location = new Point(461, 381);
            button1.Name = "button1";
            button1.Size = new Size(130, 39);
            button1.TabIndex = 12;
            button1.Text = "Payment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 450);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtWaterMoney);
            Controls.Add(txtConsumption);
            Controls.Add(txtThisMonthWater);
            Controls.Add(txtLastMonthWater);
            Controls.Add(txtNameOfCustomer);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNameOfCustomer;
        private TextBox txtLastMonthWater;
        private TextBox txtThisMonthWater;
        private TextBox txtConsumption;
        private TextBox txtWaterMoney;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}