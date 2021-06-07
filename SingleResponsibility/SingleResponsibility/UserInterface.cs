using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{

    ////Bad Single Responsibility Example: This is a bad example of single responsibility principle because UserInterface does all the job itself. We should use different interfaces for different jobs.

    //interface UserInterface
    //{
    //    bool Login(string username, string password);
    //    bool Register(string username, string password, string email);
    //    void LoginError(string error);
    //    bool SendEmail(string emailContent);
    //}



    //Good Single Responsibility Example:

    interface UserInterface
    {
        //Login and Register:
        bool Login(string username, string password);
        bool Register(string username, string password, string email);
    }

    interface LoginInterface
    {
        //Error:
        void LoginError(string error);
    }

    interface EmailInterface
    {
        //Send Email:
        bool SendEmail(string emailContent);
    }

}