
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Settings
{
	[MessagePackObject]
	public class ClientSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool FractionWarsHeroRatingEnabled;
	
		// Constructors
		public ClientSettings() {}
	}
}
