Imports System.Formats.Asn1

Public Class HomeScreen
    ' Dữ liệu cố định
    Private Shared ReadOnly Students As (String, String, String, String, Double)() = {
    ("SV001", "Nguyen Van A", "DUT", "IT01", 8.5),
    ("SV002", "Tran Thi B", "DUT", "IT02", 7.8),
    ("SV003", "Le Van C", "DUT", "IT01", 9.0),
    ("SV004", "Pham Thi D", "DUT", "IT03", 8.2),
    ("SV005", "Hoang Van E", "DUT", "IT02", 7.5)
}

    Private dt As New DataTable()

    Private Sub loadData()
        Try
            dt.Columns.Add("MSSV", GetType(String))
            dt.Columns.Add("Name", GetType(String))
            dt.Columns.Add("School", GetType(String))
            dt.Columns.Add("Class", GetType(String))
            dt.Columns.Add("Grade", GetType(Double))

            For Each s In Students
                dt.Rows.Add(s.Item1, s.Item2, s.Item3, s.Item4, s.Item5)
            Next

            DataGridView.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub HomeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim form As New AddScreen()
        form.IsUpdate = False
        If form.ShowDialog() = DialogResult.OK Then
            dt.Rows.Add(form.MSSV, form.StudentName, form.School, form.ClassName, form.Grade)
        End If
    End Sub

    ' Nút xóa
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If DataGridView.CurrentRow IsNot Nothing Then
            DataGridView.Rows.Remove(DataGridView.CurrentRow)
        End If
    End Sub

    ' Nút sửa
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If DataGridView.CurrentRow IsNot Nothing Then
            MessageBox.Show("Please select a student to update.", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Dim selectedRow As DataGridViewRow = DataGridView.CurrentRow
        Dim form As New AddScreen With {
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

    ' Sửa nếu double click vào cell
    Private Sub DataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView.CurrentRow
            Dim form As New AddScreen With {
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
        txt_school.Text = ""
        txt_classname.Text = ""
        txt_grade.Text = ""
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim filters As New List(Of String)
        ' Tránh phân biệt hoa/thường
        dt.CaseSensitive = False

        ' Nếu người dùng nhập dữ liệu vào textbox nào thì thêm vào filter
        If txt_name.Text.Trim() <> "" Then
            filters.Add($"Name LIKE '%{txt_name.Text.Trim()}%'")
        End If

        If txt_classname.Text.Trim() <> "" Then
            filters.Add($"Class LIKE '%{txt_classname.Text.Trim()}%'")
        End If

        If txt_school.Text.Trim() <> "" Then
            filters.Add($"School LIKE '%{txt_school.Text.Trim()}%'")
        End If

        If txt_grade.Text.Trim() <> "" Then
            filters.Add($"Convert(Grade, 'System.String') LIKE '%{txt_grade.Text.Trim()}%'")
        End If

        ' Ghép điều kiện với AND
        Dim filter As String = String.Join(" AND ", filters)

        If filter = "" Then
            ' Nếu tất cả ô tìm kiếm trống => hiện lại toàn bộ dữ liệu
            DataGridView.DataSource = dt
            Return
        End If

        ' Lọc dữ liệu
        Dim rows() As DataRow = dt.Select(filter)

        If rows.Length > 0 Then
            Dim dtResult As DataTable = dt.Clone()
            For Each r As DataRow In rows
                dtResult.ImportRow(r)
            Next
            DataGridView.DataSource = dtResult
        Else
            MessageBox.Show("Không tìm thấy kết quả.")
        End If

    End Sub

End Class
