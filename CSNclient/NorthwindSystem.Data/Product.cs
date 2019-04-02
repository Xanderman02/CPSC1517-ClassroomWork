using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// the annotations used within the .Data project will require the 
//  System.ComponentModle.DataAnnotation assembly
// this assembly is added via your References
#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

namespace NorthwindSystem.Data
{
    // use an annotation to link this Class to the appropriate SQL table
    [Table("Products")]
    public class Product
    {
        //mapping of the SQL Table attributes will be to class properties
        private string _quantityPerUnit;

        // use an annotation to identify the primary key
        //  1) identity pkey on your sql table
        //       [Key] pkey name must end in ID or Id
        //  2) a compound pkey on your sql table
        //       [Key, Column(Order=n)] where n is the natural number indicating the
        //                              physical order of the attribute in the pkey
        //  3) a user supplied pkey on your sql table
        //       [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Product is required.")]
        [StringLength(40, ErrorMessage = "Product Name is limited to 40 characters.")]
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        [StringLength(20, ErrorMessage = "Quantity per Unit is limited to 20 characters.")]
        public string QuantityPerUnit
        {
            get
            {
                return _quantityPerUnit;
            }
            set
            {
                _quantityPerUnit = string.IsNullOrEmpty(value) ? null : value;
            }
        }
        [Range(0.00, double.MaxValue, ErrorMessage = "Unit Price must be 0 dollars or greater.")]
        public decimal? UnitPrice { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "QoH must be 0 or greater.")]
        public Int16? UnitsInStock { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "QoO must be 0 or greater.")]
        public Int16? UnitsOnOrder { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "ROL must be 0 or greater.")]
        public Int16? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        // sample of a computed field on your SQL
        // to annotate this property to be taken as a SQL computed field use
        // [DatabaseGenerated(DatabaseGeneratedOption.computed)]
        // public decimal Total { get; set; }

        // sample creating a read only property that is NOT an actual field on your SQL table
        // example: FirstName LastName attributes are often combined into a single field
        //      for display purposes: FullName
        // use the NotMapped annotation to handle this
        
        //[NotMapped]
        //public string FullName
        //{
        //    get Firstname + " " + LastName;
        //}
    }
}
