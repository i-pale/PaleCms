﻿using System.Linq;
using PL.Tools;
using PL.Models.Core;
using PL.ViewModel;

namespace PL.Services.Core.Interface
{
    /// <summary>
    /// 账户模块业务接口
    /// </summary>
    public interface IAccountService 
    {

        #region 属性
        IQueryable<User> Users { get; }
        #endregion

        #region 公共方法

        /// <summary>
        ///   用户登录
        /// </summary>
        /// <param name="loginInfo">登录信息</param>
        /// <returns>业务操作结果</returns>
        OperationResult Login(LoginVM loginVM);

        /// <summary>
        /// 用户退出
        /// </summary>
        void Logout();

        #endregion
    }
}
