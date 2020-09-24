
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta
{
	[MessagePackObject]
	public class ClientStaticData : StaticData
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<string, string> StaticDataLocalization;
		[Json]
		// [Key]
		public Dictionary<string, string> ClientLocalization;
	
		// Constructors
		public ClientStaticData() {}
	}
}
