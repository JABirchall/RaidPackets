
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Commands;
using SharedModel.Battle.Core.Setup;
using SharedModel.Battle.Journal;
using SharedModel.Common.Attributes;
using SharedModel.Meta.Battle.AutoBattle;



namespace SharedModel.Meta.Battle
{
	[MessagePackObject]
	// [RemovedJson]
	public class UserBattleData
	{
		// Fields
		[Json]
		// [Key]
		public List<DateTime> LastBattles;
		[Json]
		// [Key]
		public BattleSetup LastBattleSetup;
		[Json]
		// [Key]
		public FinishBattleResponseDto LastResponse;
		[Json]
		// [Key]
		public UserAutoBattleData AutoBattleData;
		[Json]
		// [Key]
		public BattleJournalMode? JournalMode;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public bool HasStartedBattle { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public DateTime LastBattleTime { get => default; }
	
		// Constructors
		public UserBattleData() {}
	}
}
