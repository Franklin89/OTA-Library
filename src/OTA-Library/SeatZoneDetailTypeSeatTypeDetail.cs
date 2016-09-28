using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SeatZoneDetailTypeSeatTypeDetail
    {
        
        private List<SeatFeaturesType> _features;
        
        private SeatZoneDetailTypeSeatTypeDetailType _type;
        
        private string _totalQty;
        
        private string _availableQty;
        
        public SeatZoneDetailTypeSeatTypeDetail()
        {
            this._features = new List<SeatFeaturesType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Features")]
        public List<SeatFeaturesType> Features
        {
            get
            {
                return this._features;
            }
            set
            {
                this._features = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SeatZoneDetailTypeSeatTypeDetailType Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string TotalQty
        {
            get
            {
                return this._totalQty;
            }
            set
            {
                this._totalQty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string AvailableQty
        {
            get
            {
                return this._availableQty;
            }
            set
            {
                this._availableQty = value;
            }
        }
    }
}