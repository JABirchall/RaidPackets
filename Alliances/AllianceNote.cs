
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Languages;
using SharedModel.Meta.Notes;



namespace SharedModel.Meta.Alliances
{
	[MessagePackObject]
	public class AllianceNote : INote
	{
		// Fields
		[Json]
		// [Key]
		public int SegmentId;
		[Json]
		// [Key]
		public long LeaderId;
		[Json]
		// [Key]
		public string Name;
		[Json]
		// [Key]
		public string Abbreviation;
		[Json]
		// [Key]
		public string Logo;
		[Json]
		// [Key]
		public Language LanguageId;
		[Json]
		// [Key]
		public long[] MemberIds;
		[Json]
		// [Key]
		public int Power;
		[Json]
		// [Key]
		public int RatingPosition;
		[Json]
		// [Key]
		public long RatingPoints;
		[Json]
		// [Key]
		public int MembersLimit;
		[Json]
		// [Key]
		public string Description;
		[Json]
		// [Key]
		public bool IsOpen;
		[Json]
		// [Key]
		public Dictionary<AllianceAchievementTypeId, int> AchievementLevelById;
	
		// Properties
		[Json]
		// [Key]
		public long Id { get; set; }
		[IgnoreMember]
		[JsonSkip]
		public bool Outdated { get; set; }
	
		// Constructors
		public AllianceNote() {}
	}
}
