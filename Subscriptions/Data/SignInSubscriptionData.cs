
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Attributes;
using SharedModel.Meta.Subscriptions.Dtos;



namespace SharedModel.Meta.Subscriptions.Data
{
	[MessagePackObject]
	// [RemovedJson]
	public class SignInSubscriptionData
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<int, SubscriptionDto> Subscriptions;
	
		// Constructors
		public SignInSubscriptionData() {}
	}
}
