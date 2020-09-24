
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Artifacts
{
	[MessagePackObject]
	public class ArtifactSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool DeleteArtifactEnabled;
		[Json]
		// [Key]
		public int MaxArtifactsCount;
		[Json]
		// [Key]
		public int GradationUpgradeConstraintLevel;
		[Json]
		// [Key]
		public int? MaxDropRankId;
		[Json]
		// [Key]
		public int? MaxDropRarityId;
		[Json]
		// [Key]
		public bool UpgradeOptimizationClientEnabled;
		[Json]
		// [Key]
		public bool UpgradeOptimizationServerEnabled;
		[Json]
		// [Key]
		public bool? RaiseAncientShardChancesForDepositors;
		[Json]
		// [Key]
		public bool? RaiseVoidShardChancesForDepositors;
		[Json]
		// [Key]
		public bool? RaiseLegendaryShardChancesForDepositors;
		[Json]
		// [Key]
		public bool InventoryFilterEnabled;
		[Json]
		// [Key]
		public int SecondaryStatsSelectionLimit;
		[Json]
		// [Key]
		public bool SellArtifactFromInboxEnabled;
	
		// Constructors
		public ArtifactSettings() {}
	
		// Methods
		public ArtifactSettings ToClient() => default;
	}
}
