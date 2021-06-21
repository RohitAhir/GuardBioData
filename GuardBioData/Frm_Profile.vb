Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class Frm_Profile
    Dim GuardId As Integer
    Dim Id As Integer
    Sub New(ByVal pId As Integer, ByVal gId As Integer)
        InitializeComponent()

        'Set Validation
        DxValidationProvider1.ValidationMode = ValidationMode.Manual

        Dim companyValidationRule As New ConditionValidationRule()
        companyValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        companyValidationRule.ErrorText = "Please enter a company name"
        companyValidationRule.ErrorType = ErrorType.Warning

        Dim designationValidationRule As New ConditionValidationRule()
        designationValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        designationValidationRule.ErrorText = "Please enter your designation"
        designationValidationRule.ErrorType = ErrorType.Warning

        Dim joinDateValidationRule As New ConditionValidationRule()
        joinDateValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        joinDateValidationRule.ErrorText = "Please enter a company join date"
        joinDateValidationRule.ErrorType = ErrorType.Warning

        DxValidationProvider1.SetValidationRule(CompanyNameTextEdit, companyValidationRule)
        DxValidationProvider1.SetValidationRule(DesignationTextEdit, designationValidationRule)
        DxValidationProvider1.SetValidationRule(JoinDateDateEdit, joinDateValidationRule)

        If pId <> 0 Then
            Dim connectionstring As String = conStr
            Dim connection As New SqlConnection(connectionstring)
            Dim sql As New SqlCommand("Select Id,GuardId,Company,Designation,JoinDate,ResignationDate From Profile Where Id=" + pId.ToString, connection)

            Dim dataadapter As New SqlDataAdapter(sql)
            Dim dt As New DataTable()
            connection.Open()

            dataadapter.Fill(dt)

            Id = pId
            GuardId = gId
            CompanyNameTextEdit.Text = dt.Rows(0).Item("Company").ToString
            DesignationTextEdit.Text = dt.Rows(0).Item("Designation").ToString
            JoinDateDateEdit.EditValue = Convert.ToDateTime(dt.Rows(0).Item("JoinDate").ToString)
            If dt.Rows(0).Item("ResignationDate").ToString <> "" Then
                ResignationDateDateEdit.EditValue = Convert.ToDateTime(dt.Rows(0).Item("ResignationDate").ToString)
            End If
        Else
            Id = 0
            GuardId = gId
        End If
    End Sub

    Public Sub saveData()
        Dim connectionstring As String = Nothing
        Dim connection As SqlConnection
        connectionstring = conStr
        connection = New SqlConnection(connectionstring)
        connection.Open()
        Dim rs As SqlCommand

        rs = New SqlCommand("Insert Into Profile (GuardId, Designation, Company, JoinDate, ResignationDate, CreatedDate, ModifiedDate) values 
                             (@GuardId, @Designation, @Company, @JoinDate, @ResignationDate, @CreatedDate, @ModifiedDate)", connection)

        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@GuardId", .SqlDbType = SqlDbType.Int, .Value = GuardId})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Designation", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = DesignationTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@JoinDate", .SqlDbType = SqlDbType.Date, .Value = JoinDateDateEdit.EditValue})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Company", .SqlDbType = SqlDbType.NVarChar, .Size = 50, .Value = CompanyNameTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@ResignationDate", .SqlDbType = SqlDbType.Date, .Value = IIf(ResignationDateDateEdit.EditValue Is Nothing, DBNull.Value, ResignationDateDateEdit.EditValue)})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@CreatedDate", .SqlDbType = SqlDbType.DateTime, .Value = Now})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@ModifiedDate", .SqlDbType = SqlDbType.DateTime, .Value = Now})

        rs.ExecuteNonQuery()
        connection.Close()
        connection.Dispose()
    End Sub

    Public Sub updateData()
        Dim connectionstring As String = Nothing
        Dim connection As SqlConnection
        connectionstring = conStr
        connection = New SqlConnection(connectionstring)
        connection.Open()
        Dim rs As SqlCommand

        rs = New SqlCommand("Update Profile set GuardId=@GuardId, Designation=@Designation, Company=@Company, JoinDate=@JoinDate, ResignationDate=@ResignationDate, ModifiedDate=@ModifiedDate Where Id=@Id", connection)

        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Id", .SqlDbType = SqlDbType.Int, .Value = Id})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@GuardId", .SqlDbType = SqlDbType.Int, .Value = GuardId})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Designation", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = DesignationTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@JoinDate", .SqlDbType = SqlDbType.Date, .Value = JoinDateDateEdit.EditValue})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Company", .SqlDbType = SqlDbType.NVarChar, .Size = 50, .Value = CompanyNameTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@ResignationDate", .SqlDbType = SqlDbType.Date, .Value = IIf(ResignationDateDateEdit.EditValue Is Nothing, DBNull.Value, ResignationDateDateEdit.EditValue)})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@CreatedDate", .SqlDbType = SqlDbType.DateTime, .Value = Now})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@ModifiedDate", .SqlDbType = SqlDbType.DateTime, .Value = Now})

        rs.ExecuteNonQuery()
        connection.Close()
        connection.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If DxValidationProvider1.Validate() Then
            If Id = 0 Then
                saveData()
            Else
                updateData()
            End If

            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Dispose()
    End Sub
End Class