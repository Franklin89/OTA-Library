namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleTourInfoType
    {
        
        private CompanyNameType _tourOperator;
        
        private string _tourNumber;
        
        public VehicleTourInfoType()
        {
            this._tourOperator = new CompanyNameType();
        }
        
        public CompanyNameType TourOperator
        {
            get
            {
                return this._tourOperator;
            }
            set
            {
                this._tourOperator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TourNumber
        {
            get
            {
                return this._tourNumber;
            }
            set
            {
                this._tourNumber = value;
            }
        }
    }
}