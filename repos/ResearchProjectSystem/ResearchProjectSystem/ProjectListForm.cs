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
    public partial class ProjectListForm : Form
    {
        public ProjectListForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjectListForm_Load(object sender, EventArgs e)
        {
            InitData1();
        }
        private void InitData1()
        {
            string sql = "select Accep from Project group by Accep;";
            DataTable data = DBHelper.GetDataTable(sql);
            DataRow da = data.NewRow(); 
            da["Accep"] = "--请选择--";
            data.Rows.InsertAt(da, 0);
            this.cboAcess.DisplayMember = "Accep";
            this.cboAcess.DataSource = data;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = @"select INo 项目编号, IName 项目名称, Time 起止时间, Ifee 项目经费,
                            Accep 是否验收, Balance 经费余额, J_number 专利号, P_number 期刊号 
                            from Project
                            where 1=1 ";
            sql += this.cboAcess.Text.ToString() != "" ? " and Accep=@Accep " : "";
            sql += this.txtIName.Text.Trim() != "" ? " and IName like @IName" : "";
            sql += this.txtINo.Text.Trim() != "" ? " and INo=@INo" : "";
            SqlParameter[] paras =
            {
                new SqlParameter("@Accep", this.cboAcess.Text),
                new SqlParameter("@IName", this.txtIName.Text.Trim() + "%"),
                new SqlParameter("@INo", this.txtINo.Text.Trim())
            };
            this.dgbProject.DataSource = DBHelper.GetDataTable(sql, paras);
        }
    }
}
