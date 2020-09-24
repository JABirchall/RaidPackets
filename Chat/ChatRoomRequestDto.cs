
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
	public class ChatRoomRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public long UserId;
		[Json]
		// [Key]
		public ChatRoomGroup RoomGroup;
		[Json]
		// [Key]
		public int RoomNumber;
	
		// Constructors
		public ChatRoomRequestDto() {}
	}
}
