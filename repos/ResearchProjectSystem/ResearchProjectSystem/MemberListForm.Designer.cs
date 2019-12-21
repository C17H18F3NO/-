namespace ResearchProjectSystem
{
    partial class MemberListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberListForm));
            this.dgbMember = new System.Windows.Forms.DataGridView();
            this.职工号 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtENo = new System.Windows.Forms.TextBox();
            this.txtEName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgbMember)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgbMember
            // 
            this.dgbMember.AllowUserToAddRows = false;
            this.dgbMember.BackgroundColor = System.Drawing.Color.White;
            this.dgbMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbMember.Location = new System.Drawing.Point(-1, 80);
            this.dgbMember.Name = "dgbMember";
            this.dgbMember.RowTemplate.Height = 27;
            this.dgbMember.Size = new System.Drawing.Size(799, 371);
            this.dgbMember.TabIndex = 1;
            // 
            // 职工号
            // 
            this.职工号.AutoSize = true;
            this.职工号.BackColor = System.Drawing.Color.Transparent;
            this.职工号.Location = new System.Drawing.Point(21, 37);
            this.职工号.Name = "职工号";
            this.职工号.Size = new System.Drawing.Size(67, 15);
            this.职工号.TabIndex = 0;
            this.职工号.Text = "职工号：";
            this.职工号.Click += new System.EventHandler(this.职工号_Click);
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.BackColor = System.Drawing.Color.Transparent;
            this.lable2.Location = new System.Drawing.Point(231, 37);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(52, 15);
            this.lable2.TabIndex = 1;
            this.lable2.Text = "姓名：";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.Location = new System.Drawing.Point(621, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(540, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(702, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "关闭";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtENo
            // 
            this.txtENo.Location = new System.Drawing.Point(82, 28);
            this.txtENo.Name = "txtENo";
            this.txtENo.Size = new System.Drawing.Size(116, 25);
            this.txtENo.TabIndex = 3;
            // 
            // txtEName
            // 
            this.txtEName.Location = new System.Drawing.Point(277, 27);
            this.txtEName.Name = "txtEName";
            this.txtEName.Size = new System.Drawing.Size(112, 25);
            this.txtEName.TabIndex = 3;
            this.txtEName.TextChanged += new System.EventHandler(this.txtEName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtEName);
            this.panel1.Controls.Add(this.txtENo);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lable2);
            this.panel1.Controls.Add(this.职工号);
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 84);
            this.panel1.TabIndex = 0;
            // 
            // MemberListForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgbMember);
            this.Controls.Add(this.panel1);
            this.Name = "MemberListForm";
            this.Text = "成员管理窗口";
            ((System.ComponentModel.ISupportInitialize)(this.dgbMember)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgbMember;
        private System.Windows.Forms.Label 职工号;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtENo;
        private System.Windows.Forms.TextBox txtEName;
        private System.Windows.Forms.Panel panel1;
    }
}