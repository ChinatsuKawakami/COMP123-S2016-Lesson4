using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson4
{
    /**
     * 
     *<summary>
     *The Teacher class is derived from the Person class
     * </summary>
     * @class Teacher
     * @extends Person
     */
    class Teacher:Person
    {
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++++
        private string _employeeID;
       

        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++
        public string EmployeeID
        {
            get
            {
                return _employeeID;
            }
            set
            {
                _employeeID = value;
            }
        }

        /**
         * 
         * This construcrot method takes three parametaers name , age, employeeId
         * 
         * @construncor Teacher
         * @param {string} name
         * @param {int } age
         * @param {string} employeeId
         */

        //CONSTRUCTOR++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public Teacher(string name, int age, string employeeID)
            :base(name,age)
        {
            this.EmployeeID = employeeID; // this value will be passed into private _employeeID
        }

        // PUBLIC METHOD++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         *
         * This method enables the Teachers behavior for the Teacher class
         * 
         * @method Teaches
         * @return {void}
         */
        public void Teaches()
        {
            Console.WriteLine(this.Name + " teaches.");
        }
    }
}
