using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleLocationAdditionalFeesTypeTaxes
    {
        
        private List<VehicleLocationAdditionalFeesTypeTaxesTax> _tax;
        
        private FormattedTextType _info;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        public VehicleLocationAdditionalFeesTypeTaxes()
        {
            this._info = new FormattedTextType();
            this._tax = new List<VehicleLocationAdditionalFeesTypeTaxesTax>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Tax")]
        public List<VehicleLocationAdditionalFeesTypeTaxesTax> Tax
        {
            get
            {
                return this._tax;
            }
            set
            {
                this._tax = value;
            }
        }
        
        public FormattedTextType Info
        {
            get
            {
                return this._info;
            }
            set
            {
                this._info = value;
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