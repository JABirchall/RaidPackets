
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Bundles
{
	[MessagePackObject]
	public class BundleExceptionDto
	{
		// Fields
		[Json]
		// [Key]
		public string Url;
		[Json]
		// [Key]
		public long? ResponseCode;
		[Json]
		// [Key]
		public string Message;
		[Json]
		// [Key]
		public string Type;
	
		// Constructors
		public BundleExceptionDto() {}
	}
}
