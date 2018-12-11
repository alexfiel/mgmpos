Imports System
Imports MySql.Data.MySqlClient

Public Class product
    Private _prodId As Integer
    Private _prodCode As String
    Private _prodName As String
    Private _prodDdesc As String
    Private _prodCateg As String
    Private _prodUnits As String
    Private _prodSupplier As String
    Private _prodLocation As String
    Private _prodQty As Double
    Private _prodStockIn As Double
    Private _prodStockOut As Double
    Private _docNo As String
    Private _prodAvailableStock As Double
    Private _date As Date
    Private _transcode As String
    Private _userId As String
    Private _remarks As String
    Private mysqlno As String

    Private _DataTable As DataTable
    Public Property ProductDatatable As DataTable
        Get
            Return _DataTable
        End Get
        Set(value As DataTable)
            _DataTable = value
        End Set
    End Property
    Public Property TransCode As String
        Get
            Return _transcode
        End Get
        Set(value As String)
            _transcode = value
        End Set
    End Property
    Public Property ProdCode As String
        Get
            Return _prodCode
        End Get
        Set(value As String)
            _prodCode = value
        End Set
    End Property


    Public Property ProductId As Integer
        Get
            Return _prodId
        End Get
        Set(value As Integer)
            _prodId = value

        End Set
    End Property
    Public Property ProductName As String
        Get
            Return _prodName

        End Get
        Set(value As String)
            _prodName = value
        End Set
    End Property
    Public Property ProductDescription As String
        Get
            Return _prodDdesc

        End Get
        Set(value As String)
            _prodDdesc = value
        End Set
    End Property
    Public Property ProductCategory As String
        Get
            Return _prodCateg

        End Get
        Set(value As String)
            _prodCateg = value
        End Set
    End Property
    Public Property ProductUnit As String
        Get
            Return _prodUnits
        End Get
        Set(value As String)
            _prodUnits = value

        End Set
    End Property
    Public Property ProdDocNo As String
        Get
            Return _docNo
        End Get
        Set(value As String)
            _docNo = value
        End Set
    End Property
    Public Property ProdSupplier As String
        Get
            Return _prodSupplier
        End Get
        Set(value As String)
            _prodSupplier = value

        End Set
    End Property
    Public Property ProdLocation As String
        Get
            Return _prodLocation
        End Get
        Set(value As String)
            _prodLocation = value
        End Set
    End Property
    Public Property ProductQty As Double
        Get
            Return _prodQty
        End Get
        Set(value As Double)
            _prodQty = value
        End Set
    End Property
    Public Property ProdStockin As Double
        Get
            Return _prodStockIn
        End Get
        Set(value As Double)
            _prodStockIn = value
        End Set
    End Property
    Public Property ProdStockOut As Double
        Get
            Return _prodStockOut
        End Get
        Set(value As Double)
            _prodStockOut = value
        End Set
    End Property
    Public Property ProductAvailable As Double
        Get
            Return _prodAvailableStock

        End Get
        Set(value As Double)
            _prodAvailableStock = value
        End Set
    End Property
    Public Property ProductDate As Date
        Get

            Return _date
        End Get
        Set(value As Date)

            _date = value
        End Set
    End Property
    Public Property USERID As String
        Get
            Return _userId
        End Get
        Set(value As String)
            _userId = value
        End Set
    End Property
    Public Property ProdRemarks As String
        Get
            Return _remarks
        End Get
        Set(value As String)
            _remarks = value
        End Set
    End Property
    Public Function viewAvailableStock()
        ProductAvailable = ProdStockin + ProductQty - ProdStockOut
        Return ProductAvailable
    End Function
    Public Function ReceiveProduct()
        Try
            dbConnection()
            sql = "INSERT INTO `invetory_in` (`trasno`, `prodcode`, `qtyin`, `refno`, `locid`, `date`, `userid`, `remarks`) VALUES (@transno, @prodcode, @qtyin, @refno, @locid, @datein, @userid, @remarks);"
            'sql = "INSERT INTO `invetory_in` (`trasno`, `prodcode`, `qtyin`, `refno`, `locid`, `userid`, `remarks`) VALUES (@transno, @prodcode, @qtyin, @refno, @locid, @userid, @remarks);"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@transno", TransCode)
                .Parameters.AddWithValue("@prodcode", ProdCode)
                .Parameters.AddWithValue("@qtyin", ProdStockin)
                .Parameters.AddWithValue("@refno", ProdDocNo)
                .Parameters.AddWithValue("@locid", ProdLocation)
                .Parameters.AddWithValue("@datein", ProductDate)
                .Parameters.AddWithValue("@userid", USERID)
                .Parameters.AddWithValue("@remarks", _remarks)



                result = .ExecuteNonQuery

                If result = 0 Then
                    MsgBox("Error in Receiving Product!")
                Else
                    MsgBox("S U C C E S S !")
                End If
            End With
        Catch mysqlEx As MySqlException
            mysqlno = mysqlEx.Number
            MsgBox("MYSQL ERROR" & mysqlno)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()


        End Try
        Return mysqlno
    End Function
    Public Function updateProductQTY()
        Try
            dbConnection()
            sql = "UPDATE product SET `prod_begin_qty`=@begQty WHERE `prodcode`=@prodcode;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@prodcode", ProdCode)
                .Parameters.AddWithValue("@begqty", ProductAvailable)
                result = .ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("Error in updating Stock IN !")
                Else
                    MsgBox("Successfully updated the selected Stock !")
                End If
            End With
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()

        End Try
        Return result

    End Function
    Public Function GetproductStatus()
        Return 0

    End Function
    Public Function viewAddProducts()
        Try
            dbConnection()
            sql = "select a.prodcode, a.prodname, a.prodcategory,a.prod_begin_qty,a.uom,b.qtyin,b.trasno,b.refno,b.locid,b.date from product a left outer join invetory_in b on a.prodcode = b.prodcode where trasno=@transno order by trasno desc;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@transno", TransCode)
                .Parameters.AddWithValue("@begqty", ProductAvailable)
                result = .ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("SEARCH ERROR !")

                End If

            End With
            dt = New DataTable
            da = New MySqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As Exception

            MsgBox(ex.Message)

        Finally
            conn.Close()
            da.Dispose()
            cmd.Dispose()
            If dt.Rows.Count = 0 Then
                MsgBox("No results!")

            End If
            ProductDatatable = dt
        End Try
        Return result
    End Function

End Class
