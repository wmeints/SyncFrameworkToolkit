// Type: System.ComponentModel.DataAnnotations.DisplayAttribute
// Assembly: System.ComponentModel.DataAnnotations, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Windows\Microsoft.NET\assembly\GAC_MSIL\System.ComponentModel.DataAnnotations\v4.0_4.0.0.0__31bf3856ad364e35\System.ComponentModel.DataAnnotations.dll

using System;
using System.Globalization;
using System.Runtime;

namespace System.ComponentModel.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public sealed class DisplayAttribute : Attribute
    {
        private LocalizableString _shortName = new LocalizableString("ShortName");
        private LocalizableString _name = new LocalizableString("Name");
        private LocalizableString _description = new LocalizableString("Description");
        private LocalizableString _prompt = new LocalizableString("Prompt");
        private LocalizableString _groupName = new LocalizableString("GroupName");
        private Type _resourceType;
        private bool? _autoGenerateField;
        private bool? _autoGenerateFilter;
        private int? _order;

        public string ShortName
        {
            get
            {
                return this._shortName.Value;
            }
            set
            {
                if (!(this._shortName.Value != value))
                    return;
                this._shortName.Value = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name.Value;
            }
            set
            {
                if (!(this._name.Value != value))
                    return;
                this._name.Value = value;
            }
        }

        public string Description
        {
            get
            {
                return this._description.Value;
            }
            set
            {
                if (!(this._description.Value != value))
                    return;
                this._description.Value = value;
            }
        }

        public string Prompt
        {
            get
            {
                return this._prompt.Value;
            }
            set
            {
                if (!(this._prompt.Value != value))
                    return;
                this._prompt.Value = value;
            }
        }

        public string GroupName
        {
            get
            {
                return this._groupName.Value;
            }
            set
            {
                if (!(this._groupName.Value != value))
                    return;
                this._groupName.Value = value;
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
                this._resourceType = value;
                this._shortName.ResourceType = value;
                this._name.ResourceType = value;
                this._description.ResourceType = value;
                this._prompt.ResourceType = value;
                this._groupName.ResourceType = value;
            }
        }

        public bool AutoGenerateField
        {
            get
            {
                if (this._autoGenerateField.HasValue)
                    return this._autoGenerateField.Value;

                throw new InvalidOperationException("Property was not set");
            }
            set
            {
                this._autoGenerateField = new bool?(value);
            }
        }

        public bool AutoGenerateFilter
        {
            get
            {
                if (this._autoGenerateFilter.HasValue)
                    return this._autoGenerateFilter.Value;
                throw new InvalidOperationException("Property was not set");
            }
            set
            {
                this._autoGenerateFilter = new bool?(value);
            }
        }


        public int Order
        {
            get
            {
                if (this._order.HasValue)
                    return this._order.Value;

                throw new InvalidOperationException("Order property was not set");
            }
            set
            {
                this._order = new int?(value);
            }
        }

        public DisplayAttribute()
        {
        }

        public string GetShortName()
        {
            return this._shortName.GetLocalizableValue() ?? this.GetName();
        }

        
        public string GetName()
        {
            return this._name.GetLocalizableValue();
        }

        public string GetDescription()
        {
            return this._description.GetLocalizableValue();
        }

        public string GetPrompt()
        {
            return this._prompt.GetLocalizableValue();
        }

        public string GetGroupName()
        {
            return this._groupName.GetLocalizableValue();
        }

        public bool? GetAutoGenerateField()
        {
            return this._autoGenerateField;
        }

        public bool? GetAutoGenerateFilter()
        {
            return this._autoGenerateFilter;
        }

        public int? GetOrder()
        {
            return this._order;
        }
    }
}
