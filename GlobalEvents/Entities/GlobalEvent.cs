
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using Plarium.GS.Model.Modules.GlobalRatings.Entities;
using SharedModel.Common.Hashing;
using SharedModel.Meta.GlobalEvents.Enums;



namespace SharedModel.Meta.GlobalEvents.Entities
{
	[MessagePackObject]
	public class GlobalEvent : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public int GboId;
		[Json]
		// [Key]
		public int Revision;
		[Json]
		// [Key]
		public GlobalEventUserCondition UserCondition;
		[Json]
		// [Key]
		public GlobalRatingDateCondition DateCondition;
		[Json]
		// [Key]
		public GlobalEventQuestData QuestData;
		[Json]
		// [Key]
		public string ContentSettingsJson;
		[Json]
		// [Key]
		public string PointsIcon;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public GlobalEventStateId? StateId { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool Finished { get => default; }
	
		// Constructors
		public GlobalEvent() {}
	
		// Methods
		public int CalcHash() => default;
	}
}
