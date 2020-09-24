
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;



namespace SharedModel.Meta.Stages
{
	[MessagePackObject]
	public class StageHeroesFormation : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public List<ShortHeroSlotSetup> HeroSlotsSetup;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<int, List<ShortHeroSlotSetup>> _heroesByRound;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<int, List<ShortHeroSlotSetup>> HeroesByRound { get => default; }
	
		// Constructors
		public StageHeroesFormation() {}
	
		// Methods
		public override bool Equals(object obj) => default;
		protected bool Equals(StageHeroesFormation other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
	}
}
