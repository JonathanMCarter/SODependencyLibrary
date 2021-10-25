// ----------------------------------------------------------------------------
// IDependencyLibVariable.cs
// 
// Author: Jonathan Carter (A.K.A. J)
// Date: 22/10/2021
// ----------------------------------------------------------------------------

using UnityEngine;

namespace DependencyLibrary
{
    public interface IDependencyLibVariable<T>
    {
        string DevDescription { get; set; }
        T DefaultValue { get; set; }
        T Value { get; set; }
        void SetValue(T value);
    }
}