namespace LoanSystem
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            humberger = new PictureBox();
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            labelUserType = new Label();
            pnDashboard = new Panel();
            dashboardBtn = new Button();
            menuContainer = new FlowLayoutPanel();
            pnClient = new Panel();
            ClientBtn = new Button();
            pnRepayAndPay = new Panel();
            loanApplicationBtn = new Button();
            pnLoan = new Panel();
            LoanBtn = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            fIleToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            loanApplicationToolStripMenuItem = new ToolStripMenuItem();
            loanActiveToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)humberger).BeginInit();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            pnDashboard.SuspendLayout();
            menuContainer.SuspendLayout();
            pnClient.SuspendLayout();
            pnRepayAndPay.SuspendLayout();
            pnLoan.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // humberger
            // 
            humberger.Image = (Image)resources.GetObject("humberger.Image");
            humberger.Location = new Point(0, 0);
            humberger.Name = "humberger";
            humberger.Size = new Size(49, 32);
            humberger.SizeMode = PictureBoxSizeMode.CenterImage;
            humberger.TabIndex = 1;
            humberger.TabStop = false;
            humberger.Click += humberger_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(241, 242, 246);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(pnDashboard);
            sidebar.Controls.Add(menuContainer);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 24);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(230, 592);
            sidebar.TabIndex = 1;
            sidebar.Paint += sidebar_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelUserType);
            panel1.Controls.Add(humberger);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 32);
            panel1.TabIndex = 7;
            // 
            // labelUserType
            // 
            labelUserType.AutoSize = true;
            labelUserType.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserType.Location = new Point(65, 0);
            labelUserType.Name = "labelUserType";
            labelUserType.Size = new Size(0, 25);
            labelUserType.TabIndex = 2;
            // 
            // pnDashboard
            // 
            pnDashboard.BackColor = Color.FromArgb(241, 242, 246);
            pnDashboard.Controls.Add(dashboardBtn);
            pnDashboard.Location = new Point(3, 41);
            pnDashboard.Name = "pnDashboard";
            pnDashboard.Size = new Size(221, 51);
            pnDashboard.TabIndex = 2;
            // 
            // dashboardBtn
            // 
            dashboardBtn.BackColor = Color.FromArgb(241, 242, 246);
            dashboardBtn.Dock = DockStyle.Fill;
            dashboardBtn.ForeColor = Color.Black;
            dashboardBtn.Image = (Image)resources.GetObject("dashboardBtn.Image");
            dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.Location = new Point(0, 0);
            dashboardBtn.Margin = new Padding(0);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Padding = new Padding(15, 0, 0, 0);
            dashboardBtn.Size = new Size(221, 51);
            dashboardBtn.TabIndex = 3;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.UseVisualStyleBackColor = false;
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(241, 242, 246);
            menuContainer.Controls.Add(pnClient);
            menuContainer.Controls.Add(pnRepayAndPay);
            menuContainer.Controls.Add(pnLoan);
            menuContainer.Location = new Point(0, 95);
            menuContainer.Margin = new Padding(0);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(226, 56);
            menuContainer.TabIndex = 2;
            menuContainer.Paint += menuContainer_Paint;
            // 
            // pnClient
            // 
            pnClient.Controls.Add(ClientBtn);
            pnClient.Location = new Point(3, 3);
            pnClient.Name = "pnClient";
            pnClient.Size = new Size(219, 51);
            pnClient.TabIndex = 4;
            // 
            // ClientBtn
            // 
            ClientBtn.BackColor = Color.FromArgb(241, 242, 246);
            ClientBtn.Dock = DockStyle.Fill;
            ClientBtn.ForeColor = Color.Black;
            ClientBtn.Image = (Image)resources.GetObject("ClientBtn.Image");
            ClientBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ClientBtn.Location = new Point(0, 0);
            ClientBtn.Margin = new Padding(0);
            ClientBtn.Name = "ClientBtn";
            ClientBtn.Padding = new Padding(15, 0, 0, 0);
            ClientBtn.Size = new Size(219, 51);
            ClientBtn.TabIndex = 3;
            ClientBtn.Text = "Client";
            ClientBtn.UseVisualStyleBackColor = false;
            ClientBtn.Click += ClientBtn_Click;
            // 
            // pnRepayAndPay
            // 
            pnRepayAndPay.Controls.Add(loanApplicationBtn);
            pnRepayAndPay.Location = new Point(3, 60);
            pnRepayAndPay.Name = "pnRepayAndPay";
            pnRepayAndPay.Size = new Size(219, 51);
            pnRepayAndPay.TabIndex = 6;
            // 
            // loanApplicationBtn
            // 
            loanApplicationBtn.BackColor = Color.FromArgb(241, 242, 246);
            loanApplicationBtn.Dock = DockStyle.Fill;
            loanApplicationBtn.ForeColor = Color.Black;
            loanApplicationBtn.Image = (Image)resources.GetObject("loanApplicationBtn.Image");
            loanApplicationBtn.ImageAlign = ContentAlignment.MiddleLeft;
            loanApplicationBtn.Location = new Point(0, 0);
            loanApplicationBtn.Name = "loanApplicationBtn";
            loanApplicationBtn.Padding = new Padding(20, 0, 0, 0);
            loanApplicationBtn.Size = new Size(219, 51);
            loanApplicationBtn.TabIndex = 3;
            loanApplicationBtn.Text = "Loan Application";
            loanApplicationBtn.UseVisualStyleBackColor = false;
            loanApplicationBtn.Click += loanApplicationBtn_Click;
            // 
            // pnLoan
            // 
            pnLoan.Controls.Add(LoanBtn);
            pnLoan.Location = new Point(3, 117);
            pnLoan.Name = "pnLoan";
            pnLoan.Size = new Size(219, 51);
            pnLoan.TabIndex = 5;
            // 
            // LoanBtn
            // 
            LoanBtn.BackColor = Color.FromArgb(241, 242, 246);
            LoanBtn.Dock = DockStyle.Fill;
            LoanBtn.ForeColor = Color.Black;
            LoanBtn.Image = (Image)resources.GetObject("LoanBtn.Image");
            LoanBtn.ImageAlign = ContentAlignment.MiddleLeft;
            LoanBtn.Location = new Point(0, 0);
            LoanBtn.Name = "LoanBtn";
            LoanBtn.Padding = new Padding(20, 0, 0, 0);
            LoanBtn.Size = new Size(219, 51);
            LoanBtn.TabIndex = 3;
            LoanBtn.Text = "Loan";
            LoanBtn.UseVisualStyleBackColor = false;
            LoanBtn.Click += LoanBtn_Click;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fIleToolStripMenuItem, dashboardToolStripMenuItem, loanApplicationToolStripMenuItem, loanActiveToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1151, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            fIleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            fIleToolStripMenuItem.Size = new Size(37, 20);
            fIleToolStripMenuItem.Text = "FIle";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(92, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(76, 20);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // loanApplicationToolStripMenuItem
            // 
            loanApplicationToolStripMenuItem.Name = "loanApplicationToolStripMenuItem";
            loanApplicationToolStripMenuItem.Size = new Size(109, 20);
            loanApplicationToolStripMenuItem.Text = "Loan Application";
            loanApplicationToolStripMenuItem.Click += loanApplicationToolStripMenuItem_Click_1;
            // 
            // loanActiveToolStripMenuItem
            // 
            loanActiveToolStripMenuItem.Name = "loanActiveToolStripMenuItem";
            loanActiveToolStripMenuItem.Size = new Size(81, 20);
            loanActiveToolStripMenuItem.Text = "Loan Active";
            loanActiveToolStripMenuItem.Click += loanActiveToolStripMenuItem_Click_1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 616);
            Controls.Add(sidebar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "Dasboard";
            Load += Dasboard_Load;
            ((System.ComponentModel.ISupportInitialize)humberger).EndInit();
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnDashboard.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            pnClient.ResumeLayout(false);
            pnRepayAndPay.ResumeLayout(false);
            pnLoan.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox humberger;
        private FlowLayoutPanel sidebar;
        private Panel pnDashboard;
        private Button dashboardBtn;
        private Panel pnClient;
        private Button ClientBtn;
        private FlowLayoutPanel menuContainer;
        private Panel pnRepayAndPay;
        private Button loanApplicationBtn;
        private Panel pnLoan;
        private Button LoanBtn;
        private Panel pnReport;
        private Button reportBtn;

        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private MenuStrip menuStrip1;
        private Panel panel1;
        private Label labelUserType;
        private ToolStripMenuItem fIleToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem loanApplicationToolStripMenuItem;
        private ToolStripMenuItem loanActiveToolStripMenuItem;
    }
}