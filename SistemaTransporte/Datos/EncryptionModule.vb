﻿Module EncryptionModule
    Public Function Base64Encode(ByVal sData As String) As String

        Try
            Dim encData_Byte As Byte() = New Byte(sData.Length - 1) {}
            encData_Byte = System.Text.Encoding.UTF8.GetBytes(sData)
            Dim encodedData As String = Convert.ToBase64String(encData_Byte)
            Return (encodedData)

        Catch ex As Exception

            Throw (New Exception("Error is base64Encode" & ex.Message))

        End Try


    End Function

    Public Function Base64Decode(ByVal sData As String) As String

        Dim encoder As New System.Text.UTF8Encoding()
        Dim utf8Decode As System.Text.Decoder = encoder.GetDecoder()
        Dim todecode_byte As Byte() = Convert.FromBase64String(sData)
        Dim charCount As Integer = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length)
        Dim decoded_char As Char() = New Char(charCount - 1) {}
        utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0)
        Dim result As String = New [String](decoded_char)
        Return result

    End Function

End Module