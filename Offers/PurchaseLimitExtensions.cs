
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Offers.Enums;



namespace SharedModel.Meta.Offers
{
	public static class PurchaseLimitExtensions
	{
		// Extension methods
		public static int ToNumber(this PurchaseLimit self) => default;
		public static bool IsHourly(this PurchaseLimit self) => default;
		public static bool IsDaily(this PurchaseLimit self) => default;
		public static bool IsWeekly(this PurchaseLimit self) => default;
		public static bool IsMonthly(this PurchaseLimit self) => default;
	}
}
