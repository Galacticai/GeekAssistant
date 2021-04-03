Imports Managed
Module CheckFastbootCompatible


    Public Function Run(ErrorCode_Start As String) As Boolean

        GA_SetProgressText.Run("Checking fastboot compatibility...", -1)

        If My.Settings.DeviceState = "" Or My.Settings.DeviceState = "Disconnected" Then
            AutoDetect.Run(True)
            If My.Settings.DeviceState = "Disconnected" Then
                ErrorCodeTrack($"{ErrorCode_Start}-D0") ' Unlock Bootloader - Device 0 (No device is connected)
                ErrorInfo = (0, $"We haven't found any device.{vbCrLf}{My.Resources.TroubleshootConnection}")
                Return False
            End If
        End If
        If My.Settings.DeviceState = "Multiple" Then
            ErrorCodeTrack($"{ErrorCode_Start}-D2") ' Unlock Bootloader - Device 2 or more (Multiple devices connected)
            ErrorInfo = (0, $"There are several devices connected.{vbCrLf}Would you mind keeping 1 and disconnecting the rest please?")
            Return False
        End If

        If My.Settings.DeviceManufacturer = "Samsung" Then
            ErrorCodeTrack($"{ErrorCode_Start}-DS") ' Unlock Bootloader - Device Samsung (Samsung is not supported)
            ErrorInfo = (1, $"Sorry we cannot access fastboot mode on Samsung devices.{vbCrLf}" &
                             $"You can unlock Samsung devices using this method:{vbCrLf}" &
                             $" - Unhide ""Developer options"":{vbCrLf}" &
                               $"Settings : About : Software information : (Tap ""Build number"" 7 times) : (Confirm security unlock if asked){vbCrLf}" &
                             $" - OEM Unlock:{vbCrLf}" &
                               $"Settings : Developer options : (Find and Enable ""OEM Unlock""){vbCrLf}{vbCrLf}" &
                             $" ⚠ Warning: Some devices will factory reset when unlocking for security reasons.{vbCrLf}" &
                             $" ⚠ Notice: If you don't see ""OEM Unlock"" then your device is either unlocked by default, or your manufacturer has hidden the option to unlock (Certain tricks needed to make it visible)")
            Return False
        End If

        'if passed all then compatible
        Return True
    End Function
End Module
