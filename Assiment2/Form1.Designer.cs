namespace Assiment2
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
            txtCustomerName = new TextBox();
            txtNumberOfPeople = new TextBox();
            txtLastMonthWaterMeter = new TextBox();
            txtThisMonthWaterMeter = new TextBox();
            btnCaculator = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cboTyPeOfCustomer = new ComboBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            lvWaterBill = new ListView();
            label6 = new Label();
            txtSearch = new TextBox();
            bntSortByNameZA = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(264, 60);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(339, 27);
            txtCustomerName.TabIndex = 0;
            // 
            // txtNumberOfPeople
            // 
            txtNumberOfPeople.Enabled = false;
            txtNumberOfPeople.Location = new Point(264, 181);
            txtNumberOfPeople.Name = "txtNumberOfPeople";
            txtNumberOfPeople.Size = new Size(339, 27);
            txtNumberOfPeople.TabIndex = 2;
            // 
            // txtLastMonthWaterMeter
            // 
            txtLastMonthWaterMeter.Location = new Point(264, 238);
            txtLastMonthWaterMeter.Name = "txtLastMonthWaterMeter";
            txtLastMonthWaterMeter.Size = new Size(339, 27);
            txtLastMonthWaterMeter.TabIndex = 3;
            // 
            // txtThisMonthWaterMeter
            // 
            txtThisMonthWaterMeter.Location = new Point(264, 292);
            txtThisMonthWaterMeter.Name = "txtThisMonthWaterMeter";
            txtThisMonthWaterMeter.Size = new Size(339, 27);
            txtThisMonthWaterMeter.TabIndex = 4;
            // 
            // btnCaculator
            // 
            btnCaculator.Location = new Point(443, 345);
            btnCaculator.Name = "btnCaculator";
            btnCaculator.Size = new Size(97, 40);
            btnCaculator.TabIndex = 5;
            btnCaculator.Text = "Caculator";
            btnCaculator.UseVisualStyleBackColor = true;
            btnCaculator.Click += btnCaculator_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 67);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 7;
            label1.Text = "Customer name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 122);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 8;
            label2.Text = "Type Of Customer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 181);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 9;
            label3.Text = "Number Of People:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 238);
            label4.Name = "label4";
            label4.Size = new Size(180, 20);
            label4.TabIndex = 10;
            label4.Text = "Last Month's Water Meter:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 299);
            label5.Name = "label5";
            label5.Size = new Size(180, 20);
            label5.TabIndex = 11;
            label5.Text = "This Month's Water Meter:";
            // 
            // cboTyPeOfCustomer
            // 
            cboTyPeOfCustomer.FormattingEnabled = true;
            cboTyPeOfCustomer.Location = new Point(264, 120);
            cboTyPeOfCustomer.Name = "cboTyPeOfCustomer";
            cboTyPeOfCustomer.Size = new Size(339, 28);
            cboTyPeOfCustomer.TabIndex = 12;
            cboTyPeOfCustomer.SelectedIndexChanged += cboTyPeOfCustomer_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bntSortByNameZA);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(cboTyPeOfCustomer);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnCaculator);
            groupBox1.Controls.Add(txtThisMonthWaterMeter);
            groupBox1.Controls.Add(txtLastMonthWaterMeter);
            groupBox1.Controls.Add(txtNumberOfPeople);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Location = new Point(37, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(627, 427);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "CalculatorForm";
            // 
            // button1
            // 
            button1.Location = new Point(92, 355);
            button1.Name = "button1";
            button1.Size = new Size(94, 30);
            button1.TabIndex = 13;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lvWaterBill
            // 
            lvWaterBill.FullRowSelect = true;
            lvWaterBill.GridLines = true;
            lvWaterBill.Location = new Point(666, 84);
            lvWaterBill.Name = "lvWaterBill";
            lvWaterBill.Size = new Size(705, 335);
            lvWaterBill.TabIndex = 1;
            lvWaterBill.UseCompatibleStateImageBehavior = false;
            lvWaterBill.SelectedIndexChanged += lvWaterBill_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(693, 44);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 3;
            label6.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(792, 41);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(421, 27);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged_2;
            // 
            // bntSortByNameZA
            // 
            bntSortByNameZA.Location = new Point(264, 356);
            bntSortByNameZA.Name = "bntSortByNameZA";
            bntSortByNameZA.Size = new Size(94, 29);
            bntSortByNameZA.TabIndex = 14;
            bntSortByNameZA.Text = "Arrange";
            bntSortByNameZA.UseVisualStyleBackColor = true;
            bntSortByNameZA.Click += bntSortByNameZA_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 450);
            Controls.Add(txtSearch);
            Controls.Add(label6);
            Controls.Add(lvWaterBill);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomerName;
        private TextBox txtNumberOfPeople;
        private TextBox txtLastMonthWaterMeter;
        private TextBox txtThisMonthWaterMeter;
        private Button btnCaculator;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cboTyPeOfCustomer;
        private GroupBox groupBox1;
        private ListView lvWaterBill;
        private Label label6;
        private TextBox txtSearch;
        private Button button1;
        private Button bntSortByNameZA;
    }
}
