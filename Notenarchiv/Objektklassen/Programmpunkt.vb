Imports System.Collections.Generic
Imports System.Collections
Imports Notenarchiv

Public Class Programmpunkt : Implements IComparable(Of Programmpunkt)

    Public Property Notensatz As Notensatz
    Public Property ProgrammNr As Integer

    Public Sub New(ns As Notensatz, pn As Integer)

        Notensatz = ns
        ProgrammNr = pn

    End Sub

    Public Function CompareTo(other As Programmpunkt) As Integer Implements IComparable(Of Programmpunkt).CompareTo
        If (Me.ProgrammNr < other.ProgrammNr) Then

            Return 1

        End If

        If (Me.ProgrammNr > other.ProgrammNr) Then

            Return -1

        End If

        Return 0
    End Function

End Class
