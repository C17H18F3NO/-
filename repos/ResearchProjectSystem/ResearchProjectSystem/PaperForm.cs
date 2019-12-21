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
    public partial class PaperForm : Form
    {
        public PaperForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = @"select J_number 期刊号, J_category 论文类别, J_factor 影响因子, J_cost 论文报销费用
                            from Paper where 1=1 ";

            sql += this.txtNum.Text.Trim() != "" ? " and J_number=@J_number " : "";
            sql += this.txtCate.Text.Trim() != "" ? " and J_category like @J_category" : "";
            SqlParameter[] paras =
            {
                new SqlParameter("@J_category", this.txtCate.Text.Trim() + "%"),
                new SqlParameter("@J_number", this.txtNum.Text.Trim())
            };
            this.dgvPaper.DataSource = DBHelper.GetDataTable(sql, paras);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = @"delete 
                            from Paper 
                            where 1=1 "; //1=1 恒成立
            sql += this.txtNum.Text.Trim() != "" ? " and J_number=@J_number " : "";
            sql += this.txtCate.Text.Trim() != "" ? " and J_category like @J_category" : "";
            SqlParameter[] paras =
            {
                new SqlParameter("@J_category", this.txtCate.Text.Trim() + "%"),
                new SqlParameter("@J_number", this.txtNum.Text.Trim())
            };
            this.dgvPaper.DataSource = DBHelper.GetDataTable(sql, paras);
            MessageBox.Show("删除成功！");
        }

        private void txtCate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
