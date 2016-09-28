using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PTCFareBreakdownTypePricingUnit
    {
        
        private List<PTCFareBreakdownTypePricingUnitFareComponent> _fareComponent;
        
        private string _unitNumber;
        
        public PTCFareBreakdownTypePricingUnit()
        {
            this._fareComponent = new List<PTCFareBreakdownTypePricingUnitFareComponent>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FareComponent")]
        public List<PTCFareBreakdownTypePricingUnitFareComponent> FareComponent
        {
            get
            {
                return this._fareComponent;
            }
            set
            {
                this._fareComponent = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string UnitNumber
        {
            get
            {
                return this._unitNumber;
            }
            set
            {
                this._unitNumber = value;
            }
        }
    }
}