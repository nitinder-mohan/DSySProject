using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AdminDAL
/// </summary>
public class AdminDAL
{
    SqlConnection connstring;
	public AdminDAL()
	{
        connstring = new SqlConnection(ConfigurationManager.ConnectionStrings["DSSProjectConnectionString"].ConnectionString);
	}

    public DataTable FetchCountry()
    {
        DataTable dtCountry = new DataTable();
        try
        {
            SqlCommand cmdCountry = new SqlCommand();
            cmdCountry.CommandText = "usp_FetchCountry";
            cmdCountry.CommandType = CommandType.StoredProcedure;
            cmdCountry.Connection = connstring;
            SqlDataAdapter daCountry = new SqlDataAdapter(cmdCountry);
            daCountry.Fill(dtCountry);

        }
        catch (Exception ex)
        {

        }

        finally
        {
            connstring.Close();
        }
        return dtCountry;
    }

    public DataTable FetchState(int countryId)
    {
        DataTable dtState = new DataTable();
        try
        {
            SqlCommand cmdState = new SqlCommand();
            cmdState.CommandText = "usp_FetchState";
            cmdState.CommandType = CommandType.StoredProcedure;
            cmdState.Connection = connstring;
            cmdState.Parameters.AddWithValue("@CountryId", countryId);
            SqlDataAdapter daState = new SqlDataAdapter(cmdState);
            daState.Fill(dtState);

        }
        catch (Exception ex)
        {

        }

        finally
        {
            connstring.Close();
        }
        return dtState;
    }

    public DataTable FetchCategory()
    {
        DataTable dtCategory = new DataTable();
        try
        {
            SqlCommand cmdCategory = new SqlCommand();
            cmdCategory.CommandText = "usp_FetchCategory";
            cmdCategory.CommandType = CommandType.StoredProcedure;
            cmdCategory.Connection = connstring;
            SqlDataAdapter daCategory = new SqlDataAdapter(cmdCategory);
            daCategory.Fill(dtCategory);

        }
        catch (Exception ex)
        {

        }

        finally
        {
            connstring.Close();
        }
        return dtCategory;
    }


    public DataTable FetchDegree()
    {
        DataTable dtDegree = new DataTable();
        try
        {
            SqlCommand cmdDegree = new SqlCommand();
            cmdDegree.CommandText = "usp_FetchDegree";
            cmdDegree.CommandType = CommandType.StoredProcedure;
            cmdDegree.Connection = connstring;
            SqlDataAdapter daDegree = new SqlDataAdapter(cmdDegree);
            daDegree.Fill(dtDegree);

        }
        catch (Exception ex)
        {

        }

        finally
        {
            connstring.Close();
        }
        return dtDegree;
    }

    public DataTable FetchSpecialization(int degreeId)
    {
        DataTable dtSpecialization = new DataTable();
        try
        {
            SqlCommand cmdSpecialization = new SqlCommand();
            cmdSpecialization.CommandText = "usp_FetchSpecialization";
            cmdSpecialization.CommandType = CommandType.StoredProcedure;
            cmdSpecialization.Connection = connstring;
            cmdSpecialization.Parameters.AddWithValue("@DegreeId", degreeId);
            SqlDataAdapter daSpecialization = new SqlDataAdapter(cmdSpecialization);
            daSpecialization.Fill(dtSpecialization);

        }
        catch (Exception ex)
        {

        }

        finally
        {
            connstring.Close();
        }
        return dtSpecialization;
    }

    public DataTable FetchFocusArea()
    {
        DataTable dtFocusArea = new DataTable();
        try
        {
            SqlCommand cmdFocusArea = new SqlCommand();
            cmdFocusArea.CommandText = "usp_FetchFocusArea";
            cmdFocusArea.CommandType = CommandType.StoredProcedure;
            cmdFocusArea.Connection = connstring;

            SqlDataAdapter daFocusArea = new SqlDataAdapter(cmdFocusArea);
            daFocusArea.Fill(dtFocusArea);

        }
        catch (Exception ex)
        {

        }

        finally
        {
            connstring.Close();
        }
        return dtFocusArea;
    }


    public DataTable FetchUniversity(int stateId)
    {
        DataTable dtUniversity = new DataTable();
        try
        {
            SqlCommand cmdUniversity = new SqlCommand();
            cmdUniversity.CommandText = "usp_FetchFocusArea";
            cmdUniversity.CommandType = CommandType.StoredProcedure;
            cmdUniversity.Connection = connstring;
            cmdUniversity.Parameters.AddWithValue("@StateId", stateId);
            SqlDataAdapter daUniversity = new SqlDataAdapter(cmdUniversity);
            daUniversity.Fill(dtUniversity);

        }
        catch (Exception ex)
        {

        }

        finally
        {
            connstring.Close();
        }
        return dtUniversity;
    }



}