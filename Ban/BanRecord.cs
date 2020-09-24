
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Ban
{
	[MessagePackObject]
	public class BanRecord
	{
		// Fields
		[Json]
		// [Key]
		public long UserId;
		[Json]
		// [Key]
		public DateTime? BannedUntil;
		[Json]
		// [Key]
		public DateTime BanTime;
	
		// Constructors
		public BanRecord() {}
	}
}
