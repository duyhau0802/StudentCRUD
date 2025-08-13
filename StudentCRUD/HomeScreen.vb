Imports System.Formats.Asn1

Public Class HomeScreen
    ' Dữ liệu cố định
    ' Shared : giống static trong C#
    ' ReadOnly : giống const trong C#, chỉ đc gán giá trị 1 lần duy nhất
    Private Shared ReadOnly Students As (String, String, String, String, Double)() = {
    ("SV001", "Nguyen Van A", "DUT", "IT01", 8.5),
    ("SV002", "Tran Thi B", "DUT", "IT02", 7.8),
    ("SV003", "Le Van C", "DUT", "IT01", 9.0),
    ("SV004", "Pham Thi D", "DUT", "IT03", 8.2),
    ("SV005", "Hoang Van E", "DUT", "IT02", 7.5),
    ("SV006", "Nguyen Van F", "DUE", "MKT01", 8.8),
    ("SV007", "Tran Thi G", "DUE", "ACC02", 9.1),
    ("SV008", "Le Van H", "UFL", "ENG01", 7.9),
    ("SV009", "Pham Thi I", "UED", "PHY01", 8.6),
    ("SV010", "Hoang Van K", "UED", "CHE02", 8.9),
    ("SV011", "Nguyen Van L", "VKU", "CSE01", 9.2),
    ("SV012", "Tran Thi M", "DAD", "ARCH01", 8.0),
    ("SV013", "Le Van N", "KTD", "ARCH02", 8.7),
    ("SV014", "Pham Thi O", "FPT", "KDL01", 8.4),
    ("SV015", "Hoang Van P", "DUE", "MKT02", 9.5)
}
    Private Shared ReadOnly SchoolNames As String() = {"DUT", "DUE", "UFL", "UED", "VKU"}

    Private dt As New DataTable()
    Private _rowCount As Integer

    Private Sub loadData()
        dt.Columns.Add("MSSV", GetType(String))
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("School", GetType(String))
        dt.Columns.Add("Class", GetType(String))
        dt.Columns.Add("Grade", GetType(Double))
        For Each s In Students
            dt.Rows.Add(s.Item1, s.Item2, s.Item3, s.Item4, s.Item5)
        Next
        For Each schoolName In SchoolNames
            cbb_school.Items.Add(schoolName)
        Next
        cbb_school.SelectedIndex = 0
        DataGridView.DataSource = dt
        _rowCount = dt.Rows.Count
    End Sub

    Private Sub HomeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim form As New AddScreen()
        form.IsUpdate = False
        form.RowCount = _rowCount
        form.SchoolNames = SchoolNames
        If form.ShowDialog() = DialogResult.OK Then
            dt.Rows.Add(form.MSSV, form.StudentName, form.School, form.ClassName, form.Grade)
        End If
        If dt.Rows.Count > 0 Then
            Dim lastIndex As Integer = dt.Rows.Count - 1
            DataGridView.ClearSelection()
            DataGridView.Rows(lastIndex).Selected = True
            DataGridView.FirstDisplayedScrollingRowIndex = lastIndex
        End If

    End Sub

    ' Nút xóa
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim studentName As String = DataGridView.CurrentRow.Cells("Name").Value?.ToString()
        If DataGridView.CurrentRow IsNot Nothing Then
            Dim result As DialogResult = MessageBox.Show(
            "Bạn có chắc muốn xóa sinh viên" & studentName & " không?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

            If result = DialogResult.Yes Then
                DataGridView.Rows.Remove(DataGridView.CurrentRow)
                MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Không có dòng nào được chọn để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Nút sửa
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If DataGridView.CurrentRow Is Nothing Then
            MessageBox.Show("Vui lòng chọn một sinh viên để cập nhật.", "Cập nhật Sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim selectedRow As DataGridViewRow = DataGridView.CurrentRow
        Dim form As New AddScreen With {
            .RowCount = _rowCount,
            .SchoolNames = SchoolNames,
            .MSSV = selectedRow.Cells("MSSV").Value.ToString(),
            .StudentName = selectedRow.Cells("Name").Value.ToString(),
            .School = selectedRow.Cells("School").Value.ToString(),
            .ClassName = selectedRow.Cells("Class").Value.ToString(),
            .Grade = Convert.ToDouble(selectedRow.Cells("Grade").Value),
            .IsUpdate = True
        }
        If form.ShowDialog() = DialogResult.OK Then
            selectedRow.Cells("MSSV").Value = form.MSSV
            selectedRow.Cells("Name").Value = form.StudentName
            selectedRow.Cells("School").Value = form.School
            selectedRow.Cells("Class").Value = form.ClassName
            selectedRow.Cells("Grade").Value = form.Grade
        End If
    End Sub

    'Nếu double click vào cell thì mở form Update
    Private Sub DataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView.CurrentRow
            Dim form As New AddScreen With {
                .RowCount = _rowCount,
                .SchoolNames = SchoolNames,
                .MSSV = selectedRow.Cells("MSSV").Value.ToString(),
                .StudentName = selectedRow.Cells("Name").Value.ToString(),
                .School = selectedRow.Cells("School").Value.ToString(),
                .ClassName = selectedRow.Cells("Class").Value.ToString(),
                .Grade = Convert.ToDouble(selectedRow.Cells("Grade").Value),
                .IsUpdate = True
            }
            If form.ShowDialog() = DialogResult.OK Then
                selectedRow.Cells("MSSV").Value = form.MSSV
                selectedRow.Cells("Name").Value = form.StudentName
                selectedRow.Cells("School").Value = form.School
                selectedRow.Cells("Class").Value = form.ClassName
                selectedRow.Cells("Grade").Value = form.Grade
            End If
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_name.Text = ""
        cbb_school.Text = ""
        txt_classname.Text = ""
        txt_grade.Text = ""
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim nameKeyword As String = txt_name.Text.Trim().ToLower()
        Dim schoolKeyword As String = cbb_school.Text.Trim().ToLower()
        Dim classKeyword As String = txt_classname.Text.Trim().ToLower()
        Dim gradeKeyword As String = txt_grade.Text.Trim()

        If Not ValidateGrade(txt_grade.Text) Then
            Exit Sub
        End If

        Dim fileterRows = dt.AsEnumerable().Where(Function(row) _
            (String.IsNullOrEmpty(nameKeyword) OrElse row.Field(Of String)("Name").ToLower().Contains(nameKeyword)) AndAlso
            (String.IsNullOrEmpty(classKeyword) OrElse row.Field(Of String)("Class").ToLower().Contains(classKeyword)) AndAlso
            (String.IsNullOrEmpty(schoolKeyword) OrElse row.Field(Of String)("School").ToLower().Contains(schoolKeyword)) AndAlso
            (String.IsNullOrEmpty(gradeKeyword) OrElse
            (Double.TryParse(gradeKeyword, Nothing) AndAlso row.Field(Of Double)("Grade") = Convert.ToDouble(gradeKeyword)))
       )

        If fileterRows.Any() Then
            DataGridView.DataSource = fileterRows.CopyToDataTable()
        Else
            MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

End Class
