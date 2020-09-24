
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Inbox;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Stages.Dto
{
	[MessagePackObject]
	public class CollectStarsResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public UserPrize Prize;
		[Json]
		// [Key]
		public List<InboxItem> InboxItems;
	
		// Constructors
		public CollectStarsResponseDto() {}
		public CollectStarsResponseDto(UserPrize prize, List<InboxItem> inboxItems) {}
	}
}
