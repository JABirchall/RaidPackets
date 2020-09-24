
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Inbox
{
	[MessagePackObject]
	public class StaticInboxData
	{
		// Fields
		[Json]
		// [Key]
		public int MaxInboxItemsCount;
		[Json]
		// [Key]
		public Dictionary<InboxTypeId, double> ItemLifeTimeDaysByTypeId;
		[Json]
		// [Key]
		public Dictionary<InboxTypeId, double> TokensLifeTimeDaysByTypeId;
		[Json]
		// [Key]
		public Dictionary<InboxTypeId, double> Tokens3X3LifeTimeDaysByTypeId;
		[Json]
		// [Key]
		public double ItemWithTokensLifeTimeDays;
	
		// Constructors
		public StaticInboxData() {}
	}
}
