using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcSiteMapProvider;
using MvcSiteMapProvider.Web.Html.Models;

namespace MvcSiteMapProvider_363.HtmlHelpers
{
    public class DocumentNavigationModel
    {
        public DocumentNavigationModel(ISiteMapNode node, string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentNullException("text");

            this.Node = node;
            this.Text = text;
        }

        public ISiteMapNode Node { get; private set; }
        public string Text { get; private set; }
    }
}