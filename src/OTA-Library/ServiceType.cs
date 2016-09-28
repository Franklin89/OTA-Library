using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ServiceType
    {
        
        private List<AmountType> _price;
        
        private ServiceTypeServiceDetails _serviceDetails;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private PricingType _servicePricingType;
        
        private PMS_ResStatusType _reservationStatusType;
        
        private string _serviceRPH;
        
        private string _serviceInventoryCode;
        
        private string _ratePlanCode;
        
        private string _inventoryBlockCode;
        
        private bool _priceGuaranteed;
        
        private bool _inclusive;
        
        private string _quantity;
        
        private bool _requestedIndicator;
        
        private string _uRL;
        
        private string _type;
        
        private string _instance;
        
        private string _id;
        
        private string _iD_Context;
        
        private bool _requiredInd;
        
        private string _serviceCategoryCode;
        
        public ServiceType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._serviceDetails = new ServiceTypeServiceDetails();
            this._price = new List<AmountType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Price")]
        public List<AmountType> Price
        {
            get
            {
                return this._price;
            }
            set
            {
                this._price = value;
            }
        }
        
        public ServiceTypeServiceDetails ServiceDetails
        {
            get
            {
                return this._serviceDetails;
            }
            set
            {
                this._serviceDetails = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PricingType ServicePricingType
        {
            get
            {
                return this._servicePricingType;
            }
            set
            {
                this._servicePricingType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PMS_ResStatusType ReservationStatusType
        {
            get
            {
                return this._reservationStatusType;
            }
            set
            {
                this._reservationStatusType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ServiceRPH
        {
            get
            {
                return this._serviceRPH;
            }
            set
            {
                this._serviceRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ServiceInventoryCode
        {
            get
            {
                return this._serviceInventoryCode;
            }
            set
            {
                this._serviceInventoryCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanCode
        {
            get
            {
                return this._ratePlanCode;
            }
            set
            {
                this._ratePlanCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InventoryBlockCode
        {
            get
            {
                return this._inventoryBlockCode;
            }
            set
            {
                this._inventoryBlockCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PriceGuaranteed
        {
            get
            {
                return this._priceGuaranteed;
            }
            set
            {
                this._priceGuaranteed = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Inclusive
        {
            get
            {
                return this._inclusive;
            }
            set
            {
                this._inclusive = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RequestedIndicator
        {
            get
            {
                return this._requestedIndicator;
            }
            set
            {
                this._requestedIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string URL
        {
            get
            {
                return this._uRL;
            }
            set
            {
                this._uRL = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Instance
        {
            get
            {
                return this._instance;
            }
            set
            {
                this._instance = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID_Context
        {
            get
            {
                return this._iD_Context;
            }
            set
            {
                this._iD_Context = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RequiredInd
        {
            get
            {
                return this._requiredInd;
            }
            set
            {
                this._requiredInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ServiceCategoryCode
        {
            get
            {
                return this._serviceCategoryCode;
            }
            set
            {
                this._serviceCategoryCode = value;
            }
        }
    }
}