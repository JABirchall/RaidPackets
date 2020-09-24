
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Settings
{
	[MessagePackObject]
	public class GuideSettings
	{
		// Fields
		[Json]
		// [Key]
		public string ArenaUrl;
		[Json]
		// [Key]
		public string GreatHallUrl;
		[Json]
		// [Key]
		public string ArtifactsUrl;
		[Json]
		// [Key]
		public string TavernUrl;
		[Json]
		// [Key]
		public string AllianceUrl;
		[Json]
		// [Key]
		public string AllianceBossUrl;
		[Json]
		// [Key]
		public string FusionUrl;
		[Json]
		// [Key]
		public string ChampionVaultUrl;
		[Json]
		// [Key]
		public string AutoBattleUrl;
		[Json]
		// [Key]
		public string ReferralProgramUrl;
		[Json]
		// [Key]
		public string ArtifactUpgradeUrl;
		[Json]
		// [Key]
		public string FractionWarsUrl;
		[Json]
		// [Key]
		public string BattlePass;
		[Json]
		// [Key]
		public string Arena3X3Url;
		[Json]
		// [Key]
		public string ArenaRewardsUrl;
		[Json]
		// [Key]
		public string Arena3x3LeagueUrl;
		[Json]
		// [Key]
		public string HeroPartsUrl;
		[Json]
		// [Key]
		public string ForgeUrl;
	
		// Constructors
		public GuideSettings() {}
	}
}
