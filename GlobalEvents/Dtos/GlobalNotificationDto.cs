
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.GlobalEvents.Enums;
using SharedModel.Meta.Quests;



namespace SharedModel.Meta.GlobalEvents.Dtos
{
	[MessagePackObject]
	public class GlobalNotificationDto
	{
		// Fields
		[Json]
		// [Key]
		public int EventId;
		[Json]
		// [Key]
		public DateTime Date;
		[Json]
		// [Key]
		public GlobalEventNotificationTypeId Type;
		[Json]
		// [Key]
		public QuestCategoryId? QuestCategoryId;
	
		// Constructors
		public GlobalNotificationDto() {}
	}
}
