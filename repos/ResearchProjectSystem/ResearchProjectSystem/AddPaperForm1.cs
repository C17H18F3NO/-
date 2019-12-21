using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ResearchProjectSystem
{
    public partial class AddPaperForm1 : Form
    {
        public AddPaperForm1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string J_number = this.textBox1.Text.Trim();
            string J_category = this.cboPaper.Text;
            string J_factor = this.textBox3.Text;
            string J_cost = this.textBox4.Text;
            string sql = @"update Paper set J_category=@J_category, J_factor=@J_factor, J_cost=@J_cost
                           where J_number=@J_number; ";
            SqlParameter[] paras =
            {
                new SqlParameter("J_cost", J_cost),
                new SqlParameter("J_number", J_number),
                new SqlParameter("J_category",J_category),
                new SqlParameter("J_factor", J_factor)
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
            AddPaper();
        }
        private void AddPaper()
        {   
            string J_number = this.textBox1.Text.Trim();
            string J_category = this.cboPaper.Text;
            string J_factor = this.textBox3.Text;
            string J_cost = this.textBox4.Text;
            string sql = @"insert into Paper([J_number], [J_category], [J_factor], [J_cost])
                          values(@J_number, @J_category, @J_factor, @J_cost); ";
            SqlParameter[] paras =
            {
                new SqlParameter("J_cost", J_cost),
                new SqlParameter("J_number", J_number),
                new SqlParameter("J_category",J_category),
                new SqlParameter("J_factor", J_factor)
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

        private void AddPaperForm1_Load(object sender, EventArgs e)
        {
            InitData();
        }
        private void InitData()
        {
            string s = "select J_category from Paper group by J_category;";
            DataTable dt = DBHelper.GetDataTable(s); //DataTable是临时表
            //手动创建临时表数据行
            DataRow dr = dt.NewRow(); // 创建数据行仅仅只有结构
            dr["J_category"] = "--请选择--";

            dt.Rows.InsertAt(dr, 0); //向第零行插入
         
            this.cboPaper.DisplayMember = "J_category"; //显示值
            //this.cboIName.ValueMember = "IName";
            //this.cboIName.DisplayMember = "INo";
            this.cboPaper.DataSource = dt; //给下拉框赋值
        }
    }
}
