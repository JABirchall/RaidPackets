
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Common.UserEdit;
using SharedModel.Meta.Account;
using SharedModel.Meta.BlackMarket;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.Stages;



namespace SharedModel.Meta.Effects
{
	public static class UserEffectExtensions
	{
		// Extension methods
		public static UserEffect AssertEffectExists(this UserEffectData userData, long id, bool throwException = true) => default;
		public static IEnumerable<UserEffect> GetEffectsByTypeId(this UserEffectData userData, UserEffectTypeId typeId) => default;
		public static UserEffect GetEffect(this UserEffectData userData, UserEffectTypeId typeId, UserEffectSource? source = default) => default;
		public static bool HasEffect(this UserEffectData userData, UserEffectTypeId typeId, UserEffectSource? source = default) => default;
		public static bool HasRegionPass(this UserEffectData effectData, RegionTypeId region) => default;
		public static IUndoState<UserEffect> AddEffect(this UserEffectData userData, UserEffectInfo effect, DateTime now) => default;
		public static IUndoState<UserEffect> AddOrUpdateEffect(this UserEffectData userData, UserEffectInfo effect, DateTime now) => default;
		public static void RemoveEffect(this UserEffectData userData, UserEffectInfo effect) {}
		public static List<long> GetExpiredItemIds(this UserEffectData userData, DateTime time) => default;
		public static UserEffectTypeId ToUserEffect(this HeroFraction fraction) => default;
		public static UserEffectTypeId ToUserEffect(this RegionTypeId region) => default;
		public static ResourceTypeId ToResourceId(this UserEffectTypeId typeId) => default;
		public static UserEffectKindId ToKindId(this UserEffectTypeId typeId) => default;
		public static bool IsDungeonPass(this UserEffectTypeId typeId) => default;
		public static bool IsBattlePass(this UserEffectTypeId typeId) => default;
	}
}
