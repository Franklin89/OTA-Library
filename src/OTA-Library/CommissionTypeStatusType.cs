namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public enum CommissionTypeStatusType
    {
        
        /// <remarks/>
        Full,
        
        /// <remarks/>
        Partial,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Non-paying")]
        Nonpaying,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("No-show")]
        Noshow,
        
        /// <remarks/>
        Adjustment,
        
        /// <remarks/>
        Commissionable,
    }
}