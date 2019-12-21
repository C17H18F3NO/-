using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResearchProjectSystem
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }
        UserInfos loginUser;
        public MainForm1(UserInfos userInfos)
        {
            InitializeComponent();
            this.loginUser = userInfos;
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm1_Load(object sender, EventArgs e)
        {
            this.Text += $" -  欢迎{this.loginUser.UserName}登陆！";
        }

        private void 论文成果管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 项目管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 添加学员信息的事件
        private void TsmiAddMumber_Click(object sender, EventArgs e)
        {
            AddMumberForm1 addMumberForm1 = new AddMumberForm1();
            addMumberForm1.MdiParent = this;
            addMumberForm1.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 关闭ToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void 专利成果管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //private void MainForm1_Load(object sender, EventArgs e)
        //{

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 添加项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProject();
        }
        private void AddProject()
        {
            AddProjectForm1 addProjectForm1 = new AddProjectForm1();
            addProjectForm1.MdiParent = this;
            addProjectForm1.Show();
        }
        // 添加专利成果信息的事件
        private void TsimAddPatent_Click(object sender, EventArgs e)
        {
            AddPatentForm1 addPatentForm1 = new AddPatentForm1();
            addPatentForm1.MdiParent = this;
            addPatentForm1.Show();
        }

        private void TsimAddPaper_Click(object sender, EventArgs e)
        {
            AddPaperForm1 addPaperForm1 = new AddPaperForm1();
            addPaperForm1.MdiParent = this;
            addPaperForm1.Show();
        }

        /// <summary>
        /// 查看学员列表窗口事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiMemberList_Click(object sender, EventArgs e)
        {
            MemberListForm memberListForm = new MemberListForm();
            memberListForm.MdiParent = this;
            memberListForm.Show();
        }

        private void tsmiProjectList_Click(object sender, EventArgs e)
        {
            ProjectListForm projectListForm = new ProjectListForm();
            projectListForm.MdiParent = this;
            projectListForm.Show();
        }

        private void 成员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmiPaperList_Click(object sender, EventArgs e)
        {
            PaperForm paperListForm = new PaperForm();
            paperListForm.MdiParent = this;
            paperListForm.Show();
        }

        private void tsmiPatenttList_Click(object sender, EventArgs e)
        {
            PatentForm patentForm = new PatentForm();
            patentForm.MdiParent = this;
            patentForm.Show();
        }

        //private void 添加成员ToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}
    }
}
