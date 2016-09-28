using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AdjustmentsType
    {
        
        private List<AdjustmentsTypeAdjustment> _adjustment;
        
        private string _requestID;
        
        public AdjustmentsType()
        {
            this._adjustment = new List<AdjustmentsTypeAdjustment>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Adjustment")]
        public List<AdjustmentsTypeAdjustment> Adjustment
        {
            get
            {
                return this._adjustment;
            }
            set
            {
                this._adjustment = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RequestID
        {
            get
            {
                return this._requestID;
            }
            set
            {
                this._requestID = value;
            }
        }
    }
}