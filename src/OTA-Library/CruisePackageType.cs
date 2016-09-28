using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CruisePackageType
    {
        
        private List<CruisePackageTypeLocation> _location;
        
        private string _packageTypeCode;
        
        private string _cruisePackageCode;
        
        private bool _inclusiveIndicator;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private string _status;
        
        public CruisePackageType()
        {
            this._location = new List<CruisePackageTypeLocation>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Location")]
        public List<CruisePackageTypeLocation> Location
        {
            get
            {
                return this._location;
            }
            set
            {
                this._location = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PackageTypeCode
        {
            get
            {
                return this._packageTypeCode;
            }
            set
            {
                this._packageTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CruisePackageCode
        {
            get
            {
                return this._cruisePackageCode;
            }
            set
            {
                this._cruisePackageCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool InclusiveIndicator
        {
            get
            {
                return this._inclusiveIndicator;
            }
            set
            {
                this._inclusiveIndicator = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
    }
}