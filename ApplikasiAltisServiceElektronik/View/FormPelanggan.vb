Public Class FormPelanggan
    Dim barisListView As Integer

    Dim formCheckAndRepair As FormCheckAndRepair
    Dim formMenuUtama As FormMenuUtama
    Dim formPerbaikan As FormPerbaikan

    Dim ambildata As Boolean = False

    Sub New(ByVal inst As FormPerbaikan)
        InitializeComponent()
        ambildata = True
        Me.formPerbaikan = inst
        kosong()
    End Sub
    Sub New(ByVal inst As FormMenuUtama)
        InitializeComponent()
        Me.formMenuUtama = inst
        kosong()
    End Sub

    Sub New(ByVal inst As FormCheckAndRepair)
        InitializeComponent()
        ambildata = True
        Me.formCheckAndRepair = inst
        kosong()
    End Sub

    Sub LoadDataTable()
        Dim baris As Integer = 1
        Dim myConnection As New OleDbConnection(appPathDatabase)
        myConnection.Open()

        Dim myCommand As New OleDbCommand("select * from pelanggan", myConnection)
        Dim myReader As OleDbDataReader = myCommand.ExecuteReader

        While myReader.Read()
            Me.ListView1.Items.Add(baris)
            Me.ListView1.Items(baris - 1).SubItems.Add(myReader.GetInt32(myReader.GetOrdinal("id")).ToString)
            Me.ListView1.Items(baris - 1).SubItems.Add(myReader.GetString(myReader.GetOrdinal("nama")))
            Me.ListView1.Items(baris - 1).SubItems.Add(myReader.GetString(myReader.GetOrdinal("alamat")))
            Me.ListView1.Items(baris - 1).SubItems.Add(myReader.GetString(myReader.GetOrdinal("notelepon")))
            Me.ListView1.Items(baris - 1).SubItems.Add(myReader.GetString(myReader.GetOrdinal("noktp")))

            baris = baris + 1
        End While

        myConnection.Close()
    End Sub


    Sub LoadTable()
        With Me
            ListView1.View = View.Details
            ListView1.GridLines = True
            ListView1.HideSelection = False
            ListView1.MultiSelect = False
            ListView1.FullRowSelect = True

            ListView1.Columns.Add("No")
            ListView1.Columns.Add("ID")
            ListView1.Columns.Add("Nama")
            ListView1.Columns.Add("Alamat")
            ListView1.Columns.Add("No Telepon")
            ListView1.Columns.Add("No KTP")
        End With

    End Sub


    Private Sub tambahPelanggan(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Dim status As Boolean
        status = True

        If txtNama.Text = "" Then
            txtNama.Focus()
        End If

        If txtNoKtp.Text = "" Then
            txtNoKtp.Focus()
        End If


        If status Then
            Try
                Dim myConnection As New OleDbConnection(appPathDatabase)
                myConnection.Open()

                Dim myCommmand As New OleDbCommand("Insert into pelanggan (nama, alamat, noktp, notelepon) values (@nama, @alamat, @noktp, @notelepon)", myConnection)

                myCommmand.Parameters.AddWithValue("@nama", Trim(txtNama.Text))
                myCommmand.Parameters.AddWithValue("@alamat", Trim(txtAlamat.Text))
                myCommmand.Parameters.AddWithValue("@noktp", Trim(txtNoKtp.Text))
                myCommmand.Parameters.AddWithValue("@notelepon", Trim(txtNoTelepon.Text))

                myCommmand.ExecuteNonQuery()

                Dim id As Integer = LastInsertedID()

                MsgBox("Berhasil menginputkan data pelanggan dengan id : " & id)

                With Me.ListView1
                    Dim baris As Integer = .Items.Count

                    .Items.Add(baris)
                    .Items(baris).SubItems.Add(id.ToString)
                    .Items(baris).SubItems.Add(Trim(txtNama.Text))
                    .Items(baris).SubItems.Add(Trim(txtAlamat.Text))
                    .Items(baris).SubItems.Add(Trim(txtNoKtp.Text))
                    .Items(baris).SubItems.Add(Trim(txtNoTelepon.Text))

                End With

                kosong()
            Catch ex As Exception
                MsgBox("Kesalahan dalam penyimpan data pelanggan dengan pesan : " & ex.Message)
            Finally
                koneksi.Close()
            End Try

        End If
    End Sub

    Sub kosong()
        txtID.Text = ""
        txtNama.Text = ""
        txtNoKtp.Text = ""
        txtAlamat.Text = ""
        txtNoTelepon.Text = ""
    End Sub

    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click
        Dim status As Boolean = True

        If txtNama.Text = "" Then
            status = False
        End If

        If txtNoTelepon.Text = "" Then
            status = False
        End If

        If status Then
            Try
                Dim myConnection As New OleDbConnection(appPathDatabase)
                myConnection.Open()

                Dim myCommand As New OleDbCommand("update pelanggan set nama = @nama, alamat = @alamat, notelepon = @notelepon, noktp = @noktp where id = @id", myConnection)

                myCommand.Parameters.AddWithValue("@id", Trim(txtID.Text))
                myCommand.Parameters.AddWithValue("@nama", Trim(txtNama.Text))
                myCommand.Parameters.AddWithValue("@alamat", Trim(txtAlamat.Text))
                myCommand.Parameters.AddWithValue("@noktp", Trim(txtNoKtp.Text))
                myCommand.Parameters.AddWithValue("@notelepon", Trim(txtNoTelepon.Text))

                myCommand.ExecuteNonQuery()

                myConnection.Close()

                MsgBox("Berhasil mengubah data pelanggan")

                Me.ListView1.SelectedItems(0).SubItems(1).Text = Me.txtID.Text
                Me.ListView1.SelectedItems(0).SubItems(2).Text = Trim(txtNama.Text)
                Me.ListView1.SelectedItems(0).SubItems(3).Text = Trim(txtAlamat.Text)
                Me.ListView1.SelectedItems(0).SubItems(4).Text = Trim(txtNoTelepon.Text)
                Me.ListView1.SelectedItems(0).SubItems(5).Text = Trim(txtNoKtp.Text)
                kosong()
            Catch ex As Exception
                MsgBox("terdapat kesalahan dalam perubahan data pelanggan dengan pesan : " & ex.Message)
            Finally
                koneksi.Close()
            End Try
        Else

        End If
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click

    End Sub

    Private Sub FormPelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadTable()
        LoadDataTable()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Dim id As Integer = Integer.Parse(txtID.Text)

        Dim myConnection As New OleDbConnection(appPathDatabase)
        myConnection.Open()

        Dim myCommand As New OleDbCommand("select * from pelanggan where id = @id", myConnection)

        cmd.Parameters.AddWithValue("@id", Me.ListView1.SelectedItems(0).SubItems(1).Text.Trim)

        Dim reader As OleDbDataReader = myCommand.ExecuteReader
        reader.Read()

        If reader.HasRows Then
            Dim pesanUser As String
            pesanUser = MsgBox("Yakin Hapus Data Pelanggan Ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Peringatan ")
            If pesanUser = vbYes Then
                Dim myConnection2 As New OleDbConnection(appPathDatabase)
                myConnection2.Open()

                Dim command As New OleDbCommand("delete from pelanggan where id = @id", myConnection2)

                command.Parameters.AddWithValue("@id", ListView1.SelectedItems(0).SubItems(1).Text.ToString.Trim)
                command.ExecuteNonQuery()
                myConnection2.Close()
            End If
        Else
            MsgBox("Pelanggan " & id & " tidak tersedia!", MsgBoxStyle.Critical, "Peringatan")
        End If

        myConnection.Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.Click
        If Me.ListView1.SelectedItems.Count > 0 Then
            If ambildata Then
                If Not formPerbaikan Is Nothing Then
                    Dim id As Integer = Integer.Parse(ListView1.SelectedItems(0).SubItems(1).Text.ToString.Trim)
                    Dim nama As String = ListView1.SelectedItems(0).SubItems(2).Text.ToString.Trim

                    formPerbaikan.idPelanggan = id
                    formPerbaikan.lblNamaPelanggan.Text = id.ToString.Trim & " - " & nama

                    Me.Close()
                End If

                If Not formCheckAndRepair Is Nothing Then
                    Dim id As Integer = Integer.Parse(ListView1.SelectedItems(0).SubItems(1).Text.ToString.Trim)
                    Dim nama As String = ListView1.SelectedItems(0).SubItems(2).Text.ToString.Trim

                    formCheckAndRepair.idPelanggan = id
                    formCheckAndRepair.lblNamaPelanggan.Text = id.ToString.Trim & " - " & nama

                    Me.Close()
                End If

            Else
                Me.txtID.Text = Me.ListView1.SelectedItems(0).SubItems(1).Text
                Me.txtNama.Text = Me.ListView1.SelectedItems(0).SubItems(2).Text
                Me.txtAlamat.Text = Me.ListView1.SelectedItems(0).SubItems(3).Text
                Me.txtNoTelepon.Text = Me.ListView1.SelectedItems(0).SubItems(4).Text
                Me.txtNoKtp.Text = Me.ListView1.SelectedItems(0).SubItems(5).Text
            End If

        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class