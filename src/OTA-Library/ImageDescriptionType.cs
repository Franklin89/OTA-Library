using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ImageDescriptionType
    {
        
        private List<ImageDescriptionTypeImageFormat> _imageFormat;
        
        private List<ImageDescriptionTypeDescription> _description;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _category;
        
        public ImageDescriptionType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._description = new List<ImageDescriptionTypeDescription>();
            this._imageFormat = new List<ImageDescriptionTypeImageFormat>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ImageFormat")]
        public List<ImageDescriptionTypeImageFormat> ImageFormat
        {
            get
            {
                return this._imageFormat;
            }
            set
            {
                this._imageFormat = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<ImageDescriptionTypeDescription> Description
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
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
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