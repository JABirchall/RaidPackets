
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Payments.Data
{
	public static class PurchaseResultExtension
	{
		// Extension methods
		public static bool IsSuccessful(this PurchaseResult self) => default;
		public static bool IsDuplicate(this PurchaseResult self) => default;
		public static bool IsSuccessOrDuplicate(this PurchaseResult self) => default;
	}
}
