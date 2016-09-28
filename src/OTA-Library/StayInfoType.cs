using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class StayInfoType
    {
        
        private List<LoyaltyPointsAccrualsTypeSelectedLoyalty> _loyaltyPointsAccruals;
        
        private List<RevenueCategoryType> _revenueCategories;
        
        private UniqueID_Type _reservationID;
        
        private HotelReservationType _hotelReservation;
        
        private string _sequenceNumber;
        
        private string _roomStayRPH;
        
        public StayInfoType()
        {
            this._hotelReservation = new HotelReservationType();
            this._reservationID = new UniqueID_Type();
            this._revenueCategories = new List<RevenueCategoryType>();
            this._loyaltyPointsAccruals = new List<LoyaltyPointsAccrualsTypeSelectedLoyalty>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("SelectedLoyalty", IsNullable=false)]
        public List<LoyaltyPointsAccrualsTypeSelectedLoyalty> LoyaltyPointsAccruals
        {
            get
            {
                return this._loyaltyPointsAccruals;
            }
            set
            {
                this._loyaltyPointsAccruals = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RevenueCategory", IsNullable=false)]
        public List<RevenueCategoryType> RevenueCategories
        {
            get
            {
                return this._revenueCategories;
            }
            set
            {
                this._revenueCategories = value;
            }
        }
        
        public UniqueID_Type ReservationID
        {
            get
            {
                return this._reservationID;
            }
            set
            {
                this._reservationID = value;
            }
        }
        
        public HotelReservationType HotelReservation
        {
            get
            {
                return this._hotelReservation;
            }
            set
            {
                this._hotelReservation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string SequenceNumber
        {
            get
            {
                return this._sequenceNumber;
            }
            set
            {
                this._sequenceNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string RoomStayRPH
        {
            get
            {
                return this._roomStayRPH;
            }
            set
            {
                this._roomStayRPH = value;
            }
        }
    }
}