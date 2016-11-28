﻿using Newtonsoft.Json;

namespace StrongGrid.Model
{
	public class Metrics
	{
		/// <summary>
		/// Gets or sets the blocks.
		/// </summary>
		/// <value>
		/// The blocks.
		/// </value>
		[JsonProperty("blocks")]
		public long Blocks { get; set; }

		/// <summary>
		/// Gets or sets the bounce drops.
		/// </summary>
		/// <value>
		/// The bounce drops.
		/// </value>
		[JsonProperty("bounce_drops")]
		public long BounceDrops { get; set; }

		/// <summary>
		/// Gets or sets the bounces.
		/// </summary>
		/// <value>
		/// The bounces.
		/// </value>
		[JsonProperty("bounces")]
		public long Bounces { get; set; }

		/// <summary>
		/// Gets or sets the clicks.
		/// </summary>
		/// <value>
		/// The clicks.
		/// </value>
		[JsonProperty("clicks")]
		public long Clicks { get; set; }

		/// <summary>
		/// Gets or sets the deferred.
		/// </summary>
		/// <value>
		/// The deferred.
		/// </value>
		[JsonProperty("deferred")]
		public long Deferred { get; set; }

		/// <summary>
		/// Gets or sets the delivered.
		/// </summary>
		/// <value>
		/// The delivered.
		/// </value>
		[JsonProperty("delivered")]
		public long Delivered { get; set; }

		/// <summary>
		/// Gets or sets the invalid emails.
		/// </summary>
		/// <value>
		/// The invalid emails.
		/// </value>
		[JsonProperty("invalid_emails")]
		public long InvalidEmails { get; set; }

		/// <summary>
		/// Gets or sets the opens.
		/// </summary>
		/// <value>
		/// The opens.
		/// </value>
		[JsonProperty("opens")]
		public long Opens { get; set; }

		/// <summary>
		/// Gets or sets the processed.
		/// </summary>
		/// <value>
		/// The processed.
		/// </value>
		[JsonProperty("processed")]
		public long Processed { get; set; }

		/// <summary>
		/// Gets or sets the requests.
		/// </summary>
		/// <value>
		/// The requests.
		/// </value>
		[JsonProperty("requests")]
		public long Requests { get; set; }

		/// <summary>
		/// Gets or sets the spam report drops.
		/// </summary>
		/// <value>
		/// The spam report drops.
		/// </value>
		[JsonProperty("spam_report_drops")]
		public long SpamReportDrops { get; set; }

		/// <summary>
		/// Gets or sets the spam reports.
		/// </summary>
		/// <value>
		/// The spam reports.
		/// </value>
		[JsonProperty("spam_reports")]
		public long SpamReports { get; set; }

		/// <summary>
		/// Gets or sets the unique clicks.
		/// </summary>
		/// <value>
		/// The unique clicks.
		/// </value>
		[JsonProperty("unique_clicks")]
		public long UniqueClicks { get; set; }

		/// <summary>
		/// Gets or sets the unique opens.
		/// </summary>
		/// <value>
		/// The unique opens.
		/// </value>
		[JsonProperty("unique_opens")]
		public long UniqueOpens { get; set; }

		/// <summary>
		/// Gets or sets the unsubscribe drops.
		/// </summary>
		/// <value>
		/// The unsubscribe drops.
		/// </value>
		[JsonProperty("unsubscribe_drops")]
		public long UnsubscribeDrops { get; set; }

		/// <summary>
		/// Gets or sets the unsubscribes.
		/// </summary>
		/// <value>
		/// The unsubscribes.
		/// </value>
		[JsonProperty("unsubscribes")]
		public long Unsubscribes { get; set; }
	}
}
