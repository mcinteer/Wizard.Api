﻿using Wizard.Api.Extensions;

namespace Wizard.Api.Models
{
    public class StableDataContract : WizardContract
    {
        public string RacingCode { get; set; }
        public string Trainer { get; set; }
        public string LegalEntity { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Address { get; set; }

        public string ToJson => this.ToJson<StableDataContract>();
    }
}