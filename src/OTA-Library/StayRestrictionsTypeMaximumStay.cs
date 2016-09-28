namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class StayRestrictionsTypeMaximumStay
    {
        
        private StayRestrictionsTypeMaximumStayReturnType _returnType;
        
        private string _returnTimeOfDay;
        
        private string _maxStay;
        
        private StayUnitType _stayUnit;
        
        private string _maxStayDate;
        
        private bool _complicatedRulesInd;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public StayRestrictionsTypeMaximumStayReturnType ReturnType
        {
            get
            {
                return this._returnType;
            }
            set
            {
                this._returnType = value;
            }
        }
        
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
        public string MaxStay
        {
            get
            {
                return this._maxStay;
            }
            set
            {
                this._maxStay = value;
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
        public string MaxStayDate
        {
            get
            {
                return this._maxStayDate;
            }
            set
            {
                this._maxStayDate = value;
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