﻿using System;
using Estable.Lib.Extensions;

namespace Estable.Lib.Contracts
{
	public class Horse : JsonSerializable
	{
		public long Id { get; set; }
		public string RacingName { get; set; }
		public string StableHorseName { get; set; }
		public string Sire { get; set; }
		public string Dam { get; set; }
		public string Gender { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Colour { get; set; }
		public string Markings { get; set; }

		public string ToJson =>
			this.ToJson<Horse>();
	}
}
