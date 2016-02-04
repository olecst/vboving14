Imports MySql.Data.MySqlClient


Public Class Form1
    Public brukernavn As String
    Public passord As String
    Public servernavn As String
    Dim pid As String
    Dim fornavn As String
    Dim etternavn As String
    Dim epost As String
    Public oppkobling As New MySqlConnection

    Private Function sporring(ByVal sql As String) As DataTable
        Dim tabell As New DataTable

        Try
            oppkobling.Open()

            Dim kommando As New MySqlCommand(sql, oppkobling)

            Dim da As New MySqlDataAdapter
            da.SelectCommand = kommando
            da.Fill(tabell)

            oppkobling.Close()
        Catch feil As Exception
            MessageBox.Show("Noe gikk galt: " & feil.Message)
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
        sporring("CREATE TABLE Person (Person_id int, Person_fornavn char(25), Person_etternavn char(25), Person_epost char(25))")
        sporring("INSERT INTO Person (Person_id, Person_fornavn, person_etternavn, Person_epost) VALUES (1, 'Ole', 'Strøm', 'ole@ole.com')")
        sporring("INSERT INTO Person (Person_id, Person_fornavn, person_etternavn, Person_epost) VALUES (2, 'Bjørner', 'Gråberg', 'bjorner@bjorner.com')")
        sporring("INSERT INTO Person (Person_id, Person_fornavn, person_etternavn, Person_epost) VALUES (3, 'Eric', 'Veliyulin', 'eric@eric.com')")
        sporring("INSERT INTO Person (Person_id, Person_fornavn, person_etternavn, Person_epost) VALUES (4, 'Jørn', 'Hella', 'jorn@jorn.com')")
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim tabell As New DataTable
        tabell = sporring("SELECT * FROM Person ORDER BY Person_fornavn")



        ListBox1.Items.Clear()

        For Each rad As DataRow In tabell.Rows
            pid = rad("Person_id")
            fornavn = rad("Person_fornavn")
            etternavn = rad("Person_etternavn")
            epost = rad("Person_epost")
            ListBox1.Items.Add(pid & " " & fornavn & " " & etternavn & " " & epost)
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim personsok As String = InputBox("Hvem vil du søke etter?")


        Dim tabell As New DataTable
        tabell = sporring("SELECT * FROM Person WHERE Person_fornavn = '" & personsok & "'")

        ListBox1.Items.Clear()

        For Each rad As DataRow In tabell.Rows
            pid = rad("Person_id")
            fornavn = rad("Person_fornavn")
            etternavn = rad("Person_etternavn")
            epost = rad("Person_epost")
            ListBox1.Items.Add(pid & " " & fornavn & " " & etternavn & " " & epost)
        Next
        oppkobling.Close()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim epostsok As String = InputBox("Hvem vil du søke etter?")


        Dim tabell As New DataTable
        tabell = sporring("SELECT * FROM Person WHERE Person_epost LIKE '%" & epostsok & "%'")

        ListBox1.Items.Clear()

        For Each rad As DataRow In tabell.Rows
            pid = rad("Person_id")
            fornavn = rad("Person_fornavn")
            etternavn = rad("Person_etternavn")
            epost = rad("Person_epost")
            ListBox1.Items.Add(pid & " " & fornavn & " " & etternavn & " " & epost)
        Next
        oppkobling.Close()
    End Sub
End Class
