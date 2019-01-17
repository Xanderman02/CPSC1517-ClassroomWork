using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSReview
{
    public class Die
    {
        // create a class level variable which will be an instance of the system namespace math class Random
        // create a static instance which will be used for ALL Die instances created by the programmer/developer
        // this instance of random will be generated once on the first Die instance3 taht is created
        private static Random _rnd = new Random();
               
        // Data Members, ususally private
        private int _sides;
        private string _colour;

        // Properties
        // properties are responsible for assigning and retrieving data to/from their associated data member
        // retrieving data froma data member uses the get{}, assigning data to a data member uses the set{}
        // Properties will have a return datatype BUT no parameter list
        // properties need to be exposed to ouside users

        // Fully Implimented property has a defined Data Member that the Deveolper can directly access
        public int Sides
        {
            get
            {
                // returns data of a specific datatype
                return _sides;
            }
            set
            {
                // assigns a supplied value to the data member
                // the supplied value is located in the key word: value
                // optionally include data value validation to ensure an appropriate has been supplied
                if(value >= 6 && value <= 20 )
                {
                    // this is an acceptable value to keep
                    _sides = value;
                    // Roll();
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
        // if your auto impliemented properties to have validation
        //      then a good practice is to use a private set and have
        //      the validation doen somewhere/somehow elsewhere in the class
        public int FaceValue { get; private set; }

        // public string Colour { get; private set;}

        public string Colour
        {
            get
            {
                return _colour;
            }
            set
            {
                // value.Trim() = ""
                // value == null
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("You must supply a colour string for the die.");
                }
                else
                {
                    _colour = value;
                }
            }
        }

        // Constructors
        // they are optional
        // Purpose of a constructor is to ensure that when an 
        //      instance of this class is created, it will be created within a
        //      stable state; ALWAYS
        // you DO NOT call the constructor direclty. it is called for you when you create
        //      an instance of the class.
        // if you do not code a constructor then the system will assign a default value to
        //      each data member/auto impliment property internal member matching the data type
        //      of that item
        // if you do code a constructor then you are responsible for ALL constructors for the class

        // syntax:  public classname([list of parameters]) { coding block }

        // Default constructor
        // is similar to the system default constructor
        public Die()
        {
            // if you leave this coding block empty it would be the same as 
            //   using a system default constructor

            // optionally
            // you can set your own default values
            _sides = 6;       // via data member
            Colour = "White"; // via property
            Roll();
        }

        // Greedy Constructor
        // this constructor will allow the user of the class to
        //   pass in a set of values which will be used at the 
        //   time of instance creation to set the values of the 
        //   internal data members/auto properties
        public Die(int sides, string colour)
        {
            Sides = sides;
            Colour = colour;
            Roll();  // is an internal method of this Die class
        }

        // Behaviours (Methods)
        // are methods that can be used by the outside user to
        //   a) affect values within the instance
        //   b) use instance data to generate and return information
        public void Roll()
        {
            // Random can take a set of values and produce a integer value between the two values, where
            //   the minium value is inclusive and the maxium value is exclusive
            FaceValue = _rnd.Next(1, Sides + 1);
        }
    }
}
