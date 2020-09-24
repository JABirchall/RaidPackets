
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Offers.Enums;



namespace SharedModel.Meta.Subscriptions.Dtos
{
	[MessagePackObject]
	public class ReadSubscriptionRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int SubscriptionId;
		[Json]
		// [Key]
		public ExposureLocation Exposure;
	
		// Constructors
		public ReadSubscriptionRequestDto() {}
	}
}
