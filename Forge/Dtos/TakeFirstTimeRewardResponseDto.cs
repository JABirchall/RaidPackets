
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Forge.Dtos
{
	[MessagePackObject]
	public class TakeFirstTimeRewardResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public UserPrize Prize;
	
		// Constructors
		public TakeFirstTimeRewardResponseDto() {}
	}
}
