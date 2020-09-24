
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Village
{
	[MessagePackObject]
	public class VillageSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool ChristmasTreeEnabled;
		[Json]
		// [Key]
		public bool UnlockAndRevealLevels_1_7_Enabled;
	
		// Constructors
		public VillageSettings() {}
	}
}
