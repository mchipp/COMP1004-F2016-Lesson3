using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP1004_F2016_Lesson3
{
    public class Character
    {
       /**
        * PRIVATE VARIABLES
        **/
        private String _strength;

       /**
        * PUBLIC VARIABLES
        **/
        public string Strength
        {
            get
            {
                return this._strength;
            }

            set
            {
                this._strength = value;
            }
        }
    }
}