
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;



namespace SharedModel.Meta.Alliances.Activity
{
	[MessagePackObject]
	public class UserAllianceActivityData : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<DateTime, UserDailyActivityInfo> ActivityInfoByDate;
		[Json]
		// [Key]
		public DateTime LastRewardReceiveTime;
	
		// Constructors
		public UserAllianceActivityData() {}
	
		// Methods
		public int CalcHash() => default;
	}
}
