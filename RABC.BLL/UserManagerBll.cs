using RABC.Dal;
using RABC.Model.QueryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS.Model.ViewModels;

namespace RABC.BLL
{
    public class UserManagerBll
    {
        static UserManagerDal _dal = null;
        static UserManagerBll()
        {
            _dal = new UserManagerDal();
        }



        public UserVM Login(UserVM vm)
        {
            return _dal.Login(vm);
        }

        public List<UserMenusVM> GetUserMenus(string account)
        {

            return _dal.GetUserMenus(account);
        }

        public (int Count, List<UserVM> UsersList) GetUsers(UsersQM qm)
        {
            return _dal.GetUsers(qm);
        }


        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="UserVM"></param>
        /// <returns></returns>
        public int AddUser(UserVM user)
        {
            return _dal.AddUser(user);
        }

        public int EditUser(UserVM user)
        {
            return _dal.EditUser(user);
        }


        public List<RolesVM> GetRoles(RolesVM vm)
        {
            return _dal.GetRoles(vm);
        }

        /// <summary>
        /// 新增角色
        /// </summary>
        /// <param name="UserVM"></param>
        /// <returns></returns>
        public int AddRoles(RolesVM vm)
        {
            return _dal.AddRoles(vm);
        }

        public int DeleteRoles(List<int> idLiST)
        {
            return _dal.DeleteRoles(idLiST);
        }


        public List<RolesVM> GetUserNotHaveRoles(UserRolesVM vm)
        {
            return _dal.GetUserNotHaveRoles(vm);
        }


        public int AddUserRoles(List<UserRolesVM> userRoleList)
        {
            return _dal.AddUserRoles(userRoleList);
        }




        //private static long SqlBulkCopyInsert()
        //{
        //    Stopwatch stopwatch = new Stopwatch();
        //    stopwatch.Start();
        //    DataTable dt = SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), CommandType.Text, "select  *   from    FROM [ClearAPEXDB].[dbo].[UserRoles] where  ID<0").Tables[0];
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
            return _dal.GetUserRoles(vm);
        }

        public int DeleteUserRoles(UserRolesVM vm)
        {
            return _dal.DeleteUserRoles(vm);
        }


        public List<MenusVM> GetMenus(RoleMenusVM vm)
        {
            return _dal.GetMenus(vm);
        }

        public int AddRoleMenus(List<MenusVM> list)
        {
            return _dal.AddRoleMenus(list);

        }
        public List<RoleMenusVM> GetRoleMenus(RoleMenusVM vm)
        {
            return _dal.GetRoleMenus(vm);

        }
        public int DeleteRoleMenus(RoleMenusVM vm)
        {
            return _dal.DeleteRoleMenus(vm);
        }


        public List<MenusVM> GetAllMenus(MenusVM vm)
        {
            return _dal.GetAllMenus(vm);
        }


        public int AddAuthorities(AuthoritiesVM vm)
        {
            return _dal.AddAuthorities(vm);
        }

        public List<AuthoritiesVM> GetAuthorities(AuthoritiesVM vm)
        {
            return _dal.GetAuthorities(vm);
        }

        public int DeleteAuthorities(AuthoritiesVM vm)
        {
            return _dal.DeleteAuthorities(vm);
        }


        public List<RoleMenuAuthoritiesVM> GetRoleMenuAuthorities(RoleMenuAuthoritiesVM vm)
        {
            return _dal.GetRoleMenuAuthorities(vm);
        }


        public int DeleteRoleMenuAuthority(RoleMenuAuthoritiesVM vm)
        {
            return _dal.DeleteRoleMenuAuthority(vm);
        }


        public int AddRoleMenuAuthorities(RoleMenuAuthoritiesVM vm)
        {
            return _dal.AddRoleMenuAuthorities(vm);
        }

        /// <summary>
        /// 界面按钮权限 
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        public List<FormRoleMenuAuthoritiesVM> GetFormRoleMenuAuthorities(FormRoleMenuAuthoritiesVM vm)
        {
            return _dal.GetFormRoleMenuAuthorities(vm);
        }

        /// <summary>
        /// 新增角色
        /// </summary>
        /// <param name="UserVM"></param>
        /// <returns></returns>
        public int AddMenus(MenusVM vm)
        {
            return _dal.AddMenus(vm);
        }

        public List<FormRoleMenuAuthoritiesVM> GetParentMenus()
        {
            return _dal.GetParentMenus();
        }

        public int DeleteMenus(List<int> idLiST)
        {
            return _dal.DeleteMenus(idLiST);
        }


        public int DeleteUsers(UserVM vm)
        {
            return _dal.DeleteUsers(vm);
        }
    }
}
