
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
	public class ChatSelectRoomRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public long UserId;
		[Json]
		// [Key]
		public string Locale;
		[Json]
		// [Key]
		public ChatRoomGroup? Group;
		[Json]
		// [Key]
		public int Level;
	
		// Constructors
		public ChatSelectRoomRequestDto() {}
	}
}
