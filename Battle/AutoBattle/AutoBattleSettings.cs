
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.FeatureStatuses;



namespace SharedModel.Meta.Battle.AutoBattle
{
	[MessagePackObject]
	public class AutoBattleSettings
	{
		// Fields
		[Json]
		// [Key]
		public FeatureStatus Status;
		[Json]
		// [Key]
		public int MaxFarmHeroes;
		[Json]
		// [Key]
		public int StartNextBattleDelayInSec;
		[Json]
		// [Key]
		public int TicketsBattleStartPrice;
		[Json]
		// [Key]
		public int TicketsDailyLimit;
		[Json]
		// [Key]
		public double TicketsBonusMultiplier;
		[Json]
		// [Key]
		public List<int> EnabledRegionIds;
		[IgnoreMember]
		[JsonSkip]
		private Account.Resources _battleStartPrice;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public Account.Resources BattleStartPrice { get => default; }
		[IgnoreMember]
		[JsonSkip]
		private static IEnumerable<int> DefaultEnabledRegionIds { get => default; }
	
		// Constructors
		public AutoBattleSettings() {}
	
		// Methods
		public static Action<AutoBattleSettings> OnInitialized() => default;
	}
}
