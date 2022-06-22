﻿using System.ComponentModel.DataAnnotations;

namespace Api.Genres;

public class ActorData {
	[MaxLength(100)]
	[Required]
	public string Name { get; set; } = default!;

	[MaxLength(100)]
	[Required]
	public string Birthplace { get; set; } = default!;
}
