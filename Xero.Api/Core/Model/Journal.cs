﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Common;

namespace Xero.Api.Core.Model
{
    [DataContract(Namespace = "")]
    public class Journal : IHasId
    {
        [DataMember(Name = "JournalID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember(Name = "JournalDate", EmitDefaultValue = false)]
        public DateTime Date { get; set; }

        [DataMember(Name = "JournalNumber", EmitDefaultValue = false)]
        public int Number { get; set; }

        [DataMember(Name = "CreatedDateUTC", EmitDefaultValue = false)]
        public DateTime CreatedDateUtc { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Reference { get; set; }

        [DataMember(Name = "JournalLines", EmitDefaultValue = false)]
        public List<Line> Lines { get; set; }
    }
}
