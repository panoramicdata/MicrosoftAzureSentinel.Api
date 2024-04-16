﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MicrosoftAzureSentinel.Api.Models;

public class AlertRuleResponseProperties
{
	[JsonPropertyName("queryFrequency")]
	public string? QueryFrequency { get; set; }

	[JsonPropertyName("queryPeriod")]
	public string? QueryPeriod { get; set; }

	[JsonPropertyName("triggerOperator")]
	public string? TriggerOperator { get; set; }

	[JsonPropertyName("triggerThreshold")]
	public int? TriggerThreshold { get; set; }

	[JsonPropertyName("eventGroupingSettings")]
	public AlertRuleResponseEventGroupingSettings? EventGroupingSettings { get; set; }

	[JsonPropertyName("incidentConfiguration")]
	public AlertRuleResponseIncidentConfiguration? IncidentConfiguration { get; set; }

	[JsonPropertyName("entityMappings")]
	public IReadOnlyCollection<AlertRuleResponseEntityMapping>? EntityMappings { get; set; }

	[JsonPropertyName("severity")]
	public required string Severity { get; set; }

	[JsonPropertyName("query")]
	public string? Query { get; set; }

	[JsonPropertyName("suppressionDuration")]
	public string? SuppressionDuration { get; set; }

	[JsonPropertyName("suppressionEnabled")]
	public bool? SuppressionEnabled { get; set; }

	[JsonPropertyName("tactics")]
	public required IReadOnlyCollection<string> Tactics { get; set; }

	[JsonPropertyName("techniques")]
	public required IReadOnlyCollection<string> Techniques { get; set; }

	[JsonPropertyName("displayName")]
	public required string DisplayName { get; set; }

	[JsonPropertyName("enabled")]
	public required bool Enabled { get; set; }

	[JsonPropertyName("description")]
	public required string Description { get; set; }

	[JsonPropertyName("alertRuleTemplateName")]
	public required string AlertRuleTemplateName { get; set; }

	[JsonPropertyName("lastModifiedUtc")]
	public required DateTime LastModifiedUtc { get; set; }

	[JsonPropertyName("templateVersion")]
	public string? TemplateVersion { get; set; }

	[JsonPropertyName("customDetails")]
	public AlertRuleResponseCustomDetails? CustomDetails { get; set; }
}
