
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.Fuse.Dtos
{
	[MessagePackObject]
	public class FuseResourceRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public ResourceTypeId ResourceTypeId;
		[Json]
		// [Key]
		public int Count;
	
		// Constructors
		public FuseResourceRequestDto() {}
	}
}
