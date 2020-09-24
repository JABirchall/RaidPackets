
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Core.Setup;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Alliances.Boss
{
	[MessagePackObject]
	public class AllianceBossShortInfo
	{
		// Fields
		[Json]
		// [Key]
		public List<ShortHeroInfo> MostRecentHeroInfos;
		[Json]
		// [Key]
		public int TotalGivenDamage;
		[Json]
		// [Key]
		public int TotalSpentKeys;
		[Json]
		// [Key]
		public int LastTotalPower;
	
		// Constructors
		public AllianceBossShortInfo() {}
		public AllianceBossShortInfo(TeamSetup setup, int givenDamage) {}
	
		// Methods
		public void UpdateMostRecentAttack(TeamSetup setup, int givenDamage) {}
	}
}
