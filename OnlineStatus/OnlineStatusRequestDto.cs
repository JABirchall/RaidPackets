
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.OnlineStatus
{
	[MessagePackObject]
	public class OnlineStatusRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public long[] UserIds;
	
		// Constructors
		public OnlineStatusRequestDto() {}
	}
}
