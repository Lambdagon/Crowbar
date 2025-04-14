Imports System.ComponentModel
Imports System.IO
Imports Steamworks

Public Class FortressConnectedSteamAppInfo
	Inherits SteamAppInfoBase

	Public Sub New()
		MyBase.New()

		Me.ID = New AppId_t(3561600)
		Me.Name = "Fortress Connected"
		Me.UsesSteamUGC = True
		Me.CanUseContentFolderOrFile = False
		'Me.ContentFileExtensionsAndDescriptions.Add("vpk", "Source Engine VPK Files")
		Me.TagsControlType = GetType(FortressConnectedTagsUserControl)
	End Sub

End Class
