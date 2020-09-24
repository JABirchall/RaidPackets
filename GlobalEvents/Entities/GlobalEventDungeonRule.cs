
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Stages;



namespace SharedModel.Meta.GlobalEvents.Entities
{
	[MessagePackObject]
	public class GlobalEventDungeonRule
	{
		// Fields
		[Json]
		// [Key]
		public int? Number;
		[Json]
		// [Key]
		public RegionTypeId? RegionTypeId;
	
		// Constructors
		public GlobalEventDungeonRule() {}
	
		// Methods
		public bool Satisfies(Stage stage) => default;
		public GlobalEventDungeonRule Clone() => default;
	}
}
