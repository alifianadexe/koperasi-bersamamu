Module Helper
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader

    Dim server As String = "localhost"

    Public Function generateConnString() As String
        Dim connString = "Data Source=" + server + ",1433;Network Library=DBMSSOCN;Initial Catalog=db_koperasi;user id=alifianadexe;password=adexe123"
        Try
            conn.ConnectionString = connString
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                conn.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return connString
    End Function

    Public Function cekUsername(ByVal username As String)
        Dim sql As String = "SELECT * FROM tbl_anggota WHERE username = '" + username + "'"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        rd = cmnd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            Return False
        End If
        rd.Close()
        Return True
    End Function

    Public Function cekEmptyBox(ParamArray ByVal obj() As Object)
        For i As Integer = 0 To UBound(obj)
            If obj(i).Text = "" Then
                MessageBox.Show("Isi semua kolom yang tersedia!", "Warn", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False

            End If
        Next
        Return True
    End Function

    Public Function generateID(ByVal what As String, ByVal conn As SqlClient.SqlConnection)
        Dim id As String = ""

        Select Case what
            Case "id_anggota"
                Dim sql As String = "SELECT " + id + " FROM tbl_anggota ORDER BY " + id + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "AGT001"
                Else
                    id = Val(Mid(rd.Item(0), 4, 3)) + 1
                    If Len(id) = 1 Then
                        id = "AGT00" + id
                    ElseIf Len(id) = 2 Then
                        id = "AGT0" + id
                    ElseIf Len(id) = 3 Then
                        id = "AGT" + id
                    End If
                End If

                rd.Close()
            Case "id_angsur"
                Dim sql As String = "SELECT " + id + " FROM tbl_angsur ORDER BY " + id + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "2017001"
                Else
                    id = rd.Item(0) + 1
                End If

                rd.Close()

            Case "id_total_bunga"
                Dim sql As String = "SELECT " + id + " FROM tbl_total_bunga ORDER BY " + id + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "192001"
                Else
                    id = rd.Item(0) + 1
                End If

                rd.Close()

            Case "id_det_simpanan"
                Dim sql As String = "SELECT " + id + " FROM tbl_det_simpanan ORDER BY " + id + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "168001"
                Else
                    id = rd.Item(0) + 1
                End If

                rd.Close()

            Case "id_jabatan"
                Dim sql As String = "SELECT " + id + " FROM tbl_jabatan ORDER BY " + id + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "JBT001"
                Else
                    id = Val(Mid(rd.Item(0), 4, 3)) + 1
                    If Len(id) = 1 Then
                        id = "JBT00" + id
                    ElseIf Len(id) = 2 Then
                        id = "JBT0" + id
                    ElseIf Len(id) = 3 Then
                        id = "JBT" + id
                    End If
                End If

                rd.Close()
            Case "id_jenis_simpanan"
                Dim sql As String = "SELECT " + id + " FROM tbl_jenis_simpanan ORDER BY " + id + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "JNS001"
                Else
                    id = Val(Mid(rd.Item(0), 4, 3)) + 1
                    If Len(id) = 1 Then
                        id = "JNS00" + id
                    ElseIf Len(id) = 2 Then
                        id = "JNS0" + id
                    ElseIf Len(id) = 3 Then
                        id = "JNS" + id
                    End If
                End If

                rd.Close()

            Case "id_peminjaman"
                Dim sql As String = "SELECT " + id + " FROM tbl_peminjaman ORDER BY " + id + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "PMJ001"
                Else
                    id = Val(Mid(rd.Item(0), 4, 3)) + 1
                    If Len(id) = 1 Then
                        id = "PMJ00" + id
                    ElseIf Len(id) = 2 Then
                        id = "PMJ0" + id
                    ElseIf Len(id) = 3 Then
                        id = "PMJ" + id
                    End If
                End If

                rd.Close()

            Case "id_simpanan"
                Dim sql As String = "SELECT " + id + " FROM tbl_simpanan ORDER BY " + id + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "SMP001"
                Else
                    id = Val(Mid(rd.Item(0), 4, 3)) + 1
                    If Len(id) = 1 Then
                        id = "SMP00" + id
                    ElseIf Len(id) = 2 Then
                        id = "SMP0" + id
                    ElseIf Len(id) = 3 Then
                        id = "SMP" + id
                    End If
                End If

                rd.Close()

        End Select

        Return id
    End Function
End Module
