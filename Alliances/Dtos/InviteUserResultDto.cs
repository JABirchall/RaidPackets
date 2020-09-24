
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
	public class InviteUserResultDto
	{
		// Fields
		[Json]
		// [Key]
		public AllianceInvitation Invitation;
		[Json]
		// [Key]
		public AllianceMember Member;
	
		// Constructors
		public InviteUserResultDto() {}
	}
}
