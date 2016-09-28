using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CabinAvailType
    {
        
        private List<SeatAvailabilityType> _seat;
        
        private CabinAvailTypeBaggageAllowance _baggageAllowance;
        
        private string _code;
        
        private string _name;
        
        private string _meal;
        
        public CabinAvailType()
        {
            this._baggageAllowance = new CabinAvailTypeBaggageAllowance();
            this._seat = new List<SeatAvailabilityType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Seat")]
        public List<SeatAvailabilityType> Seat
        {
            get
            {
                return this._seat;
            }
            set
            {
                this._seat = value;
            }
        }
        
        public CabinAvailTypeBaggageAllowance BaggageAllowance
        {
            get
            {
                return this._baggageAllowance;
            }
            set
            {
                this._baggageAllowance = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Meal
        {
            get
            {
                return this._meal;
            }
            set
            {
                this._meal = value;
            }
        }
    }
}