namespace LoanSystem
{
    partial class formDashboard
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
            dashboardContainer = new GroupBox();
            pnActiveLoan = new Panel();
            labelActiveLoan = new Label();
            label7 = new Label();
            pnPendingApplication = new Panel();
            labelPendingApplication = new Label();
            label333 = new Label();
            pnEmployee = new Panel();
            labelbEmployee = new Label();
            label = new Label();
            pnBranches = new Panel();
            labelBranches = new Label();
            label1 = new Label();
            dashboardContainer.SuspendLayout();
            pnActiveLoan.SuspendLayout();
            pnPendingApplication.SuspendLayout();
            pnEmployee.SuspendLayout();
            pnBranches.SuspendLayout();
            SuspendLayout();
            // 
            // dashboardContainer
            // 
            dashboardContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dashboardContainer.Controls.Add(pnActiveLoan);
            dashboardContainer.Controls.Add(pnPendingApplication);
            dashboardContainer.Controls.Add(pnEmployee);
            dashboardContainer.Controls.Add(pnBranches);
            dashboardContainer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardContainer.Location = new Point(12, 12);
            dashboardContainer.Name = "dashboardContainer";
            dashboardContainer.Size = new Size(771, 111);
            dashboardContainer.TabIndex = 0;
            dashboardContainer.TabStop = false;
            dashboardContainer.Text = "Dashboard";
            // 
            // pnActiveLoan
            // 
            pnActiveLoan.Anchor = AnchorStyles.Right;
            pnActiveLoan.BackColor = Color.FromArgb(26, 188, 156);
            pnActiveLoan.Controls.Add(labelActiveLoan);
            pnActiveLoan.Controls.Add(label7);
            pnActiveLoan.Location = new Point(590, 28);
            pnActiveLoan.Name = "pnActiveLoan";
            pnActiveLoan.Size = new Size(175, 77);
            pnActiveLoan.TabIndex = 1;
            // 
            // labelActiveLoan
            // 
            labelActiveLoan.AutoSize = true;
            labelActiveLoan.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelActiveLoan.ForeColor = Color.White;
            labelActiveLoan.Location = new Point(3, 16);
            labelActiveLoan.Name = "labelActiveLoan";
            labelActiveLoan.Size = new Size(42, 32);
            labelActiveLoan.TabIndex = 2;
            labelActiveLoan.Text = "21";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 48);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 2;
            label7.Text = "Active Loan";
            // 
            // pnPendingApplication
            // 
            pnPendingApplication.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnPendingApplication.BackColor = Color.FromArgb(26, 188, 156);
            pnPendingApplication.Controls.Add(labelPendingApplication);
            pnPendingApplication.Controls.Add(label333);
            pnPendingApplication.Location = new Point(395, 28);
            pnPendingApplication.Name = "pnPendingApplication";
            pnPendingApplication.Size = new Size(175, 77);
            pnPendingApplication.TabIndex = 1;
            // 
            // labelPendingApplication
            // 
            labelPendingApplication.AutoSize = true;
            labelPendingApplication.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPendingApplication.ForeColor = Color.White;
            labelPendingApplication.Location = new Point(3, 16);
            labelPendingApplication.Name = "labelPendingApplication";
            labelPendingApplication.Size = new Size(42, 32);
            labelPendingApplication.TabIndex = 2;
            labelPendingApplication.Text = "21";
            // 
            // label333
            // 
            label333.AutoSize = true;
            label333.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label333.ForeColor = Color.White;
            label333.Location = new Point(3, 48);
            label333.Name = "label333";
            label333.Size = new Size(117, 15);
            label333.TabIndex = 2;
            label333.Text = "Pending Application";
            // 
            // pnEmployee
            // 
            pnEmployee.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnEmployee.BackColor = Color.FromArgb(26, 188, 156);
            pnEmployee.Controls.Add(labelbEmployee);
            pnEmployee.Controls.Add(label);
            pnEmployee.Location = new Point(199, 28);
            pnEmployee.Name = "pnEmployee";
            pnEmployee.Size = new Size(175, 77);
            pnEmployee.TabIndex = 1;
            // 
            // labelbEmployee
            // 
            labelbEmployee.AutoSize = true;
            labelbEmployee.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelbEmployee.ForeColor = Color.White;
            labelbEmployee.Location = new Point(3, 16);
            labelbEmployee.Name = "labelbEmployee";
            labelbEmployee.Size = new Size(28, 32);
            labelbEmployee.TabIndex = 2;
            labelbEmployee.Text = "6";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(3, 48);
            label.Name = "label";
            label.Size = new Size(61, 15);
            label.TabIndex = 2;
            label.Text = "Employee";
            // 
            // pnBranches
            // 
            pnBranches.Anchor = AnchorStyles.Left;
            pnBranches.BackColor = Color.FromArgb(26, 188, 156);
            pnBranches.Controls.Add(labelBranches);
            pnBranches.Controls.Add(label1);
            pnBranches.Location = new Point(6, 28);
            pnBranches.Name = "pnBranches";
            pnBranches.Size = new Size(175, 77);
            pnBranches.TabIndex = 0;
            // 
            // labelBranches
            // 
            labelBranches.AutoSize = true;
            labelBranches.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBranches.ForeColor = Color.White;
            labelBranches.Location = new Point(3, 16);
            labelBranches.Name = "labelBranches";
            labelBranches.Size = new Size(42, 32);
            labelBranches.TabIndex = 2;
            labelBranches.Text = "21";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 48);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "Branches";
            // 
            // formDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 429);
            Controls.Add(dashboardContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formDashboard";
            Text = "formDashboard";
            Load += formDashboard_Load;
            dashboardContainer.ResumeLayout(false);
            pnActiveLoan.ResumeLayout(false);
            pnActiveLoan.PerformLayout();
            pnPendingApplication.ResumeLayout(false);
            pnPendingApplication.PerformLayout();
            pnEmployee.ResumeLayout(false);
            pnEmployee.PerformLayout();
            pnBranches.ResumeLayout(false);
            pnBranches.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox dashboardContainer;
        private Panel pnBranches;
        private Label labelBranches;
        private Label label1;
        private Panel pnActiveLoan;
        private Label labelActiveLoan;
        private Label label7;
        private Panel pnPendingApplication;
        private Label labelPendingApplication;
        private Label label333;
        private Panel pnEmployee;
        private Label labelbEmployee;
        private Label label;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Test;
    }
}