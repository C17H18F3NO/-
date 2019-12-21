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
    public partial class AddPatentForm1 : Form
    {
        public AddPatentForm1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string P_cost = this.textBox3.Text;
            string P_number = this.textBox1.Text.Trim();
            string P_category = this.textBox2.Text;
            string sql = @"update Patent 
                            set P_category=@P_category, P_cost=@P_cost
                            where P_number=@P_number; ";
            SqlParameter[] paras =
            {
                new SqlParameter("P_cost", P_cost),
                new SqlParameter("P_number", P_number),
                new SqlParameter("P_category",P_category)
            };
            int result = DBHelper.ExecuteNonQuery(sql, paras);
            if (result > 0)
            {
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPatent();
        }
        private void AddPatent()
        {
            string P_cost = this.textBox3.Text;
            string P_number = this.textBox1.Text.Trim();
            string P_category = this.textBox2.Text;
            string sql = @"insert into Patent([P_number], [P_category], [P_cost])
                          values(@P_number, @P_category, @P_cost); ";
            SqlParameter[] paras =
            {
                new SqlParameter("P_cost", P_cost),
                new SqlParameter("P_number", P_number),
                new SqlParameter("P_category",P_category)
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
    }
}
