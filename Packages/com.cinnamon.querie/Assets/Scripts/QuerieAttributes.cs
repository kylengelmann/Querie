using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Querie
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public class QuerieElementClass : Attribute
    {
        public Type ElementClass {get;}
        public Type ResultType { get; }
        public string DisplayName;

        public QuerieElementClass(Type elementClass, Type resultType, string displayName = "")
        {
            ElementClass = elementClass;
            ResultType = resultType;
            DisplayName = ElementClass.ToString();
        }
    }
}