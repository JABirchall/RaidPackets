
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Alliances.Dtos
{
	[MessagePackObject]
	public class FindAllianceDto
	{
		// Fields
		[Json]
		// [Key]
		public string Name;
	
		// Constructors
		public FindAllianceDto() {}
	}
}
