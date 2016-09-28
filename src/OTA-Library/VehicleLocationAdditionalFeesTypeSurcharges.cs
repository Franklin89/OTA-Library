using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleLocationAdditionalFeesTypeSurcharges
    {
        
        private List<VehicleLocationAdditionalFeesTypeSurchargesSurcharge> _surcharge;
        
        private FormattedTextType _info;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        public VehicleLocationAdditionalFeesTypeSurcharges()
        {
            this._info = new FormattedTextType();
            this._surcharge = new List<VehicleLocationAdditionalFeesTypeSurchargesSurcharge>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Surcharge")]
        public List<VehicleLocationAdditionalFeesTypeSurchargesSurcharge> Surcharge
        {
            get
            {
                return this._surcharge;
            }
            set
            {
                this._surcharge = value;
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