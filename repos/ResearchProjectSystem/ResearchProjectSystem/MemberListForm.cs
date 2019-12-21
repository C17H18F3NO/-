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
    public partial class MemberListForm : Form
    {
        public MemberListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string sql = @"select m.ENo 职工号, m.EName 姓名, m.Dept 系别, m.Position 职称,
                            m.Direction 研究方向, m.Host 是否为主持人, p.IName 参与项目名称
                            from Member m
                            left join Project p
                            on(m.INo = p.INo)
                            where 1=1 "; //1=1 恒成立
                                         //and前面加空格，在sql查询时没有空格会黏在一起，以及又是三元表达式
            sql += this.txtENo.Text.Trim() != "" ? " and m.ENo=@ENo " : "";
            sql += this.txtEName.Text.Trim() != "" ? " and m.EName like @EName " : "";
            SqlParameter[] paras =
            {
                new SqlParameter("@ENo", this.txtENo.Text.Trim()),
                new SqlParameter("@EName", this.txtEName.Text.Trim() + "%")
            };
            this.dgbMember.DataSource = DBHelper.GetDataTable(sql, paras);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            string sql = @"delete 
                            from Member 
                            where 1=1 "; //1=1 恒成立
                                         //and前面加空格，在sql查询时没有空格会黏在一起，以及又是三元表达式
            sql += this.txtENo.Text.Trim() != "" ? " and ENo=@ENo " : "";
            sql += this.txtEName.Text.Trim() != "" ? " and EName like @EName " : "";
            SqlParameter[] paras =
            {
                new SqlParameter("@ENo", this.txtENo.Text.Trim()),
                new SqlParameter("@EName", this.txtEName.Text.Trim() + "%")
            };
            this.dgbMember.DataSource = DBHelper.GetDataTable(sql, paras);
            MessageBox.Show("删除成功！");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 职工号_Click(object sender, EventArgs e)
        {

        }

        private void txtEName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
