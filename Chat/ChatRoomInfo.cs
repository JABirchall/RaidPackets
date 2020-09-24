
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Chat
{
	[MessagePackObject]
	public class ChatRoomInfo
	{
		// Fields
		[Json]
		// [Key]
		public ChatRoomName Name;
		[Json]
		// [Key]
		public List<long> ActiveUserIds;
	
		// Constructors
		public ChatRoomInfo() {}
		public ChatRoomInfo(ChatRoomName name, List<long> activeUserIds) {}
	}
}
