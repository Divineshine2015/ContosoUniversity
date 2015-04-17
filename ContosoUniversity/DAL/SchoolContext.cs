using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace ContosoUniversity.DAL
{
    public class SchoolContext:DbContext 
    {

        public SchoolContext():base("SchoolContext")
        {


        }
    }
}