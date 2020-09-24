
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Bundles
{
	[MessagePackObject]
	public class CollectLoadingRewardRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public List<int> Indexes;
	
		// Constructors
		public CollectLoadingRewardRequestDto() {}
	}
}
