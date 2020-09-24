
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.BattlePasses
{
	[MessagePackObject]
	public class BattlePassSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool Enabled;
		[Json]
		// [Key]
		public int MinUserLevel;
		[Json]
		// [Key]
		public List<BattlePassPrizeOrder> BattlePassPrizeOrders;
		[Json]
		// [Key]
		public Dictionary<int, BattlePassSpecificSetting> SpecificSettings;
	
		// Constructors
		public BattlePassSettings() {}
	}
}
