
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Chat
{
	[MessagePackObject]
	public class UserChatData
	{
		// Fields
		[Json]
		// [Key]
		public ChatRoomName CurrentRoom;
		[Json]
		// [Key]
		public bool IsModerator;
	
		// Constructors
		public UserChatData() {}
	}
}
