﻿using System;
using LiteNetLib.Utils;
using Model;

namespace Network.Messages.System
{
	public class ResponseClientIntroducerRegistrationMessage : BaseMessage
	{
		public ResponseClientIntroducerRegistrationMessage()
			: base((ushort)CustomMessageType.ResponseClientIntroducerRegistration)
		{
		}

		public Machine Machine { get; set; }

		public override void WritePayload(NetDataWriter message)
		{
			base.WritePayload(message);
			Machine.WritePayload(message);
		}

		public override void ReadPayload(NetDataReader message)
		{
			base.ReadPayload(message);
			Machine = new Machine();
			Machine.ReadPayload(message);
		}
	}
}
