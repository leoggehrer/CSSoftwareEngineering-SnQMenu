﻿//@CodeCopy
//MdStart
using SnQMenu.AspMvc.Models.Modules.Common;
using SnQMenu.AspMvc.Modules.View;
using System.Collections;
using System.Linq;

namespace SnQMenu.AspMvc.Models
{
    public partial class ModelObject
    {
        private CommandMode commandMode = CommandMode.All;

        public CommandMode CommandMode 
        {
            get => commandMode & (ViewBagInfo != null ? ViewBagInfo.CommandMode : CommandMode.All); 
            set => commandMode = value; 
        }
        public ViewBagWrapper ViewBagInfo { get; set; }

        protected static bool IsEqualsWith(object obj1, object obj2)
        {
            bool result = false;

            if (obj1 == null && obj2 == null)
            {
                result = true;
            }
            else if (obj1 != null && obj2 != null)
            {
                if (obj1 is IEnumerable objEnum1 && obj2 is IEnumerable objEnum2)
                {
                    var enumerable1 = objEnum1.Cast<object>().ToList();
                    var enumerable2 = objEnum2.Cast<object>().ToList();

                    result = enumerable1.SequenceEqual(enumerable2);
                }
                else
                {
                    result = obj1.Equals(obj2);
                }
            }
            return result;
        }
    }
}
//MdEnd
