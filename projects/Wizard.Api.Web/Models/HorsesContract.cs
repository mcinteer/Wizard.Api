﻿using System.Collections.Generic;
using Estable.Lib.Extensions;

namespace Wizard.Api.Models
{
    public class HorsesContract : WizardContract
    {
        public IEnumerable<Horse> Horses { get; set; }

        public string ToJson =>
            this.ToJson<HorsesContract>();
    }
}