using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ServicesType
    {
        
        private List<ServiceType> _service;
        
        private List<ServicesTypeServiceCategory> _serviceCategory;
        
        public ServicesType()
        {
            this._serviceCategory = new List<ServicesTypeServiceCategory>();
            this._service = new List<ServiceType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Service")]
        public List<ServiceType> Service
        {
            get
            {
                return this._service;
            }
            set
            {
                this._service = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ServiceCategory")]
        public List<ServicesTypeServiceCategory> ServiceCategory
        {
            get
            {
                return this._serviceCategory;
            }
            set
            {
                this._serviceCategory = value;
            }
        }
    }
}