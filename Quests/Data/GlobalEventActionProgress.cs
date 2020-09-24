
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Quests;



namespace SharedModel.Meta.Quests.Data
{
	[MessagePackObject]
	public class GlobalEventActionProgress
	{
		// Fields
		[Json]
		// [Key]
		public DateTime Date;
		[Json]
		// [Key]
		public GlobalEventAction Action;
		[Json]
		// [Key]
		public int Points;
	
		// Constructors
		public GlobalEventActionProgress() {}
	}
}
