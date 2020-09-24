
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Gifts.Dto
{
	[MessagePackObject]
	public class TakeGiftRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
	
		// Constructors
		public TakeGiftRequestDto() {}
	}
}
