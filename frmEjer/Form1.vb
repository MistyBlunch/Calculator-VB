Public Class Form1
    Public xOperacion As Boolean = False
    Public xOperador As String
    Public xNumero1 As Double
    Public xNumero2 As Double
    Public xMemory As Double

#Region "Procedimientos"
    'procedimiento
    Sub Punto_insercion()
        lblVisor.Focus()
        lblVisor.SelectionStart = lblVisor.Text.Length
        lblVisor.SelectionLength = lblVisor.Text.Length
    End Sub

    Sub Digita_Numero(ByVal xNum As Integer)
        'Extendido para cada botón
        'If xOperacion = True Then xNumero1 = lblVisor.Text : lblVisor.Text = xNum : xOperacion = False : Exit Sub
        'If CInt(lblVisor.Text) = 0 Then lblVisor.Text = ""
        'lblVisor.Text = lblVisor.Text & xNum

        'Resumido para cualquier botón
        If xOperacion = True Then xNumero1 = lblVisor.Text : lblVisor.Text = xNum : xOperacion = False : Exit Sub
        If lblVisor.Text = 0 Then

            If xNum = 0 Then
                'lblVisor.Focus()
                Punto_insercion()
                Exit Sub
            Else
                lblVisor.Text = ""
            End If
        End If
        lblVisor.Text = lblVisor.Text & xNum
        Punto_insercion()
    End Sub

    Sub Mostrar_Resultado(ByVal xOpe As String)
        Select Case xOpe
            Case "+" : lblVisor.Text = xNumero1 + xNumero2
            Case "-" : lblVisor.Text = xNumero1 - xNumero2
            Case "*" : lblVisor.Text = xNumero1 * xNumero2
            Case "/" : lblVisor.Text = xNumero1 / xNumero2
            Case "^" : lblVisor.Text = xNumero1 ^ xNumero2
            Case "sqrt" : lblVisor.Text = xNumero2 ^ (1 / xNumero1)
                'Case "CE" : lblVisor.Text = xNumero1 And xNumero2 = 0
        End Select
    End Sub
#End Region

#Region "Btn Numéricos"


    Private Sub btnCero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCero.Click
        Digita_Numero(0)
    End Sub

    Private Sub btnUno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUno.Click
        Digita_Numero(1)
        'If CInt(lblVisor.Text) = 0 Then lblVisor.Text = ""
        'If lblVisor.Text <> "0" Then
        '    lblVisor.Text = lblVisor.Text & 1
        'End If
    End Sub

    Private Sub btnDos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDos.Click
        Digita_Numero(2)
    End Sub

    Private Sub btnTres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTres.Click
        Digita_Numero(3)
    End Sub

    Private Sub btnCuatro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuatro.Click
        Digita_Numero(4)
    End Sub

    Private Sub btnCinco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCinco.Click
        Digita_Numero(5)
    End Sub

    Private Sub btnSeis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeis.Click
        Digita_Numero(6)
    End Sub

    Private Sub btnSiete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiete.Click
        Digita_Numero(7)
    End Sub

    Private Sub btnOcho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOcho.Click
        Digita_Numero(8)
    End Sub

    Private Sub btnNueve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueve.Click
        Digita_Numero(9)
    End Sub
#End Region
#Region "Operadores"

    Private Sub btnMasMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasMenos.Click
        If CInt(lblVisor.Text) = 0 Then Exit Sub

        If Mid(lblVisor.Text, 1, 1) = "-" Then
            lblVisor.Text = Microsoft.VisualBasic.Right(lblVisor.Text, lblVisor.Text.Length - 1)
        Else
            lblVisor.Text = "-" & lblVisor.Text
        End If
        'no pone la coma en un numero decimal(probar con btnUnosobreX)

    End Sub

    Private Sub btnComa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComa.Click
        Dim xVerificarComa As Boolean = False
        For i = 1 To lblVisor.Text.Length
            If Mid(lblVisor.Text, i, 1) = "," Then
                xVerificarComa = True
                Exit Sub
            End If
        Next

        If xVerificarComa = False Then lblVisor.Text = lblVisor.Text & ","

    End Sub

    Private Sub btnSqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSqrt.Click
        xOperador = "sqrt" : xOperacion = True
    End Sub

    Private Sub btnPotetencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPotetencia.Click
        xOperador = "^" : xOperacion = True
    End Sub

    Private Sub btnUnosobreX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnosobreX.Click
        If CInt(lblVisor.Text) = 0 Then lblVisor.Text = "0"
        lblVisor.Text = 1 / lblVisor.Text
    End Sub

    Private Sub btnSuma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuma.Click
        xOperador = "+" : xOperacion = True
    End Sub

    Private Sub btnResta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResta.Click
        xOperador = "-" : xOperacion = True
    End Sub

    Private Sub btnMultiplicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiplicacion.Click
        xOperador = "*" : xOperacion = True
    End Sub

    Private Sub btnDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivision.Click
        xOperador = "/" : xOperacion = True
    End Sub

    Private Sub btnIgual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIgual.Click
        xNumero2 = lblVisor.Text
        Mostrar_Resultado(xOperador)
    End Sub
#End Region
#Region "Memoria"

    Private Sub btnCE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCE.Click
        lblVisor.Text = "0."
        'xOperador = "CE" : xOperacion = True
        'lblVisor.Text = xNumero1
        'xNumero1 = lblVisor.Text : lblVisor.Text = xNumero1

        'If lblVisor.Text = xNumero1 Then
        '    lblVisor.Text = 0
        'End If
    End Sub

    Private Sub btnMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMS.Click
        xMemory = CDbl(lblVisor.Text)
        lblMemory.Text = "M"
    End Sub

    Private Sub btnM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnM.Click
        xMemory = CDbl(lblVisor.Text)
        lblMemory.Text = "M+"
    End Sub

    Private Sub btnMR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMR.Click
        lblVisor.Text = xMemory
    End Sub

    Private Sub btnMC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMC.Click
        xMemory = 0
        lblMemory.Text = ""
    End Sub

#End Region

    Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
        If lblVisor.Text = 0 Then lblVisor.Text = "0"
        lblVisor.Text = "0"
    End Sub

    Private Sub btnRetroceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetroceso.Click
        If Len(lblVisor.Text) = 1 Then
            If lblVisor.Text > 0 Then
                lblVisor.Text = 0
            Else
                Exit Sub
            End If
        Else
            lblVisor.Text = Microsoft.VisualBasic.Left(lblVisor.Text, Len(lblVisor.Text) - 1)
        End If
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItem.Click
        If IsNumeric(lblVisor.Text) = True Then
            My.Computer.Clipboard.SetText(lblVisor.Text)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub PegarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PegarToolStripMenuItem.Click
        If IsNumeric(My.Computer.Clipboard.GetText()) = True Then
            lblVisor.Text = My.Computer.Clipboard.GetText
        End If
    End Sub

    Private Sub AceracDeLaCalcToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceracDeLaCalcToolStripMenuItem.Click
        frmAcerca.ShowDialog()
    End Sub

    Sub NumPad(ByVal xNumero As Keys)
        If IsNumeric(lblVisor.Text) = True Then
            Select Case xNumero
                Case Keys.NumPad0 : btnCero_Click(Nothing, Nothing) 'nothing
                Case Keys.NumPad1 : btnUno_Click(Nothing, Nothing)
                Case Keys.NumPad2 : btnDos_Click(Nothing, Nothing)
                Case Keys.NumPad3 : btnTres_Click(Nothing, Nothing)
                Case Keys.NumPad4 : btnCuatro_Click(Nothing, Nothing)
                Case Keys.NumPad5 : btnCinco_Click(Nothing, Nothing)
                Case Keys.NumPad6 : btnSeis_Click(Nothing, Nothing)
                Case Keys.NumPad7 : btnSiete_Click(Nothing, Nothing)
                Case Keys.NumPad8 : btnOcho_Click(Nothing, Nothing)
                Case Keys.NumPad9 : btnNueve_Click(Nothing, Nothing)
                Case Keys.Back : btnRetroceso_Click(Nothing, Nothing) : Punto_insercion()
                Case Keys.Escape : btnC_Click(Nothing, Nothing)
            End Select
        End If
    End Sub

#Region "BtnNumeros_Click"
    Private Sub btnCero_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnCero.KeyDown
        NumPad(e.KeyCode)
    End Sub

    Private Sub btnUno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnUno.KeyDown
        NumPad(e.KeyCode)
    End Sub

    Private Sub btnDos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnDos.KeyDown
        NumPad(e.KeyCode)
    End Sub

    Private Sub btnTres_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnTres.KeyDown
        NumPad(e.KeyCode)
    End Sub

    Private Sub btnCuatro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnCuatro.KeyDown
        NumPad(e.KeyCode)
    End Sub

    Private Sub btnCinco_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnCinco.KeyDown
        NumPad(e.KeyCode)
    End Sub

    Private Sub btnSeis_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnSeis.KeyDown
        NumPad(e.KeyCode)
    End Sub

    Private Sub btnSiete_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnSiete.KeyDown
        NumPad(e.KeyCode)
    End Sub

    Private Sub btnOcho_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnOcho.KeyDown
        NumPad(e.KeyCode)
    End Sub

    Private Sub btnNueve_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnNueve.KeyDown
        NumPad(e.KeyCode)
    End Sub
#End Region

    Private Sub btnRetroceso_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnRetroceso.KeyDown
        NumPad(e.KeyCode)

    End Sub

    Private Sub lblVisor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lblVisor.KeyDown
        NumPad(e.KeyCode)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Punto_insercion()
    End Sub

    Private Sub btnC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnC.KeyDown
        NumPad(e.KeyCode)
    End Sub
End Class