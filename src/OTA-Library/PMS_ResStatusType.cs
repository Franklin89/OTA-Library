namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public enum PMS_ResStatusType
    {
        
        /// <remarks/>
        Reserved,
        
        /// <remarks/>
        Requested,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Request denied")]
        Requestdenied,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("No-show")]
        Noshow,
        
        /// <remarks/>
        Cancelled,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("In-house")]
        Inhouse,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Checked out")]
        Checkedout,
        
        /// <remarks/>
        Waitlisted,
    }
}