Public Class Form1
    Public decParts As Decimal
    Public decLabor As Decimal

    Function ValidateInputFields() As Boolean
        'Check whether the price of parts and labor is numeric and positive'
        If Not Decimal.TryParse(txtParts.Text, decParts) Then
            MessageBox.Show("Price of parts must be numeric")
            Return False
        End If
        If decParts < 0 Then
            MessageBox.Show("Price of parts cannot be less than zero")
            Return False
        End If

        If Not Decimal.TryParse(txtLabor.Text, decLabor) Then
            MessageBox.Show("Labor must be numeric")
            Return False
        End If
        If decLabor < 0 Then
            MessageBox.Show("Labor in minutes cannot be less than 0")
            Return False
        End If
        Return True
    End Function
    Function CalcOilLubeCharges() As Decimal 'Calculate all oil and lubrication charges'
        Dim decOilCharges As Decimal
        If chkOil.Checked Then
            decOilCharges += 36
        End If
        If chkLube.Checked Then
            decOilCharges += 28
        End If
        Return decOilCharges
    End Function

    Function CalcFlushCharges() As Decimal 'Calculate all radiator and transmission flush charges'
        Dim decFlushCharges As Decimal
        If chkRadiator.Checked Then
            decFlushCharges += 50
        End If
        If chkTransmission.Checked Then
            decFlushCharges += 120
        End If
        Return decFlushCharges
    End Function

    Function CalcMiscCharges() As Decimal ' Calculate inspection, muffler, and tire rotation charges.'
        Dim decMiscCharges As Decimal
        If chkInspection.Checked Then
            decMiscCharges += 15
        End If
        If chkMuffler.Checked Then
            decMiscCharges += 200
        End If

        If chkTire.Checked Then
            decMiscCharges += 20
        End If
        Return decMiscCharges
    End Function

    ' Calculate and display the total of all charges,
    ' including labor, parts, and services.
    Sub CalculateTotalCharges()
        Dim Total As Decimal
        Dim Time As Decimal
        If ValidateInputFields() Then
            Time = decLabor / 60
            Total = CalcOilLubeCharges() + CalcFlushCharges() + CalcMiscCharges() + Time * 60
            lblServLabPrint.Text = Total.ToString("c")
            lblPartPrint.Text = decParts.ToString("c")
            lblTaxPrint.Text = (0.06 * decParts).ToString("c")
            lblTotalPrint.Text = (Total + 1.06 * decParts).ToString("c")
        End If
    End Sub


    Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        CalculateTotalCharges()
    End Sub

    ' Reset the oil change and lube job check boxes.
    Sub ClearOilLube()
        chkOil.Checked = False
        chkLube.Checked = False
    End Sub

    ' Clear the radiator and transmission flush check boxes.
    Sub ClearFlushes()
        chkRadiator.Checked = False
        chkTransmission.Checked = False
    End Sub

    ' Clear the inspection, muffler replacement, and tire
    ' rotation check boxes.
    Sub ClearMisc()
        chkInspection.Checked = False
        chkMuffler.Checked = False
        chkTire.Checked = False
    End Sub

    ' Clear the parts and labor check boxes.
    Sub ClearOther()
        txtParts.Clear()
        txtLabor.Clear()
        lblServLabPrint.Text = String.Empty
        lblPartPrint.Text = String.Empty
        lblTaxPrint.Text = String.Empty
        lblTotalPrint.Text = String.Empty
    End Sub

    Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Reset the oil change and lube job check boxes.'
        ClearOilLube()
        ClearFlushes()
        ClearMisc()
        ClearOther()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        'Close the form'
    End Sub
End Class
