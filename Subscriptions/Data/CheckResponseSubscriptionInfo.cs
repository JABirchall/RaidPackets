
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Subscriptions.Data
{
	[MessagePackObject]
	public class CheckResponseSubscriptionInfo
	{
		// Fields
		[Json]
		// [Key]
		public int SubscriptionId;
	
		// Constructors
		public CheckResponseSubscriptionInfo() {}
		public CheckResponseSubscriptionInfo(int subscriptionId) {}
	}
}
