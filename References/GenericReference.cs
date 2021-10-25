// ----------------------------------------------------------------------------
// GenericReference.cs
// 
// Author: Jonathan Carter (A.K.A. J)
// Date: 22/10/2021
// ----------------------------------------------------------------------------

using UnityEngine;

namespace DependencyLibrary
{
    public class GenericReference<T>
    {
        public bool useConstant = true;
        public T constantValue;
        public IDependencyLibVariable<T> variable;

        public GenericReference() {}

        public GenericReference(T value)
        {
            useConstant = true;
            constantValue = value;
        }

        public virtual IDependencyLibVariable<T> GetVariable
        {
            get => variable;
        }

        public virtual T Value
        {
            get =>
                useConstant
                    ? constantValue
                    : GetVariable.Value;
        }


        public void SetValue(T value)
        {
            if (useConstant)
                constantValue = value;
            else
                GetVariable.SetValue(value);
        }

        public static implicit operator T(GenericReference<T> reference)
            => reference.Value;
    }
}