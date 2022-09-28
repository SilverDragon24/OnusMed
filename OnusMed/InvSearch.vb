Public Class InvSearch
    Dim ds As DataSet = New DataSet
    Private Function populateDGV() As Boolean
        Try
            ds.Tables.Clear()
            ds.Clear()
            ds = New DataSet
            Dim q As String = "select q.code 'Code',q.name 'Name',q.batchcode 'Batch',q.expiry 'Expiry',q.stock_piece 'Available',concat('₹ ',round(q.pur_rate_piece,2)) 'P.Rate',concat('₹ ',q.mrp_piece) 'M.R.P' from (select (select m.name from medicine m where code=i.code) name,i.* from inventory i) q where q.stock_piece>0;"
            selectData(q, ds)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DataGridView1.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DataGridView1.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            'For i As Integer = 0 To ds.Tables(0).Columns.Count - 1
            '    Try
            '        DataGridView1.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            '        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            '    Catch ex As Exception

            '    End Try
            'Next
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
            Dim q As String = "select q.code 'Code',q.name 'Name',q.batchcode 'Batch',q.expiry 'Expiry',q.stock_piece 'Available',concat('₹ ',round(q.pur_rate_piece,2)) 'P.Rate',concat('₹ ',q.mrp_piece) 'M.R.P' from (select (select m.name from medicine m where code=i.code) name,i.* from inventory i) q where q.stock_piece>0 and q.name like '%" + txtKeyword.Text + "%';"
            selectData(q, ds)
            If ds.Tables(0).Rows.Count = 0 Then
                q = "select q.code 'Code',q.name 'Name',q.batchcode 'Batch',q.expiry 'Expiry',q.stock_piece 'Available',concat('₹ ',round(q.pur_rate_piece,2)) 'P.Rate',concat('₹ ',q.mrp_piece) 'M.R.P' from (select (select m.name from medicine m where code=i.code) name,i.* from inventory i) q where q.code='" + txtKeyword.Text + "';"
                ds.Tables.Clear()
                ds.Clear()
                ds = New DataSet
                selectData(q, ds)
            End If
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DataGridView1.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DataGridView1.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
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