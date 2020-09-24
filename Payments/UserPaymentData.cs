
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Subscriptions.Data;



namespace SharedModel.Meta.Payments
{
	[MessagePackObject]
	public class UserPaymentData
	{
		// Fields
		[Json]
		// [Key]
		public int LastPaymentId;
		[Json]
		// [Key]
		public List<Payment> Payments;
		[Json]
		// [Key]
		public DateTime? LastReceiptUpdateTime;
		[Json]
		// [Key]
		public List<Subscription> Subscriptions;
		[Json]
		// [Key]
		public List<Payment> GooglePointsPayments;
		[IgnoreMember]
		[JsonSkip]
		public List<Payment> PaymentsForTracker;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public bool HasNewPaymentsToTrack { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public double TotalUsd { get => default; }
	
		// Constructors
		public UserPaymentData() {}
	
		// Methods
		public void ClearFreshPayments() {}
	}
}
