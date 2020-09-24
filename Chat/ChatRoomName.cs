
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
	public class ChatRoomName
	{
		// Fields
		[IgnoreMember]
		[JsonSkip]
		public const int ChunkNumber = 3;
		[Json]
		// [Key]
		public string Prefix;
		[Json]
		// [Key]
		public ChatRoomGroup Group;
		[Json]
		// [Key]
		public int Number;
	
		// Constructors
		public ChatRoomName() {}
		public ChatRoomName(string prefix, ChatRoomGroup group, int number) {}
		public ChatRoomName(string name) {}
	
		// Methods
		public override string ToString() => default;
	}
}
