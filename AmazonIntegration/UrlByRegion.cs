
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.AmazonIntegration
{
	[MessagePackObject]
	public class UrlByRegion
	{
		// Fields
		[Json]
		// [Key]
		public string Region;
		[Json]
		// [Key]
		public string Url;
	
		// Constructors
		public UrlByRegion() {}
	}
}
