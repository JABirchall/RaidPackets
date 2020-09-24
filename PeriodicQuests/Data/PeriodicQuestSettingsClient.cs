
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.PeriodicQuests.Data
{
	[MessagePackObject]
	public class PeriodicQuestSettingsClient
	{
		// Fields
		[Json]
		// [Key]
		public bool Enabled;
		[Json]
		// [Key]
		public int MinRequiredUserLevel;
	
		// Constructors
		public PeriodicQuestSettingsClient() {}
	}
}
