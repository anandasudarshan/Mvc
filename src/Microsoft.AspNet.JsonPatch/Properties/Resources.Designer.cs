// <auto-generated />
namespace Microsoft.AspNet.JsonPatch
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNet.JsonPatch.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// The property at path '{0}' could not be updated.
        /// </summary>
        internal static string CannotUpdateProperty
        {
            get { return GetString("CannotUpdateProperty"); }
        }

        /// <summary>
        /// The property at path '{0}' could not be updated.
        /// </summary>
        internal static string FormatCannotUpdateProperty(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("CannotUpdateProperty"), p0);
        }

        /// <summary>
        /// For operation '{0}' on array property at path '{1}', the index is larger than the array size.
        /// </summary>
        internal static string InvalidIndexForArrayProperty
        {
            get { return GetString("InvalidIndexForArrayProperty"); }
        }

        /// <summary>
        /// For operation '{0}' on array property at path '{1}', the index is larger than the array size.
        /// </summary>
        internal static string FormatInvalidIndexForArrayProperty(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidIndexForArrayProperty"), p0, p1);
        }

        /// <summary>
        /// The type '{0}' was malformed and could not be parsed.
        /// </summary>
        internal static string InvalidJsonPatchDocument
        {
            get { return GetString("InvalidJsonPatchDocument"); }
        }

        /// <summary>
        /// The type '{0}' was malformed and could not be parsed.
        /// </summary>
        internal static string FormatInvalidJsonPatchDocument(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidJsonPatchDocument"), p0);
        }

        /// <summary>
        /// For operation '{0}', the provided path is invalid for array property at path '{1}'.
        /// </summary>
        internal static string InvalidPathForArrayProperty
        {
            get { return GetString("InvalidPathForArrayProperty"); }
        }

        /// <summary>
        /// For operation '{0}', the provided path is invalid for array property at path '{1}'.
        /// </summary>
        internal static string FormatInvalidPathForArrayProperty(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidPathForArrayProperty"), p0, p1);
        }

        /// <summary>
        /// The value '{0}' is invalid for property at path '{1}'.
        /// </summary>
        internal static string InvalidValueForProperty
        {
            get { return GetString("InvalidValueForProperty"); }
        }

        /// <summary>
        /// The value '{0}' is invalid for property at path '{1}'.
        /// </summary>
        internal static string FormatInvalidValueForProperty(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidValueForProperty"), p0, p1);
        }

        /// <summary>
        /// Property does not exist at path '{0}'.
        /// </summary>
        internal static string PropertyDoesNotExist
        {
            get { return GetString("PropertyDoesNotExist"); }
        }

        /// <summary>
        /// Property does not exist at path '{0}'.
        /// </summary>
        internal static string FormatPropertyDoesNotExist(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("PropertyDoesNotExist"), p0);
        }

        /// <summary>
        /// The test operation is not supported.
        /// </summary>
        internal static string TestOperationNotSupported
        {
            get { return GetString("TestOperationNotSupported"); }
        }

        /// <summary>
        /// The test operation is not supported.
        /// </summary>
        internal static string FormatTestOperationNotSupported()
        {
            return GetString("TestOperationNotSupported");
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
