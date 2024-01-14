using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.MSSQLServer;
using System.Configuration;

/// <summary>
/// Summary description for UserTable
/// </summary>
public class UserTable:SQLDBTable
{
    public UserTable():base ("UserTable",DBConnection.Connection)
    {
        //
        // TODO: Add constructor logic here
        //
    }
}