using System;
using System.Collections.Generic;

namespace LogiqApps.Models
{
    public class  ImportProcessDto
    {
        public Guid RecordId { get; set; }
        public string EntityName { get; set; }
        public string Result { get; set; }
        public bool Succeeded { get; set; }
        public string ErrorList { get; set; }
    }
}
