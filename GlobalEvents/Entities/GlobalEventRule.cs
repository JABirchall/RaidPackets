
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
	public class GlobalEventRule
	{
		// Fields
		[Json]
		// [Key]
		public GlobalEventArtifactRule Artifact;
		[Json]
		// [Key]
		public GlobalEventHeroRule Hero;
		[Json]
		// [Key]
		public GlobalEventShardRule Shard;
		[Json]
		// [Key]
		public GlobalEventResourceReceiveRule Resource;
		[Json]
		// [Key]
		public GlobalEventArenaRule Arena;
		[Json]
		// [Key]
		public GlobalEventStoryRule Story;
		[Json]
		// [Key]
		public GlobalEventDungeonRule Dungeon;
		[Json]
		// [Key]
		public int Points;
	
		// Constructors
		public GlobalEventRule() {}
	
		// Methods
		public GlobalEventRule Clone() => default;
	}
}
