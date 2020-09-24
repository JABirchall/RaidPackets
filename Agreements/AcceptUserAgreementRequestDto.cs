
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Agreements
{
	[MessagePackObject]
	public class AcceptUserAgreementRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public List<UserAgreementId> UserAgreements;
	
		// Constructors
		public AcceptUserAgreementRequestDto() {}
	}
}
