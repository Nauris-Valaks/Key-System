using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace projectDesign
{
    class Admin
    {
        public string adminUsername { get; set; }
        public string adminPassword { get; set; }

        //intialise  
        public Admin(string adminuser, string adminpass)
        {
            this.adminUsername = adminuser;
            this.adminPassword = adminpass;
        }
        //validate string 
        private bool StringValidator(string input)
        {
            string pattern = "[^a-zA-Z]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //validate integer 
        private bool IntegerValidator(string input)
        {
            string pattern = "[^0-9]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //clear user inputs 
        private void ClearTexts(string adminuser, string adminpass)
        {
            adminuser = String.Empty;
            adminpass = String.Empty;
        }
        //method to check if eligible to be logged in 
        internal bool IsLoggedIn(string adminuser, string adminpass)
        {
            //check user name empty 
            if (string.IsNullOrEmpty(adminuser))
            {
                MessageBox.Show("Enter the user name!");
                return false;

            }
            //check user name is valid type 
            else if (StringValidator(adminuser) == true)
            {
                MessageBox.Show("Enter only text here");
                ClearTexts(adminuser, adminpass);
                return false;
            }
            //check user name is correct 
            else
            {
                if (adminUsername != adminuser)
                {
                    MessageBox.Show("User name is incorrect!");
                    ClearTexts(adminuser, adminpass);
                    return false;
                }
                //check password is empty 
                else
                {
                    if (string.IsNullOrEmpty(adminpass))
                    {
                        MessageBox.Show("Enter the passowrd!");
                        return false;
                    }
                    //check password is valid 
                    else if (IntegerValidator(adminpass) == true)
                    {
                        MessageBox.Show("Enter only integer here");
                        return false;
                    }
                    //check password is correct 
                    else if (adminPassword != adminpass)
                    {
                        MessageBox.Show("Password is incorrect");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
    }
}




