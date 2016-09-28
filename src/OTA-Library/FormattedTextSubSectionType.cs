using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FormattedTextSubSectionType
    {
        
        private List<ParagraphType> _paragraph;
        
        private string _subTitle;
        
        private string _subCode;
        
        private string _subSectionNumber;
        
        public FormattedTextSubSectionType()
        {
            this._paragraph = new List<ParagraphType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Paragraph")]
        public List<ParagraphType> Paragraph
        {
            get
            {
                return this._paragraph;
            }
            set
            {
                this._paragraph = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubTitle
        {
            get
            {
                return this._subTitle;
            }
            set
            {
                this._subTitle = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubCode
        {
            get
            {
                return this._subCode;
            }
            set
            {
                this._subCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string SubSectionNumber
        {
            get
            {
                return this._subSectionNumber;
            }
            set
            {
                this._subSectionNumber = value;
            }
        }
    }
}