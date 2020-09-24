
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Localization;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.BlackMarket
{
	[MessagePackObject]
	public class BlackMarketItem
	{
		// Fields
		[Json]
		// [Key]
		public BlackMarketItemId Id;
		[Json]
		// [Key]
		public Account.Resources Price;
		[Json]
		// [Key]
		// [SharedLocalization]
		public SharedLTextKey Name;
		[Json]
		// [Key]
		// [SharedLocalization]
		public SharedLTextKey Description;
		[Json]
		// [Key]
		public ResourcesData ResourcesData;
		[Json]
		// [Key]
		public ShardData ShardsData;
		[Json]
		// [Key]
		public UpdateUserData UpdateUserData;
		[Json]
		// [Key]
		public SkillUpgradeData SkillUpgradeData;
		[Json]
		// [Key]
		public UserEffectInfo UserEffectData;
		[Json]
		// [Key]
		public HeroLevelUpData HeroLevelUpData;
		[Json]
		// [Key]
		public HeroRankUpData HeroRankUpData;
		[Json]
		// [Key]
		public MasteryData MasteryData;
		[Json]
		// [Key]
		public PowerUpData PowerUpData;
		[Json]
		// [Key]
		public ForgeCharmData ForgeCharmData;
		[Json]
		// [Key]
		public TimeSpan? LifeTimeInHours;
	
		// Constructors
		public BlackMarketItem() {}
	}
}
