using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ResearchProjectSystem
{
    public partial class AddProjectForm1 : Form
    {
        public AddProjectForm1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string INo = this.textBox1.Text;
            string IName = this.textBox2.Text.Trim();
            string Time = this.textBox3.Text;

            string Ifee = this.textBox4.Text;
            string Balance = this.textBox5.Text;

            string J_number = this.cboJId.Text.ToString();
            string P_number = this.cboPID.Text.ToString();

            string Accep = this.rbtnYes.Checked ? "是" : "否"; //三元符表达式
            //string sql = @"insert into Member([ENo], [EName], [Direction], [Dept], [Position], [INo], [Host])
            //                values(@ENo, @EName, @Direction, @Dept, @Position, @INo, @Host);";
            string sql = @"update Project
                            set IName=@IName, Time=@Time, Ifee=@Ifee, Balance=@Balance, J_number=@J_number, P_number=@P_number, Accep=@Accep
                            where INo=@INo;";
            SqlParameter[] paras =
            {
                new SqlParameter("@INo", INo),
                new SqlParameter("@IName", IName),
                new SqlParameter("@Time", Time),
                new SqlParameter("@Ifee", Ifee),
                new SqlParameter("@Balance", Balance),
                new SqlParameter("@J_number", J_number),
                new SqlParameter("@P_number", P_number),
                new SqlParameter("@Accep", Accep)
            };
            int result = DBHelper.ExecuteNonQuery(sql, paras);
            if (result > 0)
            {
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProject();
        }
        private void AddProject()
        {
            if (this.textBox2.Text.Trim() == "")
            {
                MessageBox.Show("请输入项目名称！");
                return;
            }

            string INo = this.textBox1.Text;
            string IName = this.textBox2.Text.Trim();
            string Time = this.textBox3.Text;

            string Ifee = this.textBox4.Text;
            string Balance = this.textBox5.Text;
            
            string J_number = this.cboJId.Text.ToString();
            string P_number = this.cboPID.Text.ToString();
           
            string Accep = this.rbtnYes.Checked ? "是" : "否"; //三元符表达式
            string sql = @"insert into Project([INo], [IName], [Time], [Ifee], [Accep], [Balance], [J_number], [P_number])
                            values(@INo, @IName, @Time, @Ifee, @Accep, @Balance, @J_number, @P_number);";
            SqlParameter[] paras =
            {
                new SqlParameter("INo", INo),
                new SqlParameter("IName", IName),
                new SqlParameter("Time", Time),
                new SqlParameter("Ifee", Ifee),
                new SqlParameter("Accep",Accep),
                new SqlParameter("Balance", Balance),
                new SqlParameter("J_number", J_number),
                new SqlParameter("P_number", P_number)
            };
            int result = DBHelper.ExecuteNonQuery(sql, paras);
            if (result > 0)
            {
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rbtnNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddProjectForm1_Load(object sender, EventArgs e)
        {
            InitData1();
        }
        private void InitData1()
        {
            string s = "select J_number, J_category from Paper;";
            DataTable dt = DBHelper.GetDataTable(s); //DataTable是临时表
            //手动创建临时表数据行
            DataRow dr = dt.NewRow(); // 创建数据行仅仅只有结构
            dr["J_number"] = "--请选择--";
            
            dt.Rows.InsertAt(dr, 0); //向第零行插入
            this.cboJId.DisplayMember = "J_number"; //显示值

            this.cboJId.DataSource = dt; //给下拉框赋值

            string q = "select P_number, P_category from Patent;";
            DataTable data = DBHelper.GetDataTable(q);
            DataRow da = data.NewRow();
            da["P_number"] = "--请选择--";
            data.Rows.InsertAt(da, 0);
            this.cboPID.DisplayMember = "P_number";
            this.cboPID.DataSource = data;

        }

        private void cboPID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
