using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CategoryCodesTypeGuestRoomInfo
    {
        
        private List<CategoryCodesTypeGuestRoomInfoRateRange> _rateRanges;
        
        private MultimediaDescriptionsType _multimediaDescriptions;
        
        private string _descriptiveText;
        
        private string _code;
        
        private bool _removal;
        
        private string _codeDetail;
        
        private string _quantity;
        
        private string _existsCode;
        
        public CategoryCodesTypeGuestRoomInfo()
        {
            this._multimediaDescriptions = new MultimediaDescriptionsType();
            this._rateRanges = new List<CategoryCodesTypeGuestRoomInfoRateRange>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RateRange", IsNullable=false)]
        public List<CategoryCodesTypeGuestRoomInfoRateRange> RateRanges
        {
            get
            {
                return this._rateRanges;
            }
            set
            {
                this._rateRanges = value;
            }
        }
        
        public MultimediaDescriptionsType MultimediaDescriptions
        {
            get
            {
                return this._multimediaDescriptions;
            }
            set
            {
                this._multimediaDescriptions = value;
            }
        }
        
        public string DescriptiveText
        {
            get
            {
                return this._descriptiveText;
            }
            set
            {
                this._descriptiveText = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Removal
        {
            get
            {
                return this._removal;
            }
            set
            {
                this._removal = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeDetail
        {
            get
            {
                return this._codeDetail;
            }
            set
            {
                this._codeDetail = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExistsCode
        {
            get
            {
                return this._existsCode;
            }
            set
            {
                this._existsCode = value;
            }
        }
    }
}