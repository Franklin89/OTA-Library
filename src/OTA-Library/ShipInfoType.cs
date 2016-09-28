namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ShipInfoType
    {
        
        private ShipInfoTypeShip _ship;
        
        private ShipInfoTypeShipLength _shipLength;
        
        private ShipInfoTypeShipVoltage _shipVoltage;
        
        private string _vendorCode;
        
        private string _vendorName;
        
        private string _shipCode;
        
        private string _shipName;
        
        private string _vendorCodeContext;
        
        public ShipInfoType()
        {
            this._shipVoltage = new ShipInfoTypeShipVoltage();
            this._shipLength = new ShipInfoTypeShipLength();
            this._ship = new ShipInfoTypeShip();
        }
        
        public ShipInfoTypeShip Ship
        {
            get
            {
                return this._ship;
            }
            set
            {
                this._ship = value;
            }
        }
        
        public ShipInfoTypeShipLength ShipLength
        {
            get
            {
                return this._shipLength;
            }
            set
            {
                this._shipLength = value;
            }
        }
        
        public ShipInfoTypeShipVoltage ShipVoltage
        {
            get
            {
                return this._shipVoltage;
            }
            set
            {
                this._shipVoltage = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VendorCode
        {
            get
            {
                return this._vendorCode;
            }
            set
            {
                this._vendorCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VendorName
        {
            get
            {
                return this._vendorName;
            }
            set
            {
                this._vendorName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ShipCode
        {
            get
            {
                return this._shipCode;
            }
            set
            {
                this._shipCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ShipName
        {
            get
            {
                return this._shipName;
            }
            set
            {
                this._shipName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VendorCodeContext
        {
            get
            {
                return this._vendorCodeContext;
            }
            set
            {
                this._vendorCodeContext = value;
            }
        }
    }
}