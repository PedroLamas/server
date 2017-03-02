﻿using System;
using Bit.Core.Utilities;
using Bit.Core.Enums;

namespace Bit.Core.Domains
{
    public class Organization : IDataObject<Guid>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public PlanType Plan { get; set; }
        public short MaxUsers { get; set; }
        public DateTime CreationDate { get; internal set; } = DateTime.UtcNow;
        public DateTime RevisionDate { get; internal set; } = DateTime.UtcNow;

        public void SetNewId()
        {
            Id = CoreHelpers.GenerateComb();
        }
    }
}
