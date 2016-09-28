using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ErrorsType
    {
        
        private List<ErrorType> _error;
        
        public ErrorsType()
        {
            this._error = new List<ErrorType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Error")]
        public List<ErrorType> Error
        {
            get
            {
                return this._error;
            }
            set
            {
                this._error = value;
            }
        }
    }
}