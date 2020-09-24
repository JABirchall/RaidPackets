
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.AutoOpen.Settings
{
	[MessagePackObject]
	public class AutoOpenSettings
	{
		// Fields
		[Json]
		// [Key]
		public int OpenedWindowsLimit;
		[Json]
		// [Key]
		public int OffersLimit;
		[Json]
		// [Key]
		public SignInWindowTypeId[] NonDepositorWindows;
		[Json]
		// [Key]
		public SignInWindowTypeId[] DepositorWindows;
		[Json]
		// [Key]
		public bool Enabled;
		[Json]
		// [Key]
		public AutoOpenGroup[] Groups;
		[Json]
		// [Key]
		public bool NewDifficultyNotifyingEnabled;
		[IgnoreMember]
		[JsonSkip]
		public SignInWindowTypeId[] SignInWindows;
		[IgnoreMember]
		[JsonSkip]
		public InGameWindow[] InGameWindows;
	
		// Constructors
		public AutoOpenSettings() {}
	}
}
