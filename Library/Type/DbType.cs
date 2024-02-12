using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Type
{
    public class DbType
    {

        public enum Type : int
        {
            Undefined = -2,
            Delete = -1,
            Passive = 0,
            Active = 1,
        }

        public static Type GetType(object typeValue)
        {
            int value = 0;
            Type dbtype = new Type();
            if (Int32.TryParse(typeValue.ToString(), out value))
            {
                if (value == 0)
                    dbtype = Type.Passive;
                else if (value == 1)
                    dbtype = Type.Active;
                else if (value == -1)
                    dbtype = Type.Delete;
                else
                    dbtype = Type.Undefined;
            }

            return dbtype;
        }

        public static IList<Type> Gets()
        {
            return Enum.GetValues(typeof(Type)).Cast<Type>().ToList();
        }

    }
}
