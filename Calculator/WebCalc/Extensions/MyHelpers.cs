using System.Web.Mvc;

namespace WebCalc.Extensions
{
    public static class MyHelpers
    {
        public static MvcHtmlString ListerFlat(this HtmlHelper html, string[] items)
        {
            var ul = new TagBuilder("ul");
            foreach (var item in items)
            {
                var li = new TagBuilder("li");
                li.InnerHtml = item;

                ul.InnerHtml += li;
            }
            return MvcHtmlString.Create(ul.ToString());
        }

    }
}