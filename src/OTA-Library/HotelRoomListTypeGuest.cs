using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelRoomListTypeGuest : ContactPersonType
    {
        
        private UniqueID_Type _uniqueID;
        
        private List<HotelRoomListTypeGuestLoyalty> _loyalty;
        
        private List<HotelRoomListTypeGuestGuaranteePayment> _guaranteePayment;
        
        private List<AdditionalDetailType> _additionalDetails;
        
        private ActionType _guestAction;
        
        private bool _printConfoInd;
        
        public HotelRoomListTypeGuest()
        {
            this._additionalDetails = new List<AdditionalDetailType>();
            this._guaranteePayment = new List<HotelRoomListTypeGuestGuaranteePayment>();
            this._loyalty = new List<HotelRoomListTypeGuestLoyalty>();
            this._uniqueID = new UniqueID_Type();
        }
        
        public UniqueID_Type UniqueID
        {
            get
            {
                return this._uniqueID;
            }
            set
            {
                this._uniqueID = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Loyalty")]
        public List<HotelRoomListTypeGuestLoyalty> Loyalty
        {
            get
            {
                return this._loyalty;
            }
            set
            {
                this._loyalty = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("GuaranteePayment")]
        public List<HotelRoomListTypeGuestGuaranteePayment> GuaranteePayment
        {
            get
            {
                return this._guaranteePayment;
            }
            set
            {
                this._guaranteePayment = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("AdditionalDetail", IsNullable=false)]
        public List<AdditionalDetailType> AdditionalDetails
        {
            get
            {
                return this._additionalDetails;
            }
            set
            {
                this._additionalDetails = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ActionType GuestAction
        {
            get
            {
                return this._guestAction;
            }
            set
            {
                this._guestAction = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PrintConfoInd
        {
            get
            {
                return this._printConfoInd;
            }
            set
            {
                this._printConfoInd = value;
            }
        }
    }
}