This is a demo showing how you can create your own HTML helper to extend the
functionality of MvcSiteMapProvider. This demo creates Previous and Next
HTML helpers that iterate over the SiteMap as if it were a table of contents.

This project was created using the default MVC 4 template with MvcSiteMapProvider installled + the following modifications.

Files Added:

 1. /HtmlHelpers/DocumentNavigationModel.cs
 2. /HtmlHelpers/NextHelper.cs
 3. /HtmlHelpers/PreviousHelper.cs
 4. /Views/Shared/DisplayTemplates/DocumentNavigationModel.cshtml
 5. Several views to make the navigation function under /Views/Home/ (not required to be copied into a real project)

Web.config changes:

 1. Added <add namespace="MvcSiteMapProvider_363.HtmlHelpers"/>
 2. Added <add namespace="MvcSiteMapProvider_363.HtmlHelpers"/> to /Views/Web.config

Modified the /Views/Shared/_Layout.cshtml to display the HTML helpers.
