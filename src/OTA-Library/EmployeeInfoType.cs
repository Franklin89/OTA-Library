namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EmployeeInfoType
    {
        
        private string _employeeId;
        
        private string _employeeLevel;
        
        private string _employeeTitle;
        
        private string _employeeStatus;
        
        private string _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EmployeeId
        {
            get
            {
                return this._employeeId;
            }
            set
            {
                this._employeeId = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EmployeeLevel
        {
            get
            {
                return this._employeeLevel;
            }
            set
            {
                this._employeeLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EmployeeTitle
        {
            get
            {
                return this._employeeTitle;
            }
            set
            {
                this._employeeTitle = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EmployeeStatus
        {
            get
            {
                return this._employeeStatus;
            }
            set
            {
                this._employeeStatus = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}