
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.SessionChests
{
	[MessagePackObject]
	public class UserSessionChestData
	{
		// Fields
		[Json]
		// [Key]
		public List<int> PrizeReceivedMinutes;
		[Json]
		// [Key]
		public DateTime LastMilisecondsUpdateTime;
		[Json]
		// [Key]
		public int TotalMsInGameToday;
	
		// Constructors
		public UserSessionChestData() {}
	}
}
