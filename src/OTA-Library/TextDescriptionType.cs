using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TextDescriptionType
    {
        
        private List<object> _items;
        
        private string _category;
        
        private string _contentID;
        
        private string _title;
        
        private string _author;
        
        private string _copyrightNotice;
        
        private string _copyrightOwner;
        
        private string _copyrightStart;
        
        private string _copyrightEnd;
        
        private string _effectiveStart;
        
        private string _effectiveEnd;
        
        private string _applicableStart;
        
        private string _applicableEnd;
        
        private string _recordID;
        
        private string _sourceID;
        
        private string _language;
        
        public TextDescriptionType()
        {
            this._items = new List<object>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Description", typeof(TextDescriptionTypeDescription))]
        [System.Xml.Serialization.XmlElementAttribute("URL", typeof(string), DataType="anyURI")]
        public List<object> Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ContentID
        {
            get
            {
                return this._contentID;
            }
            set
            {
                this._contentID = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Author
        {
            get
            {
                return this._author;
            }
            set
            {
                this._author = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CopyrightNotice
        {
            get
            {
                return this._copyrightNotice;
            }
            set
            {
                this._copyrightNotice = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CopyrightOwner
        {
            get
            {
                return this._copyrightOwner;
            }
            set
            {
                this._copyrightOwner = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CopyrightStart
        {
            get
            {
                return this._copyrightStart;
            }
            set
            {
                this._copyrightStart = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CopyrightEnd
        {
            get
            {
                return this._copyrightEnd;
            }
            set
            {
                this._copyrightEnd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EffectiveStart
        {
            get
            {
                return this._effectiveStart;
            }
            set
            {
                this._effectiveStart = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EffectiveEnd
        {
            get
            {
                return this._effectiveEnd;
            }
            set
            {
                this._effectiveEnd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ApplicableStart
        {
            get
            {
                return this._applicableStart;
            }
            set
            {
                this._applicableStart = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ApplicableEnd
        {
            get
            {
                return this._applicableEnd;
            }
            set
            {
                this._applicableEnd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RecordID
        {
            get
            {
                return this._recordID;
            }
            set
            {
                this._recordID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SourceID
        {
            get
            {
                return this._sourceID;
            }
            set
            {
                this._sourceID = value;
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