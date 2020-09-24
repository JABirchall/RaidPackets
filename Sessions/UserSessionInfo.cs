
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Sessions
{
	[MessagePackObject]
	public class UserSessionInfo
	{
		// Fields
		[Json]
		// [Key]
		public DateTime StartTime;
		[Json]
		// [Key]
		public DateTime? LastUpdateTime;
		[Json]
		// [Key]
		public DateTime? EndTime;
		[Json]
		// [Key]
		public long InGameTimeMs;
		[Json]
		// [Key]
		public string UserHostAddress;
	
		// Constructors
		public UserSessionInfo() {}
	
		// Methods
		public int CalcHash() => default;
	}
}
