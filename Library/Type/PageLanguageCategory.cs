using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Type
{
    public class PageLanguageCategory
    {

        public enum Type : int
        {
            Home = 0,
            HotelList=1,
            HotelDetail=2, 
        }
        
        public static IList<Type> Gets()
        {
            return Enum.GetValues(typeof(Type)).Cast<Type>().ToList();
        }

    }
}
