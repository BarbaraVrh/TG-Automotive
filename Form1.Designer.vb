<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        Label1 = New Label()
        chkLube = New CheckBox()
        chkOil = New CheckBox()
        GroupBox2 = New GroupBox()
        Label4 = New Label()
        Label3 = New Label()
        chkRadiator = New CheckBox()
        chkTransmission = New CheckBox()
        GroupBox3 = New GroupBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        chkInspection = New CheckBox()
        chkTire = New CheckBox()
        chkMuffler = New CheckBox()
        GroupBox4 = New GroupBox()
        Label9 = New Label()
        Label8 = New Label()
        txtLabor = New TextBox()
        txtParts = New TextBox()
        lblLabor = New Label()
        lblParts = New Label()
        GroupBox5 = New GroupBox()
        lblTaxPrint = New Label()
        lblTotalPrint = New Label()
        lblPartPrint = New Label()
        lblServLabPrint = New Label()
        lblTotal = New Label()
        lblServLab = New Label()
        lblPart = New Label()
        lblTax = New Label()
        btnCalculate = New Button()
        btnClear = New Button()
        btnExit = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox5.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(chkLube)
        GroupBox1.Controls.Add(chkOil)
        GroupBox1.Location = New Point(17, 24)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(275, 122)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Oil and Lubrication"
        GroupBox1.UseCompatibleTextRendering = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(178, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 20)
        Label2.TabIndex = 9
        Label2.Text = "28.00"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(178, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 20)
        Label1.TabIndex = 8
        Label1.Text = "36.00"
        ' 
        ' chkLube
        ' 
        chkLube.AutoSize = True
        chkLube.Location = New Point(22, 78)
        chkLube.Name = "chkLube"
        chkLube.Size = New Size(90, 24)
        chkLube.TabIndex = 7
        chkLube.Text = "Lube Job"
        chkLube.UseVisualStyleBackColor = True
        ' 
        ' chkOil
        ' 
        chkOil.AutoSize = True
        chkOil.Location = New Point(22, 35)
        chkOil.Name = "chkOil"
        chkOil.Size = New Size(104, 24)
        chkOil.TabIndex = 6
        chkOil.Text = "Oil Change"
        chkOil.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(chkRadiator)
        GroupBox2.Controls.Add(chkTransmission)
        GroupBox2.Location = New Point(332, 24)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(312, 122)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Radiator and Transmission"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(191, 78)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 20)
        Label4.TabIndex = 13
        Label4.Text = "120.00"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(199, 34)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 20)
        Label3.TabIndex = 12
        Label3.Text = "50.00"
        ' 
        ' chkRadiator
        ' 
        chkRadiator.AutoSize = True
        chkRadiator.Location = New Point(22, 34)
        chkRadiator.Name = "chkRadiator"
        chkRadiator.Size = New Size(125, 24)
        chkRadiator.TabIndex = 10
        chkRadiator.Text = "Radiator Flush"
        chkRadiator.UseVisualStyleBackColor = True
        ' 
        ' chkTransmission
        ' 
        chkTransmission.AutoSize = True
        chkTransmission.Location = New Point(22, 78)
        chkTransmission.Name = "chkTransmission"
        chkTransmission.Size = New Size(152, 24)
        chkTransmission.TabIndex = 11
        chkTransmission.Text = "Transmission Flush"
        chkTransmission.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(chkInspection)
        GroupBox3.Controls.Add(chkTire)
        GroupBox3.Controls.Add(chkMuffler)
        GroupBox3.Location = New Point(17, 198)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(275, 166)
        GroupBox3.TabIndex = 1
        GroupBox3.TabStop = False
        GroupBox3.Text = "Miscellaneous"
        GroupBox3.UseCompatibleTextRendering = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(186, 126)
        Label7.Name = "Label7"
        Label7.Size = New Size(44, 20)
        Label7.TabIndex = 12
        Label7.Text = "20.00"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(186, 82)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 20)
        Label6.TabIndex = 11
        Label6.Text = "200.00"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(186, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 20)
        Label5.TabIndex = 10
        Label5.Text = "15.00"
        ' 
        ' chkInspection
        ' 
        chkInspection.AutoSize = True
        chkInspection.Location = New Point(22, 41)
        chkInspection.Name = "chkInspection"
        chkInspection.Size = New Size(99, 24)
        chkInspection.TabIndex = 9
        chkInspection.Text = "Inspection"
        chkInspection.UseVisualStyleBackColor = True
        ' 
        ' chkTire
        ' 
        chkTire.AutoSize = True
        chkTire.Location = New Point(22, 126)
        chkTire.Name = "chkTire"
        chkTire.Size = New Size(117, 24)
        chkTire.TabIndex = 8
        chkTire.Text = "Tire Rotation"
        chkTire.UseVisualStyleBackColor = True
        ' 
        ' chkMuffler
        ' 
        chkMuffler.AutoSize = True
        chkMuffler.Location = New Point(22, 82)
        chkMuffler.Name = "chkMuffler"
        chkMuffler.Size = New Size(136, 24)
        chkMuffler.TabIndex = 7
        chkMuffler.Text = "Replace Muffler"
        chkMuffler.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Label9)
        GroupBox4.Controls.Add(Label8)
        GroupBox4.Controls.Add(txtLabor)
        GroupBox4.Controls.Add(txtParts)
        GroupBox4.Controls.Add(lblLabor)
        GroupBox4.Controls.Add(lblParts)
        GroupBox4.Location = New Point(332, 198)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(312, 166)
        GroupBox4.TabIndex = 1
        GroupBox4.TabStop = False
        GroupBox4.Text = "Parts and labor"
        GroupBox4.UseCompatibleTextRendering = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(240, 104)
        Label9.Name = "Label9"
        Label9.Size = New Size(61, 20)
        Label9.TabIndex = 5
        Label9.Text = "minutes"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(240, 52)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 20)
        Label8.TabIndex = 4
        Label8.Text = "dollars"
        ' 
        ' txtLabor
        ' 
        txtLabor.BorderStyle = BorderStyle.FixedSingle
        txtLabor.Location = New Point(130, 102)
        txtLabor.Name = "txtLabor"
        txtLabor.Size = New Size(79, 27)
        txtLabor.TabIndex = 3
        ' 
        ' txtParts
        ' 
        txtParts.BorderStyle = BorderStyle.FixedSingle
        txtParts.Location = New Point(130, 49)
        txtParts.Name = "txtParts"
        txtParts.Size = New Size(79, 27)
        txtParts.TabIndex = 2
        ' 
        ' lblLabor
        ' 
        lblLabor.AutoSize = True
        lblLabor.Location = New Point(35, 109)
        lblLabor.Name = "lblLabor"
        lblLabor.Size = New Size(47, 20)
        lblLabor.TabIndex = 1
        lblLabor.Text = "Labor"
        ' 
        ' lblParts
        ' 
        lblParts.AutoSize = True
        lblParts.Location = New Point(35, 52)
        lblParts.Name = "lblParts"
        lblParts.Size = New Size(40, 20)
        lblParts.TabIndex = 0
        lblParts.Text = "Parts"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(lblTaxPrint)
        GroupBox5.Controls.Add(lblTotalPrint)
        GroupBox5.Controls.Add(lblPartPrint)
        GroupBox5.Controls.Add(lblServLabPrint)
        GroupBox5.Controls.Add(lblTotal)
        GroupBox5.Controls.Add(lblServLab)
        GroupBox5.Controls.Add(lblPart)
        GroupBox5.Controls.Add(lblTax)
        GroupBox5.Location = New Point(17, 386)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(627, 139)
        GroupBox5.TabIndex = 2
        GroupBox5.TabStop = False
        GroupBox5.Text = "Summary of Charges"
        ' 
        ' lblTaxPrint
        ' 
        lblTaxPrint.BorderStyle = BorderStyle.Fixed3D
        lblTaxPrint.Location = New Point(465, 40)
        lblTaxPrint.Name = "lblTaxPrint"
        lblTaxPrint.Size = New Size(127, 31)
        lblTaxPrint.TabIndex = 7
        ' 
        ' lblTotalPrint
        ' 
        lblTotalPrint.BorderStyle = BorderStyle.Fixed3D
        lblTotalPrint.Location = New Point(465, 93)
        lblTotalPrint.Name = "lblTotalPrint"
        lblTotalPrint.Size = New Size(127, 30)
        lblTotalPrint.TabIndex = 6
        ' 
        ' lblPartPrint
        ' 
        lblPartPrint.BorderStyle = BorderStyle.Fixed3D
        lblPartPrint.Location = New Point(178, 93)
        lblPartPrint.Name = "lblPartPrint"
        lblPartPrint.Size = New Size(128, 30)
        lblPartPrint.TabIndex = 5
        ' 
        ' lblServLabPrint
        ' 
        lblServLabPrint.BorderStyle = BorderStyle.Fixed3D
        lblServLabPrint.Location = New Point(178, 40)
        lblServLabPrint.Name = "lblServLabPrint"
        lblServLabPrint.Size = New Size(128, 31)
        lblServLabPrint.TabIndex = 4
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(350, 94)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(75, 20)
        lblTotal.TabIndex = 3
        lblTotal.Text = "Total Fees"
        ' 
        ' lblServLab
        ' 
        lblServLab.AutoSize = True
        lblServLab.Location = New Point(22, 40)
        lblServLab.Name = "lblServLab"
        lblServLab.Size = New Size(133, 20)
        lblServLab.TabIndex = 2
        lblServLab.Text = "Services and Labor"
        ' 
        ' lblPart
        ' 
        lblPart.AutoSize = True
        lblPart.Location = New Point(36, 93)
        lblPart.Name = "lblPart"
        lblPart.Size = New Size(40, 20)
        lblPart.TabIndex = 1
        lblPart.Text = "Parts"
        ' 
        ' lblTax
        ' 
        lblTax.AutoSize = True
        lblTax.Location = New Point(350, 41)
        lblTax.Name = "lblTax"
        lblTax.Size = New Size(98, 20)
        lblTax.TabIndex = 0
        lblTax.Text = "Tax( on parts)"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(54, 573)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(133, 29)
        btnCalculate.TabIndex = 3
        btnCalculate.Text = "Calculate Total"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(235, 573)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 4
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(398, 573)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 5
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(663, 654)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkOil As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkLube As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chkRadiator As CheckBox
    Friend WithEvents chkTransmission As CheckBox
    Friend WithEvents chkInspection As CheckBox
    Friend WithEvents chkTire As CheckBox
    Friend WithEvents chkMuffler As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLabor As TextBox
    Friend WithEvents txtParts As TextBox
    Friend WithEvents lblLabor As Label
    Friend WithEvents lblParts As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblServLab As Label
    Friend WithEvents lblPart As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTaxPrint As Label
    Friend WithEvents lblTotalPrint As Label
    Friend WithEvents lblPartPrint As Label
    Friend WithEvents lblServLabPrint As Label
End Class
