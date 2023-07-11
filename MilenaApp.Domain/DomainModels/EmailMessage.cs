using System;
using System.Collections.Generic;
using System.Text;

namespace MilenaApp.Domain.DomainModels
{
    public class EmailMessage : BaseEntity
    {
        public string mailTo { get; set; }
        public string subject { get; set; }
        public string content { get; set; }
        public Boolean status { get; set; }
    }
}
