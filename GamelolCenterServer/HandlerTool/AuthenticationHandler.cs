﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AceNetFrame.ace;
using AceNetFrame.ace.auto;
using SerializableDataMessage;
using GamelolCenterServer.PropetryServer;

namespace GamelolCenterServer.HandlerTool
{
    public class AuthenticationHandler : HanderInterface
    {
        public void ClientClose(UserToken token)
        {
            throw new NotImplementedException();
        }

        public void MessageRecevie(UserToken token, SocketModel message)
        {
            AuthenticationMessage authenticationMessage = message.getMessage<AuthenticationMessage>();
            token.playerId = authenticationMessage.playerId;
            HandlerCenter.playerToken.Add(token.playerId, token);
            PropetryNetWork.Instance.write(message);
        }
    }
}