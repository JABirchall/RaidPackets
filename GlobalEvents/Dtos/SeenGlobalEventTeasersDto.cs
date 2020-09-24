
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.GlobalEvents.Dtos
{
	[MessagePackObject]
	public class SeenGlobalEventTeasersDto
	{
		// Fields
		[Json]
		// [Key]
		public List<int> PrototypeIds;
	
		// Constructors
		public SeenGlobalEventTeasersDto() {}
	}
}
