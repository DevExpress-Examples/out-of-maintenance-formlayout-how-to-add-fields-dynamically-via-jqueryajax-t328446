
<script>
    var initialState;
    let propName = "Products";
    var staticEditorsCount = 2;//there are two static edtitors ID and Name
    function storeValues() {
        initialState = ASPxClientUtils.GetEditorValuesInContainer(FormLayout.GetMainElement());
    }

    function restoreValues(action) {
        if (action == "remove") {
            var currentState = ASPxClientUtils.GetEditorValuesInContainer(FormLayout.GetMainElement());
            var values = Object.values(initialState);
            var i = 0;
            Object.keys(currentState).forEach(function (key) {
                currentState[key] = values[i];
                i++;
            });
            ASPxClientUtils.SetEditorValues(currentState);
        }
        if (action == "add") {
            ASPxClientUtils.SetEditorValues(initialState);
        }
    }
    function OnButtonClick(s, e, index) {
        storeValues();
        delete initialState[propName + "[" + index + "].ProductName"];
        var str = "remove;" + index;
        $.ajax({
            url: '@Url.Action("CategoryFormLayoutPartial", "Home")',
            type: "GET",
            success: function (data) {
                $('#ajaxDiv').html(data);
                restoreValues("remove");

            },
            data: { command: str },
            error: function (xhr, textStatus, errorThrown) {
                alert('Request Status: ' + xhr.status + '; Status Text: ' + textStatus + '; Error: ' + errorThrown);
            }
        });
    }
    function AddProd(s, e, index) {
        storeValues();
        var str = "add;" + index;
        $.ajax({
            url: '@Url.Action("CategoryFormLayoutPartial", "Home")',
            type: "GET",
            success: function (data) {
                $('#ajaxDiv').html(data);
                restoreValues("add");
            },
            data: { command: str },
            error: function (xhr, textStatus, errorThrown) {
                alert('Request Status: ' + xhr.status + '; Status Text: ' + textStatus + '; Error: ' + errorThrown);
            }
        });
    }
</script>
@Using Html.BeginForm()
    @<input type="submit" value="post" />
    @<div id="ajaxDiv">
        @Html.Partial("CategoryFormLayoutPartial")
    </div>
End Using

