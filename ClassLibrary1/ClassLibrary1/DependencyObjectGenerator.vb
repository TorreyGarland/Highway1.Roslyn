Public Class DependencyObjectGenerator

    Public Sub GenerateDependencyObjects(writer As System.IO.TextWriter)
        Contracts.Contract.Requires(Of ArgumentNullException)(Not IsNothing(writer), NameOf(writer))
        Dim dependencyObjects = GetDependencyObjects()
        If (Not String.IsNullOrWhiteSpace(dependencyObjects)) Then
            writer.WriteLine(dependencyObjects)
        End If
    End Sub

    Public Function GetDependencyObjects() As String
        GetDependencyObjects = Nothing
    End Function

End Class
