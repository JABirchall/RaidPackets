
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Gifts.Data
{
	[MessagePackObject]
	public class UserGift
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public GiftType Type;
		[Json]
		// [Key]
		public UserPrize Prize;
		[Json]
		// [Key]
		public UiSettings UiSettings;
	
		// Constructors
		public UserGift() {}
	}
}
