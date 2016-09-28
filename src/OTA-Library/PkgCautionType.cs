using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PkgCautionType : FormattedTextTextType
    {
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private string _type;
        
        private string _id;
        
        private List<string> _listOfItineraryItemRPH;
        
        private List<string> _listOfExtraRPH;
        
        public PkgCautionType()
        {
            this._listOfExtraRPH = new List<string>();
            this._listOfItineraryItemRPH = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> ListOfItineraryItemRPH
        {
            get
            {
                return this._listOfItineraryItemRPH;
            }
            set
            {
                this._listOfItineraryItemRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> ListOfExtraRPH
        {
            get
            {
                return this._listOfExtraRPH;
            }
            set
            {
                this._listOfExtraRPH = value;
            }
        }
    }
}