using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    [System.Xml.Serialization.XmlRootAttribute("TPA_Extensions", Namespace="http://www.opentravel.org/OTA/2003/05", IsNullable=false)]
    public partial class TPA_ExtensionsType
    {
        
        private List<System.Xml.XmlElement> _any;
        
        public TPA_ExtensionsType()
        {
            this._any = new List<System.Xml.XmlElement>();
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public List<System.Xml.XmlElement> Any
        {
            get
            {
                return this._any;
            }
            set
            {
                this._any = value;
            }
        }
    }
}