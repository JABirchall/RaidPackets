
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Payments.Data
{
	[MessagePackObject]
	public class BillingPrice
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public int UnitedPriceId;
		[Json]
		// [Key]
		public int AppId;
		[Json]
		// [Key]
		public int ClusterId;
		[Json]
		// [Key]
		public int SocialNetworkId;
		[Json]
		// [Key]
		public string BundleId;
		[Json]
		// [Key]
		public bool IsPromoted;
		[Json]
		// [Key]
		public BillingPriceAmount[] Amounts;
		[IgnoreMember]
		[JsonSkip]
		private BillingPriceAmount _usd;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public BillingPriceAmount Usd { get => default; }
	
		// Constructors
		public BillingPrice() {}
	
		// Methods
		public ClientPriceDto ToClientPrice() => default;
	}
}
