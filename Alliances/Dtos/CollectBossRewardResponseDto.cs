
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Alliances.Dtos
{
	[MessagePackObject]
	public class CollectBossRewardResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public List<UserPrize> Prizes;
	
		// Constructors
		public CollectBossRewardResponseDto() {}
	}
}
