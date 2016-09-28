using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class WarningsType
    {
        
        private List<WarningType> _warning;
        
        public WarningsType()
        {
            this._warning = new List<WarningType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Warning")]
        public List<WarningType> Warning
        {
            get
            {
                return this._warning;
            }
            set
            {
                this._warning = value;
            }
        }
    }
}