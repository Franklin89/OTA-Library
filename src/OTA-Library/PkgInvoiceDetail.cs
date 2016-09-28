using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PkgInvoiceDetail
    {
        
        private List<CostingItemType> _costingItems;
        
        private PkgInvoiceDetailGrossAmount _grossAmount;
        
        private PkgInvoiceDetailDepositAmount _depositAmount;
        
        private List<PkgInvoiceDetailAgentCommission> _agentCommission;
        
        private PkgInvoiceDetailNetAmount _netAmount;
        
        private TaxesType _taxItems;
        
        private PkgInvoiceDetailBalanceDueAmount _balanceDueAmount;
        
        private PkgInvoiceDetailAmountReceived _amountReceived;
        
        public PkgInvoiceDetail()
        {
            this._amountReceived = new PkgInvoiceDetailAmountReceived();
            this._balanceDueAmount = new PkgInvoiceDetailBalanceDueAmount();
            this._taxItems = new TaxesType();
            this._netAmount = new PkgInvoiceDetailNetAmount();
            this._agentCommission = new List<PkgInvoiceDetailAgentCommission>();
            this._depositAmount = new PkgInvoiceDetailDepositAmount();
            this._grossAmount = new PkgInvoiceDetailGrossAmount();
            this._costingItems = new List<CostingItemType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("CostingItem", IsNullable=false)]
        public List<CostingItemType> CostingItems
        {
            get
            {
                return this._costingItems;
            }
            set
            {
                this._costingItems = value;
            }
        }
        
        public PkgInvoiceDetailGrossAmount GrossAmount
        {
            get
            {
                return this._grossAmount;
            }
            set
            {
                this._grossAmount = value;
            }
        }
        
        public PkgInvoiceDetailDepositAmount DepositAmount
        {
            get
            {
                return this._depositAmount;
            }
            set
            {
                this._depositAmount = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AgentCommission")]
        public List<PkgInvoiceDetailAgentCommission> AgentCommission
        {
            get
            {
                return this._agentCommission;
            }
            set
            {
                this._agentCommission = value;
            }
        }
        
        public PkgInvoiceDetailNetAmount NetAmount
        {
            get
            {
                return this._netAmount;
            }
            set
            {
                this._netAmount = value;
            }
        }
        
        public TaxesType TaxItems
        {
            get
            {
                return this._taxItems;
            }
            set
            {
                this._taxItems = value;
            }
        }
        
        public PkgInvoiceDetailBalanceDueAmount BalanceDueAmount
        {
            get
            {
                return this._balanceDueAmount;
            }
            set
            {
                this._balanceDueAmount = value;
            }
        }
        
        public PkgInvoiceDetailAmountReceived AmountReceived
        {
            get
            {
                return this._amountReceived;
            }
            set
            {
                this._amountReceived = value;
            }
        }
    }
}