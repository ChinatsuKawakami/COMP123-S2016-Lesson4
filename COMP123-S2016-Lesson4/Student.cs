using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson4
{
    /**
     * <summary>
     * this is student class. It is drivers from the personclass
     * 
     * @class student
     * @extends Person
     * 
     * 
     * 
     */
    class Student : Person //inheritance relationship
    {
        //PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++
        private string _studentID;

        //PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
      /**
       * 
       * This property,StudentID, includes a getter and setter for the private
       * instance variables 
       * 
       * 
       */
        
        
        public string StudentID {
           get{
               return this._studentID;
           } 
            set{
                this._studentID = value;
            } 
        }


        // CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++



        /**
         * 
         *<summary>
         *This is the empty / default constructor for the 
         *student class
         * </summary>
         * @constructor Student
         * @extends Person
         * @param {string}name
         * @param {int} age
         * @param {string} StudentID
         */
        public Student(string name,int age, string studentID)
            :base(name,age)
        {

            this.StudentID = studentID;
            
        }

        //PUBLIC METHOD *********************************************************
        /**
         * <summary>
         * This method enables the Studies behavior for the student 
         * 
         * @method Studies
         * @return {void} 
         */
        public void Studies()
        {
            Console.WriteLine(this.Name +" studies.");
        }
    }
}
