
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Heroes
{
	[MessagePackObject]
	public class HeroSettings
	{
		// Fields
		[Json]
		// [Key]
		public int DefaultInventorySlotsCount;
		[Json]
		// [Key]
		public int MaxInventorySlotsCount;
		[Json]
		// [Key]
		public bool HeroStorageEnabled;
		[Json]
		// [Key]
		public int DefaultStorageSlotsCount;
		[Json]
		// [Key]
		public int MaxStorageSlotsCount;
		[Json]
		// [Key]
		public List<HeroPartInfo> HeroParts;
	
		// Constructors
		public HeroSettings() {}
	}
}
