using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TextItemsType
    {
        
        private List<TextItemsTypeTextItem> _textItem;
        
        public TextItemsType()
        {
            this._textItem = new List<TextItemsTypeTextItem>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TextItem")]
        public List<TextItemsTypeTextItem> TextItem
        {
            get
            {
                return this._textItem;
            }
            set
            {
                this._textItem = value;
            }
        }
    }
}