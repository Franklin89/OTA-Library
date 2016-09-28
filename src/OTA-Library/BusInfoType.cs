namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BusInfoType
    {
        
        private BusIdentificationType _bus;
        
        private BusInfoTypeValidDate _validDate;
        
        private string _delayTime;
        
        private string _scheduleCode;
        
        public BusInfoType()
        {
            this._validDate = new BusInfoTypeValidDate();
            this._bus = new BusIdentificationType();
        }
        
        public BusIdentificationType Bus
        {
            get
            {
                return this._bus;
            }
            set
            {
                this._bus = value;
            }
        }
        
        public BusInfoTypeValidDate ValidDate
        {
            get
            {
                return this._validDate;
            }
            set
            {
                this._validDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string DelayTime
        {
            get
            {
                return this._delayTime;
            }
            set
            {
                this._delayTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ScheduleCode
        {
            get
            {
                return this._scheduleCode;
            }
            set
            {
                this._scheduleCode = value;
            }
        }
    }
}