using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.MSSQLServer;
/// <summary>
/// Summary description for ExpTable
/// </summary>
public class ExpTable:SQLDBTable
{
    public ExpTable():base ("ExpTable",DBConnection.Connection)
    {
        //
        // TODO: Add constructor logic here
        //
    }
}