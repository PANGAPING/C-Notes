Create table tblCity
(
 CityId int primary key,
 CityName nvarchar(50),
 Country nvarchar(50)
)

Insert into tblCity values(101, 'Delhi', 'India')
Insert into tblCity values(102, 'London', 'UK')
Insert into tblCity values(103, 'New York', 'US')
Insert into tblCity values(104, 'Tokyo', 'Japan') 



//Create an ASP.NET web application. Drag and drop a DropDownList control onto the webform. Copy and paste the following code in the code behind page. 
protected void Page_Load(object sender, EventArgs e)
{
    if (!IsPostBack)
    {
        string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;s
        using (SqlConnection con = new SqlConnection(CS))
        {
            SqlCommand cmd = new SqlCommand("Select CityId, CityName, Country from tblCity", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            DropDownList1.DataSource = rdr;
            DropDownList1.DataBind();
        }
    }
} 
