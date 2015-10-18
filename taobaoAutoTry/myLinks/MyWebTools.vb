Public Class MyWebTools

    ''' <summary>
    ''' 插入脚本元素
    ''' </summary>
    ''' <param name="webbrower"></param>
    ''' <param name="src"></param>
    ''' <param name="text"></param>
    ''' <remarks></remarks>
    Shared Sub insertScriptEle(ByVal webbrower As WebBrowser, Optional ByVal src As String = "", Optional ByVal text As String = "")

        Dim eleT = webbrower.Document.CreateElement("script")

        If Not String.IsNullOrEmpty(src) Then

            eleT.SetAttribute("src", src)


        End If

        If Not String.IsNullOrEmpty(text) Then

            eleT.SetAttribute("text", text)


        End If

        webbrower.Document.Body.AppendChild(eleT)


    End Sub

    Shared Sub insertJqueryEle(ByVal webbrower As WebBrowser)

        insertScriptEle(webbrower, "http://apps.bdimg.com/libs/jquery/2.1.1/jquery.min.js")


    End Sub




End Class
