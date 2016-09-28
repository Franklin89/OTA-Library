using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_HotelBookingRuleRQRuleMessageStatusApplication
    {
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private string _ratePlanType;
        
        private string _ratePlanCode;
        
        private string _ratePlanID;
        
        private bool _ratePlanQualifier;
        
        private string _promotionCode;
        
        private List<string> _promotionVendorCode;
        
        private string _ratePlanCategory;
        
        private StatusApplicationControlTypeInvCodeApplication _invCodeApplication;
        
        private string _invCode;
        
        private string _invType;
        
        private string _invTypeCode;
        
        private bool _isRoom;
        
        private string _numberOfUnits;
        
        public OTA_HotelBookingRuleRQRuleMessageStatusApplication()
        {
            this._promotionVendorCode = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanType
        {
            get
            {
                return this._ratePlanType;
            }
            set
            {
                this._ratePlanType = value;
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
        public string RatePlanID
        {
            get
            {
                return this._ratePlanID;
            }
            set
            {
                this._ratePlanID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RatePlanQualifier
        {
            get
            {
                return this._ratePlanQualifier;
            }
            set
            {
                this._ratePlanQualifier = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PromotionCode
        {
            get
            {
                return this._promotionCode;
            }
            set
            {
                this._promotionCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> PromotionVendorCode
        {
            get
            {
                return this._promotionVendorCode;
            }
            set
            {
                this._promotionVendorCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanCategory
        {
            get
            {
                return this._ratePlanCategory;
            }
            set
            {
                this._ratePlanCategory = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public StatusApplicationControlTypeInvCodeApplication InvCodeApplication
        {
            get
            {
                return this._invCodeApplication;
            }
            set
            {
                this._invCodeApplication = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvCode
        {
            get
            {
                return this._invCode;
            }
            set
            {
                this._invCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvType
        {
            get
            {
                return this._invType;
            }
            set
            {
                this._invType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvTypeCode
        {
            get
            {
                return this._invTypeCode;
            }
            set
            {
                this._invTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsRoom
        {
            get
            {
                return this._isRoom;
            }
            set
            {
                this._isRoom = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string NumberOfUnits
        {
            get
            {
                return this._numberOfUnits;
            }
            set
            {
                this._numberOfUnits = value;
            }
        }
    }
}