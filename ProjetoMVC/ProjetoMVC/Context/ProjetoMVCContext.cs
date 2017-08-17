using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProjetoMVC.Models;

namespace ProjetoMVC.Context
{
    public class ProjetoMVCContext :DbContext
    {
        public ProjetoMVCContext()
            :base("ProjetoMVCContext")
            //:base("ProjetoMVCHome")
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}