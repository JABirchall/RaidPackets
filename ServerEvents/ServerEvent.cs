
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Configuration;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;



namespace SharedModel.Meta.ServerEvents
{
	[MessagePackObject]
	public class ServerEvent : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public ServerEventTypeId TypeId;
		[Json]
		// [Key]
		public PortalColor? PortalColor;
		[Json]
		// [Key]
		public ConfigDateTime From;
		[Json]
		// [Key]
		public ConfigDateTime To;
		[Json]
		// [Key]
		public NewbieData NewbieData;
		[Json]
		// [Key]
		public ShardsData Shards;
		[Json]
		// [Key]
		public FractionsData Fractions;
		[Json]
		// [Key]
		public HeroesData Heroes;
	
		// Constructors
		public ServerEvent() {}
	
		// Methods
		public int CalcHash() => default;
	}
}
