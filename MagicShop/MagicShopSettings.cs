
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.MagicShop
{
	[MessagePackObject]
	public class MagicShopSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool Enabled;
		[Json]
		// [Key]
		public int RefreshSec;
		[Json]
		// [Key]
		public int MaxSlots;
		[Json]
		// [Key]
		public int AncientShardLimitPerMonth;
	
		// Constructors
		public MagicShopSettings() {}
	}
}
