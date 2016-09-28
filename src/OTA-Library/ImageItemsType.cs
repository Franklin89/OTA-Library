using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ImageItemsType
    {
        
        private List<ImageItemsTypeImageItem> _imageItem;
        
        public ImageItemsType()
        {
            this._imageItem = new List<ImageItemsTypeImageItem>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ImageItem")]
        public List<ImageItemsTypeImageItem> ImageItem
        {
            get
            {
                return this._imageItem;
            }
            set
            {
                this._imageItem = value;
            }
        }
    }
}