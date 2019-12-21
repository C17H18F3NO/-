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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

         private void Button1_Click(object sender, EventArgs e)
        {
            this.Close(); //关闭窗体
         }


        // btnLogin_Click
        private void Button2_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            // 存放登陆人信息
            UserInfos userInfos = null;
            // 获取用户名  Trim去掉两边的空格
            string userName = this.TxtUserName.Text.Trim(); //获取用户名  Trim()去掉两边的空格word
            string password = this.TxtPassword.Text.Trim();
            string sql = $@"select UserName, [Password] 
                            from UserInfos 
                            where UserName = userName and [Password] = password";
            SqlParameter[] paras =
            {
                new SqlParameter("uerName",userName),
                new SqlParameter("password",password)
            }; //初始化
               // 第一步  创建数据库链接对象
               //SqlConnection conn = new SqlConnection("server=. ; uid = sa;pwd=12; database=Rearch_P");
               // 第二步  打开数据库
               //conn.Open();
               // 第三步  创建执行脚本的对象
               // SqlCommand command = new SqlCommand(sql, conn);
               //  添加参数化数组  防止SQL注入
               //command.Parameters.AddRange(paras);
               //  读取信息  通过只读游标
               // SqlDataReader reader = command.ExecuteReader();
               // 释放资源 内部带异常处理形式释放资源

            
            SqlDataReader reader = DBHelper.ExecuteReader(sql, paras);

            // 前进到下一条记录
            if (reader.Read())
            {
                userInfos = new UserInfos();
                //userInfos.UserId = (int)reader["UserId"];
                userInfos.UserName = reader["UserName"].ToString();
                userInfos.Password = reader["Password"].ToString();
            }
            reader.Close(); //关闭只读游标对象
           
            if(userInfos != null)
            {
                MainForm1 mainForm1 = new MainForm1(userInfos);
                mainForm1.Show();
                this.Hide(); //隐藏登陆窗口，进入下一个界面  主线程窗口不能直接关闭，这个应用程序关闭
            }
            else
            {
                MessageBox.Show("登陆失败！");
            }


        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

       private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
       {

        }

       private void CheckBox1_CheckedChanged(object sender, EventArgs e)
       {

       }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
       {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
