
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.FeatureStatuses
{
	public static class FeatureStatusExtensions
	{
		// Extension methods
		public static bool IsEnabled(this FeatureStatus status, UserAccount account = null) => default;
		public static bool IsEnabled(this FeatureStatus status, bool isAdmin) => default;
		public static void AssertIsEnabled(this FeatureStatus status, bool isAdmin, string featureName) {}
		public static void AssertIsEnabled(this FeatureStatus status, UserAccount account, string featureName) {}
	}
}
