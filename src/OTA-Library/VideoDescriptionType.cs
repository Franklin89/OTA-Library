using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VideoDescriptionType
    {
        
        private List<VideoDescriptionTypeVideoFormat> _videoFormat;
        
        private List<VideoDescriptionTypeDescription> _description;
        
        private string _category;
        
        public VideoDescriptionType()
        {
            this._description = new List<VideoDescriptionTypeDescription>();
            this._videoFormat = new List<VideoDescriptionTypeVideoFormat>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("VideoFormat")]
        public List<VideoDescriptionTypeVideoFormat> VideoFormat
        {
            get
            {
                return this._videoFormat;
            }
            set
            {
                this._videoFormat = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<VideoDescriptionTypeDescription> Description
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Category
        {
            get
            {
                return this._category;
            }
            set
            {
                this._category = value;
            }
        }
    }
}