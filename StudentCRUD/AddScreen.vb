Public Class AddScreen
    Public Property MSSV As String
    Public Property StudentName As String
    Public Property School As String
    Public Property ClassName As String
    Public Property Grade As Double

    Public Property IsUpdate As Boolean = False

    Private Sub AddScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsUpdate Then
            txt_mssv.Text = MSSV
            txt_studentname.Text = StudentName
            txt_classname.Text = ClassName
            txt_school.Text = School
            txt_grade.Text = Grade.ToString()
            txt_mssv.Enabled = False
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        MSSV = txt_mssv.Text
        StudentName = txt_studentname.Text
        School = txt_classname.Text
        ClassName = txt_school.Text
        Double.TryParse(txt_grade.Text, Grade)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

End Class