
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Network;



namespace SharedModel.Meta.Network.Settings
{
	[MessagePackObject]
	public class MessagePackSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool DisableStaticDataCacheMessagePack;
		[Json]
		// [Key]
		public bool DisableManifestCacheMessagePack;
		[Json]
		// [Key]
		public bool GetBundleManifestMessagePackEnabled;
		[Json]
		// [Key]
		public bool GetStaticDataMessagePackEnabled;
		[Json]
		// [Key]
		public SerializationBySegment SerializationBySegment;
	
		// Constructors
		public MessagePackSettings() {}
	}
}
