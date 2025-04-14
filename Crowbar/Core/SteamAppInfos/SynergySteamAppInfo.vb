Imports System.ComponentModel
Imports System.IO
Imports Steamworks

Public Class SynergySteamAppInfo
	Inherits SteamAppInfoBase

	Public Sub New()
		MyBase.New()

		Me.ID = New AppId_t(17520)
		Me.Name = "Synergy"
		Me.UsesSteamUGC = True
		Me.CanUseContentFolderOrFile = False
		'Me.ContentFileExtensionsAndDescriptions.Add("vpk", "Source Engine VPK Files")
		Me.TagsControlType = GetType(FortressConnectedTagsUserControl)
	End Sub

End Class