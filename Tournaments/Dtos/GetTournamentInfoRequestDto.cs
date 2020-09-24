
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Tournaments.Dtos
{
	[MessagePackObject]
	public class GetTournamentInfoRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int QuestStateId;
	
		// Constructors
		public GetTournamentInfoRequestDto() {}
	}
}
