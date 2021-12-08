//@CodeCopy
//MdStart
using SnQMenu.AspMvc.Modules.View;
using System;
using System.Reflection;

namespace SnQMenu.AspMvc.Models.Modules.View
{
    public interface IViewModel
    {
        ViewBagWrapper ViewBagInfo { get; init; }
        Type DisplayType { get; }
        Type ModelType { get; }

        string GetId(PropertyInfo propertyInfo);
        string GetLabel(PropertyInfo propertyInfo);
        string GetName(PropertyInfo propertyInfo);
        object GetValue(object model, PropertyInfo propertyInfo);
    }
}
//MdEnd
