
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Artifacts;



namespace SharedModel.Meta.Battle.AutoBattle
{
	[MessagePackObject]
	public class UserAutoBattleData
	{
		// Fields
		[Json]
		// [Key]
		public int AutoBattlesCount;
		[Json]
		// [Key]
		public int BattlesCount;
		[Json]
		// [Key]
		public bool ContinueOnMaxLevel;
		[Json]
		// [Key]
		public bool ContinueOnDefeat;
		[Json]
		// [Key]
		public bool AutoBuyEnergy;
		[Json]
		// [Key]
		public List<ArtifactRankId> SellArtifactRankIds;
		[Json]
		// [Key]
		public List<int> SelectedHeroIds;
		[Json]
		// [Key]
		public List<int> FarmHeroIds;
		[Json]
		// [Key]
		public int StageId;
		[Json]
		// [Key]
		public bool RewardOverflowAccepted;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public bool AutoSellArtifacts { get => default; }
	
		// Constructors
		public UserAutoBattleData() {}
	}
}
