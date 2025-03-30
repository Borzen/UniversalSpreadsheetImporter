using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USSI.API.Models.Database
{
    public class TemplateColumn
    {
        public int TemplateColumnId { get; set; }
        public int TemplateId { get; set; }
        public string Name { get; set; }
        public string DataType { get; set; }
        public bool Required { get; set; }
    }
}
