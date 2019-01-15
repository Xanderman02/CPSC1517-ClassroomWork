using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSReview
{
    public class Die
    {
        // Data Members, ususally private
        private int _side;
        private string _colour;

        // Properties
        // properties are responsible for assigning and retrieving data to/from their associated data member
        // retrieving data froma data member uses the get{}, assigning data to a data member uses the set{}
        // Properties will have a return datatype BUT no parameter list
        // properties need to be exposed to ouside users

        // Fully Implimented property has a defined Data Member that the Deveolper can directly access
        public int Side
        {
            get
            {
                // returns data of a specific datatype
                return _side;
            }
            set
            {
                // assigns a supplied value to the data member
                // the supplied value is located in the key word: value
                // optionally include data value validation to ensure an appropriate has been supplied
                if(value >=6 && value <= 20 )
                {
                    // this is an acceptable value to keep
                    _side = value;
                }
                else
                {
                    // this is an unaccpetable value to keep
                    // issue a user friendly error message
                    throw new Exception("Die cannot be " + value.ToString() + " sided. die must be between 6 and 20 sided");
                }
            }
        }

        // auto implimented property
        // NO data member definition, the data member is internally created for you
        // the data member data type is taken from your return datatype, specified
        //     on the property header
        // auto implimented properties are usually used when there is no need for
        //      internal validation
        // access to a value managed by an auto implimented property MUST be done
        //      via the property
        public int FaceValue { get; set; }
    }
}
