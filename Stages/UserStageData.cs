
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Stages
{
	[MessagePackObject]
	public class UserStageData
	{
		// Fields
		[Json]
		// [Key]
		public DateTime LastBattleTime;
		[Json]
		// [Key]
		public Dictionary<int, StageStats> BattleResultsByStageId;
		[Json]
		// [Key]
		public Dictionary<DifficultyId, List<int>> CollectedRewards;
		[Json]
		// [Key]
		public List<int> CollectedFractionWarRewards;
		[Json]
		// [Key]
		public bool FractionWarMainRewardTaken;
		[Json]
		// [Key]
		public FreeStageData FreeStageData;
		[Json]
		// [Key]
		public DifficultyId SelectedDifficulty;
		[Json]
		// [Key]
		public DifficultyId MaxSeenDifficultyId;
		[Json]
		// [Key]
		public DifficultyId MaxSeenDifficultyPopupId;
		[IgnoreMember]
		[JsonSkip]
		protected Dictionary<DifficultyId, int> _starsByDifficulty;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<DifficultyId, int> StarsByDifficulty { get => default; }
	
		// Constructors
		public UserStageData() {}
	
		// Methods
		protected Dictionary<DifficultyId, int> InitializeStarsByDifficulty() => default;
		public int GetStarsInAreaByDifficulty(AreaTypeId areaTypeId, DifficultyId difficultyId) => default;
		public override int GetHashCode() => default;
	}
}
