
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Offers.Enums;
using SharedModel.Meta.Payments.Data;
using SharedModel.Meta.Payments.Log;



namespace SharedModel.Meta.Payments
{
	[MessagePackObject]
	public class LogPurchaseFlowRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public LogRecordPaymentType TypeId;
		[Json]
		// [Key]
		public ClientStateId StateId;
		[Json]
		// [Key]
		public ClientStepId StepId;
		[Json]
		// [Key]
		public PurchaseResult? PurchaseResult;
		[Json]
		// [Key]
		public int? ClientErrorCode;
		[Json]
		// [Key]
		public int? OpenOfferId;
		[Json]
		// [Key]
		public int? GiveOfferId;
		[Json]
		// [Key]
		public int? SubscriptionId;
		[Json]
		// [Key]
		public string Amount;
		[Json]
		// [Key]
		public string Currency;
		[Json]
		// [Key]
		public string BillingTransactionId;
		[Json]
		// [Key]
		public string ClientTransactionId;
		[Json]
		// [Key]
		public ExposureLocation? ExposureLocation;
	
		// Constructors
		public LogPurchaseFlowRequestDto() {}
	}
}
