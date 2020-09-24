
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.AutoOpen.Settings;



namespace SharedModel.Meta.AutoOpen
{
	[MessagePackObject]
	public class UserAutoOpenData
	{
		// Fields
		[Json]
		// [Key]
		public List<DisplayedWindowByHour> WindowsByHourToday;
		[Json]
		// [Key]
		public Dictionary<InGameWindowTypeId, DateTime> WindowsByDate;
		[IgnoreMember]
		[JsonSkip]
		public List<DisplayedWindowByHour> SessionWindowsByHourToday;
	
		// Constructors
		public UserAutoOpenData() {}
	}
}
