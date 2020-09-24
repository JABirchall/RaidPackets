
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Masteries;
using SharedModel.Meta.Skills;



namespace SharedModel.Meta.Heroes
{
	[MessagePackObject]
	public class Hero
	{
		// Fields
		[IgnoreMember]
		[JsonSkip]
		private HeroType _type;
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public int TypeId;
		[Json]
		// [Key]
		public HeroGrade Grade;
		[Json]
		// [Key]
		public int Level;
		[Json]
		// [Key]
		public int Experience;
		[Json]
		// [Key]
		public int FullExperience;
		[Json]
		// [Key]
		public bool Locked;
		[Json]
		// [Key]
		public bool InStorage;
		[Json]
		// [Key]
		public DateTime? RecentBattleTime;
		[Json]
		// [Key]
		public TotalBattleStatistics BattleStatistics;
		[Json]
		// [Key]
		public List<Skill> Skills;
		[Json]
		// [Key]
		public HeroMasteryData MasteryData;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public HeroType Type { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsBoss { get => default; }
	
		// Constructors
		public Hero() {}
		public Hero(int id, int heroTypeId, HeroGrade grade, int level, bool locked = false) {}
	
		// Methods
		public Hero Clone() => default;
		public bool CanReceiveMasteryPoints(MasteryPointType pointType) => default;
		public Hero CloneForLog() => default;
	}
}
