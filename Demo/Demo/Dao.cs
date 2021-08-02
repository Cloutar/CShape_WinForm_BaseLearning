using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//数据库需要的
using System.Data;
using System.Data.SqlClient;

namespace Demo
{
    /// <summary>
    /// DAO (Data Access Object) 数据访问对象 
    /// 是一个面向对象的数据库接口
    /// </summary>
    class Dao
    {

        public SqlConnection connection()
        {
            string str = "Data Source=DESKTOP-6GEU7SQ;Initial Catalog=Demo;User ID=sa;Password=123456;";
            SqlConnection sc = new SqlConnection(str);
            sc.Open();   //打开数据库连接

            return sc;
        }

        //SqlConnection sc1;
        ///// <summary>
        ///// 数据库连接
        ///// </summary>
        //public void connection()
        //{
        //    string str = "Data Source=DESKTOP-6GEU7SQ;Initial Catalog=Demo;User ID=sa;Password=123456;";
        //    SqlConnection sc = new SqlConnection(str);
        //    sc.Open();
        //    this.sc1 = sc;
        //}

        /// <summary>
        /// sql操作
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SqlCommand command(string sql)
        {
            SqlCommand sc = new SqlCommand(sql, connection());

            return sc;
        }

        /// <summary>
        /// 用于delete update insert 返回影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int Excute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }

        /// <summary>
        /// 用于select 返回SqlDataReader对象, 包含select到的数据
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }


    }
}
