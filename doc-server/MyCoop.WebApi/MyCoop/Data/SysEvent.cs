//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyCoop.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class SysEvent
    {
        public int Id { get; set; }
        public System.DateTime Time { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public Nullable<int> UserId { get; set; }
        public System.Guid TransactionId { get; set; }
    
        public virtual User User { get; set; }
    }
}
