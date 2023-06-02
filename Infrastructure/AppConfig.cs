using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SklepMVC.Infrastructure
{
    public class AppConfig
    {
        private static string _ikonyKategoriFolderWzgledny = ConfigurationManager.AppSettings["IkonykategoriiFolder"];//pobier sciezke stw w Webconfig, tu mozna bedzie zmianiec folder dla calosci obrazkow

        public static string IkonyKategoriFolderWzgledny
        {
            get
            {
                return _ikonyKategoriFolderWzgledny;
            }

        }
    }
}