using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using RABC.Common;

namespace RABC.Dal
{
    public class DapperHelper
    {
        static string _conStr = string.Empty;
        static DapperHelper()
        {
            _conStr = SystemConfig.RABCConnectionString;
        }

        public static List<T> Query<T>(string sql, object param = null,bool transaction = false)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_conStr))
                {
                    IDbTransaction tran = transaction ? con.BeginTransaction() : null;
                    return con.Query<T>(sql, param, tran).ToList();
                }
            }
            catch (Exception ex)
            {
                Log.Error<DapperHelper>(ex.ToString());
                return null;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static T ExecuteScalar<T>(string sql, object param = null, bool transaction = false)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_conStr))
                {
                    IDbTransaction tran = transaction ? con.BeginTransaction() : null;
                    return con.ExecuteScalar<T>(sql, param, tran);
                }
            }
            catch (Exception ex)
            {
                Log.Error<DapperHelper>(ex.ToString());
                return default(T);
            }
        }

        /// <summary>
        /// 执行修改语句
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static int Execute(string sql, object param = null, bool transaction = false)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_conStr))
                {
                    IDbTransaction tran = transaction ? con.BeginTransaction() : null;
                    return con.Execute(sql, param, tran);
                }
            }
            catch (Exception ex)
            {
                Log.Error<DapperHelper>(ex.ToString());
                return 0;
            }
        }
    }
}
