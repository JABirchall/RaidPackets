
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Artifacts;
using SharedModel.Meta.Inbox;



namespace SharedModel.Meta.Forge.Dtos
{
	[MessagePackObject]
	public class ForgeArtifactResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public Artifact Artifact;
		[Json]
		// [Key]
		public InboxItem InboxArtifact;
	
		// Constructors
		public ForgeArtifactResponseDto() {}
	}
}
