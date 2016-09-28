using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class StatusApplicationControlType
    {
        
        private List<DestinationSystemCodesTypeDestinationSystemCode> _destinationSystemCodes;
        
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
        
        private bool _mon;
        
        private bool _tue;
        
        private bool _weds;
        
        private bool _thur;
        
        private bool _fri;
        
        private bool _sat;
        
        private bool _sun;
        
        private StatusApplicationControlTypeRatePlanCodeType _ratePlanCodeType;
        
        private string _rateTier;
        
        private bool _allRateCode;
        
        private bool _allInvCode;
        
        private StatusApplicationControlTypeInvBlockCodeApply _invBlockCodeApply;
        
        private string _invBlockCode;
        
        private bool _override;
        
        private string _quoteID;
        
        private string _subBlockCode;
        
        private string _wingIdentifier;
        
        public StatusApplicationControlType()
        {
            this._promotionVendorCode = new List<string>();
            this._destinationSystemCodes = new List<DestinationSystemCodesTypeDestinationSystemCode>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("DestinationSystemCode", IsNullable=false)]
        public List<DestinationSystemCodesTypeDestinationSystemCode> DestinationSystemCodes
        {
            get
            {
                return this._destinationSystemCodes;
            }
            set
            {
                this._destinationSystemCodes = value;
            }
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Mon
        {
            get
            {
                return this._mon;
            }
            set
            {
                this._mon = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Tue
        {
            get
            {
                return this._tue;
            }
            set
            {
                this._tue = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Weds
        {
            get
            {
                return this._weds;
            }
            set
            {
                this._weds = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Thur
        {
            get
            {
                return this._thur;
            }
            set
            {
                this._thur = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Fri
        {
            get
            {
                return this._fri;
            }
            set
            {
                this._fri = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Sat
        {
            get
            {
                return this._sat;
            }
            set
            {
                this._sat = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Sun
        {
            get
            {
                return this._sun;
            }
            set
            {
                this._sun = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public StatusApplicationControlTypeRatePlanCodeType RatePlanCodeType
        {
            get
            {
                return this._ratePlanCodeType;
            }
            set
            {
                this._ratePlanCodeType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RateTier
        {
            get
            {
                return this._rateTier;
            }
            set
            {
                this._rateTier = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AllRateCode
        {
            get
            {
                return this._allRateCode;
            }
            set
            {
                this._allRateCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AllInvCode
        {
            get
            {
                return this._allInvCode;
            }
            set
            {
                this._allInvCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public StatusApplicationControlTypeInvBlockCodeApply InvBlockCodeApply
        {
            get
            {
                return this._invBlockCodeApply;
            }
            set
            {
                this._invBlockCodeApply = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvBlockCode
        {
            get
            {
                return this._invBlockCode;
            }
            set
            {
                this._invBlockCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Override
        {
            get
            {
                return this._override;
            }
            set
            {
                this._override = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string QuoteID
        {
            get
            {
                return this._quoteID;
            }
            set
            {
                this._quoteID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubBlockCode
        {
            get
            {
                return this._subBlockCode;
            }
            set
            {
                this._subBlockCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string WingIdentifier
        {
            get
            {
                return this._wingIdentifier;
            }
            set
            {
                this._wingIdentifier = value;
            }
        }
    }
}