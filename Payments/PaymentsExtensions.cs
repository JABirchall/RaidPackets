
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Inbox;
using SharedModel.Meta.Offers;
using SharedModel.Meta.Offers.Dto;
using SharedModel.Meta.Payments.Data;
using SharedModel.Meta.Subscriptions.Data;
using SharedModel.Meta.Subscriptions.Dtos;
using SharedModel.Meta.Subscriptions.Enums;



namespace SharedModel.Meta.Payments
{
	public static class PaymentsExtensions
	{
		// Methods
		public static PurchasingPlatformId GetPlatformId(int? paymentProviderId) => default;
		public static bool IsMobile(int? paymentProviderId) => default;
	
		// Extension methods
		public static int GetNextTransactionId(this UserPaymentData paymentData) => default;
		public static Payment GetPayment(this UserPaymentData paymentData, int paymentId) => default;
		public static bool IsBillingNotPaymentNotification(this SubscriptionOperation operation) => default;
		public static Subscription GetSubscription(this UserPaymentData paymentData, int subscription) => default;
		public static Subscription GetSingleSubscription(this UserPaymentData paymentData, int groupId = 1) => default;
		public static int? GetActiveSubscriptionId(this UserPaymentData paymentData) => default;
		public static Subscription GetActiveSubscription(this UserPaymentData paymentData) => default;
		public static Payment GetPaymentByBillingTx(this UserPaymentData paymentData, string billingTransactionId, string externalTransactionId) => default;
		public static Subscription GetSubscriptionByBillingTx(this UserPaymentData paymentData, string billingTransactionId) => default;
		public static Payment AndPayment(this UserPaymentData paymentData, string billingTxId, string clientTxId, BillingPrice price, string originalCurrency, double? originalAmount, int? netEasePaymentTypeId, DateTime now, OfferPaymentInfo info = null, SubscriptionPaymentInfo subscriptionInfo = null, GooglePointsPaymentInfo googlePointsInfo = null, BattlePassPaymentInfo battlePassInfo = null, bool isTestPayment = false) => default;
		public static Payment ClosedManually(this Payment payment) => default;
		public static Subscription AddSubscription(this UserPaymentData paymentData, string billingTxId, SubscriptionDto subscriptionDto, int? paymentProviderId, DateTime now, DateTime expireDate) => default;
		public static void AddPrizeToPaymentIfNeeded(this UserPaymentData paymentData, UserOffer offer, List<InboxItem> inboxItems) {}
		public static IEnumerable<DateTime> EnumeratePurchaseDates(this UserPaymentData paymentData, int promoOfferId) => default;
		public static bool CanApplyPrizeMultiplier(this UserPaymentData paymentData, OpenOfferDto offer) => default;
		public static LogRecordPaymentType ToLogType(this BillingOperationType type) => default;
		public static SubscriptionDto AssertExist(this Dictionary<int, SubscriptionDto> subscriptionsById, int id, bool throwException = true) => default;
		public static PurchasingPlatformId AssertPurchasingPlatformId(this Subscription subscription, int? paymentProviderId) => default;
		public static int AssertNewIdExist(this SubscriptionPayData data) => default;
		public static Payment AddPayment(this UserPaymentData paymentData, PayRequest request, BillingPrice price, DateTime now, OfferPaymentInfo offer = null, SubscriptionPaymentInfo subscription = null) => default;
		public static Payment With(this Payment payment, BillingPrice price) => default;
	}
}
