using System;
using System.Collections.Generic;
using System.Text;

namespace Analytic4Tests.Tests
{

    class UsersForTests
    {
        //private string[] startLogin = new string[] { "test0", "test1", "test2", "admin" };

        public static string StartLogin
        {
            get
            {
            string startLogin = "admin";
            return startLogin;
            }
            set
            {
                //startLogin = value;
            }
        }

        //private string[] startPass = new string[] { "test0", "test1", "test2", "admin" };
        public static string StartPass
        {
            get
            {
                string startPass = "admin";
                return startPass;
            }
            set
            {
                //startPass = value;
            }
        }
 
        //public static string[] StartLogin
        //{
        //  get; set;
        //}

        //public static string[] StartPass
        //{
        //  get; set;
        // }
    }
}
