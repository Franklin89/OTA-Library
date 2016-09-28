namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailPrefTypeAncillaryServicePref
    {
        
        private string _ancillaryServiceCode;
        
        private string _foodAllergies;
        
        private PreferLevelType _preferLevel;
        
        private string _remark;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AncillaryServiceCode
        {
            get
            {
                return this._ancillaryServiceCode;
            }
            set
            {
                this._ancillaryServiceCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FoodAllergies
        {
            get
            {
                return this._foodAllergies;
            }
            set
            {
                this._foodAllergies = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType PreferLevel
        {
            get
            {
                return this._preferLevel;
            }
            set
            {
                this._preferLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Remark
        {
            get
            {
                return this._remark;
            }
            set
            {
                this._remark = value;
            }
        }
    }
}