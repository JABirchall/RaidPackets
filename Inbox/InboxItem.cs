
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Inbox
{
	[MessagePackObject]
	public class InboxItem
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public InboxTypeId TypeId;
		[Json]
		// [Key]
		public bool IsRead;
		[Json]
		// [Key]
		public DateTime GivenTime;
		[Json]
		// [Key]
		public DateTime ValidTill;
		[Json]
		// [Key]
		public UserPrize Prize;
		[Json]
		// [Key]
		public int? QuestPrototypeId;
	
		// Constructors
		public InboxItem() {}
	
		// Methods
		public string ToStringExt() => default;
	}
}
