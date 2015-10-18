<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.WebBrowserMain = New System.Windows.Forms.WebBrowser()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridViewItems = New System.Windows.Forms.DataGridView()
        Me.ButtonGet = New System.Windows.Forms.Button()
        Me.ButtonLoadScript = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxKeyWords = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDetailUrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Form1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TaobaoItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Form1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.Form1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaobaoItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebBrowserMain
        '
        Me.WebBrowserMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowserMain.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowserMain.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserMain.Name = "WebBrowserMain"
        Me.WebBrowserMain.Size = New System.Drawing.Size(595, 253)
        Me.WebBrowserMain.TabIndex = 0
        Me.WebBrowserMain.Url = New System.Uri("https://try.taobao.com/?spm=a21bo.7724922.8374-3.2.dDmRQL", System.UriKind.Absolute)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(609, 285)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridViewItems)
        Me.TabPage2.Controls.Add(Me.ButtonGet)
        Me.TabPage2.Controls.Add(Me.ButtonLoadScript)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.TextBoxKeyWords)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(601, 259)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridViewItems
        '
        Me.DataGridViewItems.AllowUserToAddRows = False
        Me.DataGridViewItems.AllowUserToDeleteRows = False
        Me.DataGridViewItems.AllowUserToOrderColumns = True
        Me.DataGridViewItems.AutoGenerateColumns = False
        Me.DataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TitleDataGridViewTextBoxColumn, Me.ItemDetailUrlDataGridViewTextBoxColumn, Me.CurrentPriceDataGridViewTextBoxColumn})
        Me.DataGridViewItems.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.Form1BindingSource1, "AutoSizeMode", True))
        Me.DataGridViewItems.DataSource = Me.TaobaoItemBindingSource
        Me.DataGridViewItems.Dock = System.Windows.Forms.DockStyle.Left
        Me.DataGridViewItems.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewItems.Name = "DataGridViewItems"
        Me.DataGridViewItems.ReadOnly = True
        Me.DataGridViewItems.RowTemplate.Height = 23
        Me.DataGridViewItems.Size = New System.Drawing.Size(250, 253)
        Me.DataGridViewItems.TabIndex = 9
        '
        'ButtonGet
        '
        Me.ButtonGet.Location = New System.Drawing.Point(439, 7)
        Me.ButtonGet.Name = "ButtonGet"
        Me.ButtonGet.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGet.TabIndex = 8
        Me.ButtonGet.Text = "get"
        Me.ButtonGet.UseVisualStyleBackColor = True
        '
        'ButtonLoadScript
        '
        Me.ButtonLoadScript.Location = New System.Drawing.Point(270, 199)
        Me.ButtonLoadScript.Name = "ButtonLoadScript"
        Me.ButtonLoadScript.Size = New System.Drawing.Size(131, 23)
        Me.ButtonLoadScript.TabIndex = 7
        Me.ButtonLoadScript.Text = "load script"
        Me.ButtonLoadScript.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(464, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxKeyWords
        '
        Me.TextBoxKeyWords.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Form1BindingSource, "keyWord", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxKeyWords.Location = New System.Drawing.Point(270, 7)
        Me.TextBoxKeyWords.Name = "TextBoxKeyWords"
        Me.TextBoxKeyWords.Size = New System.Drawing.Size(131, 21)
        Me.TextBoxKeyWords.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WebBrowserMain)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(601, 259)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemDetailUrlDataGridViewTextBoxColumn
        '
        Me.ItemDetailUrlDataGridViewTextBoxColumn.DataPropertyName = "itemDetailUrl"
        Me.ItemDetailUrlDataGridViewTextBoxColumn.HeaderText = "itemDetailUrl"
        Me.ItemDetailUrlDataGridViewTextBoxColumn.Name = "ItemDetailUrlDataGridViewTextBoxColumn"
        Me.ItemDetailUrlDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CurrentPriceDataGridViewTextBoxColumn
        '
        Me.CurrentPriceDataGridViewTextBoxColumn.DataPropertyName = "currentPrice"
        Me.CurrentPriceDataGridViewTextBoxColumn.HeaderText = "currentPrice"
        Me.CurrentPriceDataGridViewTextBoxColumn.Name = "CurrentPriceDataGridViewTextBoxColumn"
        Me.CurrentPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Form1BindingSource1
        '
        Me.Form1BindingSource1.DataSource = GetType(taobaoAutoTry.Form1)
        '
        'TaobaoItemBindingSource
        '
        Me.TaobaoItemBindingSource.DataSource = GetType(taobaoAutoTry.TaobaoItem)
        '
        'Form1BindingSource
        '
        Me.Form1BindingSource.DataSource = GetType(taobaoAutoTry.Form1)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 285)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridViewItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Form1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaobaoItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebBrowserMain As System.Windows.Forms.WebBrowser
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBoxKeyWords As System.Windows.Forms.TextBox
    Friend WithEvents ButtonLoadScript As System.Windows.Forms.Button
    Friend WithEvents ButtonGet As System.Windows.Forms.Button
    Friend WithEvents DataGridViewItems As System.Windows.Forms.DataGridView
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDetailUrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaobaoItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Form1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Form1BindingSource1 As System.Windows.Forms.BindingSource

End Class
