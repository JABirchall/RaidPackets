
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.UserEdit;



namespace SharedModel.Meta.BlackMarket
{
	[MessagePackObject]
	public class BmiBox
	{
		// Fields
		[Json]
		// [Key]
		public int Count;
		[Json]
		// [Key]
		public List<DateTime> ExpiryDates;
		[Json]
		// [Key]
		public bool IsSeen;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public bool Empty { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public int ActiveItemsCount { get => default; }
	
		// Constructors
		public BmiBox() {}
	
		// Methods
		public IUndoState Add(int count = 1, DateTime? expiryDate = default, bool isSeen = false) => default;
		public List<DateTime> RemoveActiveItem(int count = 1) => default;
		public void RemoveActiveItem(DateTime? expiryDate) {}
		public bool IsExistItem(DateTime? expiryDate) => default;
		public List<DateTime> RemoveAllExpiredItems() => default;
		public int GetActiveItemsCount() => default;
		public bool IsExistActiveItem() => default;
	}
}
