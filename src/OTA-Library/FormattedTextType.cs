using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleLocationInformationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VendorMessageType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FormattedTextType
    {
        
        private List<FormattedTextSubSectionType> _subSection;
        
        private string _title;
        
        private string _language;
        
        public FormattedTextType()
        {
            this._subSection = new List<FormattedTextSubSectionType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SubSection")]
        public List<FormattedTextSubSectionType> SubSection
        {
            get
            {
                return this._subSection;
            }
            set
            {
                this._subSection = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string Language
        {
            get
            {
                return this._language;
            }
            set
            {
                this._language = value;
            }
        }
    }
}