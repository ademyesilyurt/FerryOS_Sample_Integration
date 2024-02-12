using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Type
{
    public class BannerType
    {

        public enum Type : int
        {
            size1920x336 = 1,
            size208x299  = 2,
            size980x177  = 3,
            size208x370  = 4,
            size208x538  = 5,
        }

        public static IList<Type> Gets()
        {
            return Enum.GetValues(typeof(Type)).Cast<Type>().ToList();
        }
    }
}
