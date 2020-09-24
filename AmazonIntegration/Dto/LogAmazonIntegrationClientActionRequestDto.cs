
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.AmazonIntegration.Dto
{
	[MessagePackObject]
	public class LogAmazonIntegrationClientActionRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public AmazonIntegrationExposureLocationId ExposureId;
		[Json]
		// [Key]
		public LogRecordAmazonIntegrationType ActionType;
	
		// Constructors
		public LogAmazonIntegrationClientActionRequestDto() {}
	}
}
