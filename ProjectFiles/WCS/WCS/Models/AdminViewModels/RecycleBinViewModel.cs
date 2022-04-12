using System.Collections.Generic;

namespace WCS.Models
{
    public class RecycleBinViewModel
    {
        public string StatusMessage { get; set; }

        public IEnumerable<RecycledItem> RecycledItems { get; set; }
    }
}
