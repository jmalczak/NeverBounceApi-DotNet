﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeverBounce.Models
{
  
    public class CreditsInfo
    {
        public int paid_credits_used { get; set; }
        public int free_credits_used { get; set; }
        public int paid_credits_remaining { get; set; }
        public int free_credits_remaining { get; set; }
    }

    public class JobCounts
    {
        public int completed { get; set; }
        public int under_review { get; set; }
        public int queued { get; set; }
        public int processing { get; set; }
    }

    public class AccountInfoModel : ResponseModel
    {
        public string status { get; set; }
        public CreditsInfo credits_info { get; set; }
        public JobCounts job_counts { get; set; }
        public int execution_time { get; set; }
    }
}
