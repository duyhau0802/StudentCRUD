Module ValidationHelper
    Public Function ValidateRequired(value As String, fieldName As String) As Boolean
        If String.IsNullOrWhiteSpace(value) Then
            MessageBox.Show(fieldName & " không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Public Function ValidateGrade(value As String) As Boolean
        Dim trimmedValue As String = value.Trim()
        If String.IsNullOrEmpty(trimmedValue) Then
            Return True
        End If
        Dim gradeValue As Double
        If Not String.IsNullOrEmpty(value) Then
            If Not Double.TryParse(value, gradeValue) Then
                MessageBox.Show("Giá trị Grade phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            If gradeValue < 0 OrElse gradeValue > 10 Then
                MessageBox.Show("Grade phải >= 0 và <= 10", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
        End If
        Return True
    End Function
    Public Function GenerateMSSV(schoolName As String, rowCount As Integer)
        Dim newMSSV As String = $"{schoolName}{(rowCount + 1):D3}"
        Return newMSSV
    End Function
End Module
