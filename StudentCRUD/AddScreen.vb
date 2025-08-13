Public Class AddScreen
    Public Property MSSV As String
    Public Property StudentName As String
    Public Property School As String
    Public Property ClassName As String
    Public Property Grade As Double
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