
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.SessionChests
{
	[MessagePackObject]
	public class StaticSessionChestData
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<int, UserPrize> UserPrizeByMinutes;
	
		// Constructors
		public StaticSessionChestData() {}
	
		// Methods
		public bool TryGetUnreachedThreshold(TimeSpan sessionDuration, out int threshold) {
			threshold = default;
			return default;
		}
	}
}
