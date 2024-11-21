'Nombre alumn@:Shangjie 

'Apellidos alumn@: Zhou

'Curso alumn@: DAM2

'Asignatura alumn@:Desarollo de interfaces

'Nombre y/o nº de actividad :Calculadora



Public Class Form1
    ' Variables para almacenar el primer número y la operación seleccionada
    Private primerNumero As Double = 0
    Private operacion As String = ""
    ' Variable para controlar si el botón "2nd" está activado
    Private modo2nd As Boolean = False


    ' Evento que se activa cuando cambia el texto en el cuadro de texto (TxtDisplay)
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtDisplay.TextChanged
        ' Actualmente no realiza ninguna acción cuando cambia el texto
    End Sub

    ' Evento para manejar el clic en los botones de la calculadora (números y coma)
    Private Sub btnCalculadora(sender As Button, e As EventArgs) Handles BtnCero.Click, Btn1.Click, Btn2.Click, Btn3.Click, Btn4.Click, Btn5.Click, Btn6.Click, Btn7.Click, Btn8.Click, Btn9.Click, BtnComa.Click
        ' Concatenamos el texto del botón presionado al cuadro de texto (TxtDisplay)
        TxtDisplay.Text += sender.Text
    End Sub

    ' Evento para manejar el clic en el botón "C" (limpiar)
    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles BtnC.Click
        ' Limpia el cuadro de texto (TxtDisplay)
        TxtDisplay.Text = ""
    End Sub

    ' Evento para manejar el clic en el botón de suma
    Private Sub BtnSumar_Click(sender As Object, e As EventArgs) Handles BtnSumar.Click
        ' Verifica que el cuadro de texto no esté vacío
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número y lo guarda en primerNumero
            primerNumero = Convert.ToDouble(TxtDisplay.Text)
            ' Guarda la operación seleccionada
            operacion = "+"
            ' Limpia el cuadro de texto para permitir ingresar el segundo número
            TxtDisplay.Text = ""
        End If
    End Sub

    ' Evento para manejar el clic en el botón "=" (resultado)
    Private Sub BtnResultado_Click(sender As Object, e As EventArgs) Handles BtnResultado.Click
        ' Variable para almacenar el segundo número
        Dim segundoNumero As Double
        ' Verifica que el cuadro de texto no esté vacío
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número y lo guarda en segundoNumero
            segundoNumero = Convert.ToDouble(TxtDisplay.Text)

            ' Realiza la operación correspondiente según la operación seleccionada
            Select Case operacion
                Case "+"
                    TxtDisplay.Text = (primerNumero + segundoNumero).ToString()
                Case "-"
                    TxtDisplay.Text = (primerNumero - segundoNumero).ToString()
                Case "*"
                    TxtDisplay.Text = (primerNumero * segundoNumero).ToString()
                Case "/"
                    If segundoNumero <> 0 Then
                        TxtDisplay.Text = (primerNumero / segundoNumero).ToString()
                    Else
                        TxtDisplay.Text = "Error" ' Previene la división por cero
                    End If
                Case "^"
                    TxtDisplay.Text = Math.Pow(primerNumero, segundoNumero).ToString()
                Case "%"
                    TxtDisplay.Text = ((primerNumero * segundoNumero) / 100).ToString()
                Case "SQRT"
                    TxtDisplay.Text = Math.Sqrt(primerNumero).ToString()
                Case "1/x"
                    If primerNumero <> 0 Then
                        TxtDisplay.Text = (1 / primerNumero).ToString()
                    Else
                        TxtDisplay.Text = "Error" ' Previene la división por cero
                    End If
                Case "sen"
                    TxtDisplay.Text = Math.Sin(primerNumero).ToString()

                Case "senh"
                    TxtDisplay.Text = Math.Sinh(primerNumero).ToString()
                Case "cosh"
                    TxtDisplay.Text = Math.Cosh(primerNumero).ToString()
            End Select

        End If
    End Sub

    ' Evento para manejar el clic en el botón de resta
    Private Sub BtnRestar_Click(sender As Object, e As EventArgs) Handles BtnRestar.Click
        ' Verifica que el cuadro de texto no esté vacío
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número y lo guarda en primerNumero
            primerNumero = Convert.ToDouble(TxtDisplay.Text)
            ' Guarda la operación seleccionada
            operacion = "-"
            ' Limpia el cuadro de texto para permitir ingresar el segundo número
            TxtDisplay.Text = ""
        End If
    End Sub

    ' Evento para manejar el clic en el botón de multiplicación
    Private Sub BtnMultiplicar_Click(sender As Object, e As EventArgs) Handles BtnMultiplicar.Click
        ' Verifica que el cuadro de texto no esté vacío
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número y lo guarda en primerNumero
            primerNumero = Convert.ToDouble(TxtDisplay.Text)
            ' Guarda la operación seleccionada
            operacion = "*"
            ' Limpia el cuadro de texto para permitir ingresar el segundo número
            TxtDisplay.Text = ""
        End If
    End Sub

    ' Evento para manejar el clic en el botón de división
    Private Sub BtnDividir_Click(sender As Object, e As EventArgs) Handles BtnDividir.Click
        ' Verifica que el cuadro de texto no esté vacío
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número y lo guarda en primerNumero
            primerNumero = Convert.ToDouble(TxtDisplay.Text)
            ' Guarda la operación seleccionada
            operacion = "/"
            ' Limpia el cuadro de texto para permitir ingresar el segundo número
            TxtDisplay.Text = ""
        End If
    End Sub

    ' Evento para manejar el clic en el botón de potencia
    Private Sub BtnPotencia_Click(sender As Object, e As EventArgs) Handles BtnPotencia.Click
        ' Verifica que el cuadro de texto no esté vacío
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número y lo guarda en primerNumero
            primerNumero = Convert.ToDouble(TxtDisplay.Text)
            ' Guarda la operación seleccionada
            operacion = "^"
            ' Limpia el cuadro de texto para permitir ingresar el segundo número
            TxtDisplay.Text = ""
        End If
    End Sub

    ' Evento para manejar el clic en el botón de porcentaje
    Private Sub BtnModulo_Click(sender As Object, e As EventArgs) Handles BtnModulo.Click
        ' Verifica que el cuadro de texto no esté vacío
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número y lo guarda en primerNumero
            primerNumero = Convert.ToDouble(TxtDisplay.Text)
            ' Guarda la operación seleccionada
            operacion = "%"
            ' Limpia el cuadro de texto para permitir ingresar el segundo número
            TxtDisplay.Text = ""
        End If
    End Sub

    Private Sub btnCalculadora(sender As Object, e As EventArgs) Handles BtnComa.Click, BtnCero.Click, Btn9.Click, Btn8.Click, Btn7.Click, Btn6.Click, Btn5.Click, Btn4.Click, Btn3.Click, Btn2.Click, Btn1.Click

    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número
            Dim numero As Double = Convert.ToDouble(TxtDisplay.Text)

            ' Calcula 10 elevado a la potencia del número ingresado
            Dim resultado As Double = Math.Pow(10, numero)

            ' Muestra el resultado en el cuadro de texto
            TxtDisplay.Text = resultado.ToString()
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número
            Dim numero As Double = Convert.ToDouble(TxtDisplay.Text)

            ' Realiza la operación de elevar al cubo (x³)
            TxtDisplay.Text = Math.Pow(numero, 3).ToString()
        End If
    End Sub

    Private Sub ButtonSenh_Click(sender As Object, e As EventArgs) Handles ButtonSenh.Click
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número
            Dim numero As Double = Convert.ToDouble(TxtDisplay.Text)

            Dim radianes = (numero * Math.PI) / 180

            ' Realiza la operación de coseno'
            TxtDisplay.Text = Math.Sinh(radianes).ToString()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        primerNumero = Math.PI
        TxtDisplay.Text = Math.PI.ToString()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número
            Dim numero As Double = Convert.ToDouble(TxtDisplay.Text)

            ' Realiza la operación de elevar al cuadrado (x²)
            TxtDisplay.Text = Math.Pow(numero, 2).ToString()
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número
            Dim numero As Double = Convert.ToDouble(TxtDisplay.Text)

            ' Realiza la operación de raíz cuadrada (√x)
            If numero >= 0 Then
                TxtDisplay.Text = Math.Sqrt(numero).ToString()
            Else
                TxtDisplay.Text = "Error" ' Si el número es negativo, muestra un error
            End If
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número
            Dim numero As Double = Convert.ToDouble(TxtDisplay.Text)

            ' Realiza la operación de raíz cúbica (∛x)
            TxtDisplay.Text = Math.Pow(numero, 1 / 3.0).ToString()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número (primer número)
            Dim primerNumero As Double = Convert.ToDouble(TxtDisplay.Text)

            ' Solicita al usuario el exponente de la raíz (como 2 para raíz cuadrada, 3 para raíz cúbica, etc.)
            Dim exponenteRaiz As Double = Convert.ToDouble(InputBox("Ingrese el exponente de la raíz (2 para cuadrada, 3 para cúbica, etc.):", "Raíz"))

            ' Calcula la raíz del primer número con el exponente especificado
            Dim resultado As Double = Math.Pow(primerNumero, 1 / exponenteRaiz)

            ' Muestra el resultado en el cuadro de texto
            TxtDisplay.Text = resultado.ToString()
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

    End Sub

    Private Sub Button_e_Click(sender As Object, e As EventArgs) Handles Button_e.Click
        primerNumero = Math.E
        TxtDisplay.Text = primerNumero.ToString()
    End Sub

    Private Sub ButtonInverso_Click(sender As Object, e As EventArgs) Handles ButtonInverso.Click
        ' Convierte el texto en número
        Dim numero As Double = Convert.ToDouble(TxtDisplay.Text)

        ' Calcula e elevado al número ingresado
        Dim resultado As Double = 1 / numero

        ' Muestra el resultado en el cuadro de texto
        TxtDisplay.Text = resultado.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        modo2nd = Not modo2nd

        ' Cambia el texto del botón para indicar el estado
        If modo2nd Then
            Button5.Text = "2nd (ON)"
        Else
            Button5.Text = "2nd (OFF)"
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número
            Dim numero As Double = Convert.ToDouble(TxtDisplay.Text)

            ' Verifica que el número sea mayor que 0 (porque el logaritmo no está definido para números <= 0)
            If numero > 0 Then
                ' Calcula el logaritmo en base 10
                Dim resultado As Double = Math.Log10(numero)

                ' Muestra el resultado en el cuadro de texto
                TxtDisplay.Text = resultado.ToString()
            Else
                ' Muestra un mensaje de error si el número es menor o igual a 0
                TxtDisplay.Text = "Error" ' El logaritmo no está definido para números <= 0
            End If
        End If
    End Sub

    Private Sub ButtonCotangente_Click(sender As Object, e As EventArgs) Handles ButtonCotangente.Click
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número
            Dim numero As Double = Convert.ToDouble(TxtDisplay.Text)

            Dim radianes = (numero * Math.PI) / 180

            ' Realiza la operación de coseno'
            TxtDisplay.Text = 1 / (Math.Tan(radianes)).ToString()
        End If
    End Sub

    Private Sub ButtonCoseno_Click(sender As Object, e As EventArgs) Handles ButtonCoseno.Click
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número
            Dim numero As Double = Convert.ToDouble(TxtDisplay.Text)

            Dim radianes = (numero * Math.PI) / 180

            ' Realiza la operación de coseno'
            TxtDisplay.Text = Math.Cos(radianes).ToString()
        End If
    End Sub

    Private Sub ButtonSeno_Click(sender As Object, e As EventArgs) Handles ButtonSeno.Click
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número
            Dim numero As Double = Convert.ToDouble(TxtDisplay.Text)

            Dim radianes = (numero * Math.PI) / 180

            ' Realiza la operación de coseno'
            TxtDisplay.Text = Math.Sin(radianes).ToString()
        End If
    End Sub

    Private Sub ButtonTangente_Click(sender As Object, e As EventArgs) Handles ButtonTangente.Click
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número
            Dim numero As Double = Convert.ToDouble(TxtDisplay.Text)

            Dim radianes = (numero * Math.PI) / 180

            ' Realiza la operación de coseno'
            TxtDisplay.Text = Math.Tan(radianes).ToString()
        End If
    End Sub

    Private Sub ButtonCosh_Click(sender As Object, e As EventArgs) Handles ButtonCosh.Click
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número
            Dim numero As Double = Convert.ToDouble(TxtDisplay.Text)

            Dim radianes = (numero * Math.PI) / 180

            ' Realiza la operación de coseno'
            TxtDisplay.Text = Math.Cosh(radianes).ToString()
        End If
    End Sub

    Private Sub ButtonTanh_Click(sender As Object, e As EventArgs) Handles ButtonTanh.Click
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número
            Dim numero As Double = Convert.ToDouble(TxtDisplay.Text)

            Dim radianes = (numero * Math.PI) / 180

            ' Realiza la operación de coseno'
            TxtDisplay.Text = Math.Tanh(radianes).ToString()
        End If
    End Sub

    Private Sub ButtonCosecante_Click(sender As Object, e As EventArgs) Handles ButtonCosecante.Click
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número
            Dim numero As Double = Convert.ToDouble(TxtDisplay.Text)

            Dim radianes = (numero * Math.PI) / 180

            ' Realiza la operación de coseno'
            TxtDisplay.Text = 1 / (Math.Sin(radianes)).ToString()
        End If
    End Sub

    Private Sub ButtonSecante_Click(sender As Object, e As EventArgs) Handles ButtonSecante.Click
        If TxtDisplay.Text <> "" Then
            ' Convierte el texto en número
            Dim numero As Double = Convert.ToDouble(TxtDisplay.Text)

            Dim radianes = (numero * Math.PI) / 180

            ' Realiza la operación de coseno'
            TxtDisplay.Text = 1 / (Math.Cos(radianes)).ToString()
        End If
    End Sub

    Private Sub ButtonFactorial_Click(sender As Object, e As EventArgs) Handles ButtonFactorial.Click

        ' Convierte el texto en número
        Dim a As Double = Convert.ToDouble(TxtDisplay.Text)
        Dim b As Double = Convert.ToDouble(1)
        Dim c As Double

        For c = Convert.ToDouble(1) To a
            b = b * c
            TxtDisplay.Text = b
        Next

    End Sub
End Class
