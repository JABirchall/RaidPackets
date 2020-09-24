
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.PerformanceMeter.Dto
{
	[MessagePackObject]
	public class PerformanceDataDto
	{
		// Fields
		[Json]
		// [Key]
		public int View;
		[Json]
		// [Key]
		public long TimeMs;
		[Json]
		// [Key]
		public int TargetFPS;
		[Json]
		// [Key]
		public int[] Fps;
		[Json]
		// [Key]
		public int[] UpdatesTime;
		[Json]
		// [Key]
		public int[] RendersTime;
		[Json]
		// [Key]
		public Dictionary<string, string> ExtraData;
	
		// Constructors
		public PerformanceDataDto() {}
	}
}
