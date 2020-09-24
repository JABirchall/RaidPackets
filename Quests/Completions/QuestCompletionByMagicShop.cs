
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.MagicShop;
using SharedModel.Meta.Stats;



namespace SharedModel.Meta.Quests.Completions
{
	[MessagePackObject]
	public class QuestCompletionByMagicShop
	{
		// Fields
		[Json]
		// [Key]
		public int CountRequired;
		[Json]
		// [Key]
		public int CountCollected;
		[Json]
		// [Key]
		public bool? BuySlots;
		[Json]
		// [Key]
		public bool? BuyShards;
		[Json]
		// [Key]
		public bool? BuyArtifacts;
	
		// Constructors
		public QuestCompletionByMagicShop() {}
	
		// Methods
		public bool IsCompleted(UserMagicShopData shopData, UserStatsData statsData) => default;
		public QuestCompletionProgress CalcProgress(UserMagicShopData shopData, UserStatsData statsData) => default;
		public QuestCompletionByMagicShop Clone() => default;
	}
}
