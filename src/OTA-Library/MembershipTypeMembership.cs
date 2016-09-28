namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MembershipTypeMembership
    {
        
        private string _programCode;
        
        private string _bonusCode;
        
        private string _accountID;
        
        private string _pointsEarned;
        
        private string _travelSector;
        
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelSector
        {
            get
            {
                return this._travelSector;
            }
            set
            {
                this._travelSector = value;
            }
        }
    }
}