
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Inbox;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.BattlePasses.Dtos
{
	[MessagePackObject]
	public class CollectBattlePassLevelRewardResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public UserPrize GivenPrize;
		[Json]
		// [Key]
		public List<InboxItem> InboxItems;
	
		// Constructors
		public CollectBattlePassLevelRewardResponseDto() {}
		public CollectBattlePassLevelRewardResponseDto(UserPrize givenPrize, List<InboxItem> inboxItems) {}
	}
}
