Imports System.Text.RegularExpressions
Imports System.IO
Public Class QuizFileReader
    Implements IDisposable

    Private Const CATEGORY_TITLE_PATTERN As String = "(?<Category>^[A-Za-z0-9]{2}-[0-9]{3}\t)(?<MainQuestion>[^\n]+)"
    Private Const QUESTION_ANSWER_ONE_PATTERN As String = "(?<=^[\t]{1}[1]{1}[\t]{1})(?<Question>[^\t]+)\t(?<Answer>[VFvf])"
    Private Const QUESTION_ANSWER_TWO_PATTERN As String = "(?<=^[\t]{1}[2]{1}[\t]{1})(?<Question>[^\t]+)\t(?<Answer>[VFvf])"
    Private Const QUESTION_ANSWER_THREE_PATTERN As String = "(?<=^[\t]{1}[3]{1}[\t]{1})(?<Question>[^\t]+)\t(?<Answer>[VFvf])"

    Private disposedValue As Boolean
    Private LongTextFile As String
    Private TextReader As StreamReader
    Private nTabsCount As Integer
    Private lElapsedMilliseconds As Long

    ' Use regular expressions
    Private CategoryTitleRegexMatches As MatchCollection
    Private QuestionAnswerOneRegexMatches As MatchCollection
    Private QuestionAnswerTwoRegexMatches As MatchCollection
    Private QuestionAnswerThreeRegexMatches As MatchCollection

    Public Sub New(ByVal Path As String)
        Dim QueryPerformance As New Stopwatch

        ' Check if file exist
        If My.Computer.FileSystem.FileExists(Path) = False Then
            Throw New FileNotFoundException(Path & " file non found, make sure the file Quiz.dat  is in the ..\Resources\ folder")
        End If

        ' Start Measuring time for loading and regex all fields
        QueryPerformance.Start()

        ' Open text file
        TextReader = File.OpenText(Path)

        ' Check if TextStream is valid
        If TextReader Is Nothing Then Exit Sub

        ' Read all file to the end
        LongTextFile = TextReader.ReadToEnd()

        ' Regex all results
        CategoryTitleRegexMatches = Regex.Matches(LongTextFile, CATEGORY_TITLE_PATTERN, RegexOptions.Multiline)
        QuestionAnswerOneRegexMatches = Regex.Matches(LongTextFile, QUESTION_ANSWER_ONE_PATTERN, RegexOptions.Multiline)
        QuestionAnswerTwoRegexMatches = Regex.Matches(LongTextFile, QUESTION_ANSWER_TWO_PATTERN, RegexOptions.Multiline)
        QuestionAnswerThreeRegexMatches = Regex.Matches(LongTextFile, QUESTION_ANSWER_THREE_PATTERN, RegexOptions.Multiline)

        ' Check the format of file
        If ((CategoryTitleRegexMatches.Count = QuestionAnswerOneRegexMatches.Count) And
           (QuestionAnswerTwoRegexMatches.Count = QuestionAnswerThreeRegexMatches.Count)) = False Then
            Throw New FileLoadException("Bad input file!")
        End If

        ' Assign the number of tabs
        nTabsCount = CategoryTitleRegexMatches.Count

        ' Stop Measuring time 
        QueryPerformance.Stop()
        lElapsedMilliseconds = QueryPerformance.ElapsedMilliseconds

#If DEBUG Then
        Debug.WriteLine("Loading time(ms): " & lElapsedMilliseconds.ToString)
        Debug.WriteLine("Questions Loaded: " & CategoryTitleRegexMatches.Count.ToString)
#End If

        ' Free unused resources
        LongTextFile = Nothing
        TextReader.Dispose()
        TextReader = Nothing
    End Sub

    Public ReadOnly Property LoadingElapsedTime() As Long
        Get
            Return lElapsedMilliseconds
        End Get
    End Property

    Public ReadOnly Property TabsCount() As Integer
        Get
            Return nTabsCount
        End Get
    End Property

    Public Function ReadTab(ByVal Index As Integer) As ADRTab
        Dim Tab As ADRTab = Nothing

        If (Index >= 0) And (Index <= nTabsCount) Then

            Tab = New ADRTab

            ' Read Category and Question
            Tab.Category = CategoryTitleRegexMatches(Index).Groups("Category").Value
            Tab.MainQuestion = CategoryTitleRegexMatches(Index).Groups("MainQuestion").Value

            ' Read 3 V/F questions with answer
            Tab.QuestionOne = QuestionAnswerOneRegexMatches(Index).Groups("Question").Value
            Tab.AnswerOne = IIf(QuestionAnswerOneRegexMatches(Index).Groups("Answer").Value.ToLower = "v", True, False)

            Tab.QuestionTwo = QuestionAnswerTwoRegexMatches(Index).Groups("Question").Value
            Tab.AnswerTwo = IIf(QuestionAnswerTwoRegexMatches(Index).Groups("Answer").Value.ToLower = "v", True, False)

            Tab.QuestionThree = QuestionAnswerThreeRegexMatches(Index).Groups("Question").Value
            Tab.AnswerThree = IIf(QuestionAnswerThreeRegexMatches(Index).Groups("Answer").Value.ToLower = "v", True, False)

        End If

        Return Tab
    End Function

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' Free resources
                LongTextFile = Nothing

                CategoryTitleRegexMatches = Nothing
                QuestionAnswerOneRegexMatches = Nothing
                QuestionAnswerTwoRegexMatches = Nothing
                QuestionAnswerThreeRegexMatches = Nothing
            End If

            disposedValue = True
        End If
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(disposing:=True)
        GC.SuppressFinalize(Me)
    End Sub
End Class
