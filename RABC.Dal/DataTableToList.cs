using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace RABC.Dal
{
    public class DataTableToList
    {
        #region 将从数据中获取的数据装换成泛型实体
        /// <summary>
        /// 将从数据中获取的数据装换成泛型实体
        /// </summary>
        /// <typeparam name="T">要获得的数据类型</typeparam>
        /// <param name="dataSet">要转化成泛型list的dataset数据源</param>
        /// <param name="tableIndex">表索引</param>
        /// <returns></returns>
        public static List<T> DataSetToList<T>(DataSet dataSet, int tableIndex = 0)
        {
            //确认参数有效
            if (dataSet == null || dataSet.Tables.Count <= 0 || tableIndex < 0)
            {
                return null;
            }
            DataTable dt = dataSet.Tables[tableIndex];
            List<T> list = new List<T>();
            //遍历所有行
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //创建泛型对象(用于保存遍历该行的数据）
                T _t = Activator.CreateInstance<T>();
                //获取对象所有属性
                PropertyInfo[] propertyInfo = _t.GetType().GetProperties();
                //遍历所有列
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    foreach (PropertyInfo info in propertyInfo)
                    {
                        if (dt.Columns[j].ColumnName.Equals(info.Name))
                        {
                            if (dt.Rows[i][j] != DBNull.Value)
                            {
                                info.SetValue(_t, dt.Rows[i][j], null);
                            }
                            else
                            {
                                info.SetValue(_t, null, null);
                            }
                            break;
                        }
                    }
                }
                list.Add(_t);
            }
            return list;
        }
        #endregion

        //    /// <summary>
        //    ///   LR添加
        //    /// </summary>
        //    /// <param name="selectComand">SQL命令</param>
        //    /// <returns></returns>
        //    public T GetSingle<T>(string selectComand)
        //    {
        //        using (IDbConnection iConn = this.GetConnection())
        //        {
        //            using (IDbCommand iCmd = GetCommand(selectComand, iConn))
        //            {
        //                DataSet ds = new DataSet();
        //                try
        //                {
        //                    IDataAdapter iDataAdapter = this.GetAdapater(selectComand, iConn);
        //                    iDataAdapter.Fill(ds);
        //                    return ds.Tables[0].Rows[0][0] == DBNull.Value ? default(T) : (T)ds.Tables[0].Rows[0][0];
        //                }
        //                catch (SqlException ex)
        //                {
        //                    WriteLog.WriteAppLog("", ex.ToString());
        //                    return default(T);
        //                }
        //                catch (System.Exception e)
        //                {
        //                    WriteLog.WriteAppLog("", e.ToString());
        //                    return default(T);
        //                }
        //                finally
        //                {
        //                    if (iConn.State != ConnectionState.Closed)
        //                    {
        //                        iConn.Close();
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
