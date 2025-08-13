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
        If form.ShowDialog() = DialogResult.OK Then
            dt.Rows.Add(form.MSSV, form.StudentName, form.School, form.ClassName, form.Grade)
        End If
    End Sub


    ' Load data into the DataGridView when the form loads






    ' Nút xóa
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If DataGridView.CurrentRow IsNot Nothing Then
            DataGridView.Rows.Remove(DataGridView.CurrentRow)
        End If
    End Sub

    ' Nút sửa
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If DataGridView.CurrentRow IsNot Nothing Then
            Dim rowIndex As Integer = DataGridView.CurrentRow.Index
            dt.Rows(rowIndex)("name") = txt_name.Text
            dt.Rows(rowIndex)("school") = txt_school.Text
            dt.Rows(rowIndex)("class") = txt_class.Text
            dt.Rows(rowIndex)("grade") = Val(txt_grade.Text)
        End If
    End Sub

    ' Khi chọn dòng → load dữ liệu vào TextBox
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView.Rows(e.RowIndex)
            txt_name.Text = row.Cells("name").Value.ToString()
            txt_school.Text = row.Cells("school").Value.ToString()
            txt_class.Text = row.Cells("class").Value.ToString()
            txt_grade.Text = row.Cells("grade").Value.ToString()
        End If
    End Sub


    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_name.Text = ""
        txt_school.Text = ""
        txt_class.Text = ""
        txt_grade.Text = ""
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
    End Sub


End Class
