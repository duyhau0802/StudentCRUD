<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label2 = New Label()
        txt_classname = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        txt_grade = New TextBox()
        Label5 = New Label()
        btn_save = New Button()
        Label1 = New Label()
        txt_mssv = New TextBox()
        cbb_school = New ComboBox()
        txt_studentname = New TextBox()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(51, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 2
        Label2.Text = "Name"
        ' 
        ' txt_classname
        ' 
        txt_classname.Location = New Point(107, 150)
        txt_classname.Name = "txt_classname"
        txt_classname.Size = New Size(154, 23)
        txt_classname.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(51, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 15)
        Label3.TabIndex = 6
        Label3.Text = "Class"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(51, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 15)
        Label4.TabIndex = 4
        Label4.Text = "School"
        ' 
        ' txt_grade
        ' 
        txt_grade.Location = New Point(107, 189)
        txt_grade.Name = "txt_grade"
        txt_grade.Size = New Size(154, 23)
        txt_grade.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(51, 192)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 15)
        Label5.TabIndex = 8
        Label5.Text = "Grade"
        ' 
        ' btn_save
        ' 
        btn_save.Location = New Point(137, 240)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(93, 29)
        btn_save.TabIndex = 10
        btn_save.Text = "Save"
        btn_save.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(51, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 15)
        Label1.TabIndex = 0
        Label1.Text = "MSSV"
        ' 
        ' txt_mssv
        ' 
        txt_mssv.Enabled = False
        txt_mssv.Location = New Point(107, 31)
        txt_mssv.Name = "txt_mssv"
        txt_mssv.Size = New Size(154, 23)
        txt_mssv.TabIndex = 1
        ' 
        ' cbb_school
        ' 
        cbb_school.FormattingEnabled = True
        cbb_school.Location = New Point(107, 114)
        cbb_school.Name = "cbb_school"
        cbb_school.Size = New Size(154, 23)
        cbb_school.TabIndex = 11
        ' 
        ' txt_studentname
        ' 
        txt_studentname.Location = New Point(107, 73)
        txt_studentname.Name = "txt_studentname"
        txt_studentname.Size = New Size(156, 23)
        txt_studentname.TabIndex = 0
        ' 
        ' AddScreen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(343, 300)
        Controls.Add(txt_studentname)
        Controls.Add(cbb_school)
        Controls.Add(btn_save)
        Controls.Add(txt_grade)
        Controls.Add(Label5)
        Controls.Add(txt_classname)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(txt_mssv)
        Controls.Add(Label1)
        Name = "AddScreen"
        Text = "AddScreen"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_classname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_grade As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_mssv As TextBox
    Friend WithEvents cbb_school As ComboBox
    Friend WithEvents txt_studentname As TextBox
End Class
