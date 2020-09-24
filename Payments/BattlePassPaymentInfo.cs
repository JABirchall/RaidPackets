
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.BattlePasses;
using SharedModel.Meta.Offers.Enums;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Payments
{
	[MessagePackObject]
	public class BattlePassPaymentInfo
	{
		// Fields
		[Json]
		// [Key]
		public int BattlePassId;
		[Json]
		// [Key]
		public BattlePassPaymentTypeId BattlePassPaymentTypeId;
		[Json]
		// [Key]
		public bool IsOverdue;
		[Json]
		// [Key]
		public ExposureLocation Exposure;
		[Json]
		// [Key]
		public List<int> BoughtLevels;
		[Json]
		// [Key]
		public UserPrize Prize;
	
		// Constructors
		public BattlePassPaymentInfo() {}
	}
}
