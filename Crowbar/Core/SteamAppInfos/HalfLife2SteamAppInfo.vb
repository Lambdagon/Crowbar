Imports System.ComponentModel
Imports System.IO
Imports Steamworks

Public Class HalfLife2SteamAppInfo
	Inherits SteamAppInfoBase

	Public Sub New()
		MyBase.New()

		Me.ID = New AppId_t(220)
		Me.Name = "Half Life 2"
		Me.UsesSteamUGC = True
		Me.CanUseContentFolderOrFile = False
		'Me.ContentFileExtensionsAndDescriptions.Add("vpk", "Source Engine VPK Files")
		Me.TagsControlType = GetType(FortressConnectedTagsUserControl)
	End Sub

End Class