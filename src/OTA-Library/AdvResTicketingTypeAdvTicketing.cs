namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AdvResTicketingTypeAdvTicketing
    {
        
        private string _fromResTimeOfDay;
        
        private string _fromResPeriod;
        
        private StayUnitType _fromResUnit;
        
        private string _fromDepartTimeOfDay;
        
        private string _fromDepartPeriod;
        
        private StayUnitType _fromDepartUnit;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FromResTimeOfDay
        {
            get
            {
                return this._fromResTimeOfDay;
            }
            set
            {
                this._fromResTimeOfDay = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FromResPeriod
        {
            get
            {
                return this._fromResPeriod;
            }
            set
            {
                this._fromResPeriod = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public StayUnitType FromResUnit
        {
            get
            {
                return this._fromResUnit;
            }
            set
            {
                this._fromResUnit = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FromDepartTimeOfDay
        {
            get
            {
                return this._fromDepartTimeOfDay;
            }
            set
            {
                this._fromDepartTimeOfDay = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FromDepartPeriod
        {
            get
            {
                return this._fromDepartPeriod;
            }
            set
            {
                this._fromDepartPeriod = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public StayUnitType FromDepartUnit
        {
            get
            {
                return this._fromDepartUnit;
            }
            set
            {
                this._fromDepartUnit = value;
            }
        }
    }
}