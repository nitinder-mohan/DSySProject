using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AdminBL
/// </summary>
public class AdminBL
{
	public AdminBL()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DataTable FetchCountry()
    {
        return new AdminDAL().FetchCountry();
    }

    public DataTable FetchState(int countryId)
    {
        return new AdminDAL().FetchState(countryId);
    }

    public DataTable FetchCategory()
    {
        return new AdminDAL().FetchCategory();
    }


    public DataTable FetchDegree()
    {
        return new AdminDAL().FetchDegree();
    }

    public DataTable FetchSpecialization(int degreeId)
    {
        return new AdminDAL().FetchSpecialization(degreeId);
    }

    public DataTable FetchFocusArea()
    {
        return new AdminDAL().FetchFocusArea();
    }


    public DataTable FetchUniversity(int stateId)
    {
        return new AdminDAL().FetchUniversity(stateId);
    }
}