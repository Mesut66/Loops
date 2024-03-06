using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForForeacFaster
{
    internal class DataInitializer:CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {
            base.Seed(context);
        }
    }
}
