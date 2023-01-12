using System.Collections.Generic;

namespace LogiqApps.CustomEntity
{
    public class CustomEntityCollection
    {
        public int TotalCount { get; set; }
        public int Count { get; set; }
        public IEnumerable<CustomEntity> Entities { get; set; }
    }
}
