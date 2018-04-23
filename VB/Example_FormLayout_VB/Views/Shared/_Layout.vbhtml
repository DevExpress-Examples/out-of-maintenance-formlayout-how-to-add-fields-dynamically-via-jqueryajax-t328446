<!DOCTYPE html>

<html>
<head>
    <meta charset="UTF-8" />
    <title>@ViewData("Title")</title>

    @Html.DevExpress().GetStyleSheets(
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.GridView}, 
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.CardView}, 
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.PivotGrid}, 
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.HtmlEditor}, 
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.Editors}, 
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout}, 
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.Chart}, 
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.Report},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.Scheduler},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.TreeList},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.RichEdit},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.Spreadsheet},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.SpellChecker})
@Html.DevExpress().GetScripts(
    New Script With {.ExtensionSuite = ExtensionSuite.GridView}, 
    New Script With {.ExtensionSuite = ExtensionSuite.CardView}, 
    New Script With {.ExtensionSuite = ExtensionSuite.PivotGrid}, 
    New Script With {.ExtensionSuite = ExtensionSuite.HtmlEditor}, 
    New Script With {.ExtensionSuite = ExtensionSuite.Editors}, 
    New Script With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout}, 
    New Script With {.ExtensionSuite = ExtensionSuite.Chart}, 
    New Script With {.ExtensionSuite = ExtensionSuite.Report},
    New Script With {.ExtensionSuite = ExtensionSuite.Scheduler},
    New Script With {.ExtensionSuite = ExtensionSuite.TreeList},
    New Script With {.ExtensionSuite = ExtensionSuite.RichEdit},
    New Script With {.ExtensionSuite = ExtensionSuite.Spreadsheet},
    New Script With {.ExtensionSuite = ExtensionSuite.SpellChecker})
</head>

<body>
    @RenderBody()
</body>
</html>