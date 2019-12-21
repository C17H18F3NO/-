namespace ResearchProjectSystem
{
    partial class ProjectListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectListForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIName = new System.Windows.Forms.TextBox();
            this.txtINo = new System.Windows.Forms.TextBox();
            this.cboAcess = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgbProject = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbProject)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtIName);
            this.groupBox1.Controls.Add(this.txtINo);
            this.groupBox1.Controls.Add(this.cboAcess);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "项目查询";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(694, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIName
            // 
            this.txtIName.Location = new System.Drawing.Point(302, 25);
            this.txtIName.Name = "txtIName";
            this.txtIName.Size = new System.Drawing.Size(136, 25);
            this.txtIName.TabIndex = 2;
            this.txtIName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtINo
            // 
            this.txtINo.Location = new System.Drawing.Point(517, 23);
            this.txtINo.Name = "txtINo";
            this.txtINo.Size = new System.Drawing.Size(116, 25);
            this.txtINo.TabIndex = 2;
            this.txtINo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cboAcess
            // 
            this.cboAcess.FormattingEnabled = true;
            this.cboAcess.Location = new System.Drawing.Point(95, 28);
            this.cboAcess.Name = "cboAcess";
            this.cboAcess.Size = new System.Drawing.Size(121, 23);
            this.cboAcess.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "项目名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "项目编号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "是否验收：";
            // 
            // dgbProject
            // 
            this.dgbProject.AllowUserToAddRows = false;
            this.dgbProject.BackgroundColor = System.Drawing.Color.White;
            this.dgbProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbProject.Location = new System.Drawing.Point(2, 93);
            this.dgbProject.Name = "dgbProject";
            this.dgbProject.RowTemplate.Height = 27;
            this.dgbProject.Size = new System.Drawing.Size(795, 365);
            this.dgbProject.TabIndex = 1;
            // 
            // ProjectListForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 452);
            this.Controls.Add(this.dgbProject);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProjectListForm";
            this.Text = "项目管理窗口";
            this.Load += new System.EventHandler(this.ProjectListForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbProject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIName;
        private System.Windows.Forms.TextBox txtINo;
        private System.Windows.Forms.ComboBox cboAcess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgbProject;
    }
}