using System.Globalization;
using System.Reflection;

namespace System.ComponentModel.DataAnnotations
{
    internal class LocalizableString
    {
        private string _propertyName;
        private string _propertyValue;
        private Type _resourceType;
        private Func<string> _cachedResult;

        public string Value
        {
            get
            {
                return this._propertyValue;
            }
            set
            {
                if (!(this._propertyValue != value))
                    return;
                this.ClearCache();
                this._propertyValue = value;
            }
        }

        public Type ResourceType
        {
            get
            {
                return this._resourceType;
            }
            set
            {
                if (!(this._resourceType != value))
                    return;
                this.ClearCache();
                this._resourceType = value;
            }
        }

        public LocalizableString(string propertyName)
        {
            this._propertyName = propertyName;
        }

        public string GetLocalizableValue()
        {
            if (this._cachedResult == null)
            {
                if (this._propertyValue == null || this._resourceType == (Type)null)
                {
                    this._cachedResult = (Func<string>)(() => this._propertyValue);
                }
                else
                {
                    PropertyInfo property = this._resourceType.GetProperty(this._propertyValue);
                    bool flag = false;
                    if (!this._resourceType.IsVisible || property == (PropertyInfo)null || property.PropertyType != typeof(string))
                    {
                        flag = true;
                    }
                    else
                    {
                        MethodInfo getMethod = property.GetGetMethod();
                        if (getMethod == (MethodInfo)null || !getMethod.IsPublic || !getMethod.IsStatic)
                            flag = true;
                    }
                    if (flag)
                    {
                        string exceptionMessage = string.Format((IFormatProvider)CultureInfo.CurrentCulture, 
                            "Failed to localized value '{2}' for property '{0}' not found on type '{1}'", (object)this._propertyName, 
                            (object)this._resourceType.FullName, (object)this._propertyValue);

                        this._cachedResult = (Func<string>)(() =>
                        {
                            throw new InvalidOperationException(exceptionMessage);
                        });
                    }
                    else
                        this._cachedResult = (Func<string>)(() => (string)property.GetValue((object)null, (object[])null));
                }
            }
            return this._cachedResult();
        }

        private void ClearCache()
        {
            this._cachedResult = (Func<string>)null;
        }
    }
}
