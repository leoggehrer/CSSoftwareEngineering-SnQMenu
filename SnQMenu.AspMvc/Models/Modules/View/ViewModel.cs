﻿//@CodeCopy
//MdStart
using SnQMenu.AspMvc.Modules.View;
using System;
using System.Linq;
using System.Reflection;

namespace SnQMenu.AspMvc.Models.Modules.View
{
    public abstract partial class ViewModel : IViewModel
    {
        static ViewModel()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();

        public ViewBagWrapper ViewBagInfo { get; init; }
        public Type ModelType { get; }
        public Type DisplayType { get; }

        public List<string> HiddenNames { get; } = new List<string>()
        {
            nameof(IdentityModel.Id),
            nameof(VersionModel.RowVersionString),
        };
        public IEnumerable<string> AllHiddenNames
        {
            get { return HiddenNames.Union(ViewBagInfo.HiddenNames).Distinct(); }
        }
        public List<string> IgnoreNames { get; } = new List<string>()
        {
            nameof(IdentityModel.Id),
            nameof(VersionModel.RowVersion),
            nameof(VersionModel.RowVersionString),
            nameof(ModelObject.ViewBagInfo)
        };
        public IEnumerable<string> AllIgnoreNames
        {
            get { return IgnoreNames.Union(ViewBagInfo.IgnoreNames).Distinct(); }
        }
        public List<string> DisplayNames { get; } = new List<string>()
        {
        };
        public IEnumerable<string> AllDisplayNames
        {
            get { return DisplayNames.Union(ViewBagInfo.DisplayNames).Distinct(); }
        }

        protected ViewModel(ViewBagWrapper viewBagInfo, Type modelType, Type displayType)
        {
            viewBagInfo.CheckArgument(nameof(viewBagInfo));
            modelType.CheckArgument(nameof(modelType));
            displayType.CheckArgument(nameof(displayType));

            Constructing();
            ViewBagInfo = viewBagInfo;
            ModelType = modelType;
            DisplayType = displayType;
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();

        public void AddIgnoreHidden(string name)
        {
            if (IgnoreNames.Contains(name) == false)
                IgnoreNames.Add(name);

            if (HiddenNames.Contains(name) == false)
                HiddenNames.Add(name);
        }
        public virtual IEnumerable<PropertyInfo> GetHiddenProperties(Type type)
        {
            type.CheckArgument(nameof(type));

            return AllHiddenNames.Select(n => ViewBagInfo.GetMapping(n))
                                 .Select(n => type.GetProperty(n))
                                 .Where(p => p != null && p.CanRead)
                                 .ToArray();
        }
        public virtual IEnumerable<PropertyInfo> GetDisplayProperties(Type type)
        {
            type.CheckArgument(nameof(type));

            var result = new List<PropertyInfo>();
            var typeProperties = type.GetAllPropertyInfos();

            foreach (var item in type.GetAllInterfacePropertyInfos())
            {
                var typeProperty = default(PropertyInfo);
                var mapName = ViewBagInfo.GetMapping(item.Name);

                typeProperty = typeProperties.FirstOrDefault(p => p.Name.Equals(mapName, StringComparison.OrdinalIgnoreCase));
                if (typeProperty != null)
                {
                    ViewBagInfo.AddMappingProperty(mapName, typeProperty);
                }

                if (item.CanRead && AllDisplayNames.Any(e => e.Equals(item.Name)))
                {
                    result.Add(item);
                }
                else if (item.CanRead && AllDisplayNames.Any() == false && AllIgnoreNames.Any(e => e.Equals(item.Name)) == false)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public virtual string GetId(PropertyInfo propertyInfo)
        {
            propertyInfo.CheckArgument(nameof(propertyInfo));

            var itemPrefix = ViewBagInfo.ItemPrefix;

            return string.IsNullOrEmpty(itemPrefix) ? propertyInfo.Name : $"{itemPrefix}_{propertyInfo.Name}";
        }
        public virtual string GetName(PropertyInfo propertyInfo)
        {
            propertyInfo.CheckArgument(nameof(propertyInfo));

            var itemPrefix = ViewBagInfo.ItemPrefix;

            return string.IsNullOrEmpty(itemPrefix) ? propertyInfo.Name : $"{itemPrefix}.{propertyInfo.Name}";
        }
        public virtual string GetLabel(PropertyInfo propertyInfo)
        {
            propertyInfo.CheckArgument(nameof(propertyInfo));

            return propertyInfo.Name;
        }

        public virtual object GetValue(Object model, PropertyInfo propertyInfo)
        {
            model.CheckArgument(nameof(model));
            propertyInfo.CheckArgument(nameof(propertyInfo));

            var handled = false;
            var result = default(object);

            BeforeGetValue(model, propertyInfo, ref result, ref handled);
            if (handled == false)
            {
                result = propertyInfo.GetValue(model);
            }
            AfterGetValue(model, result);
            return result;
        }
        partial void BeforeGetValue(Object model, PropertyInfo propertyInfo, ref object value, ref bool handled);
        partial void AfterGetValue(Object model, Object value);
        public virtual string GetDisplayValue(Object model, PropertyInfo propertyInfo)
        {
            model.CheckArgument(nameof(model));
            propertyInfo.CheckArgument(nameof(propertyInfo));

            var handled = false;
            var result = string.Empty;

            BeforeGetDisplayValue(model, propertyInfo, ref result, ref handled);
            if (handled == false)
            {
                var value = propertyInfo.GetValue(model);

                if (value is DateTime dt)
                {
                    result = dt.ToString("yyyy-MM-ddTHH:mm");
                }
                else if (value != null)
                {
                    result = value.ToString();
                }
            }
            AfterGetDisplayValue(model, result);
            return result;
        }
        partial void BeforeGetDisplayValue(Object model, PropertyInfo propertyInfo, ref string value, ref bool handled);
        partial void AfterGetDisplayValue(Object model, string value);

    }
}
//MdEnd
