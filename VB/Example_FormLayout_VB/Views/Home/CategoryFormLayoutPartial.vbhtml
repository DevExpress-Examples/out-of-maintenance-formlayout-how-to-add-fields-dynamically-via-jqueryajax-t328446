

@ModelType  Example_FormLayout_VB.Category


@Html.DevExpress().FormLayout(Sub(settings)
                                       settings.Name = "FormLayout"
                                       settings.RequiredMarkDisplayMode = RequiredMarkMode.None
                                       settings.Items.Add(Function(m) m.ID, Sub(s)
                                                                                s.NestedExtensionType = FormLayoutNestedExtensionItemType.TextBox
                                                                                Dim ts As TextBoxSettings = s.NestedExtensionSettings
                                                                            End Sub)

                                       settings.Items.Add(Function(m) m.Name, Sub(s)
                                                                                  s.NestedExtensionType = FormLayoutNestedExtensionItemType.TextBox
                                                                                  Dim ts As TextBoxSettings = s.NestedExtensionSettings
                                                                              End Sub)

                                       settings.Items.Add(Sub(s)
                                                              s.Caption = ""
                                                              s.ShowCaption = DefaultBoolean.False
                                                              s.SetNestedContent(Sub()
                                                                                     Html.DevExpress().Button(Sub(bt)
                                                                                                                  bt.Name = "AddButton"
                                                                                                                  bt.Text = "Add a product field"
                                                                                                                  bt.ClientSideEvents.Click = String.Format("function(s,e) {{ AddProd(s,e,{0}); }}", Model.Products.Count - 1)
                                                                                                              End Sub).Render()
                                                                                 End Sub)
                                                          End Sub)

                                       For i As Integer = 0 To Model.Products.Count - 1
                                           Dim index As Integer = i
                                           settings.Items.Add(Sub(s)
                                                                  s.Caption = "Product " + index.ToString()
                                                                  s.SetNestedContent(Sub()
                                                                                         Html.DevExpress().ButtonEditFor(Function(m) m.Products(index).ProductName, Sub(be)
                                                                                                                                                                        be.Properties.Buttons.Add("x")
                                                                                                                                                                        be.Properties.ClientSideEvents.ButtonClick = String.Format("function(s,e) {{ OnButtonClick(s,e,{0}); }}", index)
                                                                                                                                                                    End Sub).Render()
                                                                                     End Sub)
                                                              End Sub)
                                       Next
                                   End Sub).Bind(dataObject:=Model).GetHtml()


