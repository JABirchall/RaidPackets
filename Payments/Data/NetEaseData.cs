
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Payments.Data
{
	[MessagePackObject]
	public class NetEaseData
	{
		// Fields
		[Json]
		// [Key]
		public int? PaymentTypeId;
	
		// Constructors
		public NetEaseData() {}
	}
}
