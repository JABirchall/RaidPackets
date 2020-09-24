
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.ServerEvents
{
	[MessagePackObject]
	public class UserServerEventsData
	{
		// Fields
		[Json]
		// [Key]
		public UserNewbieEventData NewbieEventData;
	
		// Constructors
		public UserServerEventsData() {}
	}
}
