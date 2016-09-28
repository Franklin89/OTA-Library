using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EMD_LiteType
    {
        
        private List<UniqueID_Type> _agentID;
        
        private EMD_LiteTypeEndorsement _endorsement;
        
        private List<EMD_LiteTypeTotalFare> _totalFare;
        
        private List<EMD_LiteTypeTax> _taxes;
        
        private EMD_LiteTypeFareInfo _fareInfo;
        
        private List<EMD_LiteTypeTicketDocument> _ticketDocument;
        
        private EMD_LiteTypeOriginalIssueInfo _originalIssueInfo;
        
        private EMD_LiteTypeReasonForIssuance _reasonForIssuance;
        
        private string _totalFltSegQty;
        
        private string _ticketingModeCode;
        
        private EMD_LiteTypeEMD_Type _eMD_Type;
        
        public EMD_LiteType()
        {
            this._reasonForIssuance = new EMD_LiteTypeReasonForIssuance();
            this._originalIssueInfo = new EMD_LiteTypeOriginalIssueInfo();
            this._ticketDocument = new List<EMD_LiteTypeTicketDocument>();
            this._fareInfo = new EMD_LiteTypeFareInfo();
            this._taxes = new List<EMD_LiteTypeTax>();
            this._totalFare = new List<EMD_LiteTypeTotalFare>();
            this._endorsement = new EMD_LiteTypeEndorsement();
            this._agentID = new List<UniqueID_Type>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AgentID")]
        public List<UniqueID_Type> AgentID
        {
            get
            {
                return this._agentID;
            }
            set
            {
                this._agentID = value;
            }
        }
        
        public EMD_LiteTypeEndorsement Endorsement
        {
            get
            {
                return this._endorsement;
            }
            set
            {
                this._endorsement = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TotalFare")]
        public List<EMD_LiteTypeTotalFare> TotalFare
        {
            get
            {
                return this._totalFare;
            }
            set
            {
                this._totalFare = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Tax", IsNullable=false)]
        public List<EMD_LiteTypeTax> Taxes
        {
            get
            {
                return this._taxes;
            }
            set
            {
                this._taxes = value;
            }
        }
        
        public EMD_LiteTypeFareInfo FareInfo
        {
            get
            {
                return this._fareInfo;
            }
            set
            {
                this._fareInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TicketDocument")]
        public List<EMD_LiteTypeTicketDocument> TicketDocument
        {
            get
            {
                return this._ticketDocument;
            }
            set
            {
                this._ticketDocument = value;
            }
        }
        
        public EMD_LiteTypeOriginalIssueInfo OriginalIssueInfo
        {
            get
            {
                return this._originalIssueInfo;
            }
            set
            {
                this._originalIssueInfo = value;
            }
        }
        
        public EMD_LiteTypeReasonForIssuance ReasonForIssuance
        {
            get
            {
                return this._reasonForIssuance;
            }
            set
            {
                this._reasonForIssuance = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string TotalFltSegQty
        {
            get
            {
                return this._totalFltSegQty;
            }
            set
            {
                this._totalFltSegQty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketingModeCode
        {
            get
            {
                return this._ticketingModeCode;
            }
            set
            {
                this._ticketingModeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public EMD_LiteTypeEMD_Type EMD_Type
        {
            get
            {
                return this._eMD_Type;
            }
            set
            {
                this._eMD_Type = value;
            }
        }
    }
}