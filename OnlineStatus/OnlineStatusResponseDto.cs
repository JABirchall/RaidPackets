
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.OnlineStatus
{
	[MessagePackObject]
	public class OnlineStatusResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<long, DateTime> UserActivityTimeById;
	
		// Constructors
		public OnlineStatusResponseDto() {}
	}
}
