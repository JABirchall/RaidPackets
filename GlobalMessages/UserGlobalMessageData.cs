
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.GlobalMessages
{
	[MessagePackObject]
	public class UserGlobalMessageData
	{
		// Fields
		[Json]
		// [Key]
		public int LastKnownMessageId;
		[Json]
		// [Key]
		public int LastKnownStaticMessageId;
		[Json]
		// [Key]
		public List<int> UnreadMessageIds;
		[Json]
		// [Key]
		public long LastUserMessageId;
	
		// Constructors
		public UserGlobalMessageData() {}
	}
}
