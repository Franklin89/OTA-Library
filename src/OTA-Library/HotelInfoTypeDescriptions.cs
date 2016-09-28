using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelInfoTypeDescriptions
    {
        
        private List<HotelInfoTypeDescriptionsRenovation> _renovation;
        
        private HotelInfoTypeDescriptionsMultimediaDescriptions _multimediaDescriptions;
        
        private string _descriptiveText;
        
        public HotelInfoTypeDescriptions()
        {
            this._multimediaDescriptions = new HotelInfoTypeDescriptionsMultimediaDescriptions();
            this._renovation = new List<HotelInfoTypeDescriptionsRenovation>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Renovation")]
        public List<HotelInfoTypeDescriptionsRenovation> Renovation
        {
            get
            {
                return this._renovation;
            }
            set
            {
                this._renovation = value;
            }
        }
        
        public HotelInfoTypeDescriptionsMultimediaDescriptions MultimediaDescriptions
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
    }
}