
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
	public class GlobalEventStoryRule
	{
		// Fields
		[Json]
		// [Key]
		public DifficultyId DifficultyId;
		[Json]
		// [Key]
		public RegionTypeId RegionTypeId;
		[Json]
		// [Key]
		public bool IsBoss;
	
		// Constructors
		public GlobalEventStoryRule() {}
	
		// Methods
		public bool Satisfies(Stage stage) => default;
		public GlobalEventStoryRule Clone() => default;
	}
}
