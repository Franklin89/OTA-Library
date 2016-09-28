namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_ReadRQReadRequestsHotelReadRequestSelectionCriteria
    {
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private OTA_ReadRQReadRequestsHotelReadRequestSelectionCriteriaDateType _dateType;
        
        private OTA_ReadRQReadRequestsHotelReadRequestSelectionCriteriaSelectionType _selectionType;
        
        private string _groupCode;
        
        private string _resStatus;
        
        private string _originalDeliveryMethodCode;
        
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
        public OTA_ReadRQReadRequestsHotelReadRequestSelectionCriteriaDateType DateType
        {
            get
            {
                return this._dateType;
            }
            set
            {
                this._dateType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OTA_ReadRQReadRequestsHotelReadRequestSelectionCriteriaSelectionType SelectionType
        {
            get
            {
                return this._selectionType;
            }
            set
            {
                this._selectionType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GroupCode
        {
            get
            {
                return this._groupCode;
            }
            set
            {
                this._groupCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResStatus
        {
            get
            {
                return this._resStatus;
            }
            set
            {
                this._resStatus = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OriginalDeliveryMethodCode
        {
            get
            {
                return this._originalDeliveryMethodCode;
            }
            set
            {
                this._originalDeliveryMethodCode = value;
            }
        }
    }
}