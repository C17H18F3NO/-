namespace ResearchProjectSystem
{
    partial class MainForm1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.成员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMemberList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddMumber = new System.Windows.Forms.ToolStripMenuItem();
            this.项目管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProjectList = new System.Windows.Forms.ToolStripMenuItem();
            this.TsimAddProject = new System.Windows.Forms.ToolStripMenuItem();
            this.成果管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaperList = new System.Windows.Forms.ToolStripMenuItem();
            this.TsimAddPaper = new System.Windows.Forms.ToolStripMenuItem();
            this.专利成果管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPatenttList = new System.Windows.Forms.ToolStripMenuItem();
            this.TsimAddPatent = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.成员管理ToolStripMenuItem,
            this.项目管理ToolStripMenuItem,
            this.成果管理ToolStripMenuItem,
            this.专利成果管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 成员管理ToolStripMenuItem
            // 
            this.成员管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMemberList,
            this.tsmiAddMumber});
            this.成员管理ToolStripMenuItem.Name = "成员管理ToolStripMenuItem";
            this.成员管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.成员管理ToolStripMenuItem.Text = "成员管理";
            this.成员管理ToolStripMenuItem.Click += new System.EventHandler(this.成员管理ToolStripMenuItem_Click);
            // 
            // tsmiMemberList
            // 
            this.tsmiMemberList.Name = "tsmiMemberList";
            this.tsmiMemberList.Size = new System.Drawing.Size(144, 26);
            this.tsmiMemberList.Text = "成员列表";
            this.tsmiMemberList.Click += new System.EventHandler(this.tsmiMemberList_Click);
            // 
            // tsmiAddMumber
            // 
            this.tsmiAddMumber.Name = "tsmiAddMumber";
            this.tsmiAddMumber.Size = new System.Drawing.Size(144, 26);
            this.tsmiAddMumber.Text = "添加成员";
            this.tsmiAddMumber.Click += new System.EventHandler(this.TsmiAddMumber_Click);
            // 
            // 项目管理ToolStripMenuItem
            // 
            this.项目管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProjectList,
            this.TsimAddProject});
            this.项目管理ToolStripMenuItem.Name = "项目管理ToolStripMenuItem";
            this.项目管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.项目管理ToolStripMenuItem.Text = "项目管理";
            this.项目管理ToolStripMenuItem.Click += new System.EventHandler(this.项目管理ToolStripMenuItem_Click);
            // 
            // tsmiProjectList
            // 
            this.tsmiProjectList.Name = "tsmiProjectList";
            this.tsmiProjectList.Size = new System.Drawing.Size(144, 26);
            this.tsmiProjectList.Text = "项目列表";
            this.tsmiProjectList.Click += new System.EventHandler(this.tsmiProjectList_Click);
            // 
            // TsimAddProject
            // 
            this.TsimAddProject.Name = "TsimAddProject";
            this.TsimAddProject.Size = new System.Drawing.Size(144, 26);
            this.TsimAddProject.Text = "添加项目";
            this.TsimAddProject.Click += new System.EventHandler(this.添加项目ToolStripMenuItem_Click);
            // 
            // 成果管理ToolStripMenuItem
            // 
            this.成果管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPaperList,
            this.TsimAddPaper});
            this.成果管理ToolStripMenuItem.Name = "成果管理ToolStripMenuItem";
            this.成果管理ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.成果管理ToolStripMenuItem.Text = "论文成果管理";
            // 
            // tsmiPaperList
            // 
            this.tsmiPaperList.Name = "tsmiPaperList";
            this.tsmiPaperList.Size = new System.Drawing.Size(174, 26);
            this.tsmiPaperList.Text = "论文成果列表";
            this.tsmiPaperList.Click += new System.EventHandler(this.tsmiPaperList_Click);
            // 
            // TsimAddPaper
            // 
            this.TsimAddPaper.Name = "TsimAddPaper";
            this.TsimAddPaper.Size = new System.Drawing.Size(174, 26);
            this.TsimAddPaper.Text = "添加论文成果";
            this.TsimAddPaper.Click += new System.EventHandler(this.TsimAddPaper_Click);
            // 
            // 专利成果管理ToolStripMenuItem
            // 
            this.专利成果管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPatenttList,
            this.TsimAddPatent});
            this.专利成果管理ToolStripMenuItem.Name = "专利成果管理ToolStripMenuItem";
            this.专利成果管理ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.专利成果管理ToolStripMenuItem.Text = "专利成果管理";
            this.专利成果管理ToolStripMenuItem.Click += new System.EventHandler(this.专利成果管理ToolStripMenuItem_Click);
            // 
            // tsmiPatenttList
            // 
            this.tsmiPatenttList.Name = "tsmiPatenttList";
            this.tsmiPatenttList.Size = new System.Drawing.Size(204, 26);
            this.tsmiPatenttList.Text = "专利成果列表";
            this.tsmiPatenttList.Click += new System.EventHandler(this.tsmiPatenttList_Click);
            // 
            // TsimAddPatent
            // 
            this.TsimAddPatent.Name = "TsimAddPatent";
            this.TsimAddPatent.Size = new System.Drawing.Size(204, 26);
            this.TsimAddPatent.Text = "添加专利成果列表";
            this.TsimAddPatent.Click += new System.EventHandler(this.TsimAddPatent_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Location = new System.Drawing.Point(703, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(789, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MainForm1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(789, 455);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm1";
            this.Text = "广理科研项目管理系统";
            this.Load += new System.EventHandler(this.MainForm1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 成员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 项目管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成果管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiMemberList;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddMumber;
        private System.Windows.Forms.ToolStripMenuItem tsmiProjectList;
        private System.Windows.Forms.ToolStripMenuItem TsimAddProject;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaperList;
        private System.Windows.Forms.ToolStripMenuItem TsimAddPaper;
        private System.Windows.Forms.ToolStripMenuItem 专利成果管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiPatenttList;
        private System.Windows.Forms.ToolStripMenuItem TsimAddPatent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}