//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ionov4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Things
    {
        public int mi_id { get; set; }
        public string thing_type { get; set; }
        public string name { get; set; }
        public string material { get; set; }
        public int price { get; set; }
        public string color { get; set; }
        public int user_id { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
