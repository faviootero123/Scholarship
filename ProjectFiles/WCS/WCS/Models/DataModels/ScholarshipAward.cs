using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace WCS.Models
{
    public class ScholarshipAward
    {
        public int Id { get; set; }

        public int StudentProfileId { get; set; }
        [JsonIgnore]
        public StudentProfile StudentProfile { get; set; }

        public int ScholarshipId { get; set; }
        [JsonIgnore]
        public Scholarship Scholarship { get; set; }

        public int AwardCycleId { get; set; }
        [JsonIgnore]
        public AwardCycle AwardCycle { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateAwarded { get; set; }

        public List<ScholarshipAwardMoney> AwardMonies { get; set; }

        public ScholarshipAward() => DateAwarded = DateTime.Now;

        [NotMapped]
        public double TotalAwardMoney
        {
            get
            {
                if(AwardMonies is not null)
                    return AwardMonies.Sum(i => i.Amount);
                return 0;
            }
        }
    }
}
