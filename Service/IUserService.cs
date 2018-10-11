using System;

namespace Service
{
    public interface IUserService
    {
        /// <summary>
        /// 注册方法
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        string Register(string username, string password);

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        string Login(string username, string password);
    }
}
