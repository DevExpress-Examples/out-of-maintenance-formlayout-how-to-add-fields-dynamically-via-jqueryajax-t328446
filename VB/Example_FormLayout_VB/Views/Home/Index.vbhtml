﻿
<script>
    function OnButtonClick(s, e, index) {
            var str = "remove;" + index;
            $.ajax({
                url: '@Url.Action("CategoryFormLayoutPartial", "Home")',
                type: "GET",
                success: function (data) {
                    $('#ajaxDiv').html(data);
                },
                data: { command: str },
                error: function (xhr, textStatus, errorThrown) {
                    alert('Request Status: ' + xhr.status + '; Status Text: ' + textStatus + '; Error: ' + errorThrown);
                }
            });
    }
    function AddProd(s, e,index) {
        var str = "add;" + index;
        $.ajax({
            url: '@Url.Action("CategoryFormLayoutPartial", "Home")',
               type: "GET",
               success: function (data) {
                   $('#ajaxDiv').html(data);
               },
               data: { command: str },
               error: function (xhr, textStatus, errorThrown) {
                   alert('Request Status: ' + xhr.status + '; Status Text: ' + textStatus + '; Error: ' + errorThrown);
               }
           });
    }
</script>
<div id="ajaxDiv">
    @Html.Partial("CategoryFormLayoutPartial")
</div>
