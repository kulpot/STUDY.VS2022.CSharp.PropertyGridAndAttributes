using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGridAndAttributes
{
    class MyClass
    {
        // Set the same values here or in the constructor as the default values
        private bool _isLookingNice = true;
        private string _errorMessage = "Because I said so";

        [DefaultValue(true)]
        [Category("Apperance")]
        public bool IsLookingNice
        {
            get { return _isLookingNice; }
            set { _isLookingNice = value; }
        }

        [Browsable(false)]
        [DisplayName("Error Message 545")]
        [Description("Gets the message to display when error 545 occurs")]
        [DefaultValue("Because I said so")]
        [Category("Prompting")]
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }
    }
}
