Public Class ExamManager
    Implements IDisposable

    Private Const NUMBER_OF_EXAM_TABS As Integer = 40
    Private Const QUIZ_PATH As String = "Resources\Quiz.dat"

    Private ListOfTabs As New List(Of ADRTab)
    Private disposedValue As Boolean
    Private QuizReader As QuizFileReader

    Public Sub New()
        QuizReader = New QuizFileReader(QUIZ_PATH)
    End Sub

    Public Function NewExam() As Boolean
        Dim RandomTabs(NUMBER_OF_EXAM_TABS - 1) As Integer
        Dim nCurrentIndex As Integer = 0
        Dim nRandomNumber As Integer
        Dim RandomGenerator As New Random
        Dim bFoundNumber As Boolean

        ' Check if we can generate enough tandom numbers
        If QuizReader.TabsCount <= NUMBER_OF_EXAM_TABS Then Return False

        ' Clear array
        Array.Clear(RandomTabs, 0, RandomTabs.Length)

        ' Fill array with no repeted random numbers
        While (nCurrentIndex < NUMBER_OF_EXAM_TABS)
            nRandomNumber = RandomGenerator.Next(0, QuizReader.TabsCount - 1)
            bFoundNumber = False

            For i As Integer = 0 To RandomTabs.Length - 1
                If nRandomNumber = RandomTabs(i) Then
                    bFoundNumber = True
                End If
            Next

            If bFoundNumber = False Then
                RandomTabs(nCurrentIndex) = nRandomNumber
                nCurrentIndex += 1
            End If
        End While

        ' Add tabs to list
        For i As Integer = 0 To RandomTabs.Length - 1
            ListOfTabs.Add(QuizReader.ReadTab(RandomTabs(i)))
        Next

        Return True
    End Function

    Public Sub ClearExam()
        ' Remove all exam tabs
        ListOfTabs.Clear()
    End Sub

    Public ReadOnly Property ExamTabs As Integer
        Get
            Return ListOfTabs.Count
        End Get
    End Property

    Public ReadOnly Property ExamTab(ByVal Index As Integer) As ADRTab
        Get
            Return ListOfTabs(Index)
        End Get
    End Property

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                If QuizReader IsNot Nothing Then
                    QuizReader.Dispose()
                    QuizReader = Nothing
                End If

                If ListOfTabs IsNot Nothing Then
                    ListOfTabs.Clear()
                    ListOfTabs = Nothing
                End If
            End If

            disposedValue = True
        End If
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(disposing:=True)
        GC.SuppressFinalize(Me)
    End Sub
End Class
