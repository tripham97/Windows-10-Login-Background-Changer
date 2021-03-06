using System;

namespace W10_Logon_BG_Changer.Annotations
{
    /// <summary>
    ///     Indicates that parameter is regular expression pattern.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class RegexPatternAttribute : Attribute
    {
    }
}