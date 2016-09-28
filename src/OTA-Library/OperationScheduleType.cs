using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationSchedulePlusChargeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OperationScheduleType
    {
        
        private List<OperationScheduleTypeOperationTime> _operationTimes;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        public OperationScheduleType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._operationTimes = new List<OperationScheduleTypeOperationTime>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("OperationTime", IsNullable=false)]
        public List<OperationScheduleTypeOperationTime> OperationTimes
        {
            get
            {
                return this._operationTimes;
            }
            set
            {
                this._operationTimes = value;
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