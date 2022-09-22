Public Class InvSearch
    Dim ds As DataSet = New DataSet
    Private Function populateDGV() As Boolean
        Try
            ds.Tables.Clear()
            ds.Clear()
            ds = New DataSet
            Dim q As String = "select q.code,q.name,q.batchcode,q.expiry,q.stock_piece,q.mrp_piece from (select (select m.name from medicine m where code=i.code) name,i.* from inventory i) q where q.stock_piece>0;"
            selectData(q, ds)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function
    Private Function populateDGV(str As String) As Boolean
        Try
            ds.Tables.Clear()
            ds.Clear()
            ds = New DataSet
            Dim q As String = "select q.code,q.name,q.batchcode,q.expiry,q.stock_piece,q.mrp_piece from (select (select m.name from medicine m where code=i.code) name,i.* from inventory i) q where q.stock_piece>0 and q.name like '%" + txtKeyword.Text + "%';"
            selectData(q, ds)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtKeyword.Text.Length > 0 Then
            populateDGV(txtKeyword.Text)
        Else
            populateDGV()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        populateDGV()
    End Sub

    Private Sub InvSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateDGV()
    End Sub
    Private Sub txtKeyword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return Then
            btnSearch_Click(sender, e)
        End If
        If e.KeyCode = Keys.Escape Then
            btnReset_Click(sender, e)
        End If
    End Sub
End Class