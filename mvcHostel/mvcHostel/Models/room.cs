//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvcHostel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class room
    {
        public room()
        {
            this.guest_in_room = new HashSet<guest_in_room>();
            this.room_photo = new HashSet<room_photo>();
            this.equipment = new HashSet<equipment>();
        }
    
        public int idroom { get; set; }
        public int room_type_idroom_type { get; set; }
        public Nullable<int> current_status { get; set; }
    
        public virtual ICollection<guest_in_room> guest_in_room { get; set; }
        public virtual ICollection<room_photo> room_photo { get; set; }
        public virtual room_type room_type { get; set; }
        public virtual ICollection<equipment> equipment { get; set; }
    }
}
