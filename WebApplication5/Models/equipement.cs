//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class equipement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public equipement()
        {
            this.fiche_tech = new HashSet<fiche_tech>();
            this.intervention = new HashSet<intervention>();
        }
    
        public int id_equip { get; set; }
        public string @ref { get; set; }
        public string libelleq { get; set; }
        public Nullable<int> id_dep { get; set; }
        public Nullable<int> id_type { get; set; }
        public Nullable<int> etat { get; set; }
    
        public virtual departement departement { get; set; }
        public virtual type type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fiche_tech> fiche_tech { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<intervention> intervention { get; set; }
    }
}