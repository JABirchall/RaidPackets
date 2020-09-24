
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Common.UserEdit;
using SharedModel.Meta.Account;
using SharedModel.Meta.Fuse.Dtos;
using SharedModel.Meta.Fuse.Static;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Fuse
{
	public static class FuseExtensions
	{
		// Extension methods
		public static FuseHeroRecipe AssertAvailableForDateTime(this FuseHeroRecipe recipe, DateTime currentTime) => default;
		public static bool AvailableForDateTime(this FuseHeroRecipe recipe, DateTime currentTime) => default;
		public static bool UsageLimitExceeded(this FuseHeroRecipe recipe, UserHeroData data) => default;
		public static FuseHeroRecipe AssertUsageLimitNotExceeded(this FuseHeroRecipe recipe, UserHeroData data) => default;
		public static FuseHeroRequestDto AssertIsValidFuseMaterials(this FuseHeroRequestDto dto) => default;
		public static FuseHeroRequestDto AssertIsValidFuseMaterialsCount(this FuseHeroRequestDto dto, int requiredCount) => default;
		public static FuseHeroRecipe AssertNotNull(this FuseHeroRecipe recipe) => default;
		public static FuseResourceRecipe AssertNotNull(this FuseResourceRecipe recipe) => default;
		public static IUndoState IncrementHeroFuseCountIfHasLimit(this UserHeroData data, FuseHeroRecipe recipe) => default;
		public static IUndoState Fused(this UserHeroData data, int outputHeroId) => default;
		public static IUndoState ProcessFuse(this UserHeroData data, FuseHeroRecipe recipe) => default;
		public static FuseHeroRecipe GetRecipe(this StaticFuseData fuseData, int outputHeroId) => default;
		public static FuseHeroRecipe WithPriceOf(this FuseHeroRecipe recipe, Account.Resources price) => default;
		public static FuseHeroRecipe ThatConsumesHero(this FuseHeroRecipe recipe, int heroTypeId, HeroGrade grade, int level) => default;
		public static FuseHeroRecipe ThatOutputsHero(this FuseHeroRecipe recipe, int heroTypeId, HeroGrade grade) => default;
		public static FuseHeroRecipe ThatIsActiveInTimePeriod(this FuseHeroRecipe recipe, DateTime? from, DateTime? to) => default;
		public static FuseHeroRecipe ThatHasUsageLimitOf(this FuseHeroRecipe recipe, int? limit) => default;
	}
}
