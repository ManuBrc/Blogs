﻿using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreOData.Database
{
    public partial class BusinessEntityContact
    {
        [Key]
        public int BusinessEntityId { get; set; }
        [Key]
        public int PersonId { get; set; }
        [Key]
        public int ContactTypeId { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual ContactType ContactType { get; set; }
        public virtual Person Person { get; set; }
    }
}
