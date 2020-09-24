
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Alliances;



namespace SharedModel.Meta.Alliances.Dtos
{
	[MessagePackObject]
	public class AddAllianceRequestResultDto
	{
		// Fields
		[Json]
		// [Key]
		public UserAllianceRequest AllianceRequest;
		[Json]
		// [Key]
		public AllianceMember AllianceMember;
	
		// Constructors
		public AddAllianceRequestResultDto() {}
	}
}
