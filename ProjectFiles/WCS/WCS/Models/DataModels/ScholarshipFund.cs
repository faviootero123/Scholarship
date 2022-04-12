﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WCS.Models
{
    public class ScholarshipFund
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Amount { get; set; }

        [NotMapped]
        [JsonIgnore]
        public double Remaining
        {
            get
            {
                double amt = Amount;
                if (AwardMonies is not null)
                {
                    foreach (ScholarshipAwardMoney awarded in AwardMonies)
                    {
                        amt -= awarded.Amount;
                    }
                }
                return amt;
            }
        }

        //Nav Prop
        public int ScholarshipId { get; set; }
        [JsonIgnore]
        public Scholarship Scholarship { get; set; }

        public int AwardCycleId { get; set; }
        [JsonIgnore]
        public AwardCycle AwardCycle { get; set; }

        [JsonIgnore]
        public List<ScholarshipAwardMoney> AwardMonies { get; set; }
    }
}