using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_HotelDescriptiveInfoRQHotelDescriptiveInfosHotelDescriptiveInfo : HotelDescriptiveInfoRequestType
    {
        
        private List<string> _stateCodeList;
        
        private List<string> _countryCodeList;
        
        private List<string> _brandCodeList;
        
        private string _moreDataEchoToken;
        
        private System.DateTime _applicableDate;
        
        public OTA_HotelDescriptiveInfoRQHotelDescriptiveInfosHotelDescriptiveInfo()
        {
            this._brandCodeList = new List<string>();
            this._countryCodeList = new List<string>();
            this._stateCodeList = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> StateCodeList
        {
            get
            {
                return this._stateCodeList;
            }
            set
            {
                this._stateCodeList = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> CountryCodeList
        {
            get
            {
                return this._countryCodeList;
            }
            set
            {
                this._countryCodeList = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> BrandCodeList
        {
            get
            {
                return this._brandCodeList;
            }
            set
            {
                this._brandCodeList = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MoreDataEchoToken
        {
            get
            {
                return this._moreDataEchoToken;
            }
            set
            {
                this._moreDataEchoToken = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime ApplicableDate
        {
            get
            {
                return this._applicableDate;
            }
            set
            {
                this._applicableDate = value;
            }
        }
    }
}