using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CodeListScheduleType
    {
        
        private List<CodeListScheduleTypeOperationTime> _operationTimes;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private string _feeRefRPH;
        
        private string _scheduleRPH;
        
        public CodeListScheduleType()
        {
            this._operationTimes = new List<CodeListScheduleTypeOperationTime>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("OperationTime", IsNullable=false)]
        public List<CodeListScheduleTypeOperationTime> OperationTimes
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
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
        public string FeeRefRPH
        {
            get
            {
                return this._feeRefRPH;
            }
            set
            {
                this._feeRefRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ScheduleRPH
        {
            get
            {
                return this._scheduleRPH;
            }
            set
            {
                this._scheduleRPH = value;
            }
        }
    }
}