using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleAvailVendorInfoType
    {
        
        private List<VendorMessageType> _vendorMessages;
        
        private List<OffLocationServicePricedType> _offLocServices;
        
        private List<MonetaryRuleType> _paymentRules;
        
        private List<VehicleLocationDetailsType> _locationDetails;
        
        private VehicleAvailVendorInfoTypeTourInfo _tourInfo;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        public VehicleAvailVendorInfoType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._tourInfo = new VehicleAvailVendorInfoTypeTourInfo();
            this._locationDetails = new List<VehicleLocationDetailsType>();
            this._paymentRules = new List<MonetaryRuleType>();
            this._offLocServices = new List<OffLocationServicePricedType>();
            this._vendorMessages = new List<VendorMessageType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("VendorMessage", IsNullable=false)]
        public List<VendorMessageType> VendorMessages
        {
            get
            {
                return this._vendorMessages;
            }
            set
            {
                this._vendorMessages = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("OffLocServices")]
        public List<OffLocationServicePricedType> OffLocServices
        {
            get
            {
                return this._offLocServices;
            }
            set
            {
                this._offLocServices = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("PaymentRule", IsNullable=false)]
        public List<MonetaryRuleType> PaymentRules
        {
            get
            {
                return this._paymentRules;
            }
            set
            {
                this._paymentRules = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("LocationDetails")]
        public List<VehicleLocationDetailsType> LocationDetails
        {
            get
            {
                return this._locationDetails;
            }
            set
            {
                this._locationDetails = value;
            }
        }
        
        public VehicleAvailVendorInfoTypeTourInfo TourInfo
        {
            get
            {
                return this._tourInfo;
            }
            set
            {
                this._tourInfo = value;
            }
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
    }
}