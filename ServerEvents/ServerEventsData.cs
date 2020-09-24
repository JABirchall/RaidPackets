
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
	public class ServerEventsData
	{
		// Fields
		[Json]
		// [Key]
		public List<ServerEvent> ServerEvents;
		[Json]
		// [Key]
		public int KnownHash;
	
		// Constructors
		public ServerEventsData() {}
		public ServerEventsData(List<ServerEvent> serverEvents) {}
		public ServerEventsData(List<ServerEvent> serverEvents, int hash) {}
	
		// Methods
		public ServerEventsData CopyWithoutNewbie() => default;
	}
}
