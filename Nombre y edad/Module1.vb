Imports System.Threading

Module Module1

    Sub Iniciar()
        Console.WriteLine("Hola, ¿cómo te llamas?")
        Dim respuestanombre As String = Console.ReadLine
        Dim nombrecontienenumeros As Boolean
        Dim nombre As String = ""
        Dim preguntaredad As Boolean = True
        Dim preguntaredad1 As Boolean = True

        Do Until nombre.LongCount > 0
            If respuestanombre.Equals("") Then
                Dim replycounter As Integer
                Select Case replycounter
                    Case Is = 0
                        Console.WriteLine("Dime tu nombre")
                        respuestanombre = Console.ReadLine
                        replycounter = 1
                    Case Is = 1
                        Console.WriteLine("Todo el mundo tiene nombre. Dime el tuyo.")
                        respuestanombre = Console.ReadLine
                        replycounter = 2
                    Case Is = 2
                        Console.WriteLine("No sé qué problema tienes con decirme tu edad.")
                        respuestanombre = Console.ReadLine
                        replycounter = 3
                    Case Is = 3
                        Console.WriteLine("No puedo seguir si no me dices tu nombre. Hagamos una cosa, tú te inventas tu nombre, y yo salgo de este bucle, ¿vale?")
                        respuestanombre = Console.ReadLine
                        replycounter = 4
                    Case Is = 4
                        Console.WriteLine("Queda feo que un programa haga esto, pero te aguantas, te llamaré Perico de los palotes. ¿Cuántos años tienes?")
                        preguntaredad1 = False
                        respuestanombre = "Perico de los palotes"
                        replycounter = 0
                End Select
                
            Else
                If respuestanombre.Contains("0") OrElse respuestanombre.Contains("1") OrElse respuestanombre.Contains("2") OrElse respuestanombre.Contains("3") OrElse respuestanombre.Contains("4") OrElse respuestanombre.Contains("5") OrElse respuestanombre.Contains("6") OrElse respuestanombre.Contains("7") OrElse respuestanombre.Contains("8") OrElse respuestanombre.Contains("9") Then
                    nombrecontienenumeros = True
                Else
                    nombrecontienenumeros = False

                End If
                If nombrecontienenumeros = True Then
                    Dim replycounter As Integer
                    Select Case replycounter
                        Case Is = 0
                            Console.WriteLine("No me engañes, sé que un nombre no puede tener números. Si eres un rey, usa" & vbNewLine & "números romanos. Dime tu nombre.")
                            respuestanombre = Console.ReadLine
                            replycounter = 1

                        Case Is = 1
                            Console.WriteLine("¿De verdad tu nombre tiene números? bueno, hay gente que se dedica a chupar" & vbNewLine & "candados. ¿Cuántos años tienes?")
                            nombre = respuestanombre
                            preguntaredad = False
                    End Select
                Else
                    nombre = respuestanombre
                    If preguntaredad1.Equals(False) Then
                        preguntaredad = False
                    Else
                        preguntaredad = True

                    End If

                End If
            End If
        Loop


        Dim edad As Integer
        Dim respuestaedad As String = ""
        Dim replycounter2 As Integer
        If preguntaredad.Equals(True) Then
            Console.WriteLine("¿Cuántos años tienes?")
        End If

        Do Until edad > 0
            Try
                respuestaedad = Console.ReadLine
                edad = respuestaedad
                If edad < 100 Then
                    If replycounter2 > 2 Then
                        Console.WriteLine("Al fin, gracias. Tu nombre es " & nombre & " y tienes " & edad & " años." & vbNewLine & "Se lo contaré a la NSA.")
                    Else
                        Console.WriteLine("Tu nombre es " & nombre & " y tienes " & edad & " años. Se lo contaré a la NSA.")
                    End If
                Else
                    Select Case edad

                        Case Is > 200
                            Console.WriteLine("Debes estar batiendo récords con tantos años.")
                        Case Is = 200
                            Console.WriteLine("¿Dos siglos viviendo? ¡¿me estás diciendo que eres el hombre bicentenario?!")
                        Case Is = 199
                            Console.WriteLine("¡Programador mío, casi dos siglos viviendo!")
                        Case Is > 100
                            Console.WriteLine("¿Más de un siglo? wow, me gustaría ver qué tal funcionaré con esa edad.")
                        Case Is = 99
                            Console.WriteLine("¡Casi un siglo aún viviendo, enhorabuena!")

                    End Select
                    Console.WriteLine("Tu nombre es " & nombre & " y tienes " & edad & " años. Se lo contaré a la NSA.")
                End If
            Catch ex As Exception
                If respuestaedad.Equals("") Then

                    Select Case replycounter2
                        Case Is = 0
                            Console.WriteLine("¿No tienes edad?")
                            replycounter2 = 1
                        Case Is = 1
                            Console.WriteLine("Dime tu edad.")
                            replycounter2 = 2
                        Case Is = 2
                            Console.WriteLine("No sé qué problema tienes con decirme tu edad.")
                            replycounter2 = 3
                        Case Is = 3
                            Console.WriteLine("¿Te da vergüenza revelar tu edad? ¿debes ocultarla por secretos de estado?" & vbNewLine & "Son preguntas retóricas, no las contestes, sólo soy un programa. Ahora, dime tu edad.")
                            replycounter2 = 4
                        Case Is = 4
                            Console.WriteLine("¡Por el amor de Dios, invéntatela ya, pero sácame de este bucle que yo sólo soy un triste programa!")
                    End Select
                Else
                    Console.WriteLine("No te he entendido, ¿puedes repetirme tu edad? en números, no en letras.")
                End If

            End Try
        Loop
        preguntaredad = True
        preguntaredad1 = True
        Reiniciar()

    End Sub

    Sub Reiniciar()
        Dim restart As String
        Do Until restart <> ""
            Console.WriteLine("¿Empezamos de nuevo? Sí/No")
            restart = Console.ReadLine
            If restart = "Sí" Then
                Console.WriteLine("¡Genial!")
                Iniciar()

            ElseIf restart = "No" Then
                Console.WriteLine("Es usted terrible. Ya me cierro yo solo...")
                Thread.Sleep(3000)
                Environment.Exit(0)
            End If
        Loop
    End Sub

    Sub Main()
        Console.Title = "Nombre y edad"


        Iniciar()


        Reiniciar()


    End Sub

End Module
