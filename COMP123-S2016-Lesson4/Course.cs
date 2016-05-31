using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson4
{
    /**
     * <summary>
     * This is Course class - we are using this as
     * a custom data type for our Teacher and Student classes
     * 
     * @class Course
     */
    class Course
    {
        //PRIVATe INSTANCE VARIABLES*****************************************************

        private string _code;
        private string _description;

        //PUBLIC PROPERTY++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public string Code
        {
            get//reading
            {
                return this._code;

            }
            set//writeiing
            {
                this._code = value;
            }
        }
        public string Description
        {
            get//reading
            {
                return this._description;

            }
            set//writeiing
            {
                this._description = value;
            }
        }

        //CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        /**
         * <summary>
         * This constructoer takes two parameters: courseCode, and Description
         * @construcror Course
         * @params {stirng} code
         * @params {string} description
         */
        public Course(string code, string description)
        {
            this.Code = Code;
            this.Description = description;
        }
    }
}
