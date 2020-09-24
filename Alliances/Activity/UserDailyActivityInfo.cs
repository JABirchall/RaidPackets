
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;
using SharedModel.Meta.Stages;



namespace SharedModel.Meta.Alliances.Activity
{
	[MessagePackObject]
	public class UserDailyActivityInfo : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public bool CheckedIn;
		[Json]
		// [Key]
		public long OnlineTimeMs;
		[Json]
		// [Key]
		public Dictionary<AreaTypeId, int> BattleCountByArea;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public int Stars { get => default; }
	
		// Constructors
		public UserDailyActivityInfo() {}
	
		// Methods
		public int CalcHash() => default;
	}
}
