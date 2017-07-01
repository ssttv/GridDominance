﻿using System;

namespace MonoSAMFramework.Portable.Network.Multiplayer
{
	public interface INetworkMedium : IDisposable
	{
		byte[] RecieveOrNull();
		void Send(byte[] data);
	}
}