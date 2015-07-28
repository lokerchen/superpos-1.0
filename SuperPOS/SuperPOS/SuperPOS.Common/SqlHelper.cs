using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using NHibernate;

namespace SuperPOS.Common
{
    public class SqlHelper
    {
        #region 执行一个不需要返回值的 SqlCommand 命令
        /// <summary>
        /// 执行一个不需要返回值的 SqlCommand 命令
        /// </summary>
        /// <param name="session">ISession，包含连接IDbConnection</param>
        /// <param name="cmdText">数据库表名称</param>
        /// <returns>此命令影响的记录条数</returns>
        public static int ExecuteNonQuery(ISession session, string cmdText)
        {
            using (session)
            {
                IDbConnection conn = session.Connection;
                SqlCommand cmd = new SqlCommand
                {
                    Connection = (SqlConnection)conn,
                    CommandType = CommandType.Text,
                    CommandText = cmdText
                };

                return cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region 执行存储过程的方法
        /// <summary>
        /// 执行存储过程的方法
        /// </summary>
        /// <param name="session">ISession，包含连接IDbConnectio</param>
        /// <param name="spName">存储过程名称</param>
        /// <param name="paramInfos">参数</param>
        /// <returns></returns>
        public static List<StructClass.ReturnMsgInfo> ExecuteStoredProc(ISession session, string spName, List<StructClass.ParamInfo> paramInfos)
        {
            List<StructClass.ReturnMsgInfo> returnMsg = new List<StructClass.ReturnMsgInfo>();
            using (session)
            {
                IDbConnection conn = session.Connection;
                SqlCommand cmd = new SqlCommand
                {
                    Connection = (SqlConnection)conn,
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 3600,
                    CommandText = spName
                };
                // 加入参数
                if (paramInfos != null)
                {
                    foreach (StructClass.ParamInfo info in paramInfos)
                    {
                        IDbDataParameter parameter = cmd.CreateParameter();
                        parameter.ParameterName = info.Name;
                        parameter.Value = info.Value;
                        parameter.Direction = info.Direction;
                        parameter.DbType = info.Type;
                        parameter.Size = info.Size;
                        cmd.Parameters.Add(parameter);
                    }
                }
                cmd.ExecuteNonQuery();
                foreach (IDbDataParameter item in cmd.Parameters)
                {
                    switch (item.Direction)
                    {
                        case ParameterDirection.ReturnValue:
                        case ParameterDirection.InputOutput:
                        case ParameterDirection.Output:
                            StructClass.ReturnMsgInfo msgInfo = new StructClass.ReturnMsgInfo
                            {
                                Name = item.ParameterName,
                                ReturnMsg = item.Value.ToString()
                            };
                            returnMsg.Add(msgInfo);
                            break;
                    }
                }
            }
            return returnMsg;
        }
        #endregion
    }
}
