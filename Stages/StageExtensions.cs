
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Account;
using SharedModel.Meta.Effects;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Stages
{
	public static class StageExtensions
	{
		// Fields
		private static readonly Type HeroFractionEnumType;
	
		// Constructors
		static StageExtensions() {}
	
		// Methods
		public static int CalcStageStars(float durationInSeconds, int heroesCount, int deadHeroesCount, bool passed) => default;
		public static int CalcStoryStars(float durationInSeconds, int heroesCount, int deadHeroesCount, bool passed) => default;
		public static int CalcFractionWarStars(int heroesCount, int deadHeroesCount, bool passed) => default;
	
		// Extension methods
		public static Region RegionOrThrow(this StaticStageData data, AreaTypeId areaTypeId, RegionTypeId regionTypeId) => default;
		public static UserPrize AssertCanCollectStoryStarsReward(this UserStageData data, DifficultyId difficultyId, int stars) => default;
		public static UserPrize AssertCanCollectFractionWarStarsReward(this UserStageData data, int stars) => default;
		public static UserPrize AssertCanCollectFractionWarMainReward(this UserStageData data, int totalStars) => default;
		public static Region AssertContainPaidRegionPass(this Region region) => default;
		public static UserEffectTypeId FractionRegionPassOrThrow(this Region region) => default;
		public static RegionOpenCondition AssertCanBuyRegionPass(this RegionOpenCondition condition, UserEffectData data, RegionTypeId regionTypeId) => default;
		public static bool IsPassed(this UserStageData data, Stage stage) => default;
		public static AreaTypeId Area(this RegionTypeId region) => default;
		public static bool IsArena(this AreaTypeId area) => default;
		public static bool EqualsTo(this AreaTypeId first, AreaTypeId second) => default;
		public static bool HasFractionCondition(this Region region) => default;
		public static HeroFraction GetFraction(this Region region) => default;
		public static UserPrizeSource ToUserPrizeSource(this AreaTypeId typeId) => default;
		public static HeroFraction ToHeroFraction(this RegionTypeId region) => default;
		public static RegionTypeId ToRegionTypeId(this HeroFraction fraction) => default;
		public static ResourceTypeId ToResourceId(this HeroFraction fraction) => default;
	}
}
