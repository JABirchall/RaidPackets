
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Stages;



namespace SharedModel.Meta.Stages.Dto
{
	[MessagePackObject]
	public class CollectStarsRewardRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public DifficultyId DifficultyId;
		[Json]
		// [Key]
		public int StarsCount;
	
		// Constructors
		public CollectStarsRewardRequestDto() {}
	}
}
