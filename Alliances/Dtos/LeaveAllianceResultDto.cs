
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
	public class LeaveAllianceResultDto
	{
		// Fields
		[Json]
		// [Key]
		public DateTime DeletionTime;
	
		// Constructors
		public LeaveAllianceResultDto() {}
	}
}
