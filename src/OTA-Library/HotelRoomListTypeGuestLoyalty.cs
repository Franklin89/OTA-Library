namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelRoomListTypeGuestLoyalty
    {
        
        private string _reservationActionType;
        
        private string _selectedLoyaltyRPH;
        
        private string _programCode;
        
        private string _bonusCode;
        
        private string _accountID;
        
        private string _pointsEarned;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReservationActionType
        {
            get
            {
                return this._reservationActionType;
            }
            set
            {
                this._reservationActionType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SelectedLoyaltyRPH
        {
            get
            {
                return this._selectedLoyaltyRPH;
            }
            set
            {
                this._selectedLoyaltyRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProgramCode
        {
            get
            {
                return this._programCode;
            }
            set
            {
                this._programCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BonusCode
        {
            get
            {
                return this._bonusCode;
            }
            set
            {
                this._bonusCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AccountID
        {
            get
            {
                return this._accountID;
            }
            set
            {
                this._accountID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PointsEarned
        {
            get
            {
                return this._pointsEarned;
            }
            set
            {
                this._pointsEarned = value;
            }
        }
    }
}