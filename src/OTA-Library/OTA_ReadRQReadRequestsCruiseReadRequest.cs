namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_ReadRQReadRequestsCruiseReadRequest
    {
        
        private OTA_ReadRQReadRequestsCruiseReadRequestSelectedSailing _selectedSailing;
        
        private PersonNameType _guestInfo;
        
        private bool _historyRequestedInd;
        
        public OTA_ReadRQReadRequestsCruiseReadRequest()
        {
            this._guestInfo = new PersonNameType();
            this._selectedSailing = new OTA_ReadRQReadRequestsCruiseReadRequestSelectedSailing();
        }
        
        public OTA_ReadRQReadRequestsCruiseReadRequestSelectedSailing SelectedSailing
        {
            get
            {
                return this._selectedSailing;
            }
            set
            {
                this._selectedSailing = value;
            }
        }
        
        public PersonNameType GuestInfo
        {
            get
            {
                return this._guestInfo;
            }
            set
            {
                this._guestInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HistoryRequestedInd
        {
            get
            {
                return this._historyRequestedInd;
            }
            set
            {
                this._historyRequestedInd = value;
            }
        }
    }
}