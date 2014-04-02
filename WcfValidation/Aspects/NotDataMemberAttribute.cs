using System;

namespace WcfValidation.Aspects
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class NotADataMemberAttribute:Attribute
    {
        
    }
}