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
    public partial class AddMumberForm1 : Form
    {
        public AddMumberForm1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboINo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbtnNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //获取用户输入信息
            AddMember();
        }
        /// <summary>
        /// 添加成员信息
        /// </summary>
        private void AddMember()
        {
            if(this.textBox1.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名！");
                return;
            }

            //如果项目人数大于5人，显示  已满员
            //string sql1 = @"select count(*) from Member where ";
            string ENo = this.textBox3.Text;
            string EName = this.textBox1.Text.Trim();
            string Direction = this.textBox2.Text;

            string Dept = this.cboDept.Text.ToString ();
            string Position = this.cboPos.Text.ToString();
            //string INo = this.textBox4.Text;
            //string INo = this.cboIName.SelectedItem.ToString();
            string INo = this.cboIName.SelectedValue.ToString();
            //string host = "";
            //if (this.rbtnYes.Checked)
            //{
            //    host = "是";
            //}
            //else
            //{
            //    host = "否";
            //}
            string Host = this.rbtnYes.Checked ? "是" : "否"; //三元符表达式
            string sql = @"insert into Member([ENo], [EName], [Direction], [Dept], [Position], [INo], [Host])
                            values(@ENo, @EName, @Direction, @Dept, @Position, @INo, @Host);";
            SqlParameter[] paras =
            {
                new SqlParameter("ENo", ENo),
                new SqlParameter("EName", EName),
                new SqlParameter("Direction", Direction),
                new SqlParameter("Dept", Dept),
                new SqlParameter("Position", Position),
                new SqlParameter("INo", INo),
                new SqlParameter("Host", Host)
            };
            int result = DBHelper.ExecuteNonQuery(sql, paras);
            if(result > 0)
            {
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMumberForm1_Load(object sender, EventArgs e)
        {
            InitData();
            //InitData1();
            //InitData2();  
        }
        /// <summary>
        /// 初始化信息方法
        /// </summary>
        private void InitData()
        {
            //绑定下拉框信息 显示值  隐藏值
            string s = "select INo, IName from Project;";
            DataTable dt = DBHelper.GetDataTable(s); //DataTable是临时表
            //手动创建临时表数据行
            DataRow dr = dt.NewRow(); // 创建数据行仅仅只有结构
            dr["INo"] = 0;
            dr["IName"] = "--请选择--";
            //dr["INo"] = "--请选择--";
            //dr["IName"] = 0;
            dt.Rows.InsertAt(dr, 0); //向第零行插入

            this.cboIName.ValueMember = "INo"; //隐藏值
            this.cboIName.DisplayMember = "IName"; //显示值
            //this.cboIName.ValueMember = "IName";
            //this.cboIName.DisplayMember = "INo";
            this.cboIName.DataSource = dt; //给下拉框赋值

            //this.cboIName.Items.Add("--请选择--");
            string q = "select Dept from Member group by Dept;";
            DataTable data = DBHelper.GetDataTable(q);
            DataRow da = data.NewRow();
            da["Dept"] = "--请选择--";
            data.Rows.InsertAt(da, 0);
            this.cboDept.DisplayMember = "Dept";
            this.cboDept.DataSource = data;

            string l = "select Position from Member group by Position;";
            DataTable table = DBHelper.GetDataTable(l);
            DataRow dat = table.NewRow();
            dat["Position"] = "--请选择--";
            table.Rows.InsertAt(dat, 0);
            this.cboPos.DisplayMember = "Position";
            this.cboPos.DataSource = table;
        }
        //private void InitData1()
        //{
        //    string q = "select Dept from Member group by Dept;";
        //    DataTable data = DBHelper.GetDataTable(q);
        //    DataRow da = data.NewRow();
        //    da["Dept"] = "--请选择--";
        //    data.Rows.InsertAt(da, 0);
        //    this.cboDept.DataSource = data;
        //}
        //private void InitData2()
        //{
        //    string l = "select Position from Member group by Position;";
        //    DataTable table = DBHelper.GetDataTable(l);
        //    DataRow dat = table.NewRow();
        //    dat["Position"] = "--请选择--";
        //    table.Rows.InsertAt(dat, 0);
        //    this.cboPos.DataSource = table;
        //}



        private void cboDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboPos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtnYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ENo = this.textBox3.Text;
            string EName = this.textBox1.Text.Trim();
            string Direction = this.textBox2.Text;

            string Dept = this.cboDept.Text;
            string Position = this.cboPos.Text.ToString();
          
            string INo = this.cboIName.SelectedValue.ToString();
           
            string Host = this.rbtnYes.Checked ? "是" : "否"; //三元符表达式
            //string sql = @"insert into Member([ENo], [EName], [Direction], [Dept], [Position], [INo], [Host])
            //                values(@ENo, @EName, @Direction, @Dept, @Position, @INo, @Host);";
            string sql = @"update Member
                            set EName=@EName, Direction=@Direction, Dept=@Dept, Position=@Position, INo=@INo, Host=@Host
                            where ENo=@ENo;";
            SqlParameter[] paras =
            {
                new SqlParameter("@ENo", ENo),
                new SqlParameter("@EName", EName),
                new SqlParameter("@Direction", Direction),
                new SqlParameter("@Dept", Dept),
                new SqlParameter("@Position", Position),
                new SqlParameter("@INo", INo),
                new SqlParameter("@Host", Host)
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
    }
}
