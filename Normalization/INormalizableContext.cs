
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Account;
using SharedModel.Meta.AmazonIntegration;
using SharedModel.Meta.AutoOpen;
using SharedModel.Meta.Battle.Arena;
using SharedModel.Meta.DailyUpdates;
using SharedModel.Meta.Effects;
using SharedModel.Meta.Inbox;
using SharedModel.Meta.Offers;
using SharedModel.Meta.Payments;
using SharedModel.Meta.Village;



namespace SharedModel.Meta.Normalization
{
	public interface INormalizableContext
	{
		// Properties
		long UserId { get; }
		string EntityIdStr { get; }
		DateTime NormalizationTime { get; set; }
		UserAccount NormalizationAccountData { get; }
		UserVillageData NormalizationVillageData { get; }
		UserInboxData NormalizationInboxData { get; }
		UserEffectData NormalizationEffectData { get; }
		UserPaymentData NormalizationPaymentData { get; }
		UserDailyUpdateData NormalizationDailyUpdateData { get; }
		UserOfferData NormalizationOfferData { get; }
		UserAutoOpenData NormalizationAutoOpenData { get; }
		UserAmazonIntegrationData NormalizationAmazonIntegrationData { get; }
		UserArenaData NormalizationArenaData { get; }
	
		// Methods
		IEnumerable<INormalizable<INormalizableContext>> GetNormalizableList();
		void OnNormalizationStarting();
		void OnEventProcessing(INEvent @event);
		void OnNormalized();
	}
}
