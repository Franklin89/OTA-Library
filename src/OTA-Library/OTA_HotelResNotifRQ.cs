// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.31
//    <NameSpace>MLSoftware.OTA</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><DataMemberNameArg>OnlyIfDifferent</DataMemberNameArg><DataMemberOnXmlIgnore>False</DataMemberOnXmlIgnore><CodeBaseTag>Net40</CodeBaseTag><InitializeFields>All</InitializeFields><GenerateUnusedComplexTypes>True</GenerateUnusedComplexTypes><GenerateUnusedSimpleTypes>True</GenerateUnusedSimpleTypes><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableLazyLoading>False</EnableLazyLoading><VirtualProp>False</VirtualProp><PascalCase>False</PascalCase><AutomaticProperties>False</AutomaticProperties><PropNameSpecified>None</PropNameSpecified><PrivateFieldName>StartWithUnderscore</PrivateFieldName><PrivateFieldNamePrefix></PrivateFieldNamePrefix><EnableRestriction>False</EnableRestriction><RestrictionMaxLenght>False</RestrictionMaxLenght><RestrictionRegEx>False</RestrictionRegEx><RestrictionRange>False</RestrictionRange><ValidateProperty>False</ValidateProperty><ClassNamePrefix></ClassNamePrefix><ClassLevel>Public</ClassLevel><PartialClass>True</PartialClass><ClassesInSeparateFiles>False</ClassesInSeparateFiles><ClassesInSeparateFilesDir></ClassesInSeparateFilesDir><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><EnableAppInfoSettings>False</EnableAppInfoSettings><EnableExternalSchemasCache>False</EnableExternalSchemasCache><EnableDebug>False</EnableDebug><EnableWarn>False</EnableWarn><ExcludeImportedTypes>False</ExcludeImportedTypes><ExpandNesteadAttributeGroup>False</ExpandNesteadAttributeGroup><CleanupCode>False</CleanupCode><EnableXmlSerialization>False</EnableXmlSerialization><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><EnableEncoding>False</EnableEncoding><EnableXMLIndent>False</EnableXMLIndent><Encoder>UTF8</Encoder><Serializer>XmlSerializer</Serializer><sspNullable>False</sspNullable><sspString>False</sspString><sspCollection>False</sspCollection><sspComplexType>False</sspComplexType><sspSimpleType>False</sspSimpleType><sspEnumType>False</sspEnumType><BaseClassName>EntityBase</BaseClassName><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><CustomUsings></CustomUsings><AttributesToExlude></AttributesToExlude>
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace MLSoftware.OTA
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Xml;
    using System.Collections.Generic;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opentravel.org/OTA/2003/05", IsNullable=false)]
    public partial class OTA_HotelResNotifRQ
    {
        
        private List<SourceType> _pOS;
        
        private UniqueID_Type _messageID;
        
        private HotelReservationsType _hotelReservations;
        
        private string _echoToken;
        
        private System.DateTime _timeStamp;
        
        private MessageTypeOriginalPayloadStdAttributesTarget _target;
        
        private string _targetName;
        
        private decimal _version;
        
        private string _transactionIdentifier;
        
        private string _sequenceNmbr;
        
        private MessageTypeOriginalPayloadStdAttributesTransactionStatusCode _transactionStatusCode;
        
        private bool _retransmissionIndicator;
        
        private string _correlationID;
        
        private string _primaryLangID;
        
        private string _altLangID;
        
        private TransactionActionType _resStatus;
        
        private string _holdDuration;
        
        public OTA_HotelResNotifRQ()
        {
            this._hotelReservations = new HotelReservationsType();
            this._messageID = new UniqueID_Type();
            this._pOS = new List<SourceType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Source", IsNullable=false)]
        public List<SourceType> POS
        {
            get
            {
                return this._pOS;
            }
            set
            {
                this._pOS = value;
            }
        }
        
        public UniqueID_Type MessageID
        {
            get
            {
                return this._messageID;
            }
            set
            {
                this._messageID = value;
            }
        }
        
        public HotelReservationsType HotelReservations
        {
            get
            {
                return this._hotelReservations;
            }
            set
            {
                this._hotelReservations = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EchoToken
        {
            get
            {
                return this._echoToken;
            }
            set
            {
                this._echoToken = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime TimeStamp
        {
            get
            {
                return this._timeStamp;
            }
            set
            {
                this._timeStamp = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MessageTypeOriginalPayloadStdAttributesTarget Target
        {
            get
            {
                return this._target;
            }
            set
            {
                this._target = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TargetName
        {
            get
            {
                return this._targetName;
            }
            set
            {
                this._targetName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TransactionIdentifier
        {
            get
            {
                return this._transactionIdentifier;
            }
            set
            {
                this._transactionIdentifier = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string SequenceNmbr
        {
            get
            {
                return this._sequenceNmbr;
            }
            set
            {
                this._sequenceNmbr = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MessageTypeOriginalPayloadStdAttributesTransactionStatusCode TransactionStatusCode
        {
            get
            {
                return this._transactionStatusCode;
            }
            set
            {
                this._transactionStatusCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RetransmissionIndicator
        {
            get
            {
                return this._retransmissionIndicator;
            }
            set
            {
                this._retransmissionIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CorrelationID
        {
            get
            {
                return this._correlationID;
            }
            set
            {
                this._correlationID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string PrimaryLangID
        {
            get
            {
                return this._primaryLangID;
            }
            set
            {
                this._primaryLangID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string AltLangID
        {
            get
            {
                return this._altLangID;
            }
            set
            {
                this._altLangID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TransactionActionType ResStatus
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string HoldDuration
        {
            get
            {
                return this._holdDuration;
            }
            set
            {
                this._holdDuration = value;
            }
        }
    }
}
#pragma warning restore
