
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.ServerEvents
{
	[MessagePackObject]
	public class ServerEventsSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool Enable;
		[Json]
		// [Key]
		public int UpdateDelaySeconds;
		[IgnoreMember]
		[JsonSkip]
		public List<ServerEvent> ServerEventsRaw;
	
		// Properties
		[Json]
		// [Key]
		[Obsolete]
		public List<ServerEvent> ServerEvents { get => default; set {} }
	
		// Constructors
		public ServerEventsSettings() {}
	}
}
