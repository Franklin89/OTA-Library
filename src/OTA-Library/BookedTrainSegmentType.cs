using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BookedTrainSegmentType : TrainSegmentType
    {
        
        private ClassCodeType _classCode;
        
        private List<FreeTextType> _comment;
        
        private List<BookedTrainSegmentTypeAssignment> _assignment;
        
        private string _marriageGrp;
        
        private string _bookStatus;
        
        private string _ticketStatus;
        
        public BookedTrainSegmentType()
        {
            this._assignment = new List<BookedTrainSegmentTypeAssignment>();
            this._comment = new List<FreeTextType>();
            this._classCode = new ClassCodeType();
        }
        
        public ClassCodeType ClassCode
        {
            get
            {
                return this._classCode;
            }
            set
            {
                this._classCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Comment")]
        public List<FreeTextType> Comment
        {
            get
            {
                return this._comment;
            }
            set
            {
                this._comment = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Assignment")]
        public List<BookedTrainSegmentTypeAssignment> Assignment
        {
            get
            {
                return this._assignment;
            }
            set
            {
                this._assignment = value;
            }
        }
        
        public string MarriageGrp
        {
            get
            {
                return this._marriageGrp;
            }
            set
            {
                this._marriageGrp = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BookStatus
        {
            get
            {
                return this._bookStatus;
            }
            set
            {
                this._bookStatus = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketStatus
        {
            get
            {
                return this._ticketStatus;
            }
            set
            {
                this._ticketStatus = value;
            }
        }
    }
}