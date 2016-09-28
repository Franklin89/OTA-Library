using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FareComponentTypePriceableUnit
    {
        
        private List<FareComponentTypePriceableUnitFareComponentDetail> _fareComponentDetail;
        
        private string _number;
        
        public FareComponentTypePriceableUnit()
        {
            this._fareComponentDetail = new List<FareComponentTypePriceableUnitFareComponentDetail>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FareComponentDetail")]
        public List<FareComponentTypePriceableUnitFareComponentDetail> FareComponentDetail
        {
            get
            {
                return this._fareComponentDetail;
            }
            set
            {
                this._fareComponentDetail = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Number
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
            }
        }
    }
}