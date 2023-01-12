using System;
using System.Collections.Generic;

namespace LogiqApps.CustomEntity
{
    public class CustomEntity
    {
        public Guid Id { get; set; }
        public string LogicalName { get; set; }
        public IEnumerable<Field> Attributes { get; set; }
    }
}
