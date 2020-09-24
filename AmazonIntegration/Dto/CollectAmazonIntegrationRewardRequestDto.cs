
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.AmazonIntegration.Dto
{
	public class CollectAmazonIntegrationRewardRequestDto
	{
		// Fields
		[Json]
		public AmazonIntegrationExposureLocationId ExposureId;
		[Json]
		public long GameId;
		[Json]
		public string AccessToken;
		[Json]
		public bool UserDidLogin;
	
		// Constructors
		public CollectAmazonIntegrationRewardRequestDto() {}
	}
}
