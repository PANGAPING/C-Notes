private DataSet GetData(string SPName, SqlParameter SPParameter)
{
    string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
    SqlConnection con = new SqlConnection(CS);
    SqlDataAdapter da = new SqlDataAdapter(SPName, con);
    da.SelectCommand.CommandType = CommandType.StoredProcedure;
    if (SPParameter != null)
    {
        da.SelectCommand.Parameters.Add(SPParameter);
    }
    DataSet DS = new DataSet();
    da.Fill(DS);
    return DS;
}