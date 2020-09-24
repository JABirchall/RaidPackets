
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.ServerEvents
{
	[MessagePackObject]
	public class UserNewbieEventData
	{
		// Fields
		[Json]
		// [Key]
		public DateTime StartTime;
		[Json]
		// [Key]
		public double LifeTimeInHours;
	
		// Constructors
		public UserNewbieEventData() {}
	}
}
