using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class GuaranteeType
    {
        
        private List<GuaranteeTypeGuaranteeAccepted> _guaranteesAccepted;
        
        private GuaranteeTypeDeadline _deadline;
        
        private List<CommentTypeComment> _comments;
        
        private List<ParagraphType> _guaranteeDescription;
        
        private GuaranteeTypeRetributionType _retributionType;
        
        private string _guaranteeCode;
        
        private GuaranteeTypeGuaranteeType _guaranteeType1;
        
        private System.DateTime _holdTime;
        
        public GuaranteeType()
        {
            this._guaranteeDescription = new List<ParagraphType>();
            this._comments = new List<CommentTypeComment>();
            this._deadline = new GuaranteeTypeDeadline();
            this._guaranteesAccepted = new List<GuaranteeTypeGuaranteeAccepted>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("GuaranteeAccepted", IsNullable=false)]
        public List<GuaranteeTypeGuaranteeAccepted> GuaranteesAccepted
        {
            get
            {
                return this._guaranteesAccepted;
            }
            set
            {
                this._guaranteesAccepted = value;
            }
        }
        
        public GuaranteeTypeDeadline Deadline
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Comment", IsNullable=false)]
        public List<CommentTypeComment> Comments
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
        
        [System.Xml.Serialization.XmlElementAttribute("GuaranteeDescription")]
        public List<ParagraphType> GuaranteeDescription
        {
            get
            {
                return this._guaranteeDescription;
            }
            set
            {
                this._guaranteeDescription = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public GuaranteeTypeRetributionType RetributionType
        {
            get
            {
                return this._retributionType;
            }
            set
            {
                this._retributionType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GuaranteeCode
        {
            get
            {
                return this._guaranteeCode;
            }
            set
            {
                this._guaranteeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("GuaranteeType")]
        public GuaranteeTypeGuaranteeType GuaranteeType1
        {
            get
            {
                return this._guaranteeType1;
            }
            set
            {
                this._guaranteeType1 = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="time")]
        public System.DateTime HoldTime
        {
            get
            {
                return this._holdTime;
            }
            set
            {
                this._holdTime = value;
            }
        }
    }
}