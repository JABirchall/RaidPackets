
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.Battle.AutoBattle
{
	[MessagePackObject]
	public class AutoBattleStatistics
	{
		// Fields
		[Json]
		// [Key]
		public int BattlesCount;
		[Json]
		// [Key]
		public Account.Resources ResourcesGained;
		[Json]
		// [Key]
		public Account.Resources ResourcesSpent;
		[Json]
		// [Key]
		public int TotalXPGained;
		[Json]
		// [Key]
		public int VictoryBattlesCount;
		[Json]
		// [Key]
		public List<int> HeroIds;
	
		// Constructors
		public AutoBattleStatistics() {}
	}
}
