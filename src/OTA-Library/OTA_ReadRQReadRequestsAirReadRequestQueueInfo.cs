using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_ReadRQReadRequestsAirReadRequestQueueInfo
    {
        
        private List<OTA_ReadRQReadRequestsAirReadRequestQueueInfoQueue> _queue;
        
        private bool _firstItemOnlyInd;
        
        private bool _removeFromQueueInd;
        
        private bool _fullDataInd;
        
        private string _startDate;
        
        private string _endDate;
        
        public OTA_ReadRQReadRequestsAirReadRequestQueueInfo()
        {
            this._queue = new List<OTA_ReadRQReadRequestsAirReadRequestQueueInfoQueue>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Queue")]
        public List<OTA_ReadRQReadRequestsAirReadRequestQueueInfoQueue> Queue
        {
            get
            {
                return this._queue;
            }
            set
            {
                this._queue = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FirstItemOnlyInd
        {
            get
            {
                return this._firstItemOnlyInd;
            }
            set
            {
                this._firstItemOnlyInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RemoveFromQueueInd
        {
            get
            {
                return this._removeFromQueueInd;
            }
            set
            {
                this._removeFromQueueInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FullDataInd
        {
            get
            {
                return this._fullDataInd;
            }
            set
            {
                this._fullDataInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StartDate
        {
            get
            {
                return this._startDate;
            }
            set
            {
                this._startDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EndDate
        {
            get
            {
                return this._endDate;
            }
            set
            {
                this._endDate = value;
            }
        }
    }
}