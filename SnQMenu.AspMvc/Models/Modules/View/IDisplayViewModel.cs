﻿//@CodeCopy
//MdStart
using SnQMenu.AspMvc.Modules.View;
using System.Collections.Generic;
using System.Reflection;

namespace SnQMenu.AspMvc.Models.Modules.View
{
    public interface IDisplayViewModel : IViewModel
    {
        ModelObject Model { get; }
        ModelObject DisplayModel { get; }

        IEnumerable<PropertyInfo> GetDisplayProperties();
        string GetDisplayValue(PropertyInfo propertyInfo);
        object GetValue(PropertyInfo propertyInfo);
    }
}
//MdEnd