//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace home_accounting.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class accounting
    {
        public int id { get; set; }
        public System.DateTime date_add { get; set; }
        public int category_type_id { get; set; }
        public int category_id { get; set; }
        public string sum { get; set; }
        public string comment { get; set; }
    
        public virtual Categories Categories { get; set; }
        public virtual category_type category_type { get; set; }
    }
}
