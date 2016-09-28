using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelativePositionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TransportationsType
    {
        
        private List<TransportationTypeTransportation> _transportations;
        
        public TransportationsType()
        {
            this._transportations = new List<TransportationTypeTransportation>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Transportation", IsNullable=false)]
        public List<TransportationTypeTransportation> Transportations
        {
            get
            {
                return this._transportations;
            }
            set
            {
                this._transportations = value;
            }
        }
    }
}