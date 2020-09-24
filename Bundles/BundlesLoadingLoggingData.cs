
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Bundles
{
	[MessagePackObject]
	public class BundlesLoadingLoggingData
	{
		// Fields
		[Json]
		// [Key]
		public LogRecordBundlesType LogRecordType;
		[Json]
		// [Key]
		public int EventIndex;
		[Json]
		// [Key]
		public int? LoadingCount;
		[Json]
		// [Key]
		public int? TotalCount;
	
		// Constructors
		public BundlesLoadingLoggingData() {}
		public BundlesLoadingLoggingData(LogRecordBundlesType logRecordType, int eventIndex, int? totalCount = default, int? loadingCount = default) {}
	}
}
