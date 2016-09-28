using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RFP_ResponseDetailType
    {
        
        private List<ParagraphType> _comments;
        
        private bool _detailIncludedIndicator;
        
        private string _minimumTime;
        
        private string _maximumTime;
        
        private string _responseMethod;
        
        private RFP_ResponseDetailTypeResponseTimeUnit _responseTimeUnit;
        
        private bool _declineIndicator;
        
        private string _declineReasonCode;
        
        private string _codeDetail;
        
        public RFP_ResponseDetailType()
        {
            this._comments = new List<ParagraphType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Comment", IsNullable=false)]
        public List<ParagraphType> Comments
        {
            get
            {
                return this._comments;
            }
            set
            {
                this._comments = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DetailIncludedIndicator
        {
            get
            {
                return this._detailIncludedIndicator;
            }
            set
            {
                this._detailIncludedIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string MinimumTime
        {
            get
            {
                return this._minimumTime;
            }
            set
            {
                this._minimumTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string MaximumTime
        {
            get
            {
                return this._maximumTime;
            }
            set
            {
                this._maximumTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResponseMethod
        {
            get
            {
                return this._responseMethod;
            }
            set
            {
                this._responseMethod = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RFP_ResponseDetailTypeResponseTimeUnit ResponseTimeUnit
        {
            get
            {
                return this._responseTimeUnit;
            }
            set
            {
                this._responseTimeUnit = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DeclineIndicator
        {
            get
            {
                return this._declineIndicator;
            }
            set
            {
                this._declineIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DeclineReasonCode
        {
            get
            {
                return this._declineReasonCode;
            }
            set
            {
                this._declineReasonCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeDetail
        {
            get
            {
                return this._codeDetail;
            }
            set
            {
                this._codeDetail = value;
            }
        }
    }
}