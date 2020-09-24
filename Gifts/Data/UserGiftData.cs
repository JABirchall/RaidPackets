
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Gifts.Data
{
	[MessagePackObject]
	public class UserGiftData
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<int, UserGift> Gifts;
		[Json]
		// [Key]
		public List<int> Taken;
	
		// Constructors
		public UserGiftData() {}
	}
}
