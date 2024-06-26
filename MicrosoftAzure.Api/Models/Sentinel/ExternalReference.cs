﻿using System.Text.Json.Serialization;

namespace MicrosoftAzure.Api.Models.Sentinel;

public class ExternalReference
{
	[JsonPropertyName("description")]
	public required string Description { get; set; }

	[JsonPropertyName("externalId")]
	public required string ExternalId { get; set; }

	[JsonPropertyName("sourceName")]
	public required string SourceName { get; set; }
}
