namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CabinClassAvailabilityType
    {
        
        private string _seatNumber;
        
        private bool _advancePurchaseInd;
        
        private bool _availableInd;
        
        private bool _inoperativeInd;
        
        private bool _occupiedInd;
        
        private bool _premiumInd;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatNumber
        {
            get
            {
                return this._seatNumber;
            }
            set
            {
                this._seatNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AdvancePurchaseInd
        {
            get
            {
                return this._advancePurchaseInd;
            }
            set
            {
                this._advancePurchaseInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AvailableInd
        {
            get
            {
                return this._availableInd;
            }
            set
            {
                this._availableInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool InoperativeInd
        {
            get
            {
                return this._inoperativeInd;
            }
            set
            {
                this._inoperativeInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OccupiedInd
        {
            get
            {
                return this._occupiedInd;
            }
            set
            {
                this._occupiedInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PremiumInd
        {
            get
            {
                return this._premiumInd;
            }
            set
            {
                this._premiumInd = value;
            }
        }
    }
}