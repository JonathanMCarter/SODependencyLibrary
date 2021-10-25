// ----------------------------------------------------------------------------
// DependencyLibraryPreBuildProcess.cs
// 
// Author: Jonathan Carter (A.K.A. J)
// Date: 22/10/2021
// ----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;

namespace DependencyLibrary.Editor
{
    public class DependencyLibraryPreBuildProcess : IPreprocessBuildWithReport
    {
        private static List<string> ValidTypes = new List<string>
        {
            "Bool",
            "Int",
            "Float",
            "Double",
            "Vector3"
        };


        public int callbackOrder { get; }


        public void OnPreprocessBuild(BuildReport report)
        {
            ResetAllValuesToDefault();
        }


        [MenuItem("Tools/Dependency Library/Reset All To Default Values")]
        public static void Test()
        {
            ResetAllValuesToDefault();
        }

        private static void ResetAllValuesToDefault()
        {
            foreach (var typeName in ValidTypes)
            {
                var _typeToFind = $"t:{typeName}Variable";
                var _allFound = AssetDatabase.FindAssets(_typeToFind, null);

                foreach (var _found in _allFound)
                {
                    var _path = AssetDatabase.GUIDToAssetPath(_found);
                    var _loadedAsset = (IDependencyResetOnBuild) AssetDatabase.LoadAssetAtPath(_path, typeof(IDependencyResetOnBuild));
                    _loadedAsset?.ResetValue();
                }
            }
        }
    }
}