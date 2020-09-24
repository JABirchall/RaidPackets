
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Agreements
{
	[MessagePackObject]
	public class AcceptUserAgreementResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public string Token;
	
		// Constructors
		public AcceptUserAgreementResponseDto() {}
	}
}
