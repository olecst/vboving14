Imports MySql.Data.MySqlClient


Public Class Form1
    Public brukernavn As String
    Public passord As String
    Public servernavn As String

    Public oppkobling As New MySqlConnection

    Private Function sporring(ByVal sql As String) As DataTable
        Dim tabell As New DataTable

        Try
            oppkobling.Open()

            Dim kommando As New MySqlCommand(sql, oppkobling)

            Dim da As New MySqlDataAdapter
            da.SelectCommand = kommando
            da.Fill(tabell)

            MessageBox.Show("Tabell opprettet.")
            oppkobling.Close()
        Catch feil As Exception
            MessageBox.Show("You fail at life. Fordi " & feil.Message)
        End Try

        Return tabell

    End Function





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        brukernavn = TextBox1.Text
        passord = TextBox2.Text
        servernavn = TextBox3.Text

        oppkobling.ConnectionString = "Server=" & servernavn & ";" &
                                        "Database=" & brukernavn & ";" &
                                        "Uid=" & brukernavn & ";" &
                                        "Pwd=" & passord & ";"

        Try
            oppkobling.Open()
            MessageBox.Show("Oppkobling vellykket")
            oppkobling.Close()
        Catch minerror As Exception
            MessageBox.Show("Oppkobbling mislykket - følgende feilmelding oppgitt: " & minerror.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sporring("CREATE TABLE Person (Person_id int, Person_fornavn char(25), Person_etternavn char(25))")
        sporring("INSERT INTO Person (Person_id, Person_fornavn, person_etternavn) VALUES (1, 'Ole', 'Strøm')")
        sporring("INSERT INTO Person (Person_id, Person_fornavn, person_etternavn) VALUES (2, 'Bjørner', 'Gråberg')")
        sporring("INSERT INTO Person (Person_id, Person_fornavn, person_etternavn) VALUES (3, 'Eric', 'Veliyulin')")
        sporring("INSERT INTO Person (Person_id, Person_fornavn, person_etternavn) VALUES (4, 'Jørn', 'Hella')")
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim tabell As New DataTable
        tabell = sporring("Select * FROM Person")

        Dim pid As String
        Dim fornavn As String
        Dim etternavn As String

        ListBox1.Items.Clear()

        For Each rad As DataRow In tabell.Rows
            pid = rad("Person_id")
            fornavn = rad("Person_fornavn")
            etternavn = rad("Person_etternavn")
            ListBox1.Items.Add(pid & " " & fornavn & " " & etternavn)
        Next
    End Sub
End Class
