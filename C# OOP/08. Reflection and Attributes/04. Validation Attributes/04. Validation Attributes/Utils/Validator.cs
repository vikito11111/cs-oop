﻿using _04._Validation_Attributes.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _04._Validation_Attributes.Utils
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            Type objectType = obj.GetType();

            PropertyInfo[] propertyInfos = objectType.GetProperties()
                .Where(p => p.CustomAttributes.Any(ca => typeof(MyValidationAttribute).IsAssignableFrom(ca.AttributeType)))
                .ToArray();

            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                IEnumerable<MyValidationAttribute> attributes = propertyInfo.GetCustomAttributes()
                    .Where(ca => typeof(MyValidationAttribute).IsAssignableFrom(ca.GetType()))
                    .Cast<MyValidationAttribute>();

                foreach (MyValidationAttribute attribute in attributes)
                {
                    object value = propertyInfo.GetValue(obj);

                    if (attribute.IsValid(value))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}