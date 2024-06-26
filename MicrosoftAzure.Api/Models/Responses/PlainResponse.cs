﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MicrosoftAzure.Api.Models.Responses;

public class PlainResponse<TProperties>
{
	[JsonPropertyName("value")]
	public required IReadOnlyCollection<TProperties> Values { get; set; }
}
