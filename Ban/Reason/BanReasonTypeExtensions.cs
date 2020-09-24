
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Ban.Reason
{
	public static class BanReasonTypeExtensions
	{
		// Fields
		private static readonly Dictionary<BanReasonType, string> StringByReasonType;
	
		// Constructors
		static BanReasonTypeExtensions() {}
	
		// Extension methods
		public static BanReasonType? AsBanReasonType(this string reason) => default;
		public static string AsString(this BanReasonType reasonType) => default;
	}
}
