
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plarium.Common.Serialization;
using SharedModel.Meta.Offers.Enums;



namespace SharedModel.Meta.Offers.Dto
{
	public class GiveEmptyOfferDto
	{
		// Fields
		[Json]
		public int PromoOfferId;
		[Json]
		public OfferTypeId TypeId;
		[Json]
		public int Revision;
		[Json]
		public int SegmentId;
		[Json]
		public long UserId;
		[Json]
		public Guid PromotionExposureId;
		[Json]
		public double DurationHours;
		[Json]
		public AggressiveOfferDto AggressiveData;
		[Json]
		public string UserGroupLabel;
	
		// Constructors
		public GiveEmptyOfferDto() {}
	}
}
