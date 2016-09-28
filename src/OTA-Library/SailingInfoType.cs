namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SailingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SailingCategoryInfoType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SailingInfoType
    {
        
        private SailingInfoTypeSelectedSailing _selectedSailing;
        
        private SailingInfoTypeInclusivePackageOption _inclusivePackageOption;
        
        private SailingInfoTypeCurrency _currency;
        
        public SailingInfoType()
        {
            this._currency = new SailingInfoTypeCurrency();
            this._inclusivePackageOption = new SailingInfoTypeInclusivePackageOption();
            this._selectedSailing = new SailingInfoTypeSelectedSailing();
        }
        
        public SailingInfoTypeSelectedSailing SelectedSailing
        {
            get
            {
                return this._selectedSailing;
            }
            set
            {
                this._selectedSailing = value;
            }
        }
        
        public SailingInfoTypeInclusivePackageOption InclusivePackageOption
        {
            get
            {
                return this._inclusivePackageOption;
            }
            set
            {
                this._inclusivePackageOption = value;
            }
        }
        
        public SailingInfoTypeCurrency Currency
        {
            get
            {
                return this._currency;
            }
            set
            {
                this._currency = value;
            }
        }
    }
}