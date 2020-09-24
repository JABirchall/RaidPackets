
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Network
{
	[MessagePackObject]
	public class SerializationBySegment
	{
		// Fields
		[Json]
		// [Key]
		public int Revision;
		[Json]
		// [Key]
		public Dictionary<int, string> Map;
	
		// Constructors
		public SerializationBySegment() {}
	
		// Methods
		public string Of(int segment) => default;
		public SerializationBySegment ReturnIfDifferent(int? revision) => default;
	}
}
