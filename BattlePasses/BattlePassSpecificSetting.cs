
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Configuration;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.BattlePasses
{
	[MessagePackObject]
	public class BattlePassSpecificSetting
	{
		// Fields
		[Json]
		// [Key]
		public ConfigDateTime StartTime;
		[Json]
		// [Key]
		public int DurationInDays;
		[Json]
		// [Key]
		public bool AdminsOnly;
		[Json]
		// [Key]
		public bool ForceStop;
	
		// Constructors
		public BattlePassSpecificSetting() {}
	}
}
