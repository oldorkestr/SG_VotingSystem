﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGLNU.BLL.DTO
{
    public class VoteDTO
    {
        public int Id { get; set; }

        public string AuthorEmail { get; set; }

        public int VotingId { get; set; }
    }
}
