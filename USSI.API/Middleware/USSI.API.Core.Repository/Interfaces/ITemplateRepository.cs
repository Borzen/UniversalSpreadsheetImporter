using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USSI.API.Models.Database;

namespace USSI.API.Core.Repository.Interfaces
{
    public interface ITemplateRepository
    {
        List<Template> Get();
        Template Get(int id);
        Template Create(Template template);
        Template Update(Template template);
        Template Delete(int id);

    }
}
