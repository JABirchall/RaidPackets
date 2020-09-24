
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
	public class StaticBattlePassData
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<int, BattlePass> BattlePasses;
		[IgnoreMember]
		[JsonSkip]
		public BattlePass Last;
	
		// Constructors
		public StaticBattlePassData() {}
	
		// Methods
		public void Cache() {}
	}
}
