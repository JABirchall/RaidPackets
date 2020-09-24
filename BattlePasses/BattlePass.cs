
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.BattlePasses
{
	[MessagePackObject]
	public class BattlePass : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public string LogoPath;
		[Json]
		// [Key]
		public bool AdminsOnly;
		[Json]
		// [Key]
		public int? MinUserLevel;
		[Json]
		// [Key]
		public int? MaxUserLevel;
		[Json]
		// [Key]
		public DateTime? TeaserStart;
		[Json]
		// [Key]
		public DateTime Start;
		[Json]
		// [Key]
		public int DurationDays;
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public bool ForceStop;
		[Json]
		// [Key]
		public int DefaultPoints;
		[Json]
		// [Key]
		public UserAvatarGroupId GroupId;
		[Json]
		// [Key]
		public BattlePassSeasonTypeId Season;
		[Json]
		// [Key]
		public List<BattlePassLevel> Levels;
		[Json]
		// [Key]
		public Dictionary<BattlePassPaymentTypeId, int> PriceIdByPaymentTypeId;
		[Json]
		// [Key]
		public BattlePassIntroData Intro;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public DateTime End { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsActive { get => default; }
	
		// Constructors
		public BattlePass() {}
	
		// Methods
		public BattlePass Clone() => default;
		public int CalcHash() => default;
	}
}
