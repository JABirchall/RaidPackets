
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Payments;



namespace SharedModel.Meta.Payments.Data
{
	[MessagePackObject]
	public class SignInPaymentData
	{
		// Fields
		[Json]
		// [Key]
		public List<ClientPriceDto> Prices;
		[Json]
		// [Key]
		public PaymentSettings Settings;
	
		// Constructors
		public SignInPaymentData() {}
	}
}
