﻿using Dapper.Contrib.Extensions;

namespace DbModels.ModelHelpers
{
    public class TblUtils<T> where T : class
    {
        public static string Table()
        {
            var tableAttr = typeof(T).GetCustomAttributes(typeof(TableAttribute), true).FirstOrDefault() as TableAttribute;

            if (tableAttr != null)
            {
                return tableAttr.Name;
            }
            else
            {
                return string.Concat(typeof(T).Name.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString()));
            }
        }
    }
}
