namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class StayRestrictionsTypeMinimumStay
    {
        
        private string _returnTimeOfDay;
        
        private string _minStay;
        
        private StayUnitType _stayUnit;
        
        private string _minStayDate;
        
        private bool _complicatedRulesInd;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReturnTimeOfDay
        {
            get
            {
                return this._returnTimeOfDay;
            }
            set
            {
                this._returnTimeOfDay = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MinStay
        {
            get
            {
                return this._minStay;
            }
            set
            {
                this._minStay = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public StayUnitType StayUnit
        {
            get
            {
                return this._stayUnit;
            }
            set
            {
                this._stayUnit = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MinStayDate
        {
            get
            {
                return this._minStayDate;
            }
            set
            {
                this._minStayDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ComplicatedRulesInd
        {
            get
            {
                return this._complicatedRulesInd;
            }
            set
            {
                this._complicatedRulesInd = value;
            }
        }
    }
}