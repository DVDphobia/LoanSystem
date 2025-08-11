namespace LoanSystem
{
    partial class formLoanActive
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dataGridViewLoanActive = new DataGridView();
            DateCol = new DataGridViewTextBoxColumn();
            LoanNumberCol = new DataGridViewTextBoxColumn();
            OfficerCol = new DataGridViewTextBoxColumn();
            AmountCol = new DataGridViewTextBoxColumn();
            PrincipalAmountCol = new DataGridViewTextBoxColumn();
            NameLoanerCol = new DataGridViewTextBoxColumn();
            LoanTypeCol = new DataGridViewTextBoxColumn();
            RepaymentCol = new DataGridViewTextBoxColumn();
            ActionCol = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label2 = new Label();
            searchLoanbtn = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoanActive).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 0;
            label1.Text = "Loan - Active";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(searchLoanbtn);
            groupBox1.Controls.Add(dataGridViewLoanActive);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1096, 620);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Active Loans";
            // 
            // dataGridViewLoanActive
            // 
            dataGridViewLoanActive.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewLoanActive.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewLoanActive.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewLoanActive.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLoanActive.BackgroundColor = SystemColors.Control;
            dataGridViewLoanActive.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoanActive.Columns.AddRange(new DataGridViewColumn[] { DateCol, LoanNumberCol, OfficerCol, AmountCol, PrincipalAmountCol, NameLoanerCol, LoanTypeCol, RepaymentCol, ActionCol });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewLoanActive.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewLoanActive.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewLoanActive.Location = new Point(6, 63);
            dataGridViewLoanActive.Name = "dataGridViewLoanActive";
            dataGridViewLoanActive.Size = new Size(1084, 551);
            dataGridViewLoanActive.TabIndex = 3;
            dataGridViewLoanActive.CellBeginEdit += dataGridViewLoanActive_CellBeginEdit;
            dataGridViewLoanActive.CellMouseClick += dataGridViewLoanActive_CellMouseClick;
            dataGridViewLoanActive.CellPainting += dataGridViewLoanActive_CellPainting;
            // 
            // DateCol
            // 
            DateCol.HeaderText = "Date";
            DateCol.Name = "DateCol";
            // 
            // LoanNumberCol
            // 
            LoanNumberCol.HeaderText = "Loan Number";
            LoanNumberCol.Name = "LoanNumberCol";
            // 
            // OfficerCol
            // 
            OfficerCol.HeaderText = "Officer";
            OfficerCol.Name = "OfficerCol";
            // 
            // AmountCol
            // 
            AmountCol.HeaderText = "Amount";
            AmountCol.Name = "AmountCol";
            // 
            // PrincipalAmountCol
            // 
            PrincipalAmountCol.HeaderText = "Principal Amount";
            PrincipalAmountCol.Name = "PrincipalAmountCol";
            // 
            // NameLoanerCol
            // 
            NameLoanerCol.HeaderText = "Name";
            NameLoanerCol.Name = "NameLoanerCol";
            // 
            // LoanTypeCol
            // 
            LoanTypeCol.HeaderText = "Loan Type";
            LoanTypeCol.Name = "LoanTypeCol";
            // 
            // RepaymentCol
            // 
            RepaymentCol.HeaderText = "Repayment Period";
            RepaymentCol.Name = "RepaymentCol";
            // 
            // ActionCol
            // 
            ActionCol.FillWeight = 60F;
            ActionCol.HeaderText = "Actions";
            ActionCol.MinimumWidth = 160;
            ActionCol.Name = "ActionCol";
            ActionCol.ReadOnly = true;
            ActionCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(846, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(789, 34);
            label2.Name = "label2";
            label2.Size = new Size(51, 17);
            label2.TabIndex = 1;
            label2.Text = "Search ";
            // 
            // searchLoanbtn
            // 
            searchLoanbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchLoanbtn.Location = new Point(992, 27);
            searchLoanbtn.Name = "searchLoanbtn";
            searchLoanbtn.Size = new Size(75, 23);
            searchLoanbtn.TabIndex = 4;
            searchLoanbtn.Text = "Search";
            searchLoanbtn.UseVisualStyleBackColor = true;
            searchLoanbtn.Click += searchLoanbtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(159, 18);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // formLoanActive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 680);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formLoanActive";
            Text = "formLoanActive";
            Load += formLoanActive_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoanActive).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dataGridViewLoanActive;
        private DataGridViewTextBoxColumn DateCol;
        private DataGridViewTextBoxColumn LoanNumberCol;
        private DataGridViewTextBoxColumn OfficerCol;
        private DataGridViewTextBoxColumn AmountCol;
        private DataGridViewTextBoxColumn PrincipalAmountCol;
        private DataGridViewTextBoxColumn NameLoanerCol;
        private DataGridViewTextBoxColumn LoanTypeCol;
        private DataGridViewTextBoxColumn RepaymentCol;
        private DataGridViewTextBoxColumn ActionCol;
        private Button button2;
        private Button searchLoanbtn;
    }
}