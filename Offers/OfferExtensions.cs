
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Account;
using SharedModel.Meta.Offers.Dto;
using SharedModel.Meta.Offers.Enums;
using SharedModel.Meta.Payments;



namespace SharedModel.Meta.Offers
{
	public static class OfferExtensions
	{
		// Extension methods
		public static UserOffer AddOffer(this UserOfferData userData, GiveOfferDto giveOffer, DateTime givenTime, DateTime? validTill) => default;
		public static UserOffer AddOffer(this UserOfferData userData, OpenOfferDto openOffer, string paymentId) => default;
		public static bool IsFree(this UserOffer offer) => default;
		public static UserOffer GetOpenOffer(this UserOfferData userData, int promoOfferId, bool throwException = true) => default;
		public static UserOffer GetGiveOffer(this UserOfferData userData, int id, bool throwException = true) => default;
		public static bool IsToAdd(this OpenOfferDto offer) => default;
		public static UserOffer AddOrUpdateOfferIfNeeded(this UserOfferData userData, OpenOfferDto offer, DateTime time, string paymentId) => default;
		public static void CheckPurchaseLimit(this UserOfferData userData, OpenOfferDto offer, DateTime time) {}
		public static void AssertOfferPurchaseLimit(this UserOffer userOffer, DateTime time, PurchaseLimit purchaseLimit) {}
		public static bool SkipRefreshDynamicPriceOffer(this UserOfferDynamicPriceData data, DateTime now) => default;
		public static TimeSpan? GetPriceCooldownTime(this UserOfferDynamicPriceData data) => default;
		public static void AssertOfferPurchaseLimit(this UserOffer offer, DateTime time) {}
		public static bool ValidatePurchaseCount(this IEnumerable<DateTime> purchaseDates, PurchaseLimit? limitType, DateTime time, UserOffer offer = null) => default;
		public static int GetPurchaseCount(this IEnumerable<DateTime> purchaseDates, PurchaseLimit purchaseLimit, DateTime time) => default;
		public static OpenOfferDto AssertItemExist(this Dictionary<int, OpenOfferDto> openOfferById, int offerId, bool throwException = true) => default;
		public static OpenOfferDto AssertOfferHasResourcePrice(this OpenOfferDto offer, bool throwException = true) => default;
		public static UserOffer AssertOfferHasResourcePrice(this UserOffer offer, bool throwException = true) => default;
		public static OpenOfferDto AssertOfferHasDynamicPriceScale(this OpenOfferDto offer, bool throwException = true) => default;
		public static Account.Resources GetCurrentPrice(this UserOfferDynamicPriceData data) => default;
		public static bool IsEmpty(this GiveOfferDto offer) => default;
		public static bool IsObsolete(this UserOffer offer, DateTime time) => default;
		public static bool IsEmpty(this UnitedPrize prize) => default;
		public static bool RetentionPrizeAlreadyTaken(this UserOffer offer, DateTime now) => default;
		public static bool IsRetention(this UserOffer offer) => default;
		public static bool IsRetention(this OfferTypeId typeId) => default;
		public static bool AllRewardsHaveBeenTaken(this UserOfferRetentionData retentionData) => default;
		public static UserOfferProgressData ToUserProgressData(this ProgressOfferDto dto) => default;
		public static UserOfferRetentionData ToUserRetentionData(this RetentionOfferDto dto) => default;
		public static UserOfferDynamicPriceData ToUserDynamicPriceData(this DynamicPriceOfferDto dto) => default;
		public static bool IsEqual(this AggressiveOfferDto first, AggressiveOfferDto second) => default;
		public static bool IsEqual(this ChainOfferDto first, ChainOfferDto second) => default;
	}
}
