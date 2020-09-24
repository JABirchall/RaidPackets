
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Account;
using SharedModel.Meta.BlackMarket;
using SharedModel.Meta.Effects;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.Masteries;
using SharedModel.Meta.Shards;



namespace SharedModel.Meta.UserPrizes
{
	public static class UserPrizeExtensions
	{
		// Nested types
		public class BmiRewardResult
		{
			// Fields
			public Account.Resources Resources;
			public readonly Dictionary<BlackMarketItemId, int> BmiCountById;
			public readonly List<Shard> Shards;
			public readonly List<UserEffect> Effects;
			public readonly List<MasteryRewardResult> MasteryResults;
	
			// Constructors
			public BmiRewardResult() {}
		}
	
		public class MasteryRewardResult
		{
			// Fields
			public readonly Hero Hero;
			public readonly MasteryPointType PointType;
			public readonly int AddedPoints;
	
			// Constructors
			public MasteryRewardResult() {} // Dummy constructor
			public MasteryRewardResult(Hero hero, MasteryPointType pointType, int addedPoints) {}
		}
	}
}
