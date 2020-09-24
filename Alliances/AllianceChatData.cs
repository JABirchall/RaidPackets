
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Chat;



namespace SharedModel.Meta.Alliances
{
	[MessagePackObject]
	public class AllianceChatData
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<ChatRoomName, AllianceChatRoomData> Rooms;
		[Json]
		// [Key]
		public DateTime? LastChatActivity;
	
		// Constructors
		public AllianceChatData() {}
	}
}
