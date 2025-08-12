namespace LoanSystem
{
    partial class formViewLoan
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            groupBox1 = new GroupBox();
            labelNationalID = new Label();
            labelLoanAmount = new Label();
            label6 = new Label();
            label5 = new Label();
            labelLoanType = new Label();
            labelName = new Label();
            label2 = new Label();
            label1 = new Label();
            btnExportPdf = new Button();
            btnViewHistory = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.GridLines = true;
            listView1.Location = new Point(12, 129);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 309);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.ItemChecked += listView1_ItemChecked;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Month";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Payment Date";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Interest";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Principal Paid";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Monthly Payment";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Remaining Balance";
            columnHeader6.Width = 150;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelNationalID);
            groupBox1.Controls.Add(labelLoanAmount);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(labelLoanType);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnExportPdf);
            groupBox1.Controls.Add(btnViewHistory);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loan Info";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // labelNationalID
            // 
            labelNationalID.AutoSize = true;
            labelNationalID.Location = new Point(375, 66);
            labelNationalID.Name = "labelNationalID";
            labelNationalID.Size = new Size(38, 15);
            labelNationalID.TabIndex = 7;
            labelNationalID.Text = "label8";
            // 
            // labelLoanAmount
            // 
            labelLoanAmount.AutoSize = true;
            labelLoanAmount.Location = new Point(375, 31);
            labelLoanAmount.Name = "labelLoanAmount";
            labelLoanAmount.Size = new Size(38, 15);
            labelLoanAmount.TabIndex = 6;
            labelLoanAmount.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(260, 61);
            label6.Name = "label6";
            label6.Size = new Size(109, 21);
            label6.TabIndex = 5;
            label6.Text = "National ID:*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(245, 25);
            label5.Name = "label5";
            label5.Size = new Size(124, 21);
            label5.TabIndex = 4;
            label5.Text = "Loan Amount:*";
            // 
            // labelLoanType
            // 
            labelLoanType.AutoSize = true;
            labelLoanType.Location = new Point(114, 67);
            labelLoanType.Name = "labelLoanType";
            labelLoanType.Size = new Size(38, 15);
            labelLoanType.TabIndex = 3;
            labelLoanType.Text = "label4";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(114, 25);
            labelName.Name = "labelName";
            labelName.Size = new Size(38, 15);
            labelName.TabIndex = 2;
            labelName.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 61);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 1;
            label2.Text = "Loan Type:* ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 19);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 0;
            label1.Text = "Name:*";
            // 
            // btnExportPdf
            // 
            btnExportPdf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportPdf.Location = new Point(601, 17);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(166, 28);
            btnExportPdf.TabIndex = 8;
            btnExportPdf.Text = "Export PDF";
            btnExportPdf.UseVisualStyleBackColor = true;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // btnViewHistory
            // 
            btnViewHistory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnViewHistory.Location = new Point(601, 55);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(166, 28);
            btnViewHistory.TabIndex = 10;
            btnViewHistory.Text = "View Payment History";
            btnViewHistory.UseVisualStyleBackColor = true;
            btnViewHistory.Click += btnViewHistory_Click;
            // 
            // formViewLoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(listView1);
            Name = "formViewLoan";
            Text = "formViewLoan";
            Load += formViewLoan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label labelNationalID;
        private Label labelLoanAmount;
        private Label label6;
        private Label label5;
        private Label labelLoanType;
        private Label labelName;
    private Button btnExportPdf;
    private Button btnExportXls;
    private Button btnViewHistory;
    }
}