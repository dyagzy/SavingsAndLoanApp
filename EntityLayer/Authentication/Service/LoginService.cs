using Dapper;
using EntityLayer.Authentication.Common;
using EntityLayer.Authentication.IService;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Authentication.Service
{
    public class LoginService : ILoginService
    {
        LoginInfo _oLoginInfo = new LoginInfo();
        public Task<string> ConfirmMail(string username)
        {
            throw new NotImplementedException();
        }

        public async Task<LoginInfo> SignUp(LoginInfo oLoginInfo)
        {
            _oLoginInfo = new LoginInfo();
            try
            {
                LoginInfo loginInfo = await this.CheckRecordExistence(oLoginInfo);
                if (loginInfo == null )
                {
                    using (IDbConnection con = new SqlConnection(Global.ConnectionString))
                    {
                        if (con.State == ConnectionState.Closed) con.Open();
                        {
                            var oLoginInfos = await con.QueryAsync<LoginInfo>("");
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                _oLoginInfo.Message = ex.Message;
            }

            return _oLoginInfo;

        }

        private async Task<LoginInfo> CheckRecordExistence(LoginInfo oLoginInof)
        {
            LoginInfo loginInfo = new LoginInfo();
            if (!string.IsNullOrEmpty(oLoginInof.UserName))
            {
                loginInfo = await this.GetLoginUser(oLoginInof.UserName);
                if (loginInfo != null)
                {
                    if (!loginInfo.IsMailConfirmed)
                    {
                        loginInfo.Message = Message.VerifyMail;
                    }
                    else if (loginInfo.IsMailConfirmed)
                    {
                        loginInfo.Message = Message.UserAllReadyCreated;
                    }
                }
            }
            return oLoginInof;
        }

        public async Task<LoginInfo> GetLoginUser(string username)
        {
            _oLoginInfo = new LoginInfo();
            using(IDbConnection con = new SqlConnection(Global.ConnectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();

                string sSQL = "SELECT * FROM  LoginInfos WHERE 1 = 1 ";
                if (!string.IsNullOrEmpty(username)) sSQL += "AND Username=" +"'" + username + "'";
                var oLoginInfos = (await con.QueryAsync<LoginInfo>(sSQL)).ToList();
                if (oLoginInfos != null && oLoginInfos.Count > 0) _oLoginInfo = oLoginInfos.SingleOrDefault();
                else return null;

                
            }
            return _oLoginInfo;
        }

    }
}
