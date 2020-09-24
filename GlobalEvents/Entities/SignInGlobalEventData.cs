
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.GlobalEvents.Entities
{
	[MessagePackObject]
	public class SignInGlobalEventData
	{
		// Fields
		[Json]
		// [Key]
		public GlobalEventsData Data;
		[Json]
		// [Key]
		public GlobalEventsSettings Settings;
	
		// Constructors
		public SignInGlobalEventData() {}
	}
}
