using System.Text.Json.Serialization;

namespace StrongGrid.Json
{
	[JsonSerializable(typeof(string[]))]
	[JsonSerializable(typeof(long[]))]

	[JsonSerializable(typeof(StrongGrid.Json.StrongGridJsonObject))]
	[JsonSerializable(typeof(StrongGrid.Json.StrongGridJsonObject[]))]

	[JsonSerializable(typeof(StrongGrid.Models.AccessEntry))]
	[JsonSerializable(typeof(StrongGrid.Models.AccessRequest))]
	[JsonSerializable(typeof(StrongGrid.Models.Account))]
	[JsonSerializable(typeof(StrongGrid.Models.AddIpAddressResult))]
	[JsonSerializable(typeof(StrongGrid.Models.AddressWhitelistSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.Alert))]
	[JsonSerializable(typeof(StrongGrid.Models.ApiKey))]
	[JsonSerializable(typeof(StrongGrid.Models.Attachment))]
	[JsonSerializable(typeof(StrongGrid.Models.AuthenticatedDomain))]
	[JsonSerializable(typeof(StrongGrid.Models.AuthenticatedDomainDns))]
	[JsonSerializable(typeof(StrongGrid.Models.BatchInfo))]
	[JsonSerializable(typeof(StrongGrid.Models.BccSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.Block))]
	[JsonSerializable(typeof(StrongGrid.Models.Bounce))]
	[JsonSerializable(typeof(StrongGrid.Models.BouncePurgeSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.BrandedLink))]
	[JsonSerializable(typeof(StrongGrid.Models.BrandedLinkDns))]
	[JsonSerializable(typeof(StrongGrid.Models.ClickTrackingSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.Contact))]
	[JsonSerializable(typeof(StrongGrid.Models.Design))]
	[JsonSerializable(typeof(StrongGrid.Models.DnsRecord))]
	[JsonSerializable(typeof(StrongGrid.Models.DomainValidation))]
	[JsonSerializable(typeof(StrongGrid.Models.DomainValidationResults))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.BlockedEvent), TypeInfoPropertyName = "EmailActivitiesBlockedEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.BounceEvent), TypeInfoPropertyName = "EmailActivitiesBounceEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.ClickEvent), TypeInfoPropertyName = "EmailActivitiesClickEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.DeferredEvent), TypeInfoPropertyName = "EmailActivitiesDeferredEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.DeliveredEvent), TypeInfoPropertyName = "EmailActivitiesDeliveredEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.DroppedEvent), TypeInfoPropertyName = "EmailActivitiesDroppedEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.Event), TypeInfoPropertyName = "EmailActivitiesEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.GroupResubscribeEvent), TypeInfoPropertyName = "EmailActivitiesGroupResubscribeEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.GroupUnsubscribeEvent), TypeInfoPropertyName = "EmailActivitiesGroupUnsubscribeEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.OpenEvent), TypeInfoPropertyName = "EmailActivitiesOpenEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.ProcessedEvent), TypeInfoPropertyName = "EmailActivitiesProcessedEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.SpamReportEvent), TypeInfoPropertyName = "EmailActivitiesSpamReportEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.UnsubscribeEvent), TypeInfoPropertyName = "EmailActivitiesUnsubscribeEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailAddressSetting))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailMessageActivity))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailMessageSummary))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailValidationAdditionalChecks))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailValidationChecks))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailValidationDomainChecks))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailValidationLocalPartChecks))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailValidationResult))]
	[JsonSerializable(typeof(StrongGrid.Models.EnforcedTlsSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.Error))]
	[JsonSerializable(typeof(StrongGrid.Models.EventWebhookSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.ExportJob))]
	[JsonSerializable(typeof(StrongGrid.Models.Field))]
	[JsonSerializable(typeof(StrongGrid.Models.FieldMetadata))]
	[JsonSerializable(typeof(StrongGrid.Models.FooterGlobalSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.FooterSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.GlobalSetting))]
	[JsonSerializable(typeof(StrongGrid.Models.GlobalSuppression))]
	[JsonSerializable(typeof(StrongGrid.Models.GoogleAnalyticsGlobalSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.GoogleAnalyticsSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.ImportJob))]
	[JsonSerializable(typeof(StrongGrid.Models.ImportJobRequest))]
	[JsonSerializable(typeof(StrongGrid.Models.ImportResults))]
	[JsonSerializable(typeof(StrongGrid.Models.InboundParseWebhookSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.InvalidEmail))]
	[JsonSerializable(typeof(StrongGrid.Models.IpAddress))]
	[JsonSerializable(typeof(StrongGrid.Models.IpAddressesRemaining))]
	[JsonSerializable(typeof(StrongGrid.Models.IpPool))]
	[JsonSerializable(typeof(StrongGrid.Models.IpPoolAddress))]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.Campaign), TypeInfoPropertyName = "LegacyCampaign")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.Contact), TypeInfoPropertyName = "LegacyContact")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.CustomFieldMetadata), TypeInfoPropertyName = "LegacyCustomFieldMetadata")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.Field), TypeInfoPropertyName = "LegacyField")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.Field[]), TypeInfoPropertyName = "LegacyFieldArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.FieldMetadata), TypeInfoPropertyName = "LegacyFieldMetadata")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.ImportResult), TypeInfoPropertyName = "LegacyImportResult")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.List), TypeInfoPropertyName = "LegacyList")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.SearchCondition), TypeInfoPropertyName = "LegacySearchCondition")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.Segment), TypeInfoPropertyName = "LegacySegment")]
	[JsonSerializable(typeof(StrongGrid.Models.LinkValidation))]
	[JsonSerializable(typeof(StrongGrid.Models.LinkValidationResults))]
	[JsonSerializable(typeof(StrongGrid.Models.List))]
	[JsonSerializable(typeof(StrongGrid.Models.MailAddress))]
	[JsonSerializable(typeof(StrongGrid.Models.MailContent))]
	[JsonSerializable(typeof(StrongGrid.Models.MailPersonalization))]
	[JsonSerializable(typeof(StrongGrid.Models.MailSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.MonitorSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.NewRelicSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.OpenTrackingSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.PaginationMetadata))]
	[JsonSerializable(typeof(StrongGrid.Models.ReverseDns))]
	[JsonSerializable(typeof(StrongGrid.Models.ReverseDnsValidation))]
	[JsonSerializable(typeof(StrongGrid.Models.ReverseDnsValidationResults))]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteria), TypeInfoPropertyName = "SearchLegacySearchCriteria")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaBetween), TypeInfoPropertyName = "SearchLegacySearchCriteriaBetween")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaEqual), TypeInfoPropertyName = "SearchLegacySearchCriteriaEqual")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaGreaterEqual), TypeInfoPropertyName = "SearchLegacySearchCriteriaGreaterEqual")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaGreaterThan), TypeInfoPropertyName = "SearchLegacySearchCriteriaGreaterThan")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaIn), TypeInfoPropertyName = "SearchLegacySearchCriteriaIn")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaIs), TypeInfoPropertyName = "SearchLegacySearchCriteriaIs")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaIsNot), TypeInfoPropertyName = "SearchLegacySearchCriteriaIsNot")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaLessEqual), TypeInfoPropertyName = "SearchLegacySearchCriteriaLessEqual")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaLessThan), TypeInfoPropertyName = "SearchLegacySearchCriteriaLessThan")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaLike), TypeInfoPropertyName = "SearchLegacySearchCriteriaLike")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaNotBetween), TypeInfoPropertyName = "SearchLegacySearchCriteriaNotBetween")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaNotEqual), TypeInfoPropertyName = "SearchLegacySearchCriteriaNotEqual")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaNotIn), TypeInfoPropertyName = "SearchLegacySearchCriteriaNotIn")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaNotLike), TypeInfoPropertyName = "SearchLegacySearchCriteriaNotLike")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaNotNull), TypeInfoPropertyName = "SearchLegacySearchCriteriaNotNull")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaNull), TypeInfoPropertyName = "SearchLegacySearchCriteriaNull")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaUniqueArg), TypeInfoPropertyName = "SearchLegacySearchCriteriaUniqueArg")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaUniqueArgBetween), TypeInfoPropertyName = "SearchLegacySearchCriteriaUniqueArgBetween")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaUniqueArgEqual), TypeInfoPropertyName = "SearchLegacySearchCriteriaUniqueArgEqual")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaUniqueArgGreaterEqual), TypeInfoPropertyName = "SearchLegacySearchCriteriaUniqueArgGreaterEqual")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaUniqueArgGreaterThan), TypeInfoPropertyName = "SearchLegacySearchCriteriaUniqueArgGreaterThan")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaUniqueArgIn), TypeInfoPropertyName = "SearchLegacySearchCriteriaUniqueArgIn")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaUniqueArgIs), TypeInfoPropertyName = "SearchLegacySearchCriteriaUniqueArgIs")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaUniqueArgIsNot), TypeInfoPropertyName = "SearchLegacySearchCriteriaUniqueArgIsNot")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaUniqueArgLessEqual), TypeInfoPropertyName = "SearchLegacySearchCriteriaUniqueArgLessEqual")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaUniqueArgLessThan), TypeInfoPropertyName = "SearchLegacySearchCriteriaUniqueArgLessThan")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaUniqueArgLike), TypeInfoPropertyName = "SearchLegacySearchCriteriaUniqueArgLike")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaUniqueArgNotBetween), TypeInfoPropertyName = "SearchLegacySearchCriteriaUniqueArgNotBetween")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaUniqueArgNotEqual), TypeInfoPropertyName = "SearchLegacySearchCriteriaUniqueArgNotEqual")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaUniqueArgNotIn), TypeInfoPropertyName = "SearchLegacySearchCriteriaUniqueArgNotIn")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaUniqueArgNotLike), TypeInfoPropertyName = "SearchLegacySearchCriteriaUniqueArgNotLike")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaUniqueArgNotNull), TypeInfoPropertyName = "SearchLegacySearchCriteriaUniqueArgNotNull")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.Legacy.SearchCriteriaUniqueArgNull), TypeInfoPropertyName = "SearchLegacySearchCriteriaUniqueArgNull")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteria), TypeInfoPropertyName = "SearchSearchCriteria")]
	[JsonSerializable(typeof(StrongGrid.Models.Segment))]
	[JsonSerializable(typeof(StrongGrid.Models.SenderIdentity))]
	[JsonSerializable(typeof(StrongGrid.Models.SenderReputation))]
	[JsonSerializable(typeof(StrongGrid.Models.SingleSend))]
	[JsonSerializable(typeof(StrongGrid.Models.SingleSendEmailConfig))]
	[JsonSerializable(typeof(StrongGrid.Models.SingleSendSendTo))]
	[JsonSerializable(typeof(StrongGrid.Models.SpamCheckingSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.SpamCheckSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.SpamReport))]
	[JsonSerializable(typeof(StrongGrid.Models.Stat))]
	[JsonSerializable(typeof(StrongGrid.Models.Statistic))]
	[JsonSerializable(typeof(StrongGrid.Models.SubscriptionSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.SubscriptionTrackingSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.Subuser))]
	[JsonSerializable(typeof(StrongGrid.Models.Suppression))]
	[JsonSerializable(typeof(StrongGrid.Models.SuppressionGroup))]
	[JsonSerializable(typeof(StrongGrid.Models.Teammate))]
	[JsonSerializable(typeof(StrongGrid.Models.TeammateInvitation))]
	[JsonSerializable(typeof(StrongGrid.Models.Template))]
	[JsonSerializable(typeof(StrongGrid.Models.TemplateSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.TemplateVersion))]
	[JsonSerializable(typeof(StrongGrid.Models.TrackingSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.UnsubscribeOptions))]
	[JsonSerializable(typeof(StrongGrid.Models.UserCredits))]
	[JsonSerializable(typeof(StrongGrid.Models.UserProfile))]
	[JsonSerializable(typeof(StrongGrid.Models.ValidationResult))]
	[JsonSerializable(typeof(StrongGrid.Models.VerificationStatus))]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.BouncedEvent), TypeInfoPropertyName = "WebhooksBouncedEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.ClickedEvent), TypeInfoPropertyName = "WebhooksClickedEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.DeferredEvent), TypeInfoPropertyName = "WebhooksDeferredEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.DeliveredEvent), TypeInfoPropertyName = "WebhooksDeliveredEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.DeliveryEvent), TypeInfoPropertyName = "WebhooksDeliveryEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.DroppedEvent), TypeInfoPropertyName = "WebhooksDroppedEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.EngagementEvent), TypeInfoPropertyName = "WebhooksEngagementEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.Event), TypeInfoPropertyName = "WebhooksEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.GroupResubscribeEvent), TypeInfoPropertyName = "WebhooksGroupResubscribeEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.GroupUnsubscribeEvent), TypeInfoPropertyName = "WebhooksGroupUnsubscribeEvent")]
	/*
	 * Intentionally commenting out the following three lines because InboundEmailAttachment has a
	 * property of type 'Stream' which System.Text.Json.SourceGeneration can not handle.
	 * To make matters worse, you get an error regarding ReadOnlySpan<byte> which is confusing and not helpful.
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.InboundEmail), TypeInfoPropertyName = "WebhooksInboundEmail")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.InboundEmailAttachment), TypeInfoPropertyName = "WebhooksInboundEmailAttachment")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.InboundEmailEnvelope), TypeInfoPropertyName = "WebhooksInboundEmailEnvelope")]
	*/
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.IpPool), TypeInfoPropertyName = "WebhooksIpPool")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.Newsletter), TypeInfoPropertyName = "WebhooksNewsletter")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.OpenedEvent), TypeInfoPropertyName = "WebhooksOpenedEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.ProcessedEvent), TypeInfoPropertyName = "WebhooksProcessedEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.SpamReportEvent), TypeInfoPropertyName = "WebhooksSpamReportEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.UnsubscribeEvent), TypeInfoPropertyName = "WebhooksUnsubscribeEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.UrlOffset), TypeInfoPropertyName = "WebhooksUrlOffset")]
	[JsonSerializable(typeof(StrongGrid.Models.WhitelistedIp))]
	internal partial class StrongGridJsonSerializerContext : JsonSerializerContext
	{
	}
}