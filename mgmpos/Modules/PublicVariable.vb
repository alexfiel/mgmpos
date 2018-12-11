Imports MySql.Data.MySqlClient

Module PublicVariable
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dr As MySqlDataReader

    Public dt As DataTable
    Public dt2 As DataTable
    Public ds As DataSet

    Public result As Integer
    Public sql As String

    Public suppID As Integer
    Public locationid As Integer
    Public userId As Integer
    Public username As String
    Public userlevel As String
    Public userimageloc As String

    Public quantity As String
    Public discount As Double

    Public vat As Double = 0.12
    Public vatprice As Double
    Public newprice As Double
    Public totalunitprice As Double
    Public postotal As Double
    Public postotalamount As Double
    Public posvat As Double
    Public cashtendered As Double
    Public accumulatedpayment As Double = 0
    Public change As Double
    Public chequeamount As Double

    Public cellevent As Double = 0
    Public Pprodcode As String
    Public Pprodname As String
    Public Pamount As Double
    Public index As Integer
    Public row As DataGridViewRow

    Public modepayment As String
    Public POStransobjid As String
    Public cashonhandobjid As String
    Public objid As String
    Public Gremittanceid As String
End Module
