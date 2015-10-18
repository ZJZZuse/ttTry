Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Threading
Imports Newtonsoft.Json

Public Class Form1

    Dim s As Object

    Property keyWord = "键盘"

    Private taobaoItems As New ArrayList

    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。


        DataGridViewItems.DataSource = taobaoItems


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub WebBrowserMain_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowserMain.DocumentCompleted

    End Sub

    Private Sub ButtonLoadScript_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLoadScript.Click

        MyWebTools.insertJqueryEle(WebBrowserMain)


        MyWebTools.insertScriptEle(WebBrowserMain, , "alert(1)")


    End Sub

    Private Sub ButtonGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGet.Click

        If String.IsNullOrEmpty(keyWord) Then

            Exit Sub

        End If



        Dim req As HttpWebRequest = HttpWebRequest.Create(String.Format("https://try.taobao.com/item/newItemList.htm?tab=0&page=1&q={0}%20&_input_charset=utf-8", keyWord))

        req.Method = "get"





        Using response As HttpWebResponse = req.GetResponse()


            'Dim s = r.GetResponseStream()

            Dim stream = response.GetResponseStream()
            Dim sr = New StreamReader(stream)
            Dim html = sr.ReadToEnd()

            '

            Dim objT As Newtonsoft.Json.Linq.JObject = JsonConvert.DeserializeObject(html)

            Dim itemsS As Newtonsoft.Json.Linq.JArray = objT.Item("below").Item("data")

            For i = 0 To itemsS.Count - 1

                Dim itemT = itemsS.Item(i)

                Dim itemS = New TaobaoItem

                itemS.currentPrice = itemT.Value(Of Double)("currentPrice")
                itemS.itemDetailUrl = itemT.Value(Of String)("itemDetailUrl")
                itemS.title = System.Text.UTF8Encoding .UTF8 .(itemT.Value(Of String)("title"))


                taobaoItems.Add(itemS)

            Next




        End Using





    End Sub

  

    Private Sub TaobaoItemBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewItems.CellContentClick

    End Sub

    Private Sub TextBoxKeyWords_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxKeyWords.TextChanged
        keyWord = sender.Text
    End Sub
End Class
