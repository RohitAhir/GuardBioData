Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting

Public Class Frm_GuardBioDataGrid

    Private Sub Frm_FamilyHousesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Start_Waiting() : getBioData() : setGridview() : End_Waiting()
    End Sub

    Sub getBioData()
        Dim connectionstring As String = conStr
        Dim connection As New SqlConnection(connectionstring)
        Dim ds As New DataSet()

        Dim BS As New BindingSource
        Dim BSDetails As New BindingSource

        Dim sql As New SqlCommand("Select Id ,SecurityAgency, VendorCode, WONo, EntryPermitNo, GuardName, FatherName, MotherName, ContactNo, Gender, BirthDate, BloodGroup, 
                             ColourOfEyes, ColourOfHair, MaritalStatus, IdentificationMark1, IdentificationMark2, PermanentAddress, PresentAddress, AadharCardNo, NomineeName, AnyPoliceOrCrimeRecords, AnyPersonalInsurance, DrivingLicense, DrivingLicenseNo,
                              LicenseType, PhysicalApprearance, LanguageKnown1, Read1, Write1, Speak1, LanguageKnown2, Read2, Write2, Speak2, NCCCertificate, ShoeSize, JerseySize, TrouserSize, ComputerKnowledge,
                              Height, Weight, Chest, BMI, Skills, Religion, Nationality, UAN, PAN, BankAccountNo, IFSCCode, ESICNo, CreatedDate, ModifiedDate From BioData order by CreatedDate desc", connection)

        Dim dataadapter As New SqlDataAdapter(sql)
        dataadapter.Fill(ds, "BioData")

        Dim sqlChild As New SqlCommand("Select GuardId,Company,Designation,JoinDate,ResignationDate from Profile", connection)
        Dim da As New SqlDataAdapter(sqlChild)
        da.Fill(ds, "Profile")

        ds.Relations.Add(New DataRelation("GuardProfile", ds.Tables("BioData").Columns("Id"), ds.Tables("Profile").Columns("GuardId"), False))
        Dim FK_Relation As New Global.System.Data.ForeignKeyConstraint("FK_BioData", ds.Tables("BioData").Columns("Id"), ds.Tables("Profile").Columns("GuardId"))
        ds.Tables("Profile").Constraints.Add(FK_Relation)
        With FK_Relation
            .AcceptRejectRule = AcceptRejectRule.None
            .DeleteRule = Rule.Cascade
            .UpdateRule = Rule.Cascade
        End With

        BS.DataSource = ds
        BS.DataMember = "BioData"

        BSDetails.DataSource = BS
        BSDetails.DataMember = "GuardProfile"

        GridControl1.DataSource = BS

        TotalLabelControl.Text = "Total :- " + GridView1.RowCount.ToString
    End Sub

    Sub getCustomBioData()
        Dim connectionstring As String = conStr
        Dim connection As New SqlConnection(connectionstring)
        Dim ds As New DataSet()

        Dim BS As New BindingSource
        Dim BSDetails As New BindingSource

        Dim sql As New SqlCommand("Select Id ,SecurityAgency, VendorCode, WONo, EntryPermitNo, GuardName, FatherName, MotherName, ContactNo, Gender, BirthDate, BloodGroup, 
                             ColourOfEyes, ColourOfHair, MaritalStatus, IdentificationMark1, IdentificationMark2, PermanentAddress, PresentAddress, AadharCardNo, NomineeName, AnyPoliceOrCrimeRecords, AnyPersonalInsurance, DrivingLicense, DrivingLicenseNo,
                              LicenseType, PhysicalApprearance, LanguageKnown1, Read1, Write1, Speak1, LanguageKnown2, Read2, Write2, Speak2, NCCCertificate, ShoeSize, JerseySize, TrouserSize, ComputerKnowledge,
                              Height, Weight, Chest, BMI, Skills, Religion, Nationality, UAN, PAN, BankAccountNo, IFSCCode, ESICNo, CreatedDate, ModifiedDate From BioData Where GuardName like '%" + NameTextEdit.Text + "%' order by CreatedDate desc", connection)

        Dim dataadapter As New SqlDataAdapter(sql)
        dataadapter.Fill(ds, "BioData")

        Dim sqlChild As New SqlCommand("Select GuardId,Company,Designation,JoinDate,ResignationDate from Profile", connection)
        Dim da As New SqlDataAdapter(sqlChild)
        da.Fill(ds, "Profile")

        ds.Relations.Add(New DataRelation("GuardProfile", ds.Tables("BioData").Columns("Id"), ds.Tables("Profile").Columns("GuardId"), False))
        Dim FK_Relation As New Global.System.Data.ForeignKeyConstraint("FK_BioData", ds.Tables("BioData").Columns("Id"), ds.Tables("Profile").Columns("GuardId"))
        ' ds.Tables("Profile").Constraints.Add(FK_Relation)
        With FK_Relation
            .AcceptRejectRule = AcceptRejectRule.None
            .DeleteRule = Rule.Cascade
            .UpdateRule = Rule.Cascade
        End With

        BS.DataSource = ds
        BS.DataMember = "BioData"

        BSDetails.DataSource = BS
        BSDetails.DataMember = "GuardProfile"

        GridControl1.DataSource = BS

        TotalLabelControl.Text = "Total :- " + GridView1.RowCount.ToString
    End Sub

    Sub setGridview()
        With GridView1
            .Columns("Id").Visible = False
        End With
        GridView1.BestFitColumns()
        GridView1.OptionsBehavior.Editable = False
        GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    End Sub

    Private Sub GridView1_MasterRowExpanded(sender As Object, e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles GridView1.MasterRowExpanded
        Dim dView As GridView = TryCast(GridView1.GetDetailView(e.RowHandle, 0), GridView)
        dView.Columns("GuardId").Visible = False

        dView.BestFitColumns()
        dView.OptionsBehavior.Editable = False
        dView.OptionsSelection.EnableAppearanceFocusedCell = False
        dView.FocusRectStyle = DrawFocusRectStyle.RowFocus
    End Sub


    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        If GridView1.RowCount > 0 Then
            GridView1.OptionsPrint.PrintDetails = True
            GridView1.OptionsPrint.ExpandAllDetails = True
            Dim opt As XlsExportOptionsEx = New XlsExportOptionsEx()
            opt.ExportType = DevExpress.Export.ExportType.WYSIWYG

            Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            GridView1.ExportToXls(path + "\Guards_BioData" + Now.ToString("HHmmss") + ".xls", opt)

            'GridView1.OptionsPrint.PrintDetails = True
            'GridView1.OptionsPrint.ExpandAllDetails = True
            'Dim opt As PdfExportOptions = New PdfExportOptions()
            'opt. = DevExpress.Export.ExportType.WYSIWYG

            'Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            'GridView1.ExportToXls(path + "\Guards_BioData" + Now.ToString("HHmmss") + ".xls", opt)

            'Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            'GridView1.ExportToXls(path + "\Guards_BioData" + Now.ToString("HHmmss") + ".xls")
        End If
    End Sub

    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        Start_Waiting() : getCustomBioData() : setGridview() : End_Waiting()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim frm As New Frm_GuardBio(0)
        If frm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            Start_Waiting() : getCustomBioData() : setGridview() : End_Waiting()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim MyRow As DataRow = GridView1.GetFocusedDataRow()
        Dim Id = CInt(MyRow("Id").ToString())

        Dim frm As New Frm_GuardBio(Id)
        If frm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            Start_Waiting() : getCustomBioData() : setGridview() : End_Waiting()
        End If
    End Sub
End Class