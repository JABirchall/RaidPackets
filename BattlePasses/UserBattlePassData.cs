
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
	public class UserBattlePassData
	{
		// Fields
		[Json]
		// [Key]
		public List<UserBattlePass> UserBattlePasses;
		[Json]
		// [Key]
		public List<int> SeenIntroIds;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public UserBattlePass CurrentBattlePass { get => default; }
	
		// Constructors
		public UserBattlePassData() {}
	}
}
