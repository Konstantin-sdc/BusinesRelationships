using System;
using System.Collections.Generic;
using BusinesRelationships.Contractors;

namespace BusinesRelationships.Contracts {
    /// <summary>Договор</summary>
    public class Contract {
        /// <summary>Является эксклюзивным</summary>
        public bool IsExclusive { get; set; }
        /// <summary>Код</summary>
        public string Code { get; set; }
        /// <summary>Предмет договора</summary>
        public ContractSubject Subject { get; set; }
        /// <summary>Время заключения договора</summary>
        public DateTime Date { get; set; }
        /// <summary>Место заключения договора</summary>
        public Address ContractPoint { get; set; }

        /// <summary>Стороны договора</summary>
        private IEnumerable<Contractor> Contractors { get; set; }
    }

    /// <summary>Предмет договора</summary>
    public class ContractSubject { }
    /// <summary>Месторасположения</summary>
    public class Address { }
    /// <summary>Сторона договора</summary>
    public class ContractSide : Contractor {

    }
}
