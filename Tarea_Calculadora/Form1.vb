Public Class Form1

    Dim numAnterior, numActual, operacion As Decimal

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        'Cerrar Formulario
        Application.Exit()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        'Minimizar Formulario
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Colocar los valores de la pantalla en el textbox
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtPantalla.Text += "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtPantalla.Text += "1"
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtPantalla.Text += "2"
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtPantalla.Text += "3"
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtPantalla.Text += "4"
    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtPantalla.Text += "5"
    End Sub
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtPantalla.Text += "6"
    End Sub
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtPantalla.Text += "7"
    End Sub
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtPantalla.Text += "8"
    End Sub
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtPantalla.Text += "9"
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        'If para ver si se puede borrar algo
        If (txtPantalla.Text.Length > 0) Then
            'Borrar último caracter con substring
            txtPantalla.Text = txtPantalla.Text.Substring(0, txtPantalla.Text.Length - 1)
        Else
            'Envío de error
            txtPantalla.Enabled = False
            txtPantalla.Text = "Error" & vbNewLine & "Presiona el botón Limpiar"
        End If

    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        'If para validar el formato del texto
        If (Not Double.TryParse(txtPantalla.Text, numActual)) Then
            'Envío de error
            txtPantalla.Text = "Error" & vbNewLine & "Presiona el botón Limpiar"
            txtPantalla.Enabled = False
            Return
        End If

        'Caso division por 0
        If (operacion = 4 And txtPantalla.Text = 0) Then
            txtPantalla.Text = "Error" & vbNewLine & "Presiona el botón Limpiar"
            txtPantalla.Enabled = False
            Return
        End If
        numActual = txtPantalla.Text
        txtPantalla.Clear()

        'Select case para poder validar la operacion
        Select Case operacion
            Case 1
                txtPantalla.Text = numActual + numAnterior
            Case 2
                txtPantalla.Text = numAnterior - numActual
            Case 3
                txtPantalla.Text = (numAnterior * numActual)
            Case 4
                txtPantalla.Text = (numAnterior / numActual)
        End Select
    End Sub

    Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click
        'If para validar el formato del texto
        If (Not Double.TryParse(txtPantalla.Text, numAnterior)) Then
            txtPantalla.Enabled = False
            txtPantalla.Text = "Error" & vbNewLine & "Presiona el botón Limpiar"
            Return
        End If

        'Declaración número de operación y guardado del primer número
        numAnterior = txtPantalla.Text
        txtPantalla.Clear()
        operacion = 2
    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        'If para validar el formato del texto
        If (Not Double.TryParse(txtPantalla.Text, numAnterior)) Then
            txtPantalla.Enabled = False
            txtPantalla.Text = "Error" & vbNewLine & "Presiona el botón Limpiar"
            Return
        End If

        'Declaración número de operación y guardado del primer número
        numAnterior = txtPantalla.Text
        txtPantalla.Clear()
        operacion = 3
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnComa.Click
        txtPantalla.Text += ","
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        'If para validar el formato del texto
        If (Not Double.TryParse(txtPantalla.Text, numAnterior)) Then
            txtPantalla.Enabled = False
            txtPantalla.Text = "Error" & vbNewLine & "Presiona el botón Limpiar"
            Return
        End If
        'Declaración número de operación y guardado del primer número
        numAnterior = txtPantalla.Text
        txtPantalla.Clear()
        operacion = 4
    End Sub

    Private Sub btnPotencia_Click(sender As Object, e As EventArgs) Handles btnPotencia.Click
        'If para validar el formato del texto
        If (Not Double.TryParse(txtPantalla.Text, numAnterior)) Then
            txtPantalla.Enabled = False
            txtPantalla.Text = "Error" & vbNewLine & "Presiona el botón Limpiar"
            Return
        End If

        'Declaración número de operación y realización de operación potencia.
        numAnterior = txtPantalla.Text
        txtPantalla.Clear()

        txtPantalla.Text = (numAnterior ^ 2)
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        'Limpiar textbox
        txtPantalla.Clear()
        txtPantalla.Enabled = True
    End Sub

    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        'If para validar el formato del texto
        If (Not Double.TryParse(txtPantalla.Text, numAnterior)) Then
            txtPantalla.Enabled = False
            txtPantalla.Text = "Error" & vbNewLine & "Presiona el botón Limpiar"
            Return
        End If

        'Declaración número de operación y guardado del primer número
        numAnterior = txtPantalla.Text
        txtPantalla.Clear()
        operacion = 1
    End Sub
End Class