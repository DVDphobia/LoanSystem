namespace LoanSystem
{
    partial class Dasboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dasboard));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            dashboardBtn = new Button();
            menuContiner = new FlowLayoutPanel();
            panel3 = new Panel();
            ClientBtn = new Button();
            panel5 = new Panel();
            RepaymentsAndPaymentsBtn = new Button();
            panel4 = new Panel();
            LoanBtn = new Button();
            panel6 = new Panel();
            button1 = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            menuContiner.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(209, 204, 192);
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1151, 39);
            panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1012, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 17);
            label1.TabIndex = 2;
            label1.Text = "Loan Managment ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(241, 242, 246);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 39);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(222, 577);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dashboardBtn);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 51);
            panel2.TabIndex = 2;
            // 
            // dashboardBtn
            // 
            dashboardBtn.BackColor = Color.FromArgb(241, 242, 246);
            dashboardBtn.Dock = DockStyle.Fill;
            dashboardBtn.ForeColor = Color.Black;
            dashboardBtn.Image = (Image)resources.GetObject("dashboardBtn.Image");
            dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.Location = new Point(0, 0);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Padding = new Padding(25, 0, 0, 0);
            dashboardBtn.Size = new Size(219, 51);
            dashboardBtn.TabIndex = 3;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.UseVisualStyleBackColor = false;
            // 
            // menuContiner
            // 
            menuContiner.BackColor = Color.FromArgb(241, 242, 246);
            menuContiner.Controls.Add(panel3);
            menuContiner.Controls.Add(panel5);
            menuContiner.Controls.Add(panel4);
            menuContiner.Location = new Point(531, 123);
            menuContiner.Margin = new Padding(0);
            menuContiner.Name = "menuContiner";
            menuContiner.Size = new Size(224, 51);
            menuContiner.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(ClientBtn);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 51);
            panel3.TabIndex = 4;
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
            ClientBtn.Padding = new Padding(25, 0, 0, 0);
            ClientBtn.Size = new Size(219, 51);
            ClientBtn.TabIndex = 3;
            ClientBtn.Text = "Client";
            ClientBtn.UseVisualStyleBackColor = false;
            ClientBtn.Click += ClientBtn_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(RepaymentsAndPaymentsBtn);
            panel5.Location = new Point(3, 60);
            panel5.Name = "panel5";
            panel5.Size = new Size(219, 51);
            panel5.TabIndex = 6;
            // 
            // RepaymentsAndPaymentsBtn
            // 
            RepaymentsAndPaymentsBtn.BackColor = Color.FromArgb(241, 242, 246);
            RepaymentsAndPaymentsBtn.Dock = DockStyle.Fill;
            RepaymentsAndPaymentsBtn.ForeColor = Color.Black;
            RepaymentsAndPaymentsBtn.Image = (Image)resources.GetObject("RepaymentsAndPaymentsBtn.Image");
            RepaymentsAndPaymentsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            RepaymentsAndPaymentsBtn.Location = new Point(0, 0);
            RepaymentsAndPaymentsBtn.Name = "RepaymentsAndPaymentsBtn";
            RepaymentsAndPaymentsBtn.Padding = new Padding(25, 0, 0, 0);
            RepaymentsAndPaymentsBtn.Size = new Size(219, 51);
            RepaymentsAndPaymentsBtn.TabIndex = 3;
            RepaymentsAndPaymentsBtn.Text = "       Repayments / Payments";
            RepaymentsAndPaymentsBtn.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(LoanBtn);
            panel4.Location = new Point(3, 117);
            panel4.Name = "panel4";
            panel4.Size = new Size(219, 51);
            panel4.TabIndex = 5;
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
            LoanBtn.Padding = new Padding(25, 0, 0, 0);
            LoanBtn.Size = new Size(219, 51);
            LoanBtn.TabIndex = 3;
            LoanBtn.Text = "Loan";
            LoanBtn.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(button1);
            panel6.Location = new Point(534, 177);
            panel6.Name = "panel6";
            panel6.Size = new Size(219, 51);
            panel6.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(241, 242, 246);
            button1.Dock = DockStyle.Fill;
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Padding = new Padding(25, 0, 0, 0);
            button1.Size = new Size(219, 51);
            button1.TabIndex = 3;
            button1.Text = "Loan";
            button1.UseVisualStyleBackColor = false;
            // 
            // menuTransition
            // 
            menuTransition.Tick += menuTransition_Tick;
            // 
            // Dasboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 616);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuContiner);
            Controls.Add(panel6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dasboard";
            Text = "Dasboard";
            Load += Dasboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            menuContiner.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Button dashboardBtn;
        private Panel panel3;
        private Button ClientBtn;
        private FlowLayoutPanel menuContiner;
        private Panel panel5;
        private Button RepaymentsAndPaymentsBtn;
        private Panel panel4;
        private Button LoanBtn;
        private Panel panel6;
        private Button button1;

        private System.Windows.Forms.Timer menuTransition;
    }
}