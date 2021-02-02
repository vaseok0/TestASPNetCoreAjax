using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestASPNetCoreAjax.Models.Data;

namespace TestASPNetCoreAjax.Models
{

    public class SelectLanguage
    {

        public IQueryable<Language> LanguageSelect(int id, MyDbContext db)
        {
            
            if(id == 1)
            {

                var res = db.Sharps;
                var a = res.ToList().Count();
                return res;
            }
            var ress = db.Sharps;
            return ress;

        }
        
    }
}
