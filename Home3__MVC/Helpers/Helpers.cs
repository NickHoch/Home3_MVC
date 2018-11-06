using System.Web.Mvc;

namespace Home3__MVC.Helpers
{
    public static class Helpers
    {
        public static MvcHtmlString NumericUpDown(this HtmlHelper htmlHelper, string min, string max, string value)
        {
            TagBuilder tag = new TagBuilder("input");
            tag.MergeAttribute("min", min);
            tag.MergeAttribute("max", max);
            tag.MergeAttribute("value", value);
            tag.AddCssClass("numericUpDown");
            return new MvcHtmlString(tag.ToString());
        }
        public static MvcHtmlString Button(this HtmlHelper htmlHelper, string id, string price, string url, string innerHtml)
        {
            TagBuilder tag = new TagBuilder("button");
            tag.MergeAttribute("data-id", id);
            tag.MergeAttribute("data-price", price);
            tag.MergeAttribute("data-url", url);
            tag.InnerHtml = innerHtml;
            return new MvcHtmlString(tag.ToString());
        }

        public static MvcHtmlString EditorForEmail(this HtmlHelper htmlHelper, string url)
        {
            TagBuilder tag = new TagBuilder("input");
            tag.MergeAttribute("class", "text-box single-line");
            tag.MergeAttribute("data-val", "true");
            tag.MergeAttribute("data-val-email", "Email is no valid");
            tag.MergeAttribute("data-val-required", "Please enter email");
            tag.MergeAttribute("id", "Email");
            tag.MergeAttribute("name", "Email");
            tag.MergeAttribute("type", "email");
            tag.MergeAttribute("value", "");
            tag.MergeAttribute("data-url", url);

            return new MvcHtmlString(tag.ToString());
        }
    }
}