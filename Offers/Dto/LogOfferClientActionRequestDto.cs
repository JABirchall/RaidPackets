
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Offers.Enums;



namespace SharedModel.Meta.Offers.Dto
{
	[MessagePackObject]
	public class LogOfferClientActionRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int? OpenOfferId;
		[Json]
		// [Key]
		public int? UserOfferId;
		[Json]
		// [Key]
		public int? SubscriptionId;
		[Json]
		// [Key]
		public ExposureLocation ExposureLocation;
		[Json]
		// [Key]
		public LogRecordOfferStateType LogType;
		[Json]
		// [Key]
		public BankCategory? BankCategory;
		[Json]
		// [Key]
		public DateTime ActionTime;
		[Json]
		// [Key]
		public int? PopupIndex;
		[Json]
		// [Key]
		public int? TabNumber;
	
		// Constructors
		public LogOfferClientActionRequestDto() {}
	}
}
