// You can give validate input(false) for your post method to allow ck editor content in the class object:

[HttpPost]   
[ValidateInput(false)]  

public ActionResult SaveArticle(ArticleModel model)
{
    return view();
}
// In M V C 3 you can also define your model property with html content as [Allow Html]

public class Article Model 
{
    [AllowHtml]

    public string Some Property { get; set; }

    public string Some Other Property { get; set; }
}