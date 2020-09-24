
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Device;



namespace SharedModel.Meta.Settings
{
	[MessagePackObject]
	public class UxCamSettings
	{
		// Fields
		[Json]
		// [Key]
		public List<string> DisabledPlatformVersions;
		[Json]
		// [Key]
		public List<string> DisabledDeviceModels;
		[Json]
		// [Key]
		public List<long> DisabledUsers;
	
		// Constructors
		public UxCamSettings() {}
	
		// Methods
		public bool UxCamEnabled(long userId, ClientInfo userClientInfo) => default;
	}
}
