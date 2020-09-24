
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.GlobalEvents.Entities
{
	[MessagePackObject]
	public class GlobalEventUserCondition
	{
		// Fields
		[Json]
		// [Key]
		public bool? AdminsOnly;
		[Json]
		// [Key]
		public int? MinUserLevel;
		[Json]
		// [Key]
		public int? MaxUserLevel;
		[Json]
		// [Key]
		public int? DaysUserWasNotInGame;
	
		// Constructors
		public GlobalEventUserCondition() {}
	}
}
