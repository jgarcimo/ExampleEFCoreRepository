namespace NetFullWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            Authors = new HashSet<Author>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookID { get; set; }

        public long ISBN { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [Column(TypeName = "date")]
        public DateTime PublishingDate { get; set; }

        public int? NumPages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Author> Authors { get; set; }
    }
}
