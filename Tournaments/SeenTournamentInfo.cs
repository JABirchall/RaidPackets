
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Tournaments
{
	[MessagePackObject]
	public class SeenTournamentInfo
	{
		// Fields
		[Json]
		// [Key]
		public bool StartSeen;
		[Json]
		// [Key]
		public bool BracketFinishSeen;
		[Json]
		// [Key]
		public bool GlobalFinishSeen;
	
		// Constructors
		public SeenTournamentInfo() {}
	}
}
