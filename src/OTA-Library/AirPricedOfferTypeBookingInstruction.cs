using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirPricedOfferTypeBookingInstruction
    {
        
        private List<SpecialServiceRequestType> _sSR_Info;
        
        private List<OtherServiceInfoType> _oSI_Info;
        
        private AirPricedOfferTypeBookingInstructionUpgrade _upgrade;
        
        private AirPricedOfferTypeBookingInstructionBookingMethod _bookingMethod;
        
        private AirPricedOfferTypeBookingInstructionEMD_Type _eMD_Type;
        
        public AirPricedOfferTypeBookingInstruction()
        {
            this._upgrade = new AirPricedOfferTypeBookingInstructionUpgrade();
            this._oSI_Info = new List<OtherServiceInfoType>();
            this._sSR_Info = new List<SpecialServiceRequestType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SSR_Info")]
        public List<SpecialServiceRequestType> SSR_Info
        {
            get
            {
                return this._sSR_Info;
            }
            set
            {
                this._sSR_Info = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("OSI_Info")]
        public List<OtherServiceInfoType> OSI_Info
        {
            get
            {
                return this._oSI_Info;
            }
            set
            {
                this._oSI_Info = value;
            }
        }
        
        public AirPricedOfferTypeBookingInstructionUpgrade Upgrade
        {
            get
            {
                return this._upgrade;
            }
            set
            {
                this._upgrade = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AirPricedOfferTypeBookingInstructionBookingMethod BookingMethod
        {
            get
            {
                return this._bookingMethod;
            }
            set
            {
                this._bookingMethod = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AirPricedOfferTypeBookingInstructionEMD_Type EMD_Type
        {
            get
            {
                return this._eMD_Type;
            }
            set
            {
                this._eMD_Type = value;
            }
        }
    }
}