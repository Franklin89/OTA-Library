using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class DateTimeSpanType
    {
        
        private List<object> _items;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        public DateTimeSpanType()
        {
            this._items = new List<object>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("DateWindowRange", typeof(TimeInstantType))]
        [System.Xml.Serialization.XmlElementAttribute("EndDateWindow", typeof(DateTimeSpanTypeEndDateWindow))]
        [System.Xml.Serialization.XmlElementAttribute("StartDateWindow", typeof(DateTimeSpanTypeStartDateWindow))]
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
    }
}