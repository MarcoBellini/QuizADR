Public Class ADRTab
    Public Category As String
    Public MainQuestion As String
    Public QuestionOne As String
    Public QuestionTwo As String
    Public QuestionThree As String
    Public AnswerOne As Boolean
    Public AnswerTwo As Boolean
    Public AnswerThree As Boolean

    Public UserAnswerOne As Boolean
    Public UserAnswerTwo As Boolean
    Public UserAnswerThree As Boolean

    ''' <summary>
    ''' Check if all answers are correct
    ''' </summary>
    ''' <returns>True or False</returns>
    Public Function AnswerAreCorrects() As Boolean
        Return (UserAnswerOne = AnswerOne) And
               (UserAnswerTwo = AnswerTwo) And
               (UserAnswerThree = AnswerThree)
    End Function
End Class
