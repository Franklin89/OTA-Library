namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class DonationTypeDonorInfo
    {
        
        private DonationTypeDonorInfoName _name;
        
        private DonationTypeDonorInfoContactInfo _contactInfo;
        
        public DonationTypeDonorInfo()
        {
            this._contactInfo = new DonationTypeDonorInfoContactInfo();
            this._name = new DonationTypeDonorInfoName();
        }
        
        public DonationTypeDonorInfoName Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        public DonationTypeDonorInfoContactInfo ContactInfo
        {
            get
            {
                return this._contactInfo;
            }
            set
            {
                this._contactInfo = value;
            }
        }
    }
}