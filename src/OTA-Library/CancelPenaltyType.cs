using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CancelPenaltyType
    {
        
        private CancelPenaltyTypeDeadline _deadline;
        
        private AmountPercentType _amountPercent;
        
        private List<ParagraphType> _penaltyDescription;
        
        private string _confirmClassCode;
        
        private string _policyCode;
        
        private bool _nonRefundable;
        
        private bool _mon;
        
        private bool _tue;
        
        private bool _weds;
        
        private bool _thur;
        
        private bool _fri;
        
        private bool _sat;
        
        private bool _sun;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private string _roomTypeCode;
        
        private bool _noCancelInd;
        
        public CancelPenaltyType()
        {
            this._penaltyDescription = new List<ParagraphType>();
            this._amountPercent = new AmountPercentType();
            this._deadline = new CancelPenaltyTypeDeadline();
        }
        
        public CancelPenaltyTypeDeadline Deadline
        {
            get
            {
                return this._deadline;
            }
            set
            {
                this._deadline = value;
            }
        }
        
        public AmountPercentType AmountPercent
        {
            get
            {
                return this._amountPercent;
            }
            set
            {
                this._amountPercent = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PenaltyDescription")]
        public List<ParagraphType> PenaltyDescription
        {
            get
            {
                return this._penaltyDescription;
            }
            set
            {
                this._penaltyDescription = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ConfirmClassCode
        {
            get
            {
                return this._confirmClassCode;
            }
            set
            {
                this._confirmClassCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PolicyCode
        {
            get
            {
                return this._policyCode;
            }
            set
            {
                this._policyCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonRefundable
        {
            get
            {
                return this._nonRefundable;
            }
            set
            {
                this._nonRefundable = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Mon
        {
            get
            {
                return this._mon;
            }
            set
            {
                this._mon = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Tue
        {
            get
            {
                return this._tue;
            }
            set
            {
                this._tue = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Weds
        {
            get
            {
                return this._weds;
            }
            set
            {
                this._weds = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Thur
        {
            get
            {
                return this._thur;
            }
            set
            {
                this._thur = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Fri
        {
            get
            {
                return this._fri;
            }
            set
            {
                this._fri = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Sat
        {
            get
            {
                return this._sat;
            }
            set
            {
                this._sat = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Sun
        {
            get
            {
                return this._sun;
            }
            set
            {
                this._sun = value;
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
        public string RoomTypeCode
        {
            get
            {
                return this._roomTypeCode;
            }
            set
            {
                this._roomTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NoCancelInd
        {
            get
            {
                return this._noCancelInd;
            }
            set
            {
                this._noCancelInd = value;
            }
        }
    }
}