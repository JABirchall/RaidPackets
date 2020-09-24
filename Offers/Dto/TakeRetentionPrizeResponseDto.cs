
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Inbox;
using SharedModel.Meta.Offers;



namespace SharedModel.Meta.Offers.Dto
{
	[MessagePackObject]
	public class TakeRetentionPrizeResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public List<InboxItem> InboxItems;
		[Json]
		// [Key]
		public UserOffer UserOffer;
	
		// Constructors
		public TakeRetentionPrizeResponseDto() {}
	}
}
