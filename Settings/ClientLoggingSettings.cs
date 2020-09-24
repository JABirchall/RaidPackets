
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
	public class ClientLoggingSettings
	{
		// Fields
		[Json]
		// [Key]
		public float ViewOpenedLogTimeFromRegistrationDays;
	
		// Constructors
		public ClientLoggingSettings() {}
	}
}
