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
    public partial class PatentForm : Form
    {
        public PatentForm()
        {
            InitializeComponent();
        }

        private void PatentForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = @"delete 
                            from Patent 
                            where 1=1 "; //1=1 恒成立
            sql += this.txtNum.Text.Trim() != "" ? " and P_number=@P_number " : "";
            sql += this.txtCate.Text.Trim() != "" ? " and P_category like @P_category" : "";
            SqlParameter[] paras =
            {
                new SqlParameter("@P_category", this.txtCate.Text.Trim() + "%"),
                new SqlParameter("@P_number", this.txtNum.Text.Trim())
            };
            this.bgvPatent.DataSource = DBHelper.GetDataTable(sql, paras);
            MessageBox.Show("删除成功！");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = @"select P_number 专利号, P_category 专利类别, P_cost 专利费用报销 from Patent where 1=1 ";

            sql += this.txtNum.Text.Trim() != "" ? " and P_number=@P_number " : "";
            sql += this.txtCate.Text.Trim() != "" ? " and P_category like @P_category" : "";
            SqlParameter[] paras =
            {
                new SqlParameter("@P_category", this.txtCate.Text.Trim() + "%"),
                new SqlParameter("@P_number", this.txtNum.Text.Trim())
            };
            this.bgvPatent.DataSource = DBHelper.GetDataTable(sql, paras);
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
