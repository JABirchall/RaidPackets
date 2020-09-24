
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.PeriodicQuests.Data;



namespace SharedModel.Meta.Notifications
{
	[MessagePackObject]
	public class PushCancellationDetails
	{
		// Fields
		[Json]
		// [Key]
		public long? UnitId;
		[Json]
		// [Key]
		public long? InventoryItemId;
		[Json]
		// [Key]
		public long? RequestId;
		[Json]
		// [Key]
		public PeriodicQuestGroupId PeriodicQuestGroupId;
		[Json]
		// [Key]
		public long? GeneralId;
	
		// Constructors
		public PushCancellationDetails() {}
	}
}
