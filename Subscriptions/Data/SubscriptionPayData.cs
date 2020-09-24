
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Subscriptions.Enums;



namespace SharedModel.Meta.Subscriptions.Data
{
	[MessagePackObject]
	public class SubscriptionPayData
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public int? NewId;
		[Json]
		// [Key]
		public string FromUserId;
		[Json]
		// [Key]
		public SubscriptionOperation Operation;
		[Json]
		// [Key]
		public DateTime ExpireDate;
	
		// Constructors
		public SubscriptionPayData() {}
	}
}
