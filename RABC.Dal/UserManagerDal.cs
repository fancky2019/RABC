using RABC.Model.QueryModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WMS.Model.ViewModels;

namespace RABC.Dal
{
    public class UserManagerDal
    {
        public UserVM Login(UserVM vm)
        {
            string retJson = "error";
            string sql = @"
SELECT  [ID] ,[Account] ,[Password] ,[Status]
      ,[CreateTime] ,[ModityTime]  ,[TimeStamp]
  FROM [RABC].[dbo].[Users]
 where [Account]=@Account ;
";

            SqlParameter paramAccount = new SqlParameter("@Account", vm.Account);
            return DataTableToList.DataSetToList<UserVM>(SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), CommandType.Text, sql, paramAccount)).FirstOrDefault();
        }

        public List<UserMenusVM> GetUserMenus(string account)
        {
            string sql = string.Format(@"
select distinct m.ID, m.[ParentID],m.[FormName] ,m.[TabHeaderText]  ,m.SortCode from  Users u
     join UserRoles  ur  on  u.ID=ur.UserID
	 join RoleMenus rm on ur.RoleID=rm.RoleID
	 join Menus m on rm.MenuID=m.ID
where u.Account='{0}' and m.[Status]=1
order  by m.SortCode
", account);
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), CommandType.Text, sql);
            var list = DataTableToList.DataSetToList<UserMenusVM>(ds);
            return list;
        }

        public (int Count, List<UserVM> UsersList) GetUsers(UsersQM qm)
        {
            try
            {

                StringBuilder selectCountCommand = new StringBuilder(@" SELECT Count([ID]) FROM [RABC].[dbo].[Users] ");

                StringBuilder where = new StringBuilder("where 1 = 1");

                List<SqlParameter> parameters = new List<SqlParameter>();
                if (!string.IsNullOrEmpty(qm.Account))
                {
                    SqlParameter param = new SqlParameter("@Account", string.Format("%{0}%", qm.Account));
                    where.Append(" and Account like @Account");
                    parameters.Add(param);
                }

                selectCountCommand.Append(where.ToString());

                StringBuilder selectDataCommand = new StringBuilder(string.Format(@" 
 select * from 
  (
     select row_number() over (order by a.ID   ) as rowNum, a.*
          from (              
                  SELECT TOP ({0}) 
                    [ID],[Account] ,[Password] FROM [RABC].[dbo].[Users]
                {1}
               ) as a 
  )c
  where c.rowNum>{2}", qm.Take + qm.Skip, where.ToString(), qm.Skip));



                //  DataPagingInfo dataPagingInfo = new DataPagingInfo();
                var list = DataTableToList.DataSetToList<UserVM>(SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), CommandType.Text, selectDataCommand.ToString(), parameters.ToArray()));
                //   dataPagingInfo.DataSoure = JsonConvert.SerializeObject(list);
                //   dataPagingInfo.SearchAllFlg = info.SearchAllFlg;
                //   dataPagingInfo.PageCount = pageCount;
                int count = (int)SqlHelper.ExecuteScalar(SqlHelper.GetConnSting(), CommandType.Text, selectCountCommand.ToString(), parameters.ToArray()); ;
                // retJson = JsonHelper.SerializeObject(dataPagingInfo);
                return (count, list);
            }
            catch (Exception ex)
            {
                return (0, null);
            }


        }


        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="UserVM"></param>
        /// <returns></returns>
        public int AddUser(UserVM user)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                SqlParameter paramAccount = new SqlParameter("@Account", user.Account);
                string exitSql = @" SELECT  count(ID) FROM [dbo].[Users] where Account=@Account ";

                var count = (int)SqlHelper.ExecuteScalar(SqlHelper.GetConnSting(), CommandType.Text, exitSql, new SqlParameter[] { paramAccount });
                if (count > 0)
                {

                    return -1;
                }
                SqlParameter paramPassword = new SqlParameter("@Password", user.Password);
                string sql = @"INSERT INTO [dbo].[Users]
                                               ([Account] ,[Password] )
                                                VALUES
                                               (@Account,@Password) 
";
                return SqlHelper.ExecuteNonQuery(SqlHelper.GetConnSting(), CommandType.Text, sql, new SqlParameter[] { paramAccount, paramPassword });
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int EditUser(UserVM user)
        {
            string retJson = "error";
            StringBuilder sb = new StringBuilder();
            try
            {
                SqlParameter paramAccount = new SqlParameter("@Account", user.Account);
                SqlParameter paramID = new SqlParameter("@ID", user.ID);
                SqlParameter paramPassword = new SqlParameter("@Password", user.Password);
                string updateCommand = @" UPDATE [dbo].[Users]
      SET [Account] =@Account ,
      [Password] = @Password
      where ID=@ID
";

                return SqlHelper.ExecuteNonQuery(SqlHelper.GetConnSting(), CommandType.Text, updateCommand, new SqlParameter[] { paramAccount, paramID, paramPassword });
            }
            catch (Exception ex)
            {
                return 0;
            }


        }


        public List<RolesVM> GetRoles(RolesVM vm)
        {
            try
            {
                //   DataPageRequestInfo info = JsonHelper.DeserializeJsonToObject<DataPageRequestInfo>(strData);
                StringBuilder where = new StringBuilder("where 1 = 1");
                //var qm = JsonConvert.DeserializeAnonymousType(info.Conditions, new { Name = "" });
                //   RolesVM qm = JsonConvert.DeserializeObject<RolesVM>(info.Conditions);
                List<SqlParameter> parameters = new List<SqlParameter>();
                if (!string.IsNullOrEmpty(vm.Name))
                {
                    SqlParameter param = new SqlParameter("@Name", string.Format("%{0}%", vm.Name));
                    where.Append(" and Name like @Name");
                    parameters.Add(param);
                }
                StringBuilder selectDataCommand = new StringBuilder("  SELECT  [ID],[Name] ,[CreateTime] ,[Remark] FROM [RABC].[dbo].[Roles]");
                selectDataCommand.Append(where.ToString());
                return DataTableToList.DataSetToList<RolesVM>(SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), CommandType.Text, selectDataCommand.ToString(), parameters.ToArray()));
                //  retJson = JsonHelper.SerializeObject(list);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 新增角色
        /// </summary>
        /// <param name="UserVM"></param>
        /// <returns></returns>
        public int AddRoles(RolesVM role)
        {

            StringBuilder sb = new StringBuilder();
            try
            {
                SqlParameter paramName = new SqlParameter("@Name", role.Name);
                string exitSql = @" SELECT  count(ID) FROM [dbo].[Roles] where Name=@Name ";

                var count = (int)SqlHelper.ExecuteScalar(SqlHelper.GetConnSting(), CommandType.Text, exitSql, new SqlParameter[] { paramName });
                if (count > 0)
                {
                    return -1;
                }

                string sql = @"INSERT INTO [dbo].[Roles] ([Name]  )  VALUES (@Name) ";
                return SqlHelper.ExecuteNonQuery(SqlHelper.GetConnSting(), CommandType.Text, sql, new SqlParameter[] { paramName });


            }
            catch (Exception ex)
            {
                return -1;
            }


        }

        public int DeleteRoles(List<int> idLiST)
        {
            StringBuilder sb = new StringBuilder();
            try
            {

                List<SqlParameter> paramList = new List<SqlParameter>();
                StringBuilder sql = new StringBuilder(@"DELETE FROM [dbo].[Roles] WHERE ID  in (  ");
                StringBuilder inIDS = new StringBuilder();
                for (int i = 0; i < idLiST.Count; i++)
                {
                    string paramName = String.Format("@ID{0}", i);
                    inIDS.Append(paramName);
                    if (i != idLiST.Count - 1)
                    {
                        inIDS.Append(",");
                    }
                    paramList.Add(new SqlParameter(paramName, idLiST[i]));

                }
                sql.Append(inIDS.ToString());
                sql.Append(" );");
                //RoleMenuAuthorities
                StringBuilder rma = new StringBuilder(@"  DELETE FROM [dbo].[RoleMenuAuthorities]
      WHERE RoleID  in (");
                rma.Append(inIDS.ToString());
                rma.Append(" );");
                //[RoleMenus]

                StringBuilder rm = new StringBuilder(@"  DELETE FROM [dbo].[RoleMenus]
      WHERE [RoleID] in (");
                rm.Append(inIDS.ToString());
                rm.Append(" );");

                //[UserRoles]
                StringBuilder ur = new StringBuilder(@"  DELETE FROM [dbo].[UserRoles]
      WHERE [RoleID] in (");
                ur.Append(inIDS.ToString());
                ur.Append(" );");

                StringBuilder sqlCommand = new StringBuilder();
                sqlCommand.Append(@"
declare @result int =1;
begin try
    begin  tran tr 
");

                sqlCommand.Append(rma.ToString());
                sqlCommand.Append("\r\n");
                sqlCommand.Append(rm.ToString());
                sqlCommand.Append("\r\n");
                sqlCommand.Append(ur.ToString());
                sqlCommand.Append("\r\n");
                sqlCommand.Append(sql.ToString());
                sqlCommand.Append("\r\n");
                sqlCommand.Append(@"
   commit tran tr 
 select  @result 
end try
begin catch
 set @result=-1
 select @result
 ROLLBACK TRAN tr 
end catch
");
                return (int)SqlHelper.ExecuteScalar(SqlHelper.GetConnSting(), CommandType.Text, sqlCommand.ToString(), paramList.ToArray());

            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        public List<RolesVM> GetUserNotHaveRoles(UserRolesVM vm)
        {
            try
            {
                //DataPageRequestInfo info = JsonHelper.DeserializeJsonToObject<DataPageRequestInfo>(strData);
                //StringBuilder where = new StringBuilder("where 1 = 1");
                //var qm = JsonConvert.DeserializeAnonymousType(info.Conditions, new { Name = "" });
                //   RolesVM qm = JsonConvert.DeserializeObject<RolesVM>(info.Conditions);
                //  List<SqlParameter> parameters = new List<SqlParameter>();

                StringBuilder selectDataCommand = new StringBuilder(@"  
select  [ID] ,[Name] ,[CreateTime],[Remark] from  [dbo].[Roles] r
where not exists
  (
  select ur.ID from [dbo].[UserRoles] ur  where ur.RoleID=r.ID and ur.UserID=@UserID
  )
");
                SqlParameter paramUserID = new SqlParameter("@UserID", vm.UserID);
                return DataTableToList.DataSetToList<RolesVM>(SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), CommandType.Text, selectDataCommand.ToString(), paramUserID));

            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public int AddUserRoles(List<UserRolesVM> userRoleList)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                int i = 0;
                using (SqlConnection con = new SqlConnection(SqlHelper.GetConnSting()))
                {

                    con.Open();
                    SqlTransaction tran = con.BeginTransaction();
                    StringBuilder sqlSB = new StringBuilder();
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.Transaction = tran;
                        for (int j = 0; j < userRoleList.Count; j++)
                        {
                            string insertCommand = String.Format(@"INSERT INTO [dbo].[UserRoles] ([UserID],[RoleID]) VALUES  (@UserID{0}  ,@RoleID{0});", j);
                            cmd.Parameters.AddWithValue(string.Format("@UserID{0}", j), userRoleList[j].UserID);
                            cmd.Parameters.AddWithValue(string.Format("@RoleID{0}", j), userRoleList[j].RoleID);
                            sqlSB.Append(insertCommand);
                        }

                        cmd.CommandText = sqlSB.ToString();
                        i = cmd.ExecuteNonQuery();

                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        i = 0;
                    }
                }
                return i;

            }
            catch (Exception ex)
            {
                return 0;
            }
        }




        //private static long SqlBulkCopyInsert()
        //{
        //    Stopwatch stopwatch = new Stopwatch();
        //    stopwatch.Start();
        //    DataTable dt = SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), CommandType.Text, "select  *   from    FROM [RABC].[dbo].[UserRoles] where  ID<0").Tables[0];
        //    string passportKey;
        //    for (int i = 0; i < dt.Columns.Count; i++)
        //    {

        //        DataRow dataRow = dt.NewRow();
        //        dataRow[""] = passportKey;
        //        dataTable.Rows.Add(dataRow);
        //    }
        //    SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(connectionString);
        //    sqlBulkCopy.DestinationTableName = "Passport";
        //    sqlBulkCopy.BatchSize = dataTable.Rows.Count;
        //    SqlConnection sqlConnection = new SqlConnection(connectionString);
        //    sqlConnection.Open();
        //    if (dataTable != null && dataTable.Rows.Count != 0)
        //    {
        //        sqlBulkCopy.WriteToServer(dataTable);
        //    }
        //    sqlBulkCopy.Close(); sqlConnection.Close();
        //    stopwatch.Stop();
        //    return stopwatch.ElapsedMilliseconds;
        //}

        public List<UserRolesVM> GetUserRoles(UserRolesVM vm)
        {
            try
            {
                //  DataPageRequestInfo info = JsonHelper.DeserializeJsonToObject<DataPageRequestInfo>(strData);
                //   StringBuilder where = new StringBuilder("where 1 = 1");
                //   var qm = JsonConvert.DeserializeAnonymousType(info.Conditions, new { Name = "" });
                //List<SqlParameter> parameters = new List<SqlParameter>();
                //if (!string.IsNullOrEmpty(qm.Name))
                //{
                //    SqlParameter param = new SqlParameter("@Name", string.Format("%{0}%", qm.Name));
                //    where.Append(" and Name like @Name");
                //    parameters.Add(param);
                //}
                StringBuilder selectDataCommand = new StringBuilder(@" 
SELECT  ur.ID ,[UserID] ,[RoleID],r.Name RoleName ,u.Account UserName FROM [RABC].[dbo].[UserRoles] ur 
 join  [dbo].[Users] u  on ur.UserID=u.[ID]
 join  [dbo].[Roles] r  on r.ID=ur.RoleID
");
                List<SqlParameter> paramList = new List<SqlParameter>();
                if (vm.UserID != 0)
                {
                    selectDataCommand.Append(" where u.ID=@UserID");
                    SqlParameter paramID = new SqlParameter("@UserID", vm.UserID);
                    paramList.Add(paramID);
                }
                //  selectDataCommand.Append(where.ToString());
                return DataTableToList.DataSetToList<UserRolesVM>(SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), CommandType.Text, selectDataCommand.ToString(), paramList.ToArray()));

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int DeleteUserRoles(UserRolesVM vm)
        {
            StringBuilder sb = new StringBuilder();
            try
            {

                SqlParameter paramID = new SqlParameter("@ID", vm.ID);
                string sql = @"DELETE FROM [dbo].[UserRoles] WHERE  ID=@ID ";
                return SqlHelper.ExecuteNonQuery(SqlHelper.GetConnSting(), CommandType.Text, sql, new SqlParameter[] { paramID });


            }
            catch (Exception ex)
            {
                return 0;
            }


        }


        public List<MenusVM> GetMenus(RoleMenusVM vm)
        {
            try
            {
                //                StringBuilder selectDataCommand = new StringBuilder(@" 
                //  SELECT m.[ID] ,[ParentID] ,[FormName] ,[TabHeaderText],[SortCode] ,[Remark]
                //  FROM [RABC].[dbo].[Menus]  m
                //  where not exists
                //  (
                //  select * from [dbo].[RoleMenus] rm  where rm.MenuID=m.ID and rm.RoleID=@RoleID
                //  )
                //");
                string sql = @"
select * into #NoParents from (
	  SELECT m.[ID] ,[ParentID] ,[FormName] ,[TabHeaderText],[SortCode] ,[Remark],[Status]
	  FROM [RABC].[dbo].[Menus]  m
	  where not exists
	  (
	    select rm.ID from [dbo].[RoleMenus] rm  where rm.MenuID=m.ID and rm.RoleID=@RoleID
	  ) and m.[Status]=1 
  ) t

select * into #parents  from
                (
				select  [ID] ,[ParentID] ,[FormName] ,[TabHeaderText],[SortCode] ,[Remark],[Status]  from  Menus  where ID  in 
					(
					    --查找所有有孩子的父节点
						select ParentID  from  #NoParents 
						where  ParentID<>0 
						group  by ParentID
					) and [Status]=1
				)t1

select *  from #NoParents
union
select  *  from #parents

drop  table #NoParents
drop  table #parents
";
                SqlParameter paramRoleID = new SqlParameter("@RoleID", vm.RoleID);
                //  selectDataCommand.Append(where.ToString());
                return DataTableToList.DataSetToList<MenusVM>(SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), CommandType.Text, sql, paramRoleID));

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int AddRoleMenus(List<MenusVM> list)
        {

            StringBuilder sb = new StringBuilder();
            int i = 0;
            using (SqlConnection con = new SqlConnection(SqlHelper.GetConnSting()))
            {

                con.Open();
                SqlTransaction tran = con.BeginTransaction();
                StringBuilder sqlSB = new StringBuilder();
                try
                {
                    //父节点单独拿出来处理
                    var parents = list.Where(p => p.ParentID == 0).ToList();
                    string existsParentIDS = "SELECT distinct [MenuID] FROM [RABC].[dbo].[RoleMenus] where RoleID= @RoleID";
                    var parentMenuIDS = DataTableToList.DataSetToList<RoleMenusVM>(SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), CommandType.Text, existsParentIDS, new SqlParameter("@RoleID", list.First().RoleID))).Select(p => p.MenuID).ToList();

                    var notEixtParent = parents.Where(p => !parentMenuIDS.Contains(p.ID)).ToList();
                    var dhildren = list.Where(p => p.ParentID != 0).ToList();
                    dhildren.AddRange(notEixtParent);
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.Transaction = tran;
                    for (int j = 0; j < dhildren.Count; j++)
                    {
                        string insertCommand = String.Format(@"INSERT INTO [dbo].[RoleMenus] ([RoleID] ,[MenuID]) VALUES  (@RoleID{0}  ,@MenuID{0});", j);
                        cmd.Parameters.AddWithValue(string.Format("@RoleID{0}", j), dhildren[j].RoleID);
                        cmd.Parameters.AddWithValue(string.Format("@MenuID{0}", j), dhildren[j].ID);
                        sqlSB.Append(insertCommand);
                    }

                    cmd.CommandText = sqlSB.ToString();
                    i = cmd.ExecuteNonQuery();

                    tran.Commit();

                }
                catch (Exception ex)
                {
                    i = 0;
                }
            }

            return i;


        }
        public List<RoleMenusVM> GetRoleMenus(RoleMenusVM vm)
        {
            try
            {
                StringBuilder selectDataCommand = new StringBuilder(@" 
 select  rm.[ID],rm.[RoleID], rm.[MenuID],r.Name  RoleName,m.TabHeaderText MenuName ,m.ParentID  from  [dbo].[RoleMenus] rm
  join [dbo].[Roles] r on rm.RoleID=r.ID
  join [dbo].[Menus] m on rm.MenuID =m.ID
");
                StringBuilder where = new StringBuilder(" where 1=1 and m.[Status]=1 ");
                List<SqlParameter> paramList = new List<SqlParameter>();
                if (!string.IsNullOrEmpty(vm.RoleName))
                {
                    where.Append(" and r.Name  like @RoleName");
                    SqlParameter paramRoleName = new SqlParameter("@RoleName", string.Format("%{0}%", vm.RoleName));
                    paramList.Add(paramRoleName);
                }
                if (!string.IsNullOrEmpty(vm.MenuName))
                {
                    where.Append(" and m.TabHeaderText  like @MenuName");
                    SqlParameter paramMenuName = new SqlParameter("@MenuName", string.Format("%{0}%", vm.MenuName));
                    paramList.Add(paramMenuName);
                }
                if (vm.RoleID != 0)
                {
                    where.Append(" and r.ID  = @RoleID");
                    SqlParameter paramRoleID = new SqlParameter("@RoleID", vm.RoleID);
                    paramList.Add(paramRoleID);
                }
                selectDataCommand.Append(where.ToString());


                return DataTableToList.DataSetToList<RoleMenusVM>(SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), CommandType.Text, selectDataCommand.ToString(), paramList.ToArray()));

            }
            catch (Exception ex)
            {
                return null;
            }


        }
        public int DeleteRoleMenus(RoleMenusVM vm)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                string sql = @"
begin try
    begin  tran tr
		declare @parentID int =0;
		select  @parentID=ParentID  from [dbo].[Menus]  where id=@MenuID
		if(@parentID!=0)--子节点
			begin
			  delete  from [dbo].[RoleMenus] where MenuID=@MenuID and RoleID=@RoleID
			end
		else--要删除的是父节点
		   begin
			--删除所有子节点和该节点
			delete  from [dbo].[RoleMenus] where MenuID in (select ID  from [dbo].[Menus] where ParentID=@MenuID or ID=@MenuID  )and RoleID=@RoleID;
		   end
   commit tran tr
end try
begin catch
 ROLLBACK TRAN tr 
end catch
";

                SqlParameter paramMenuID = new SqlParameter("@MenuID", vm.MenuID);
                SqlParameter paramRoleID = new SqlParameter("@RoleID", vm.RoleID);
                return SqlHelper.ExecuteNonQuery(SqlHelper.GetConnSting(), CommandType.Text, sql, new SqlParameter[] { paramMenuID, paramRoleID });
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        public List<MenusVM> GetAllMenus(MenusVM vm)
        {
            try
            {
                StringBuilder selectDataCommand = new StringBuilder(@" 
SELECT  [ID] ,[ParentID] ,[FormName] ,[TabHeaderText]
      ,[SortCode] ,[Remark]
  FROM [RABC].[dbo].[Menus]
where [Status]=1
");
                List<SqlParameter> parameters = new List<SqlParameter>();
                if (!string.IsNullOrEmpty(vm.FormName))
                {
                    selectDataCommand.Append(" and [FormName] like @FormName");
                    parameters.Add(new SqlParameter("@FormName", string.Format("%{0}%", vm.FormName)));
                }
                if (!string.IsNullOrEmpty(vm.TabHeaderText))
                {
                    selectDataCommand.Append(" and [TabHeaderText] like @TabHeaderText");
                    parameters.Add(new SqlParameter("@TabHeaderText", string.Format("%{0}%", vm.TabHeaderText)));
                }
                return DataTableToList.DataSetToList<MenusVM>(SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), CommandType.Text, selectDataCommand.ToString(), parameters.ToArray()));
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public int AddAuthorities(AuthoritiesVM vm)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                string sql = @" 
INSERT INTO [dbo].[Authorities]
           ([MenuID],[Name])
     VALUES
         (@MenuID,@Name );
";
                SqlParameter paramMenuID = new SqlParameter("@MenuID", vm.MenuID);
                SqlParameter paramName = new SqlParameter("@Name", vm.Name);
                return SqlHelper.ExecuteNonQuery(SqlHelper.GetConnSting(), CommandType.Text, sql, new SqlParameter[] { paramMenuID, paramName });


            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public List<AuthoritiesVM> GetAuthorities(AuthoritiesVM vm)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                StringBuilder sql = new StringBuilder(@"
select  a.ID,a.Name,m.TabHeaderText MenuName  from [dbo].[Authorities] a
join [dbo].[Menus] m on a.[MenuID]=m.ID 

");
                List<SqlParameter> paramList = new List<SqlParameter>();
                StringBuilder where = new StringBuilder(" where 1=1 and m.[Status]=1 ");
                if (!string.IsNullOrEmpty(vm.MenuName))
                {
                    where.Append(" and m.TabHeaderText like @MenuName");
                    SqlParameter paramMenuName = new SqlParameter("@MenuName", string.Format("%{0}%", vm.MenuName));
                    paramList.Add(paramMenuName);
                }
                if (!string.IsNullOrEmpty(vm.Name))
                {
                    where.Append(" and a.Name like @Name");
                    SqlParameter paramName = new SqlParameter("@Name", string.Format("%{0}%", vm.Name));
                    paramList.Add(paramName);
                }
                if (vm.MenuID != 0)
                {
                    where.Append(" and a.MenuID = @MenuID");
                    SqlParameter paramMenuID = new SqlParameter("@MenuID", vm.MenuID);
                    paramList.Add(paramMenuID);
                }
                sql.Append(where);
                return DataTableToList.DataSetToList<AuthoritiesVM>(SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), CommandType.Text, sql.ToString(), paramList.ToArray()));

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int DeleteAuthorities(AuthoritiesVM vm)
        {
            StringBuilder sb = new StringBuilder();
            try
            {

                SqlParameter paramID = new SqlParameter("@ID", vm.ID);
                string sql = @"DELETE FROM [dbo].[Authorities] WHERE  ID=@ID ";
                return SqlHelper.ExecuteNonQuery(SqlHelper.GetConnSting(), CommandType.Text, sql, new SqlParameter[] { paramID });
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        public List<RoleMenuAuthoritiesVM> GetRoleMenuAuthorities(RoleMenuAuthoritiesVM vm)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                StringBuilder sql = new StringBuilder(@"
select  rma.ID,m.TabHeaderText MenuName,r.Name RoleName ,a.Name AuthorityName 
from [dbo].[RoleMenuAuthorities] rma
 join [dbo].[Menus] m on rma.[MenuID]=m.ID
 join [dbo].[Roles] r on rma.RoleID=r.ID
 join [dbo].[Authorities] a on a.ID=rma.AuthorityID
");
                List<SqlParameter> paramList = new List<SqlParameter>();
                StringBuilder where = new StringBuilder(" where 1=1 and m.[Status]=1 ");
                if (!string.IsNullOrEmpty(vm.MenuName))
                {
                    where.Append(" and m.TabHeaderText like @MenuName");
                    SqlParameter paramMenuName = new SqlParameter("@MenuName", string.Format("%{0}%", vm.MenuName));
                    paramList.Add(paramMenuName);
                }
                if (!string.IsNullOrEmpty(vm.RoleName))
                {
                    where.Append(" and r.Name like @RoleName");
                    SqlParameter paramRoleName = new SqlParameter("@RoleName", string.Format("%{0}%", vm.RoleName));
                    paramList.Add(paramRoleName);
                }
                sql.Append(where);
                return DataTableToList.DataSetToList<RoleMenuAuthoritiesVM>(SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), CommandType.Text, sql.ToString(), paramList.ToArray()));

            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public int DeleteRoleMenuAuthority(RoleMenuAuthoritiesVM vm)
        {
            StringBuilder sb = new StringBuilder();
            try
            {

                SqlParameter paramID = new SqlParameter("@ID", vm.ID);
                string sql = @"DELETE FROM [dbo].[RoleMenuAuthorities] WHERE  ID=@ID ";
                return SqlHelper.ExecuteNonQuery(SqlHelper.GetConnSting(), CommandType.Text, sql, new SqlParameter[] { paramID });
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        public int AddRoleMenuAuthorities(RoleMenuAuthoritiesVM vm)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                string sql = @" 
INSERT INTO [dbo].[RoleMenuAuthorities]
           ([AuthorityID] ,[RoleID] ,[MenuID])
     VALUES
         (@AuthorityID,@RoleID,@MenuID );
";
                SqlParameter paramAuthorityID = new SqlParameter("@AuthorityID", vm.AuthorityID);
                SqlParameter paramRoleID = new SqlParameter("@RoleID", vm.RoleID);
                SqlParameter paramMenuID = new SqlParameter("@MenuID", vm.MenuID);
                return SqlHelper.ExecuteNonQuery(SqlHelper.GetConnSting(), CommandType.Text, sql, new SqlParameter[] { paramAuthorityID, paramRoleID, paramMenuID });


            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        /// <summary>
        /// 界面按钮权限 
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        public List<FormRoleMenuAuthoritiesVM> GetFormRoleMenuAuthorities(FormRoleMenuAuthoritiesVM vm)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                string sql = @"
select u.ID,u.Account,a.Name AuthorityName,m.FormName  from  Users u
     join UserRoles  ur  on  u.ID=ur.UserID
	 join RoleMenus rm on ur.RoleID=rm.RoleID
	 join Menus m on rm.MenuID=m.ID
	 join RoleMenuAuthorities rma on m.ID=rma.MenuID and rma.RoleID=ur.RoleID
	 join Authorities a on rma.AuthorityID=a.ID
	 where u.Account=@Account and m.FormName=@FormName and m.[Status]=1
";
                List<SqlParameter> paramList = new List<SqlParameter>();

                SqlParameter paramAccount = new SqlParameter("@Account", vm.Account);
                SqlParameter paramFormName = new SqlParameter("@FormName", vm.FormName);
                paramList.Add(paramAccount);
                paramList.Add(paramFormName);

                return DataTableToList.DataSetToList<FormRoleMenuAuthoritiesVM>(SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), CommandType.Text, sql, paramList.ToArray()));
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 新增角色
        /// </summary>
        /// <param name="UserVM"></param>
        /// <returns></returns>
        public int AddMenus(MenusVM vm)
        {
            StringBuilder sb = new StringBuilder();
            try
            {

                string sql = "";
                int maxSortCode = 0;
                if (vm.ParentID != 0)//插入的是子菜单
                {
                    sql = @"
begin try
    begin  tran tr
		declare @maxSortCode int =0;
		select  @maxSortCode=MAX([SortCode])  from [dbo].[Menus]  where [ParentID]=@ParentID
	set	@maxSortCode+=1;
	select @maxSortCode;
		 INSERT INTO [dbo].[Menus]
           ([ParentID] ,[FormName] ,[TabHeaderText],[SortCode],[Status])
     VALUES
           (@ParentID,@FormName,@TabHeaderText,@maxSortCode,@Status)
		
   commit tran tr
end try
begin catch
 ROLLBACK TRAN tr 
end catch
";
                }
                else//插入的是父节点
                {
                    sql = @" 
begin try
    begin  tran tr
		declare @currentInsertID int =0;
		 INSERT INTO [dbo].[Menus]
           ([ParentID] ,[FormName] ,[TabHeaderText],[SortCode],[Status])
     VALUES
            (@ParentID,@FormName,@TabHeaderText,0,@Status)
	select	@currentInsertID= ident_current('[RABC].[dbo].[Menus]');
	update  [dbo].[Menus] set [SortCode]=@currentInsertID*100 where ID=@currentInsertID;
   commit tran tr
end try
begin catch
 ROLLBACK TRAN tr 
end catch

";
                }

                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@ParentID", vm.ParentID));
                parameters.Add(new SqlParameter("@FormName", vm.FormName));
                parameters.Add(new SqlParameter("@TabHeaderText", vm.TabHeaderText));
                parameters.Add(new SqlParameter("@Status", vm.Status));

                return SqlHelper.ExecuteNonQuery(SqlHelper.GetConnSting(), CommandType.Text, sql, parameters.ToArray());
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        public List<FormRoleMenuAuthoritiesVM> GetParentMenus()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                string sql = @"
SELECT  [ID] ,[ParentID]
      ,[FormName],[TabHeaderText]
      ,[SortCode] ,[Remark],[Status]
  FROM [RABC].[dbo].[Menus]
  where ParentID=0 and [Status]=1
";
                return DataTableToList.DataSetToList<FormRoleMenuAuthoritiesVM>(SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), CommandType.Text, sql));

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int DeleteMenus(List<int> idLiST)
        {
            StringBuilder sb = new StringBuilder();
            try
            {

                List<SqlParameter> paramList = new List<SqlParameter>();
                StringBuilder sql = new StringBuilder(@"DELETE FROM [dbo].[Menus] WHERE ID  in (  ");
                StringBuilder inIDS = new StringBuilder();
                for (int i = 0; i < idLiST.Count; i++)
                {
                    string paramName = String.Format("@ID{0}", i);
                    inIDS.Append(paramName);
                    if (i != idLiST.Count - 1)
                    {
                        inIDS.Append(",");
                    }
                    paramList.Add(new SqlParameter(paramName, idLiST[i]));

                }
                sql.Append(inIDS.ToString());
                sql.Append(" );");
                //RoleMenuAuthorities
                StringBuilder rma = new StringBuilder(@"  DELETE FROM [dbo].[RoleMenuAuthorities]
      WHERE [MenuID]  in (");
                rma.Append(inIDS.ToString());
                rma.Append(" );");
                //[RoleMenus]

                StringBuilder rm = new StringBuilder(@"  DELETE FROM [dbo].[RoleMenus]
      WHERE [MenuID] in (");
                rm.Append(inIDS.ToString());
                rm.Append(" );");

                //[Authorities]
                StringBuilder ur = new StringBuilder(@"  DELETE FROM [dbo].[Authorities]
      WHERE [MenuID] in (");
                ur.Append(inIDS.ToString());
                ur.Append(" );");

                StringBuilder sqlCommand = new StringBuilder();
                sqlCommand.Append(@"
declare @result int =1;
begin try
    begin  tran tr 
");

                sqlCommand.Append(rma.ToString());
                sqlCommand.Append("\r\n");
                sqlCommand.Append(rm.ToString());
                sqlCommand.Append("\r\n");
                sqlCommand.Append(ur.ToString());
                sqlCommand.Append("\r\n");
                sqlCommand.Append(sql.ToString());
                sqlCommand.Append("\r\n");
                sqlCommand.Append(@"
   commit tran tr 
 select  @result 
end try
begin catch
 set @result=-1
 select @result
 ROLLBACK TRAN tr 
end catch
");
                return (int)SqlHelper.ExecuteScalar(SqlHelper.GetConnSting(), CommandType.Text, sqlCommand.ToString(), paramList.ToArray());

            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        public int DeleteUsers(UserVM vm)
        {
            StringBuilder sb = new StringBuilder();
            try
            {

                List<SqlParameter> paramList = new List<SqlParameter>();

                StringBuilder sql = new StringBuilder(@" DELETE FROM  [dbo].[Users] WHERE ID  =@UserID ;  ");

                StringBuilder ur = new StringBuilder(@"  DELETE FROM [dbo].[UserRoles] WHERE [UserID] =@UserID;");
                StringBuilder sqlCommand = new StringBuilder();
                sqlCommand.Append(@"
declare @result int =1;
begin try
    begin  tran tr 
");
                sqlCommand.Append(ur.ToString());
                sqlCommand.Append("\r\n");
                sqlCommand.Append(sql.ToString());
                sqlCommand.Append("\r\n");
                sqlCommand.Append(@"
   commit tran tr 
 select  @result 
end try
begin catch
 set @result=-1
 select @result
 ROLLBACK TRAN tr 
end catch
");
                paramList.Add(new SqlParameter("@UserID", vm.ID));
                return (int)SqlHelper.ExecuteScalar(SqlHelper.GetConnSting(), CommandType.Text, sqlCommand.ToString(), paramList.ToArray());

            }
            catch (Exception ex)
            {
                return 0;
            }
        }

    }


}
