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
<<<<<<< HEAD
        public async Task<string> ConfirmMail(string username)
=======
        public Task<string> ConfirmMail(string username)
>>>>>>> c25a47e37451c557c00693761f6a5f67f92fba30
        {
            try
            {
                if (string.IsNullOrEmpty(username)) return "Invalid Username";
                LoginInfo oLoginInfo = new LoginInfo()
                {
                    UserName = username
                };
                LoginInfo loginInfo = await this.CheckRecordExistence(oLoginInfo);
                if (loginInfo == null)
                {
                    return Message.InvalidUser;
                }
                else
                {
                    using (IDbConnection con = new SqlConnection(Global.ConnectionString))
                    {
                        if (con.State == ConnectionState.Closed) con.Open();

                        var oLoginInfos = await con.QueryAsync<LoginInfo>("sys.xp_logininfo",
                                this.SetParamerters(oLoginInfo, (int)OperationType.UpdateConfirmed)
                                , commandType: CommandType.StoredProcedure);

                        if (oLoginInfos != null && oLoginInfos.Count() > 0)
                        {
                            _oLoginInfo = oLoginInfos.FirstOrDefault();
                        }
                        return "Mail Confirmed";



                    }
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
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
                            var oLoginInfos = await con.QueryAsync<LoginInfo>("sys.xp_logininfo", 
                                this.SetParamerters(oLoginInfo, (int)OperationType.SignUp)
                                , commandType: CommandType.StoredProcedure);

                            if (oLoginInfos != null && oLoginInfos.Count() > 0) 
                            {
                                _oLoginInfo = oLoginInfos.FirstOrDefault();
                            }
                            _oLoginInfo.Message = Message.Success;
                        }
                        
                    }

                }
                else
                {
                    _oLoginInfo = loginInfo;
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

        private DynamicParameters SetParamerters(LoginInfo ologinInfo, int nOperationType)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@UserInfoId", _oLoginInfo.UserInfoId);
            parameters.Add("@EmailId", _oLoginInfo.EmailId);
            parameters.Add("@Username", _oLoginInfo.UserName);
            parameters.Add("@Password", _oLoginInfo.Password);
            parameters.Add("@IsMailConfirmed", _oLoginInfo.IsMailConfirmed);
            parameters.Add("@UserInfoId", nOperationType);
            return parameters;

        }
        
    }
}
