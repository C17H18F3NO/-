using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



/// <summary>
/// 数据库帮助类
/// </summary>
public class DBHelper
{
    private static readonly string ConnStr = "server=WIN102019JWEHIW;uid=sa;pwd=12;database=Rearch_P";
    /// <summary>
    /// 执行添加、删除、修改的方法
    /// </summary>
    //<param name="sql"></param>
    // <param name="paras"></param>
    /// <returns></returns>
    public static int ExecuteNonQuery(string sql, params SqlParameter[] paras)
    {

        using (SqlConnection conn = new SqlConnection(ConnStr))
        {
            //打开数据库连接
            conn.Open();
            //创建执行脚本的对象
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddRange(paras);
            int result = command.ExecuteNonQuery();
            return result;
        }
    }
    /// <summary>
    /// 执行SQL并返回第一行第一列
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="paras"></param>
    /// <returns></returns>
    public static object ExecuteScalar(string sql, params SqlParameter[] paras)
    {
        using (SqlConnection conn = new SqlConnection(ConnStr))
        {
            conn.Open();
            SqlCommand command = new SqlCommand(sql, conn);
            object obj = command.ExecuteScalar();

            return obj;
        }
    }
    public static DataTable GetDataTable(string sql, params SqlParameter[] paras)
    {
        DataTable dt = null;
        using (SqlConnection conn = new SqlConnection(ConnStr))
        {
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddRange(paras);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
        }
        return dt;
    }
    /// <summary>
    /// 执行SQL返回SqlDataReader对象
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="paras"></param>
    /// <returns></returns>
    public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] paras)
    {
        SqlConnection conn = new SqlConnection(ConnStr);

        conn.Open();
        SqlCommand command = new SqlCommand(sql, conn);
        if (paras != null)
        {
            command.Parameters.AddRange(paras);
        }
        return command.ExecuteReader(CommandBehavior.CloseConnection);

    }
    public static DataRow GetDataRow(string sql, params SqlParameter[] paras)
    {
        DataTable dt = null;
        using (SqlConnection conn = new SqlConnection(ConnStr))
        {
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddRange(paras);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
        }
        if (dt.Rows.Count > 0)
            return dt.Rows[0];
        else
            return null;
    }

    public static DataSet GetDataSet(string sql, params SqlParameter[] paras)
    {
        DataSet ds = null;
        using (SqlConnection conn = new SqlConnection(ConnStr))
        {
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddRange(paras);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            ds = new DataSet();
            adapter.Fill(ds);
        }
        return ds;
    }

}

//using System;
//using System.Data;
//using System.Data.Common;
//using System.Configuration;

//public class DbHelper
//{
//    private static readonly string ConnStr = "server=WIN102019JWEHIW;uid=sa;pwd=12;database=Rearch_P";
//    private static string dbProviderName = ConfigurationManager.AppSettings["DbHelperProvider"];
//    private static string dbConnectionString = ConfigurationManager.AppSettings["DbHelperConnectionString"];

//    private DbConnection connection;
//    public DbHelper()
//    {
//        this.connection = CreateConnection(DbHelper.dbConnectionString);
//    }
//    public DbHelper(string connectionString)
//    {
//        this.connection = CreateConnection(connectionString);
//    }
//    public static DbConnection CreateConnection()
//    {
//        DbProviderFactory dbfactory = DbProviderFactories.GetFactory(DbHelper.dbProviderName);
//        DbConnection dbconn = dbfactory.CreateConnection();
//        dbconn.ConnectionString = DbHelper.dbConnectionString;
//        return dbconn;
//    }
//    public static DbConnection CreateConnection(string connectionString)
//    {
//        DbProviderFactory dbfactory = DbProviderFactories.GetFactory(DbHelper.dbProviderName);
//        DbConnection dbconn = dbfactory.CreateConnection();
//        dbconn.ConnectionString = connectionString;
//        return dbconn;
//    }

//    public DbCommand GetStoredProcCommond(string storedProcedure)
//    {
//        DbCommand dbCommand = connection.CreateCommand();
//        dbCommand.CommandText = storedProcedure;
//        dbCommand.CommandType = CommandType.StoredProcedure;
//        return dbCommand;
//    }
//    public DbCommand GetSqlStringCommond(string sqlQuery)
//    {
//        DbCommand dbCommand = connection.CreateCommand();
//        dbCommand.CommandText = sqlQuery;
//        dbCommand.CommandType = CommandType.Text;
//        return dbCommand;
//    }

//    #region 增加参数
//    public void AddParameterCollection(DbCommand cmd, DbParameterCollection dbParameterCollection)
//    {
//        foreach (DbParameter dbParameter in dbParameterCollection)
//        {
//            cmd.Parameters.Add(dbParameter);
//        }
//    }
//    public void AddOutParameter(DbCommand cmd, string parameterName, DbType dbType, int size)
//    {
//        DbParameter dbParameter = cmd.CreateParameter();
//        dbParameter.DbType = dbType;
//        dbParameter.ParameterName = parameterName;
//        dbParameter.Size = size;
//        dbParameter.Direction = ParameterDirection.Output;
//        cmd.Parameters.Add(dbParameter);
//    }
//    public void AddInParameter(DbCommand cmd, string parameterName, DbType dbType, object value)
//    {
//        DbParameter dbParameter = cmd.CreateParameter();
//        dbParameter.DbType = dbType;
//        dbParameter.ParameterName = parameterName;
//        dbParameter.Value = value;
//        dbParameter.Direction = ParameterDirection.Input;
//        cmd.Parameters.Add(dbParameter);
//    }
//    public void AddReturnParameter(DbCommand cmd, string parameterName, DbType dbType)
//    {
//        DbParameter dbParameter = cmd.CreateParameter();
//        dbParameter.DbType = dbType;
//        dbParameter.ParameterName = parameterName;
//        dbParameter.Direction = ParameterDirection.ReturnValue;
//        cmd.Parameters.Add(dbParameter);
//    }
//    public DbParameter GetParameter(DbCommand cmd, string parameterName)
//    {
//        return cmd.Parameters[parameterName];
//    }

//    #endregion

//    #region 执行
//    public DataSet ExecuteDataSet(DbCommand cmd)
//    {
//        DbProviderFactory dbfactory = DbProviderFactories.GetFactory(DbHelper.dbProviderName);
//        DbDataAdapter dbDataAdapter = dbfactory.CreateDataAdapter();
//        dbDataAdapter.SelectCommand = cmd;
//        DataSet ds = new DataSet();
//        dbDataAdapter.Fill(ds);
//        return ds;
//    }

//    public DataTable ExecuteDataTable(DbCommand cmd)
//    {
//        DbProviderFactory dbfactory = DbProviderFactories.GetFactory(DbHelper.dbProviderName);
//        DbDataAdapter dbDataAdapter = dbfactory.CreateDataAdapter();
//        dbDataAdapter.SelectCommand = cmd;
//        DataTable dataTable = new DataTable();
//        dbDataAdapter.Fill(dataTable);
//        return dataTable;
//    }

//    public DbDataReader ExecuteReader(DbCommand cmd)
//    {
//        cmd.Connection.Open();
//        DbDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
//        return reader;
//    }
//    public int ExecuteNonQuery(DbCommand cmd)
//    {
//        cmd.Connection.Open();
//        int ret = cmd.ExecuteNonQuery();
//        cmd.Connection.Close();
//        return ret;
//    }

//    public object ExecuteScalar(DbCommand cmd)
//    {
//        cmd.Connection.Open();
//        object ret = cmd.ExecuteScalar();
//        cmd.Connection.Close();
//        return ret;
//    }
//    #endregion

//    #region 执行事务
//    public DataSet ExecuteDataSet(DbCommand cmd, Trans t)
//    {
//        cmd.Connection = t.DbConnection;
//        cmd.Transaction = t.DbTrans;
//        DbProviderFactory dbfactory = DbProviderFactories.GetFactory(DbHelper.dbProviderName);
//        DbDataAdapter dbDataAdapter = dbfactory.CreateDataAdapter();
//        dbDataAdapter.SelectCommand = cmd;
//        DataSet ds = new DataSet();
//        dbDataAdapter.Fill(ds);
//        return ds;
//    }

//    public DataTable ExecuteDataTable(DbCommand cmd, Trans t)
//    {
//        cmd.Connection = t.DbConnection;
//        cmd.Transaction = t.DbTrans;
//        DbProviderFactory dbfactory = DbProviderFactories.GetFactory(DbHelper.dbProviderName);
//        DbDataAdapter dbDataAdapter = dbfactory.CreateDataAdapter();
//        dbDataAdapter.SelectCommand = cmd;
//        DataTable dataTable = new DataTable();
//        dbDataAdapter.Fill(dataTable);
//        return dataTable;
//    }

//    public DbDataReader ExecuteReader(DbCommand cmd, Trans t)
//    {
//        cmd.Connection.Close();
//        cmd.Connection = t.DbConnection;
//        cmd.Transaction = t.DbTrans;
//        DbDataReader reader = cmd.ExecuteReader();
//        DataTable dt = new DataTable();
//        return reader;
//    }
//    public int ExecuteNonQuery(DbCommand cmd, Trans t)
//    {
//        cmd.Connection.Close();
//        cmd.Connection = t.DbConnection;
//        cmd.Transaction = t.DbTrans;
//        int ret = cmd.ExecuteNonQuery();
//        return ret;
//    }

//    public object ExecuteScalar(DbCommand cmd, Trans t)
//    {
//        cmd.Connection.Close();
//        cmd.Connection = t.DbConnection;
//        cmd.Transaction = t.DbTrans;
//        object ret = cmd.ExecuteScalar();
//        return ret;
//    }
//    #endregion
//}

//public class Trans : IDisposable
//{
//    private DbConnection conn;
//    private DbTransaction dbTrans;
//    public DbConnection DbConnection
//    {
//        get { return this.conn; }
//    }
//    public DbTransaction DbTrans
//    {
//        get { return this.dbTrans; }
//    }

//    public Trans()
//    {
//        conn = DbHelper.CreateConnection();
//        conn.Open();
//        dbTrans = conn.BeginTransaction();
//    }
//    public Trans(string connectionString)
//    {
//        conn = DbHelper.CreateConnection(connectionString);
//        conn.Open();
//        dbTrans = conn.BeginTransaction();
//    }
//    public void Commit()
//    {
//        dbTrans.Commit();
//        this.Colse();
//    }

//    public void RollBack()
//    {
//        dbTrans.Rollback();
//        this.Colse();
//    }

//    public void Dispose()
//    {
//        this.Colse();
//    }

//    public void Colse()
//    {
//        if (conn.State == System.Data.ConnectionState.Open)
//        {
//            conn.Close();
//        }
//    }
//}