
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Alliances
{
	[MessagePackObject]
	public class AllianceRequest
	{
		// Fields
		[Json]
		// [Key]
		public long UserId;
		[Json]
		// [Key]
		public DateTime Date;
		[Json]
		// [Key]
		public string Message;
		[Json]
		// [Key]
		public bool IsSeen;
	
		// Constructors
		public AllianceRequest() {}
	}
}
