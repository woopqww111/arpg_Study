﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOLServer.dao.model;
using NetFrame;

namespace LOLServer.biz.user
{
    public interface IUserBiz
    {
        /// <summary>
        /// 创建召唤师
        /// </summary>
        /// <param name="token"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        bool Create(UserToken token,string name);
        /// <summary>
        /// 获取连接对应的用户信息
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        UserModel get(UserToken token);
        /// <summary>
        /// 通过id获取用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        UserModel get(int id);
        /// <summary>
        /// 用户上线
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        UserModel online(UserToken token);
        /// <summary>
        /// 用户下线
        /// </summary>
        /// <param name="token"></param>
        void offline(UserToken token);
        /// <summary>
        /// 通过id获取连接对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        UserToken getToken(int id);
        /// <summary>
        /// 通过账号的链接对象获取 仅在出事登录验证角色时有效
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        UserModel getByAccount(UserToken token);
    }
}
