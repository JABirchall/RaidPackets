
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Effects;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Village
{
	[MessagePackObject]
	public class UserVillageData
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<int, Building> BuildingByTypeId;
		[Json]
		// [Key]
		public int ProducedGemsCount;
		[Json]
		// [Key]
		public DateTime LastGemsCollectTime;
		[Json]
		// [Key]
		public double ExcessGemMineHours;
		[Json]
		// [Key]
		public Dictionary<Element, Dictionary<StatKindId, int>> CapitolBonusLevelByStatByElement;
	
		// Constructors
		public UserVillageData() {}
	}
}
