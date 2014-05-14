﻿using Server.Network.PacketSender;
using Server.Network.PacketTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Network.PacketHandler
{
    class LdpDisconnectRequestHandler : ILdpPacketHandler
    {
        public void Handle(LdpPacket packet, ILdpPacketSender channel)
        {
            switch (packet.Type)
            {
                case PacketType.DISCONNECT_REQUEST:
                    var discon = packet.DisconnectRequest;
                    switch (discon.Type)
                    {
                        case DisconnectionType.FROM_SCREEN_THREAD:
                            break;
                        case DisconnectionType.FROM_VOLUME_THREAD:
                            break;
                        case DisconnectionType.FROM_SERVER:
                            break;
                    }
                    break;
            }
        }
    }
}