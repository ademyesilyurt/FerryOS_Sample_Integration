using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Library
{

    public class Configuration
    {

       
        public static string SystemUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["SystemUrl"];
            }
        }
        
        public static string Lang
        {
            get
            {
                return ConfigurationManager.AppSettings["LANG"];
            }
        }


        public static string SystemCompanyID
        {
            get
            {
                return ConfigurationManager.AppSettings["SystemCompanyID"];
            }
        }

        

        public static string BaseDomainDirectory
        {
            get
            {
                return ConfigurationManager.AppSettings["BaseDomainDirectory"];
            }
        }
        public static string BaseDomain 
        {
            get
            {
                return ConfigurationManager.AppSettings["BaseDomain"];
            }
        }

        public static string EMail
        {
            get
            {
                return ConfigurationManager.AppSettings["EMail"];
            }
        }
       

        public static string Phone
        {
            get
            {
                return ConfigurationManager.AppSettings["Phone"];
            }
        }
        
        public static string CompanyName
        {
            get
            {
                return ConfigurationManager.AppSettings["CompanyName"];
            }
        }
    
      

        public static string Address
        {
            get
            {
                return ConfigurationManager.AppSettings["Address"];
            }
        }
        public static string EXTRA_SERVICE_HOME
        {
            get
            {
                return ConfigurationManager.AppSettings["EXTRA_SERVICE_HOME"];
            }
        }

        public static string API_URL
        {
            get
            {
                return ConfigurationManager.AppSettings["API_URL"];
            }
        }
        public static string API_KEY
        {
            get
            {
                return ConfigurationManager.AppSettings["API_KEY"];
            }
        }

       

        public static string EXTRA_SERVICE_ALL
        {
            get
            {
                return ConfigurationManager.AppSettings["EXTRA_SERVICE_ALL"];
            }
        }
     
        public static string Language
        {
            get
            {
                return ConfigurationManager.AppSettings["Language"];
            }
        }
        
        

       
    }
}
