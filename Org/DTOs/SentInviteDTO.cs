﻿using System;

namespace Org.DTOs
{
    public class SentInviteDTO
    {
        public Guid Id { get; set; }
        public int FromOrgId { get; set; }
        public int ToOrgId { get; set; }
        public string Message { get; internal set; }
        public string Relationship_type { get; internal set; }
        public DateTime InviteDate { get; internal set; }
        public string Status { get; set; }

    }
}
