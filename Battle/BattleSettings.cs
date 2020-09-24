
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Effects;
using SharedModel.Common.Attributes;



namespace SharedModel.Meta.Battle
{
	[MessagePackObject]
	// [RemovedJson]
	public class BattleSettings
	{
		// Fields
		[Json]
		// [Key]
		public int ActiveEngineVersion;
		[Json]
		// [Key]
		public int MaxEffectProcessingDepth;
		[Json]
		// [Key]
		public List<EffectKindId> DisabledEffects;
		[Json]
		// [Key]
		public bool ShaderWarmUpDisabled;
		[Json]
		// [Key]
		public bool ECSEffectCombinationEnabled;
		[Json]
		// [Key]
		public bool ECSSeparatePassiveSkillResultsEnabled;
		[Json]
		// [Key]
		public int MaxTurnsInBattle;
		[Json]
		// [Key]
		public float BattleLoadingStepLimitSeconds;
		[Json]
		// [Key]
		public double OneTurnTimeInSec;
		[Json]
		// [Key]
		public bool CheckBattleSetupEquality;
		[Json]
		// [Key]
		public bool LogRecordOnExceptionEnabled;
		[Json]
		// [Key]
		public bool LogRecordOnRecursionEnabled;
		[Json]
		// [Key]
		public bool AwakePools;
		[Json]
		// [Key]
		public bool ArenaOpponentsOptimizationEnabled;
		[Json]
		// [Key]
		public bool ArenaOpponentsOptimizationCanceled;
		[Json]
		// [Key]
		public bool HandleBattleSetupDoNotMatch;
		[Json]
		// [Key]
		public bool ThrowExceptionOnBattleHack;
		[Json]
		// [Key]
		public bool LogRecordOnBattleHackEnabled;
		[Json]
		// [Key]
		public BattleJournalSettings JournalSettings;
		[IgnoreMember]
		[JsonSkip]
		private BattleJournalSettings _settings;
	
		// Properties
		[Json]
		// [Key]
		public BattleJournalSettings Journal { get => default; set {} }
	
		// Constructors
		public BattleSettings() {}
	}
}
