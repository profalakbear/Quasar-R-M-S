//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quasar1._0._1.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class DISH_LIST
    {
        public int ID { get; set; }
        public int DISH_ID { get; set; }
        public Nullable<System.DateTime> DATE_ADDED { get; set; }
    
        public virtual DISHES DISHES { get; set; }
    }
}
