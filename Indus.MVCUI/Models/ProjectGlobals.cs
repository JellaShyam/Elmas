using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Elmas.MVCUI.Models
{
    public static class ProjectGlobals
    {
        public static string ApplicationDomain = ConfigurationManager.AppSettings["APPLICATION_DOMAIN"];
        //public static string ApplicationDomain = "http://vtrace.in/ElmasApiRestfull";
    }
}