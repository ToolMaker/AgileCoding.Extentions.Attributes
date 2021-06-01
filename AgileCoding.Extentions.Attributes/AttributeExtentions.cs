namespace AgileCoding.Extentions.Attributes
{
    using System;
    using System.Linq;
    using System.Reflection;

    public static class AttributeExtentions
    {
        public static object GetAttribute<ANYType>(this ANYType genericType, Type TypeOfAttribute)
            where ANYType : struct
        {
            Type genericEnumType = genericType.GetType();

            MemberInfo[] memberInfo = genericEnumType.GetMember(genericType.ToString());
            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var _Attribs = memberInfo[0].GetCustomAttributes(TypeOfAttribute, false);
                if ((_Attribs != null && _Attribs.Count() > 0))
                {
                    return _Attribs.ElementAt(0);
                }
            }
            return default(object);
        }
    }
}
