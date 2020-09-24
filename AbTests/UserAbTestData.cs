
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.AbTests
{
	[MessagePackObject]
	public class UserAbTestData
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<AbTestTypeId, AbTest> TestsById;
	
		// Constructors
		public UserAbTestData() {}
	}
}
