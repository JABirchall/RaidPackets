
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Stages
{
	[MessagePackObject]
	public class FreeStageData
	{
		// Fields
		[Json]
		// [Key]
		public List<int> FreeAreaTypeIds;
		[Json]
		// [Key]
		public List<int> FreeRegionTypeIds;
	
		// Constructors
		public FreeStageData() {}
	}
}
