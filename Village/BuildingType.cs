
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Village
{
	[MessagePackObject]
	public class BuildingType
	{
		// Fields
		[Json]
		// [Key]
		public BuildingTypeId Id;
		[Json]
		// [Key]
		public BuildingGroupId GroupId;
		[Json]
		// [Key]
		public List<BuildingLevelInfo> LevelInfos;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public int MaxLevel { get => default; }
	
		// Constructors
		public BuildingType() {}
	}
}
