
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Stages.Dto
{
	[MessagePackObject]
	public class GetFractionWarDataRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public long UserId;
	
		// Constructors
		public GetFractionWarDataRequestDto() {}
	}
}
