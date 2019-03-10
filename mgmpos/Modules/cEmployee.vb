Imports MySql.Data.MySqlClient

Public Class cEmployee
    Private custId As String
    Private EmpId As Integer
    Private First_Name As String
    Private Middle_Name As String
    Private Last_Name As String
    Private Username As String
    Private Password As String
    Private User_Lev As String
    Private imageLocation As String
    Private search As String
    Private orgName As String
    Private contact As String
    Private email As String
    Private custType As String
    Private aAddress As String
    Public Property CustomerID As String
        Get
            Return custId
        End Get
        Set(value As String)
            custId = value
        End Set
    End Property
    Public Property address As String
        Get
            Return aAddress
        End Get
        Set(value As String)
            aAddress = value
        End Set
    End Property
    Public Property CustomerType As String
        Get
            Return custType
        End Get
        Set(value As String)
            custType = value
        End Set
    End Property
    Public Property OrganizationName As String
        Get
            Return orgName
        End Get
        Set(value As String)
            orgName = value
        End Set
    End Property
    Public Property ContactNo As String
        Get
            Return contact
        End Get
        Set(value As String)
            contact = value
        End Set
    End Property
    Public Property E_mail As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property xSearch As String
        Get
            Return search

        End Get
        Set(value As String)
            search = value
        End Set
    End Property

    Public Property imageloc As String
        Get
            Return imageLocation
        End Get
        Set(value As String)
            imageLocation = value
        End Set
    End Property

    Public Property employeeID As Integer
        Get
            Return EmpId
        End Get
        Set(value As Integer)
            EmpId = value
        End Set
    End Property

    Public Property fname As String
        Get
            Return First_Name
        End Get
        Set(value As String)
            First_Name = value
        End Set
    End Property
    Public Property mname As String
        Get
            Return Middle_Name
        End Get
        Set(value As String)
            Middle_Name = value
        End Set
    End Property
    Public Property lname As String
        Get
            Return Last_Name
        End Get
        Set(value As String)
            Last_Name = value
        End Set
    End Property
    Public Property user As String
        Get
            Return Username
        End Get
        Set(value As String)
            Username = value
        End Set
    End Property
    Public Property pass As String
        Get
            Return Password
        End Get
        Set(value As String)
            Password = value
        End Set
    End Property
    Public Property designation As String
        Get
            Return User_Lev
        End Get
        Set(value As String)
            User_Lev = value
        End Set
    End Property
    Public Sub addCostumer()
        dbConnection()

        Dim myCommand As MySqlCommand = conn.CreateCommand()
        Dim myTrans As MySqlTransaction


        myTrans = conn.BeginTransaction()

        '*******************************

        Try
            myCommand.CommandText = "Select * from customer where firstname =@fname and lastname =@lname"
            With myCommand
                .Parameters.Clear()
                .Parameters.AddWithValue("@fname", fname)
                .Parameters.AddWithValue("@lname", lname)
            End With
            dr = myCommand.ExecuteReader()
            If dr.HasRows Then
                MsgBox("Costumer Already Exist!", MsgBoxStyle.Exclamation, "Add New Customer!")
            Else
                dr.Close()
                myCommand.CommandText = "INSERT INTO customer (`objid`, `costumerType`, `orgName`, `firstname`, `lastname`, `address`, `contact`, `email`, `imgLocation`) VALUES (@objid, @custType, @orgName, @fname, @lname, @address, @contact, @email, @imagelocation);"
                With myCommand
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@objid", objid)
                    .Parameters.AddWithValue("@custType", CustomerType)
                    .Parameters.AddWithValue("@orgName", OrganizationName)
                    .Parameters.AddWithValue("@fname", fname)
                    .Parameters.AddWithValue("@lname", lname)
                    .Parameters.AddWithValue("@address", address)
                    .Parameters.AddWithValue("@contact", ContactNo)
                    .Parameters.AddWithValue("@email", E_mail)
                    .Parameters.AddWithValue("@imagelocation", imageLocation)
                End With
                myCommand.ExecuteNonQuery()
                myTrans.Commit()
                MsgBox("Items recorded to database")
            End If


        Catch e As Exception
            Try
                myTrans.Rollback()
            Catch ex As MySqlException
                If Not myTrans.Connection Is Nothing Then
                    MsgBox("An exception of type " + ex.GetType().ToString() +
" was encountered while attempting to roll back the transaction.")
                End If
            End Try

            MsgBox("An exception of type " + e.GetType().ToString() +
"was encountered while inserting the data.")
            MsgBox("Neither record was written to database.")
        Finally
            conn.Close()
        End Try




    End Sub
    Public Sub addEmployee()
        Try
            dbConnection()
            sql = "INSERT INTO employees_database (First_Name,Middle_Name,Last_Name,Username,Password,User_Level,img_location)values(@fname,@mname,@lname,@username,@password,@designation,@imgloc);"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@fname", fname)
                .Parameters.AddWithValue("@mname", mname)
                .Parameters.AddWithValue("@lname", lname)
                .Parameters.AddWithValue("@username", user)
                .Parameters.AddWithValue("@password", pass)
                .Parameters.AddWithValue("@designation", designation)
                .Parameters.AddWithValue("@imgloc", imageLocation)

                result = .ExecuteNonQuery

                If result = 0 Then
                    MsgBox("Error in adding Employee!")
                Else
                    MsgBox("Successfully added new employee!")
                End If
            End With
        Catch mysqlEx As MySqlException
            If mysqlEx.Number = 1068 Then
                MsgBox("Username already taken!", vbOK + vbInformation, "Duplicate Entry")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()


        End Try
    End Sub
    ' Public Sub updateEmployee()
    'Try
    '        dbConnection()
    '       sql = "UPDATE employees_database SET `First_Name`= @Fname, `Middle_Name`='@Mname', `Last_Name`='Lname', `Username`='Uname', `Password`='@Pass', `User_Level`='@Ulevel', `img_location`='@imgloc' WHERE `Employee_ID`='@EmId';"
    ' sql = "UPDATE employees_database SET 'First_Name' = @Fname, 'Middle_Name' = @Mname, 'Last_Name' = @Lname, 'Username'= @Uname, 'Password' = @Pass, 'User_Level' = @Ulevel, 'img_location' = @imgloc WHERE Employee_ID = @EmID;"
    '       cmd = New MySqlCommand
    'With cmd
    '.Connection = conn
    '.CommandText = sql
    '.Parameters.Clear()
    '.Parameters.AddWithValue("@EmID", employeeID)
    '.Parameters.AddWithValue("@Fname", fname)
    '.Parameters.AddWithValue("@Mname", mname)
    '.Parameters.AddWithValue("@Lname", lname)
    '.Parameters.AddWithValue("@Uame", user)
    '.Parameters.AddWithValue("@Pass", pass)
    '.Parameters.AddWithValue("@Ulevel", designation)
    '.Parameters.AddWithValue("@imgloc", imageLocation)
    '
    '           result = .ExecuteNonQuery

    'If result = 0 Then
    '               MsgBox("Error in updating Employee!")
    'Else
    '               MsgBox("Successfully updated employee!")
    'End If
    'End With
    'Catch ex As Exception
    '       MsgBox(ex.Message)
    'Finally
    '       conn.Close()
    '      cmd.Dispose()
    'End Try
    'End Sub
    Public Sub searchCostumer()
        Try
            dbConnection()

            sql = "select costumerType,orgName,firstname,lastname,address,contact,email,imglocation from customer where concat(firstname,lastname,orgName) like '%' @customer '%'"
            cmd = New MySqlCommand(sql, conn)
            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@customer", xSearch)
            End With
            dr = cmd.ExecuteReader

            While dr.Read
                CustomerType = dr.Equals("costumerType")
                fname = dr.GetString("firstname")
                lname = dr.GetString("lastname")
                address = dr.GetString("address")
                ContactNo = dr.GetString("contact")
                E_mail = dr.GetString("email")
                imageloc = dr.GetString("imglocation")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub


    Public Sub searchEmployee()
        Try
            dbConnection()

            sql = "select Employee_ID,First_Name,Middle_Name,Last_Name,Username,Password,User_Level,img_location from employees_database where concat(First_Name,Last_Name,Username) like '%' @Employee '%'"
            cmd = New MySqlCommand(sql, conn)
            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@Employee", xSearch)
            End With
            dr = cmd.ExecuteReader

            While dr.Read
                CustomerType = dr.Equals("Employee_ID")
                fname = dr.GetString("First_Name")
                lname = dr.GetString("Last_Name")
                mname = dr.GetString("Middle_Name")
                user = dr.GetString("Username")
                pass = dr.GetString("Password")
                designation = dr.GetString("User_Level")
                imageloc = dr.GetString("img_location")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try

    End Sub
End Class
