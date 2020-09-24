
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
	public class UnbanUserRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public BanTypeId BanTypeId;
		[Json]
		// [Key]
		public long UserId;
		[Json]
		// [Key]
		public string RoomId;
	
		// Constructors
		public UnbanUserRequestDto() {}
	}
}
