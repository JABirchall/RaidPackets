
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Payments.Data;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Payments
{
	[MessagePackObject]
	public class GooglePointsPaymentInfo
	{
		// Fields
		[Json]
		// [Key]
		public int Points;
		[Json]
		// [Key]
		public bool IsSeen;
		[Json]
		// [Key]
		public UserPrize Prize;
	
		// Constructors
		public GooglePointsPaymentInfo(GooglePointsData requestData) {}
		public GooglePointsPaymentInfo() {}
	}
}
