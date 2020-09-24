
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.PerformanceMeter.Dto
{
	[MessagePackObject]
	public class CmdExecutionLogDto
	{
		// Fields
		[Json]
		// [Key]
		public string Tag;
		[Json]
		// [Key]
		public long? TimeMs;
		[Json]
		// [Key]
		public bool BundlesLoaded;
		[Json]
		// [Key]
		public bool WizardFinished;
		[Json]
		// [Key]
		public int InternetReachability;
	
		// Constructors
		public CmdExecutionLogDto() {}
	}
}
