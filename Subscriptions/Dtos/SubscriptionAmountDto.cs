
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Subscriptions.Dtos
{
	[MessagePackObject]
	public class SubscriptionAmountDto
	{
		// Fields
		[Json]
		// [Key]
		public double Amount;
		[Json]
		// [Key]
		public string Currency;
	
		// Constructors
		public SubscriptionAmountDto() {}
	}
}
