using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atrributes.Attributes
{
    public class ColumnName :Attribute
    {
        private string _displayName;
        public ColumnName()
        {

        }
        public ColumnName(string displayName)
        {
            this._displayName = displayName;
        }
        public string DisplayName => this._displayName;

    }
}
