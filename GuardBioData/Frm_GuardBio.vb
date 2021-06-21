Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class Frm_GuardBio
    Dim GuardId As Integer
    Sub New(ByVal gId As Integer)
        InitializeComponent()

        If gId <> 0 Then
            Dim connectionstring As String = conStr
            Dim connection As New SqlConnection(connectionstring)
            Dim sql As New SqlCommand("Select Id ,SecurityAgency, VendorCode, WONo, EntryPermitNo, GuardName, FatherName, MotherName, ContactNo, Gender, BirthDate, BloodGroup, 
                             ColourOfEyes, ColourOfHair, MaritalStatus, IdentificationMark1, IdentificationMark2, PermanentAddress, PresentAddress, AadharCardNo, NomineeName, AnyPoliceOrCrimeRecords, AnyPersonalInsurance, DrivingLicense, DrivingLicenseNo,
                              LicenseType, PhysicalApprearance, LanguageKnown1, Read1, Write1, Speak1, LanguageKnown2, Read2, Write2, Speak2, NCCCertificate, ShoeSize, JerseySize, TrouserSize, ComputerKnowledge,
                              Height, Weight, Chest, BMI, Skills, Religion, Nationality, UAN, PAN, BankAccountNo, IFSCCode, ESICNo, CreatedDate, ModifiedDate From BioData Where Id=" + gId.ToString, connection)

            Dim dataadapter As New SqlDataAdapter(sql)
            Dim dt As New DataTable()
            connection.Open()
            dataadapter.Fill(dt)
            connection.Dispose()

            GuardId = gId
            SecurityAgencyTextEdit.Text = dt.Rows(0).Item("SecurityAgency").ToString
            VendorCodeTextEdit.Text = dt.Rows(0).Item("VendorCode").ToString
            WONoTextEdit.Text = dt.Rows(0).Item("WONo").ToString
            EntryPermitNoTextEdit.Text = dt.Rows(0).Item("EntryPermitNo").ToString
            FullNameTextEdit.Text = dt.Rows(0).Item("GuardName").ToString
            FatherNameTextEdit.Text = dt.Rows(0).Item("FatherName").ToString
            MotherNameTextEdit.Text = dt.Rows(0).Item("MotherName").ToString
            ContactNoTextEdit.Text = dt.Rows(0).Item("ContactNo").ToString
            GenderComboBoxEdit.Text = dt.Rows(0).Item("Gender").ToString
            BirthDateDateEdit.EditValue = Convert.ToDateTime(dt.Rows(0).Item("BirthDate").ToString)
            BloodGroupComboBoxEdit.Text = dt.Rows(0).Item("BloodGroup").ToString
            ColourOfEyesTextEdit.Text = dt.Rows(0).Item("ColourOfEyes").ToString
            ColourOfHairTextEdit.Text = dt.Rows(0).Item("ColourOfHair").ToString
            MaritalStatusComboBoxEdit.Text = dt.Rows(0).Item("MaritalStatus").ToString
            IdentificationMark1TextEdit.Text = dt.Rows(0).Item("IdentificationMark1").ToString
            IdentificationMark2TextEdit.Text = dt.Rows(0).Item("IdentificationMark2").ToString
            PermanentAddressMemoEdit.Text = dt.Rows(0).Item("PermanentAddress").ToString
            PresentAddressMemoEdit.Text = dt.Rows(0).Item("PresentAddress").ToString
            AadharCardNoTextEdit.Text = dt.Rows(0).Item("AadharCardNo").ToString
            NomineeNameTextEdit.Text = dt.Rows(0).Item("NomineeName").ToString
            CriminalRecordsComboBoxEdit.Text = dt.Rows(0).Item("AnyPoliceOrCrimeRecords").ToString
            PersonalInsuranceComboBoxEdit.Text = dt.Rows(0).Item("AnyPersonalInsurance").ToString
            DrivingLicenseComboBoxEdit.Text = dt.Rows(0).Item("DrivingLicense").ToString
            DrivingLicenseNoTextEdit.Text = dt.Rows(0).Item("DrivingLicenseNo").ToString
            LicenseTypeComboBoxEdit.Text = dt.Rows(0).Item("LicenseType").ToString
            PhysicalApprearanceComboBoxEdit.Text = dt.Rows(0).Item("PhysicalApprearance").ToString
            LanguageKnown1ComboBoxEdit.Text = dt.Rows(0).Item("LanguageKnown1").ToString
            Read1CheckEdit.EditValue = Convert.ToBoolean(dt.Rows(0).Item("Read1").ToString)
            Write1CheckEdit.EditValue = Convert.ToBoolean(dt.Rows(0).Item("Write1").ToString)
            Speak1CheckEdit.EditValue = Convert.ToBoolean(dt.Rows(0).Item("Speak1").ToString)
            LanguageKnown2ComboBoxEdit.Text = dt.Rows(0).Item("LanguageKnown2").ToString
            Read2CheckEdit.EditValue = Convert.ToBoolean(dt.Rows(0).Item("Read2").ToString)
            Write2CheckEdit.EditValue = Convert.ToBoolean(dt.Rows(0).Item("Write2").ToString)
            Speak2CheckEdit.EditValue = Convert.ToBoolean(dt.Rows(0).Item("Speak2").ToString)
            NCCCertificateTextEdit.Text = dt.Rows(0).Item("NCCCertificate").ToString
            ShoeSizeTextEdit.Text = dt.Rows(0).Item("ShoeSize").ToString
            JerseySizeTextEdit.Text = dt.Rows(0).Item("JerseySize").ToString
            TrouserSizeTextEdit.Text = dt.Rows(0).Item("TrouserSize").ToString
            ComputerKnowledgeComboBoxEdit.Text = dt.Rows(0).Item("ComputerKnowledge").ToString
            HeightTextEdit.Text = dt.Rows(0).Item("Height").ToString
            WeightTextEdit.Text = dt.Rows(0).Item("Weight").ToString
            ChestTextEdit.Text = dt.Rows(0).Item("Chest").ToString
            BMITextEdit.Text = dt.Rows(0).Item("BMI").ToString
            SkillsMemoEdit.Text = dt.Rows(0).Item("Skills").ToString
            ReligionTextEdit.Text = dt.Rows(0).Item("Religion").ToString
            NationalityTextEdit.Text = dt.Rows(0).Item("Nationality").ToString
            UANNoTextEdit.Text = dt.Rows(0).Item("UAN").ToString
            PANNoTextEdit.Text = dt.Rows(0).Item("PAN").ToString
            AccountNoTextEdit.Text = dt.Rows(0).Item("BankAccountNo").ToString
            IFSCCodeTextEdit.Text = dt.Rows(0).Item("IFSCCode").ToString
            ESICNoTextEdit.Text = dt.Rows(0).Item("ESICNo").ToString
        Else
            GuardId = 0
        End If
    End Sub

    Private Sub Frm_GuardBio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set Validation
        DxValidationProvider1.ValidationMode = ValidationMode.Manual

        Dim securityagencyValidationRule As New ConditionValidationRule()
        securityagencyValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        securityagencyValidationRule.ErrorText = "Please enter a security agency"
        securityagencyValidationRule.ErrorType = ErrorType.Warning

        Dim WONoValidationRule As New ConditionValidationRule()
        WONoValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        WONoValidationRule.ErrorText = "Please enter a WO No"
        WONoValidationRule.ErrorType = ErrorType.Warning

        Dim permitNoValidationRule As New ConditionValidationRule()
        permitNoValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        permitNoValidationRule.ErrorText = "Please enter an entry permit no"
        permitNoValidationRule.ErrorType = ErrorType.Warning

        Dim guardNameValidationRule As New ConditionValidationRule()
        guardNameValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        guardNameValidationRule.ErrorText = "Please enter your fullname"
        guardNameValidationRule.ErrorType = ErrorType.Warning

        Dim fatherNameValidationRule As New ConditionValidationRule()
        fatherNameValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        fatherNameValidationRule.ErrorText = "Please enter a father name"
        fatherNameValidationRule.ErrorType = ErrorType.Warning

        Dim motherNameValidationRule As New ConditionValidationRule()
        motherNameValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        motherNameValidationRule.ErrorText = "Please enter a mother name"
        motherNameValidationRule.ErrorType = ErrorType.Warning

        Dim genderValidationRule As New ConditionValidationRule()
        genderValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        genderValidationRule.ErrorText = "Please select a gender"
        genderValidationRule.ErrorType = ErrorType.Warning

        Dim contactNoValidationRule As New ConditionValidationRule()
        contactNoValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        contactNoValidationRule.ErrorText = "Please enter a contact no"
        contactNoValidationRule.ErrorType = ErrorType.Warning

        Dim birthDateValidationRule As New ConditionValidationRule()
        birthDateValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        birthDateValidationRule.ErrorText = "Please enter a birth date"
        birthDateValidationRule.ErrorType = ErrorType.Warning

        Dim maritalStatusValidationRule As New ConditionValidationRule()
        maritalStatusValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        maritalStatusValidationRule.ErrorText = "Please select a marital status"
        maritalStatusValidationRule.ErrorType = ErrorType.Warning

        Dim permanentAddressValidationRule As New ConditionValidationRule()
        permanentAddressValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        permanentAddressValidationRule.ErrorText = "Please enter your permanent address"
        permanentAddressValidationRule.ErrorType = ErrorType.Warning

        Dim presentAddressValidationRule As New ConditionValidationRule()
        presentAddressValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        presentAddressValidationRule.ErrorText = "Please enter your present address"
        presentAddressValidationRule.ErrorType = ErrorType.Warning

        Dim IDProofAddressValidationRule As New ConditionValidationRule()
        IDProofAddressValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        IDProofAddressValidationRule.ErrorText = "Please select an Id proof option"
        IDProofAddressValidationRule.ErrorType = ErrorType.Warning

        Dim aadharnoValidationRule As New ConditionValidationRule()
        aadharnoValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        aadharnoValidationRule.ErrorText = "Please enter an aadhar card no"
        aadharnoValidationRule.ErrorType = ErrorType.Warning

        Dim criminalRecordsAddressValidationRule As New ConditionValidationRule()
        criminalRecordsAddressValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        criminalRecordsAddressValidationRule.ErrorText = "Please select an any option"
        criminalRecordsAddressValidationRule.ErrorType = ErrorType.Warning

        Dim personalInsuAddressValidationRule As New ConditionValidationRule()
        personalInsuAddressValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        personalInsuAddressValidationRule.ErrorText = "Please select an any option"
        personalInsuAddressValidationRule.ErrorType = ErrorType.Warning

        Dim drivingLicenseValidationRule As New ConditionValidationRule()
        drivingLicenseValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        drivingLicenseValidationRule.ErrorText = "Please select an any option"
        drivingLicenseValidationRule.ErrorType = ErrorType.Warning

        Dim physicalAppValidationRule As New ConditionValidationRule()
        physicalAppValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        physicalAppValidationRule.ErrorText = "Please select an any option"
        physicalAppValidationRule.ErrorType = ErrorType.Warning

        Dim languageValidationRule As New ConditionValidationRule()
        languageValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        languageValidationRule.ErrorText = "Please select an any option"
        languageValidationRule.ErrorType = ErrorType.Warning

        Dim computerKnowValidationRule As New ConditionValidationRule()
        computerKnowValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        computerKnowValidationRule.ErrorText = "Please select an any option"
        computerKnowValidationRule.ErrorType = ErrorType.Warning

        Dim religionValidationRule As New ConditionValidationRule()
        religionValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        religionValidationRule.ErrorText = "Please enter your religion"
        religionValidationRule.ErrorType = ErrorType.Warning

        Dim nationalityValidationRule As New ConditionValidationRule()
        nationalityValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        nationalityValidationRule.ErrorText = "Please enter your nationality"
        nationalityValidationRule.ErrorType = ErrorType.Warning

        DxValidationProvider1.SetValidationRule(SecurityAgencyTextEdit, securityagencyValidationRule)
        DxValidationProvider1.SetValidationRule(WONoTextEdit, WONoValidationRule)
        DxValidationProvider1.SetValidationRule(EntryPermitNoTextEdit, permitNoValidationRule)
        DxValidationProvider1.SetValidationRule(FullNameTextEdit, guardNameValidationRule)
        DxValidationProvider1.SetValidationRule(FatherNameTextEdit, fatherNameValidationRule)
        DxValidationProvider1.SetValidationRule(MotherNameTextEdit, motherNameValidationRule)
        DxValidationProvider1.SetValidationRule(GenderComboBoxEdit, genderValidationRule)
        DxValidationProvider1.SetValidationRule(ContactNoTextEdit, contactNoValidationRule)
        DxValidationProvider1.SetValidationRule(BirthDateDateEdit, birthDateValidationRule)
        DxValidationProvider1.SetValidationRule(MaritalStatusComboBoxEdit, maritalStatusValidationRule)
        DxValidationProvider1.SetValidationRule(PermanentAddressMemoEdit, permanentAddressValidationRule)
        DxValidationProvider1.SetValidationRule(PresentAddressMemoEdit, presentAddressValidationRule)
        DxValidationProvider1.SetValidationRule(AadharCardNoTextEdit, aadharnoValidationRule)
        DxValidationProvider1.SetValidationRule(CriminalRecordsComboBoxEdit, criminalRecordsAddressValidationRule)
        DxValidationProvider1.SetValidationRule(PersonalInsuranceComboBoxEdit, personalInsuAddressValidationRule)
        DxValidationProvider1.SetValidationRule(DrivingLicenseComboBoxEdit, drivingLicenseValidationRule)
        DxValidationProvider1.SetValidationRule(LanguageKnown1ComboBoxEdit, languageValidationRule)
        DxValidationProvider1.SetValidationRule(PhysicalApprearanceComboBoxEdit, physicalAppValidationRule)
        DxValidationProvider1.SetValidationRule(ComputerKnowledgeComboBoxEdit, computerKnowValidationRule)
        DxValidationProvider1.SetValidationRule(ReligionTextEdit, religionValidationRule)
        DxValidationProvider1.SetValidationRule(NationalityTextEdit, nationalityValidationRule)
    End Sub

    Public Sub saveData()
        Dim connectionstring As String = Nothing
        Dim connection As SqlConnection
        connectionstring = conStr
        connection = New SqlConnection(connectionstring)
        connection.Open()
        Dim rs As SqlCommand

        rs = New SqlCommand("Insert Into BioData (SecurityAgency, VendorCode, WONo, EntryPermitNo, GuardName, FatherName, MotherName, ContactNo, Gender, BirthDate, BloodGroup, 
                             ColourOfEyes, ColourOfHair, MaritalStatus, IdentificationMark1, IdentificationMark2, PermanentAddress, PresentAddress, AadharCardNo, NomineeName, AnyPoliceOrCrimeRecords, AnyPersonalInsurance, DrivingLicense, DrivingLicenseNo,
                              LicenseType, PhysicalApprearance, LanguageKnown1, Read1, Write1, Speak1, LanguageKnown2, Read2, Write2, Speak2, NCCCertificate, ShoeSize, JerseySize, TrouserSize, ComputerKnowledge,
                              Height, Weight, Chest, BMI, Skills, Religion, Nationality, UAN, PAN, BankAccountNo, IFSCCode, ESICNo, CreatedDate, ModifiedDate) values 
                             (@SecurityAgency, @VendorCode, @WONo, @EntryPermitNo, @GuardName, @FatherName, @MotherName, @ContactNo, @Gender, @BirthDate, @BloodGroup, 
                             @ColourOfEyes, @ColourOfHair, @MaritalStatus, @IdentificationMark1, @IdentificationMark2, @PermanentAddress, @PresentAddress, @AadharCardNo, @NomineeName, @AnyPoliceOrCrimeRecords, @AnyPersonalInsurance, @DrivingLicense, @DrivingLicenseNo,
                              @LicenseType, @PhysicalApprearance, @LanguageKnown1, @Read1, @Write1, @Speak1, @LanguageKnown2, @Read2, @Write2, @Speak2, @NCCCertificate, @ShoeSize, @JerseySize, @TrouserSize, @ComputerKnowledge,
                              @Height, @Weight, @Chest, @BMI, @Skills, @Religion, @Nationality, @UAN, @PAN, @BankAccountNo, @IFSCCode, @ESICNo, @CreatedDate, @ModifiedDate)" + "SELECT CAST(scope_identity() AS int)", connection)

        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@SecurityAgency", .SqlDbType = SqlDbType.NVarChar, .Size = 50, .Value = SecurityAgencyTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@VendorCode", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = VendorCodeTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@WONo", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = WONoTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@EntryPermitNo", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = EntryPermitNoTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@GuardName", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = FullNameTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@FatherName", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = FatherNameTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@MotherName", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = MotherNameTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@ContactNo", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = ContactNoTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Gender", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = GenderComboBoxEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@BirthDate", .SqlDbType = SqlDbType.DateTime, .Value = BirthDateDateEdit.EditValue})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@BloodGroup", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = BloodGroupComboBoxEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@ColourOfEyes", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = ColourOfEyesTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@ColourOfHair", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = ColourOfHairTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@MaritalStatus", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = MaritalStatusComboBoxEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@IdentificationMark1", .SqlDbType = SqlDbType.NVarChar, .Size = 50, .Value = IdentificationMark1TextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@IdentificationMark2", .SqlDbType = SqlDbType.NVarChar, .Size = 50, .Value = IdentificationMark2TextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@PermanentAddress", .SqlDbType = SqlDbType.NVarChar, .Size = 100, .Value = PermanentAddressMemoEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@PresentAddress", .SqlDbType = SqlDbType.NVarChar, .Size = 100, .Value = PresentAddressMemoEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@AadharCardNo", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = AadharCardNoTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@NomineeName", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = NomineeNameTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@AnyPoliceOrCrimeRecords", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = CriminalRecordsComboBoxEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@AnyPersonalInsurance", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = PersonalInsuranceComboBoxEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@DrivingLicense", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = DrivingLicenseComboBoxEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@DrivingLicenseNo", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = DrivingLicenseNoTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@LicenseType", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = LicenseTypeComboBoxEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@PhysicalApprearance", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = PhysicalApprearanceComboBoxEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@LanguageKnown1", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = LanguageKnown1ComboBoxEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Read1", .SqlDbType = SqlDbType.Bit, .Value = Read1CheckEdit.EditValue})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Write1", .SqlDbType = SqlDbType.Bit, .Value = Write1CheckEdit.EditValue})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Speak1", .SqlDbType = SqlDbType.Bit, .Value = Speak1CheckEdit.EditValue})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@LanguageKnown2", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = LanguageKnown2ComboBoxEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Read2", .SqlDbType = SqlDbType.Bit, .Value = Read2CheckEdit.EditValue})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Write2", .SqlDbType = SqlDbType.Bit, .Value = Write2CheckEdit.EditValue})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Speak2", .SqlDbType = SqlDbType.Bit, .Value = Speak2CheckEdit.EditValue})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@NCCCertificate", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = NCCCertificateTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@ShoeSize", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = ShoeSizeTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@JerseySize", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = JerseySizeTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@TrouserSize", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = TrouserSizeTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@ComputerKnowledge", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = ComputerKnowledgeComboBoxEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Height", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = HeightTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Weight", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = WeightTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Chest", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = ChestTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@BMI", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = BMITextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Skills", .SqlDbType = SqlDbType.NVarChar, .Size = 100, .Value = SkillsMemoEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Religion", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = ReligionTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Nationality", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = NationalityTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@UAN", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = UANNoTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@PAN", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = PANNoTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@BankAccountNo", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = AccountNoTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@IFSCCode", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = IFSCCodeTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@ESICNo", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = ESICNoTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@CreatedDate", .SqlDbType = SqlDbType.DateTime, .Value = Now})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@ModifiedDate", .SqlDbType = SqlDbType.DateTime, .Value = Now})

        GuardId = CInt(rs.ExecuteScalar())
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

        rs = New SqlCommand("Update BioData set SecurityAgency=@SecurityAgency, VendorCode=@VendorCode, WONo=@WONo, EntryPermitNo=@EntryPermitNo, GuardName=@GuardName, FatherName=@FatherName, MotherName=@MotherName, ContactNo=@ContactNo, Gender=@Gender, BirthDate=@BirthDate, BloodGroup=@BloodGroup, 
                             ColourOfEyes=@ColourOfEyes, ColourOfHair=@ColourOfHair, MaritalStatus=@MaritalStatus, IdentificationMark1=@IdentificationMark1, IdentificationMark2=@IdentificationMark2, PermanentAddress=@PermanentAddress, PresentAddress=@PresentAddress, AadharCardNo=@AadharCardNo, NomineeName=@NomineeName, AnyPoliceOrCrimeRecords=@AnyPoliceOrCrimeRecords, AnyPersonalInsurance=@AnyPersonalInsurance, DrivingLicense=@DrivingLicense, DrivingLicenseNo=@DrivingLicenseNo,
                              LicenseType=@LicenseType, PhysicalApprearance=@PhysicalApprearance, LanguageKnown1=@LanguageKnown1, Read1=@Read1, Write1=@Write1, Speak1=@Speak1, LanguageKnown2=@LanguageKnown2, Read2=@Read2, Write2=@Write2, Speak2=@Speak2, NCCCertificate=@NCCCertificate, ShoeSize=@ShoeSize, JerseySize=@JerseySize, TrouserSize=@TrouserSize, ComputerKnowledge=@ComputerKnowledge,
                              Height=@Height, Weight=@Weight, Chest=@Chest, BMI=@BMI, Skills=@Skills, Religion=@Religion, Nationality=@Nationality, UAN=@UAN, PAN=@PAN, BankAccountNo=@BankAccountNo, IFSCCode=@IFSCCode, ESICNo=@ESICNo Where Id=@Id", connection)

        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@SecurityAgency", .SqlDbType = SqlDbType.NVarChar, .Size = 50, .Value = SecurityAgencyTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@VendorCode", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = VendorCodeTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@WONo", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = WONoTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@EntryPermitNo", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = EntryPermitNoTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@GuardName", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = FullNameTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@FatherName", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = FatherNameTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@MotherName", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = MotherNameTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@ContactNo", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = ContactNoTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Gender", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = GenderComboBoxEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@BirthDate", .SqlDbType = SqlDbType.DateTime, .Value = BirthDateDateEdit.EditValue})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@BloodGroup", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = BloodGroupComboBoxEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@ColourOfEyes", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = ColourOfEyesTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@ColourOfHair", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = ColourOfHairTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@MaritalStatus", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = MaritalStatusComboBoxEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@IdentificationMark1", .SqlDbType = SqlDbType.NVarChar, .Size = 50, .Value = IdentificationMark1TextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@IdentificationMark2", .SqlDbType = SqlDbType.NVarChar, .Size = 50, .Value = IdentificationMark2TextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@PermanentAddress", .SqlDbType = SqlDbType.NVarChar, .Size = 100, .Value = PermanentAddressMemoEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@PresentAddress", .SqlDbType = SqlDbType.NVarChar, .Size = 100, .Value = PresentAddressMemoEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@AadharCardNo", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = AadharCardNoTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@NomineeName", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = NomineeNameTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@AnyPoliceOrCrimeRecords", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = CriminalRecordsComboBoxEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@AnyPersonalInsurance", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = PersonalInsuranceComboBoxEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@DrivingLicense", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = DrivingLicenseComboBoxEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@DrivingLicenseNo", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = DrivingLicenseNoTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@LicenseType", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = LicenseTypeComboBoxEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@PhysicalApprearance", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = PhysicalApprearanceComboBoxEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@LanguageKnown1", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = LanguageKnown1ComboBoxEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Read1", .SqlDbType = SqlDbType.Bit, .Value = Read1CheckEdit.EditValue})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Write1", .SqlDbType = SqlDbType.Bit, .Value = Write1CheckEdit.EditValue})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Speak1", .SqlDbType = SqlDbType.Bit, .Value = Speak1CheckEdit.EditValue})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@LanguageKnown2", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = LanguageKnown2ComboBoxEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Read2", .SqlDbType = SqlDbType.Bit, .Value = Read2CheckEdit.EditValue})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Write2", .SqlDbType = SqlDbType.Bit, .Value = Write2CheckEdit.EditValue})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Speak2", .SqlDbType = SqlDbType.Bit, .Value = Speak2CheckEdit.EditValue})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@NCCCertificate", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = NCCCertificateTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@ShoeSize", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = ShoeSizeTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@JerseySize", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = JerseySizeTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@TrouserSize", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = TrouserSizeTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@ComputerKnowledge", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = ComputerKnowledgeComboBoxEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Height", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = HeightTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Weight", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = WeightTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Chest", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = ChestTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@BMI", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = BMITextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Skills", .SqlDbType = SqlDbType.NVarChar, .Size = 100, .Value = SkillsMemoEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Religion", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = ReligionTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Nationality", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = NationalityTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@UAN", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = UANNoTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@PAN", .SqlDbType = SqlDbType.NVarChar, .Size = 10, .Value = PANNoTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@BankAccountNo", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = AccountNoTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@IFSCCode", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = IFSCCodeTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@ESICNo", .SqlDbType = SqlDbType.NVarChar, .Size = 20, .Value = ESICNoTextEdit.Text})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@ModifiedDate", .SqlDbType = SqlDbType.DateTime, .Value = Now})
        rs.Parameters.Add(New SqlParameter With {.ParameterName = "@Id", .SqlDbType = SqlDbType.Int, .Value = GuardId})

        rs.ExecuteNonQuery()
        connection.Close()
        connection.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If DxValidationProvider1.Validate() Then
            Dim isValidnumber As Boolean = Aadharcard.validateVerhoeff(AadharCardNoTextEdit.Text.Replace(" ", ""))
            If isValidnumber Then
                Start_Waiting()
                If GuardId = 0 Then
                    saveData()
                Else
                    updateData()
                End If
                getProfile() : setGridview() : End_Waiting()
                GuardNavigationFrame.SelectedPageIndex = 1
            Else
                XtraMessageBox.Show("Wrong AadharCard Number", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Sub getProfile()
        Dim connectionstring As String = conStr
        Dim connection As New SqlConnection(connectionstring)
        Dim sql As New SqlCommand("Select Id,GuardId,Company,Designation,JoinDate,ResignationDate, 
                                   case when ResignationDate is null then dbo.udfDateDiffinYrMonDay(JoinDate,GETDATE())
                                   else dbo.udfDateDiffinYrMonDay(JoinDate,ResignationDate) end As Experience From Profile Where GuardId=" + GuardId.ToString, connection)

        Dim dataadapter As New SqlDataAdapter(sql)
        Dim dt As New DataTable()
        connection.Open()

        dataadapter.Fill(dt)
        GridControl1.DataSource = dt
        connection.Dispose()
    End Sub

    Sub setGridview()
        With GridView1
            .Columns("Id").Visible = False
            .Columns("GuardId").Visible = False
            .Columns("Company").Name = "Company/Org."
        End With
        GridView1.BestFitColumns()
        GridView1.OptionsBehavior.Editable = False
        GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Dim frm As New Frm_Profile(0, GuardId)
        If frm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            Start_Waiting() : getProfile() : setGridview() : End_Waiting()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim MyRow As DataRow = GridView1.GetFocusedDataRow()
        Dim Id = CInt(MyRow("Id").ToString())

        Dim frm As New Frm_Profile(Id, GuardId)
        If frm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            Start_Waiting() : getProfile() : setGridview() : End_Waiting()
        End If
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        GuardNavigationFrame.SelectedPageIndex = 0
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.DialogResult = DialogResult.OK
        Me.Dispose()
    End Sub

    Private Sub Frm_GuardBio_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.DialogResult = DialogResult.OK
        Me.Dispose()
    End Sub
End Class

Public Class Aadharcard
    Shared d As Integer(,) = New Integer(,) {
    {0, 1, 2, 3, 4, 5, 6, 7, 8, 9},
    {1, 2, 3, 4, 0, 6, 7, 8, 9, 5},
    {2, 3, 4, 0, 1, 7, 8, 9, 5, 6},
    {3, 4, 0, 1, 2, 8, 9, 5, 6, 7},
    {4, 0, 1, 2, 3, 9, 5, 6, 7, 8},
    {5, 9, 8, 7, 6, 0, 4, 3, 2, 1},
    {6, 5, 9, 8, 7, 1, 0, 4, 3, 2},
    {7, 6, 5, 9, 8, 2, 1, 0, 4, 3},
    {8, 7, 6, 5, 9, 3, 2, 1, 0, 4},
    {9, 8, 7, 6, 5, 4, 3, 2, 1, 0}}
    Shared p As Integer(,) = New Integer(,) {
    {0, 1, 2, 3, 4, 5, 6, 7, 8, 9},
    {1, 5, 7, 6, 2, 8, 3, 0, 9, 4},
    {5, 8, 0, 3, 7, 9, 6, 1, 4, 2},
    {8, 9, 1, 6, 0, 4, 3, 5, 2, 7},
    {9, 4, 5, 3, 1, 2, 6, 8, 7, 0},
    {4, 2, 8, 6, 5, 7, 3, 9, 0, 1},
    {2, 7, 9, 3, 8, 0, 6, 4, 1, 5},
    {7, 0, 4, 6, 9, 1, 3, 2, 5, 8}}
    Shared inv As Integer() = {0, 4, 3, 2, 1, 5, 6, 7, 8, 9}

    Public Shared Function validateVerhoeff(ByVal num As String) As Boolean
        Dim c As Integer = 0
        Dim myArray As Integer() = StringToReversedIntArray(num)

        For i As Integer = 0 To myArray.Length - 1
            c = d(c, p((i Mod 8), myArray(i)))
        Next

        Return c = 0
    End Function

    Private Shared Function StringToReversedIntArray(ByVal num As String) As Integer()
        Dim myArray As Integer() = New Integer(num.Length - 1) {}

        For i As Integer = 0 To num.Length - 1
            myArray(i) = Integer.Parse(num.Substring(i, 1))
        Next

        Array.Reverse(myArray)
        Return myArray
    End Function
End Class
