namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirlinePrefTypeTourCodePrefStaffTourCodeInfo
    {
        
        private AirlinePrefTypeTourCodePrefStaffTourCodeInfoStaffType _staffType;
        
        private string _employeeID;
        
        private string _vendorCode;
        
        private string _description;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AirlinePrefTypeTourCodePrefStaffTourCodeInfoStaffType StaffType
        {
            get
            {
                return this._staffType;
            }
            set
            {
                this._staffType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EmployeeID
        {
            get
            {
                return this._employeeID;
            }
            set
            {
                this._employeeID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VendorCode
        {
            get
            {
                return this._vendorCode;
            }
            set
            {
                this._vendorCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
    }
}