
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
	public class ContextPerformanceDataDto
	{
		// Fields
		[Json]
		// [Key]
		public string Name;
		[Json]
		// [Key]
		public long RefreshTimeMs;
	
		// Constructors
		public ContextPerformanceDataDto() {}
	}
}
