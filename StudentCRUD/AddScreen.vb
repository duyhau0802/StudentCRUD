Public Class AddScreen
    Public Property MSSV As String
    Public Property StudentName As String
    Public Property School As String
    Public Property ClassName As String
    Public Property Grade As Double
    Public Property RowCount As Integer
    Public Property SchoolNames As String()
    Public Property IsUpdate As Boolean = False

    Private Sub AddScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsUpdate Then
            txt_mssv.Text = MSSV
            txt_studentname.Text = StudentName
            txt_classname.Text = ClassName
            cbb_school.Text = School
            txt_grade.Text = Grade.ToString()
            txt_mssv.Enabled = False
        End If
        For Each schoolName In SchoolNames
            cbb_school.Items.Add(schoolName)
        Next
        cbb_school.SelectedIndex = 0
        ' Thiết lập nút Save là nút mặc định khi nhấn Enter
        Me.AcceptButton = btn_save
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        StudentName = txt_studentname.Text
        School = cbb_school.Text
        ClassName = txt_classname.Text
        If Not ValidateRequired(txt_studentname.Text, "Tên") Then Exit Sub
        If Not ValidateRequired(cbb_school.Text, "Trường") Then Exit Sub
        If Not ValidateRequired(txt_classname.Text, "Lớp") Then Exit Sub
        If Not ValidateGrade(txt_grade.Text) Then
            Exit Sub
        Else
            Dim gradeValue As Double
            If Not String.IsNullOrEmpty(txt_grade.Text) Then
                Double.TryParse(txt_grade.Text, gradeValue)
                Grade = gradeValue
            Else
                Grade = 0.0 ' Default value if grade is empty
            End If
        End If
        Dim gradeKeyword As String = txt_grade.Text.Trim()
        If Not IsUpdate Then
            MSSV = GenerateMSSV(cbb_school.Text, RowCount)
            MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Dim result As DialogResult = MessageBox.Show(
            "Bạn có chắc muốn cập nhật" & StudentName & " không?",
            "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                MessageBox.Show("Đã cập nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

End Class