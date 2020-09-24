
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Payments
{
	[MessagePackObject]
	public class ChinaPaymentSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool Enabled;
		[Json]
		// [Key]
		public string StartUrl;
		[Json]
		// [Key]
		public string IosCallbackUrl;
		[Json]
		// [Key]
		public string AndroidCallbackUrl;
	
		// Constructors
		public ChinaPaymentSettings() {}
	}
}
