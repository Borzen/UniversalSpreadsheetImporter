using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USSI.API.Models.Database
{
    public class Template
    {
        public int TemplateId { get; set; }
        public string Name { get; set; }
        public string FileType { get; set; }
        public char ColumnDelimiter { get; set; }
        public char QuoteDelimiter { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedDateTime {  get; set; } = DateTime.UtcNow;

        List<TemplateColumn> TemplateColumns { get; set; }
    }
}
