<!-- <?xml version="1.0" encoding="utf-8" ?>
<Countries>
  <Country>
    <CountryId>101</CountryId>
    <CountryName>India</CountryName>
  </Country>
  <Country>
    <CountryId>102</CountryId>
    <CountryName>US</CountryName>
  </Country>
  <Country>
    <CountryId>103</CountryId>
    <CountryName>Australia</CountryName>
  </Country>
  <Country>
    <CountryId>104</CountryId>
    <CountryName>UK</CountryName>
  </Country>
</Countries> 

 -->


protected void Page_Load(object sender, EventArgs e)
{
    if (!IsPostBack)
    {
        //Create a new DataSet
        DataSet DS = new DataSet();
        //Read the xml data from the XML file using ReadXml() method
        DS.ReadXml(Server.MapPath("Countries.xml"));
        DropDownList1.DataTextField = "CountryName";
        DropDownList1.DataValueField = "CountryId";
        DropDownList1.DataSource = DS;
        DropDownList1.DataBind();
        ListItem li = new ListItem("Select", "-1");
        DropDownList1.Items.Insert(0, li);
    }
}
