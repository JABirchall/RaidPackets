
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Debug
{
	[MessagePackObject]
	public class DebugSettings
	{
		// Fields
		[Json]
		// [Key]
		public string BadRequestUrl;
		[Json]
		// [Key]
		public string InternalServerErrorUrl;
		[Json]
		// [Key]
		public string ServiceUnavailableUrl;
		[Json]
		// [Key]
		public string TimeoutErrorUrl;
		[Json]
		// [Key]
		public string NotFoundErrorUrl;
	
		// Constructors
		public DebugSettings() {}
	}
}
