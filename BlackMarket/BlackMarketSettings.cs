
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.BlackMarket
{
	[MessagePackObject]
	public class BlackMarketSettings
	{
		// Fields
		[Json]
		// [Key]
		public List<BlackMarketItemId> DisabledItemIds;
		[Json]
		// [Key]
		public bool ArtifactBinarySearchEnabledTempSetting;
	
		// Constructors
		public BlackMarketSettings() {}
	}
}
