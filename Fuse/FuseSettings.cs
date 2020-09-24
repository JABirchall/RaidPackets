
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Fuse
{
	[MessagePackObject]
	public class FuseSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool FuseHeroEnabled;
		[Json]
		// [Key]
		public bool FuseResourcesEnabled;
		[Json]
		// [Key]
		public List<FuseHeroSetting> FuseHeroRecipesSettings;
		[Json]
		// [Key]
		public bool TempFuseCollectingEnabled;
	
		// Constructors
		public FuseSettings() {}
	}
}
