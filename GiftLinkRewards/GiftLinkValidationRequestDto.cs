
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.GiftLinkRewards
{
	[MessagePackObject]
	public class GiftLinkValidationRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public string AdvertisingId;
		[Json]
		// [Key]
		public int CampaignId;
		[Json]
		// [Key]
		public string RewardId;
		[Json]
		// [Key]
		public string DeepLink;
	
		// Constructors
		public GiftLinkValidationRequestDto() {}
	}
}
