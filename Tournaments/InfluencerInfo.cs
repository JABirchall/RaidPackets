
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
	public class InfluencerInfo
	{
		// Fields
		[Json]
		// [Key]
		public string ChannelName;
	
		// Constructors
		public InfluencerInfo() {}
	}
}
