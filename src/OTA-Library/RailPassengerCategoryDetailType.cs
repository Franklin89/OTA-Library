using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailPassengerCategoryDetailType : RailPassengerCategoryType
    {
        
        private List<RailPassengerDetailType> _passengerDetail;
        
        private string _rPH;
        
        private string _quantity;
        
        public RailPassengerCategoryDetailType()
        {
            this._passengerDetail = new List<RailPassengerDetailType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PassengerDetail")]
        public List<RailPassengerDetailType> PassengerDetail
        {
            get
            {
                return this._passengerDetail;
            }
            set
            {
                this._passengerDetail = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }
    }
}