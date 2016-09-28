namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TrainInfoType
    {
        
        private TrainIdentificationType _train;
        
        private TrainInfoTypeValidDate _validDate;
        
        private string _delayTime;
        
        private string _scheduleCode;
        
        public TrainInfoType()
        {
            this._validDate = new TrainInfoTypeValidDate();
            this._train = new TrainIdentificationType();
        }
        
        public TrainIdentificationType Train
        {
            get
            {
                return this._train;
            }
            set
            {
                this._train = value;
            }
        }
        
        public TrainInfoTypeValidDate ValidDate
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
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