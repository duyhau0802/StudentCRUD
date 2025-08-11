<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btn_add = New Button()
        Label1 = New Label()
        txt_name = New TextBox()
        txt_school = New TextBox()
        Label2 = New Label()
        txt_class = New TextBox()
        Label3 = New Label()
        txt_grade = New TextBox()
        Label5 = New Label()
        btn_delete = New Button()
        btn_update = New Button()
        btn_search = New Button()
        btn_clear = New Button()
        DataGridView = New DataGridView()
        ListView1 = New ListView()
        CType(DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_add
        ' 
        btn_add.Location = New Point(27, 25)
        btn_add.Name = "btn_add"
        btn_add.Size = New Size(72, 32)
        btn_add.TabIndex = 0
        btn_add.Text = "Add"
        btn_add.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 1
        Label1.Text = "Name"
        ' 
        ' txt_name
        ' 
        txt_name.Location = New Point(82, 74)
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(108, 27)
        txt_name.TabIndex = 2
        ' 
        ' txt_school
        ' 
        txt_school.Location = New Point(287, 74)
        txt_school.Name = "txt_school"
        txt_school.Size = New Size(108, 27)
        txt_school.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(224, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 3
        Label2.Text = "School"
        ' 
        ' txt_class
        ' 
        txt_class.Location = New Point(483, 74)
        txt_class.Name = "txt_class"
        txt_class.Size = New Size(108, 27)
        txt_class.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(442, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 20)
        Label3.TabIndex = 5
        Label3.Text = "Class"
        ' 
        ' txt_grade
        ' 
        txt_grade.Location = New Point(680, 71)
        txt_grade.Name = "txt_grade"
        txt_grade.Size = New Size(108, 27)
        txt_grade.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(625, 78)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 20)
        Label5.TabIndex = 9
        Label5.Text = "Grade"
        ' 
        ' btn_delete
        ' 
        btn_delete.Location = New Point(541, 406)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(72, 32)
        btn_delete.TabIndex = 11
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = True
        ' 
        ' btn_update
        ' 
        btn_update.Location = New Point(660, 406)
        btn_update.Name = "btn_update"
        btn_update.Size = New Size(72, 32)
        btn_update.TabIndex = 12
        btn_update.Text = "Update"
        btn_update.UseVisualStyleBackColor = True
        ' 
        ' btn_search
        ' 
        btn_search.Location = New Point(541, 121)
        btn_search.Name = "btn_search"
        btn_search.Size = New Size(72, 32)
        btn_search.TabIndex = 13
        btn_search.Text = "Search"
        btn_search.UseVisualStyleBackColor = True
        ' 
        ' btn_clear
        ' 
        btn_clear.Location = New Point(660, 121)
        btn_clear.Name = "btn_clear"
        btn_clear.Size = New Size(72, 32)
        btn_clear.TabIndex = 14
        btn_clear.Text = "Clear"
        btn_clear.UseVisualStyleBackColor = True
        ' 
        ' DataGridView
        ' 
        DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView.Location = New Point(27, 171)
        DataGridView.Name = "DataGridView"
        DataGridView.RowHeadersWidth = 51
        DataGridView.Size = New Size(705, 199)
        DataGridView.TabIndex = 15
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(82, 121)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(150, 45)
        ListView1.TabIndex = 16
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' HomeScreen
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ListView1)
        Controls.Add(DataGridView)
        Controls.Add(btn_clear)
        Controls.Add(btn_search)
        Controls.Add(btn_update)
        Controls.Add(btn_delete)
        Controls.Add(txt_grade)
        Controls.Add(Label5)
        Controls.Add(txt_class)
        Controls.Add(Label3)
        Controls.Add(txt_school)
        Controls.Add(Label2)
        Controls.Add(txt_name)
        Controls.Add(Label1)
        Controls.Add(btn_add)
        Name = "HomeScreen"
        Text = "HomeScreen"
        CType(DataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_add As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_school As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_class As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_grade As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents ListView1 As ListView

End Class
