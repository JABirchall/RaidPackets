
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Artifacts.Dtos
{
	[MessagePackObject]
	public class BulkUpgradeArtifactRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int ArtifactId;
		[Json]
		// [Key]
		public int Count;
	
		// Constructors
		public BulkUpgradeArtifactRequestDto() {}
	}
}
