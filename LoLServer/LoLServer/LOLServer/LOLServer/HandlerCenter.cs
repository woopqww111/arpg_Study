/* ==============================================================================
2  * 功能描述：HandlerCenter  
3  * 创 建 者：seven_words
4  * 创建日期：2017/12/14 20:25:51
5  * ==============================================================================*/
using System;
using LOLServer.logic;
using LOLServer.logic.login;
using NetFrame;
namespace LOLServer
{
    /// <summary>
    /// HandlerCenter
    /// </summary>
    public class HandlerCenter : AbsHandlerCenter
    {
        IHandleInterface login;

        public HandlerCenter()
        {
            login = new LoginHandler();
        }
        public override void ClientClose(UserToken token, string error)
        {
            Console.WriteLine("有客户端断开链接了");
        }

        public override void ClientConnect(UserToken token)
        {
            Console.WriteLine("有客户端链接了");
        }

        public override void MessageReceive(UserToken token, object message)
        {
            SocketModel model = message as SocketModel;
            switch (model.type)
            {
                case Protocol.Protocol.TYPE_LOGIN:
                    login.MessageReceive(token,model);
                    break;
               
                    
            }
        }
    }
}