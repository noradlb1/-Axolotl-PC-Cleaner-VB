Imports System
Imports System.DirectoryServices.AccountManagement

Namespace AXOLOTL_PC_CLEANER.Helper
	Friend Class Locations
		Public Shared username As String = Environment.UserName

		Public Shared Recent_Documents As String = "C:\Users\" & username & "\AppData\Roaming\Microsoft\Windows\Recent"
		Public Shared Thumnail_Cache As String = "C:\Users\" & username & "\AppData\Local\Microsoft\Windows\Explorer"
		Public Shared Mini_Dumps As String = "C:\Windows\Minidump"

		#Region "Windows Log Files"
		Public Shared WinLogs As String = "C:\Windows"
		Public Shared WinLogs1 As String = "C:\Windows\Logs"
		Public Shared WinLogs2 As String = WinLogs1 & "\CBS"
		Public Shared WinLogs3 As String = WinLogs1 & "\DISM"
		Public Shared WinLogs4 As String = WinLogs1 & "\NetSetup"
		Public Shared WinLogs5 As String = WinLogs1 & "\SIH"
		Public Shared WinLogs6 As String = WinLogs1 & "\SystemRestore"
		Public Shared WinLogs7 As String = WinLogs1 & "\waasmedic"
		Public Shared WinLogs8 As String = WinLogs1 & "\waasmediccapsule"
		Public Shared WinLogs9 As String = WinLogs1 & "\WindowsBackup"
		Public Shared WinLogs10 As String = WinLogs1 & "\WindowsUpdate"
		Public Shared WinLogs11 As String = WinLogs1 & "\WinREAgent"
		Public Shared WinLogs12 As String = "C:\Windows\ServiceProfiles\NetworkService\AppData\Local\Temp"
		Public Shared WinLogs13 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\Windows\WebCache"
		Public Shared WinLogs14 As String = "C:\Windows\Microsoft.NET\Framework\v4.0.30319"
		Public Shared WinLogs15 As String = "C:\Windows\Microsoft.NET\Framework\v3.5"
		Public Shared WinLogs16 As String = "C:\Windows\Microsoft.NET\Framework\v3.0"
		Public Shared WinLogs17 As String = "C:\Windows\Microsoft.NET\Framework\v2.0.50727"
		Public Shared WinLogs18 As String = "C:\Windows\Microsoft.NET\Framework\v1.1.4322"
		Public Shared WinLogs19 As String = "C:\Windows\Microsoft.NET\Framework\v1.0.3705"
		Public Shared WinLogs20 As String = "C:\Windows\Panther\UnattendGC"
		Public Shared WinLogs21 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\CLR_v2.0"
		Public Shared WinLogs22 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\CLR_v2.0_32"
		Public Shared WinLogs23 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\CLR_v4.0"
		Public Shared WinLogs24 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\CLR_v4.0_32"
		Public Shared WinLogs25 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\CLR_v2.0\UsageLogs"
		Public Shared WinLogs26 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\CLR_v2.0_32\UsageLogs"
		Public Shared WinLogs27 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\CLR_v4.0\UsageLogs"
		Public Shared WinLogs28 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\CLR_v4.0_32\UsageLogs"
		Public Shared WinLogs29 As String = "C:\Windows\System32\config\systemprofile\AppData\Local\Microsoft\CLR_v4.0"
		Public Shared WinLogs30 As String = "C:\Windows\System32\config\systemprofile\AppData\Local\Microsoft\CLR_v4.0\UsageLogs"
		Public Shared WinLogs31 As String = "C:\Windows\SysWOW64\config\systemprofile\AppData\Local\Microsoft\CLR_v4.0_32"
		Public Shared WinLogs32 As String = "C:\Windows\SysWOW64\config\systemprofile\AppData\Local\Microsoft\CLR_v4.0_32\UsageLogs"
		Public Shared WinLogs33 As String = "C:\Windows\SoftwareDistribution\DataStore\Logs"
		Public Shared WinLogs34 As String = WinLogs1 & "\DPX"
		Public Shared WinLogs35 As String = WinLogs1 & "\HomeGroup"
		Public Shared WinLogs36 As String = WinLogs1 & "\MeasuredBoot"
		Public Shared WinLogs37 As String = WinLogs1 & "\MoSetup"
		Public Shared WinLogs38 As String = WinLogs1 & "\SettingSync"
		Public Shared WinLogs39 As String = WinLogs1 & "\SetupCleanupTask"
		Public Shared WinLogs40 As String = WinLogs1 & "\Telephony"
		#End Region

		Public Shared Recyle_Bin As String = "C:\$Recycle.Bin\" & My.Settings.Default.Sid
		Public Shared Temp_Files As String = "C:\Users\" & username & "\AppData\Local\Temp"
		Public Shared Win_Temp_Files As String = "C:\Windows\Temp"
		Public Shared Memory_Dumps As String = "C:\Users\" & username & "\AppData\Local\CrashDumps"
		Public Shared Error_Reports As String = "C:\ProgramData\Microsoft\Windows\WER"
		Public Shared Driver_Installtion As String = "C:\Windows\INF"
		Public Shared Delivery_Optimization As String = "C:\Windows\ServiceProfiles\NetworkService\AppData\Local\Microsoft\Windows\DeliveryOptimization"
		Public Shared Network_Data As String = "C:\Windows\System32\sru"

		Public Shared Prefetch As String = "C:\Windows\Prefetch"
		Public Shared Store_Install_Service As String = "C:\Windows\System32\config\systemprofile\AppData\Local\Microsoft\InstallService"
		Public Shared QtFramework As String = "C:\Users\" & username & "\AppData\Local\cache"
		Public Shared Power_Efficiency As String = "C:\ProgramData\Microsoft\Windows\Power Efficiency Diagnostics"
		Public Shared Notifications As String = "C:\Users\" & username & "\AppData\Local\Microsoft\Windows\ActionCenterCache"
		Public Shared MS_Search As String = "C:\ProgramData\Microsoft\Search\Data\Applications\Windows"
		Public Shared MS_Search2 As String = "C:\ProgramData\Microsoft\Search\Data\Applications\Windows\GatherLogs\SystemIndex"
		Public Shared MS_Search3 As String = "C:\Users\" & username & "\Searches"
		Public Shared MS_Search4 As String = "C:\Users\" & username & "\Searches\Everywhere" '.search-ms";
		Public Shared MS_Search5 As String = "C:\Users\" & username & "\Searches\Indexed Locations" '.search-ms";
		Public Shared Jump_List As String = "C:\Users\" & username & "\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations"
		Public Shared Font_Cache As String = "C:\Windows\ServiceProfiles\LocalService\AppData\Local\FontCache"

		Public Shared Win_Defender As String = "C:\ProgramData\Microsoft\Windows Defender\Scans\History\CacheManager"
		Public Shared Win_Defender2 As String = "C:\ProgramData\Microsoft\Windows Defender\Scans\History\Service"
		Public Shared Win_Defender3 As String = "C:\ProgramData\Microsoft\Windows Defender\Scans\History\Service\DetectionHistory"
		Public Shared Win_Defender4 As String = "C:\ProgramData\Microsoft\Windows Defender\Scans\History\Store"
		Public Shared Win_Defender5 As String = "C:\ProgramData\Microsoft\Windows Defender\Scans\RtSigs\Data"
		Public Shared Win_Defender6 As String = "C:\ProgramData\Microsoft\Windows Defender\Support"
		Public Shared Win_Defender7 As String = "C:\ProgramData\Microsoft\Windows Defender\Scans\History\Results"
		Public Shared Origin_Installers As String = "C:\Users\" & username & "\AppData\Local\Origin\ThinSetup"
		Public Shared Visual_Studio As String = "C:\ProgramData\Microsoft\VisualStudio\Packages"
		Public Shared One_Drive As String = "C:\Users\" & username & "\AppData\Local\Microsoft\OneDrive\logs"
		Public Shared One_Drive2 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\OneDrive\setup"
		Public Shared One_Drive3 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\OneDrive\setup\logs"
		Public Shared Easy_AntiCheat As String = "C:\Users\" & username & "\AppData\Roaming\EasyAntiCheat"
		Public Shared Battlenet As String = "C:\ProgramData\Blizzard Entertainment\Battle.net\Cache"
		Public Shared Battlenet2 As String = "C:\Users\" & username & "\AppData\Local\Battle.net\BrowserCache"
		Public Shared Battlenet3 As String = "C:\Users\" & username & "\AppData\Local\Battle.net\BrowserCache\Cache"
		Public Shared Battlenet4 As String = "C:\Users\" & username & "\AppData\Local\Battle.net\BrowserCache\GPUCache"
		Public Shared Battlenet5 As String = "C:\Users\" & username & "\AppData\Local\Battle.net\BrowserCache\Code Cache\js"
		Public Shared Ccleaner As String = "C:\Program Files\CCleaner\LOG"
		Public Shared Steam As String = "C:\Program Files (x86)\Steam"
		Public Shared Steam2 As String = "C:\Program Files (x86)\Steam\dumps"
		Public Shared Steam3 As String = "C:\Program Files (x86)\Steam\steamapps\temp"

		Public Shared DirectX As String = "C:\Windows\System32\config\systemprofile\AppData\Local\D3DSCache"
		Public Shared DirectX2 As String = "C:\Users\" & username & "\AppData\Local\D3DSCache"
		Public Shared Windows_Update As String = "C:\Windows\SoftwareDistribution\Download"
		Public Shared Windows_Font_Cache As String = "C:\Windows\System32\FNTCACHE.DAT"
		Public Shared Windows_Debug As String = "C:\Windows\debug"
		Public Shared Windows_Cache As String = "C:\Users\" & username & "\AppData\LocalLow\Microsoft\CryptnetUrlCache\Content"
		Public Shared Windows_Cache2 As String = "C:\Users\" & username & "\AppData\LocalLow\Microsoft\CryptnetUrlCache\MetaData"
		Public Shared Windows_Cache3 As String = "C:\Windows\ServiceProfiles\LocalService\AppData\LocalLow\Microsoft\CryptnetUrlCache\Content"
		Public Shared Windows_Cache4 As String = "C:\Windows\ServiceProfiles\LocalService\AppData\LocalLow\Microsoft\CryptnetUrlCache\MetaData"
		Public Shared Windows_Cache5 As String = "C:\Windows\System32\config\systemprofile\AppData\Local\Microsoft\Windows\Caches"
		Public Shared Windows_Installer As String = "C:\Windows\Installer"
		Public Shared Windows_Experience As String = "C:\Windows\Performance\WinSAT"
		Public Shared Windows_Experience2 As String = "C:\Windows\Performance\WinSAT\DataStore"
		Public Shared Windows_Auto_Video_Experience As String = "C:\Windows\ServiceProfiles\LocalService\AppData\Local\Microsoft\Windows"
		Public Shared Windows_Internet_Cache As String = "C:\Users\" & username & "\AppData\Local\Microsoft\Windows\INetCache\IE"

		#Region "Edge Chromium"
		Public Shared Edge_Master As String = "C:\Users\" & username & "\AppData\Local\Microsoft\Edge\User Data\Default\"

		Public Shared Edge_Cache As String = "C:\Users\" & username & "\AppData\Local\Microsoft\Edge\User Data\Default\Cache\Cache_Data" ' < all files
		Public Shared Edge_Cache2 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\Edge\User Data\Default\GPUCache" '  < all files
		Public Shared Edge_Cache3 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\Edge\User Data\Default\Code Cache\js" '  < all files
		Public Shared Edge_Cache4 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\Edge\User Data\Default\Code Cache\js\index-dir" '  < all files
		Public Shared Edge_Cache5 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\Edge\User Data\Default\Service Worker\CacheStorage" '  < files and folders
		Public Shared Edge_Cache6 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\Edge\User Data\Default\Service Worker\Database" '  < all files
		Public Shared Edge_Cache7 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\Edge\User Data\Default\Service Worker\ScriptCache" '  < all files
		Public Shared Edge_Cache8 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\Edge\User Data\Default\Service Worker\ScriptCache\index-dir" '  < all files
		Public Shared Edge_Cache9 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\Edge\User Data\GrShaderCache\GPUCache" '  < all files
		Public Shared Edge_Cache10 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\Edge\User Data\ShaderCache\GPUCache" '  < all files

		Public Shared Edge_Cache11 As String = Edge_Master & "Favicons-journal"
		Public Shared Edge_Cache12 As String = Edge_Master & "History-journal"
		Public Shared Edge_Cache13 As String = Edge_Master & "Login Data-journal"
		Public Shared Edge_Cache14 As String = Edge_Master & "Network Action Predictor-journal"
		Public Shared Edge_Cache15 As String = Edge_Master & "Shortcuts-journal"
		Public Shared Edge_Cache16 As String = Edge_Master & "Top Sites-journal"
		Public Shared Edge_Cache17 As String = Edge_Master & "Web Data-journal"
		Public Shared Edge_Cache18 As String = Edge_Master & "WebAssistDatabase-journal"
		Public Shared Edge_Cache19 As String = Edge_Master & "Network\Cookies-journal"
		Public Shared Edge_Cache20 As String = Edge_Master & "Network\Reporting and NEL-journal"
		Public Shared Edge_Cache21 As String = Edge_Master & "WebStorage\QuotaManager-journal"

		Public Shared Edge_Cookies As String = "C:\Users\" & username & "\AppData\Local\Microsoft\Edge\User Data\Default\IndexedDB" ' < all files and folders
		Public Shared Edge_Cookies1 As String = Edge_Master & "Network\Cookies"

		Public Shared Edge_History As String = Edge_Master & "Favicons"
		Public Shared Edge_History2 As String = Edge_Master & "History"
		Public Shared Edge_History3 As String = Edge_Master & "Network Action Predictor"
		Public Shared Edge_History4 As String = Edge_Master & "Shortcuts"
		Public Shared Edge_History5 As String = Edge_Master & "Top Sites"
		Public Shared Edge_History6 As String = Edge_Master & "Visited Links"
		Public Shared Edge_History7 As String = Edge_Master & "Web Data"
		Public Shared Edge_History8 As String = Edge_Master & "WebAssistDatabase"
		Public Shared Edge_History9 As String = Edge_Master & "Network\Network Persistent State"
		Public Shared Edge_History10 As String = Edge_Master & "Network\NetworkDataMigrated"
		Public Shared Edge_History11 As String = Edge_Master & "Network\Reporting and NEL"
		Public Shared Edge_History12 As String = Edge_Master & "Network\Token Bindings"
		Public Shared Edge_History13 As String = Edge_Master & "Network\TransportSecurity"
		Public Shared Edge_History14 As String = Edge_Master & "WebStorage\QuotaManager"

		Public Shared Edge_Session As String = "C:\Users\" & username & "\AppData\Local\Microsoft\Edge\User Data\Default\Session Storage" ' < all files
		Public Shared Edge_Session2 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\Edge\User Data\Default\Extension State" ' < all files
		Public Shared Edge_Session3 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\Edge\User Data\Default\Sessions" ' < all files

		Public Shared Edge_Passwords As String = Edge_Master & "Login Data"

		Public Shared Edge_Metrics As String = "C:\Users\" & username & "\AppData\Local\Microsoft\Edge\User Data" ' < pma files
		Public Shared Edge_Metrics2 As String = "C:\Users\" & username & "\AppData\Local\Microsoft\Edge\User Data\BrowserMetrics" ' < pma files
		#End Region

		#Region "Google Chrome"
		Public Shared Chrome_Master As String = "C:\Users\" & username & "\AppData\Local\Google\Chrome\User Data\Default\"

		Public Shared Chrome_Cache As String = "C:\Users\" & username & "\AppData\Local\Google\Chrome\User Data\Default\Cache\Cache_Data"
		Public Shared Chrome_Cache2 As String = "C:\Users\" & username & "\AppData\Local\Google\Chrome\User Data\Default\Cache\Cache_Data"
		Public Shared Chrome_Cache3 As String = "C:\Users\" & username & "\AppData\Local\Google\Chrome\User Data\Default\GPUCache"
		Public Shared Chrome_Cache4 As String = "C:\Users\" & username & "\AppData\Local\Google\Chrome\User Data\Default\Code Cache\js"
		Public Shared Chrome_Cache5 As String = "C:\Users\" & username & "\AppData\Local\Google\Chrome\User Data\Default\Code Cache\js\index-dir"
		Public Shared Chrome_Cache6 As String = "C:\Users\" & username & "\AppData\Local\Google\Chrome\User Data\Default\File System\001\t\Paths"
		Public Shared Chrome_Cache7 As String = "C:\Users\" & username & "\AppData\Local\Google\Chrome\User Data\Default\File System\Origins"
		Public Shared Chrome_Cache8 As String = "C:\Users\" & username & "\AppData\Local\Google\Chrome\User Data\Default\Service Worker\CacheStorage" '< files and folders
		Public Shared Chrome_Cache9 As String = "C:\Users\" & username & "\AppData\Local\Google\Chrome\User Data\GrShaderCache\GPUCache"
		Public Shared Chrome_Cache10 As String = "C:\Users\" & username & "\AppData\Local\Google\Chrome\User Data\ShaderCache\GPUCache"
		Public Shared Chrome_Cache11 As String = "C:\Users\" & username & "\AppData\Local\Google\Chrome\User Data\Default\JumpListIconsRecentClosed"
		Public Shared Chrome_Cache12 As String = "C:\Users\" & username & "\AppData\Local\Google\Chrome\User Data\Default\Safe Browsing Network"

		Public Shared Chrome_Cache13 As String = Chrome_Master & "History-journal"
		Public Shared Chrome_Cache14 As String = Chrome_Master & "Login Data-journal"
		Public Shared Chrome_Cache15 As String = Chrome_Master & "Network Action Predictor-journal"
		Public Shared Chrome_Cache16 As String = Chrome_Master & "Shortcuts-journal"
		Public Shared Chrome_Cache17 As String = Chrome_Master & "Top Sites-journal"
		Public Shared Chrome_Cache18 As String = Chrome_Master & "Web Data-journal"
		Public Shared Chrome_Cache19 As String = Chrome_Master & "Visited Links-journal"
		Public Shared Chrome_Cache20 As String = Chrome_Master & "\Network\Cookies-journal"
		Public Shared Chrome_Cache21 As String = Chrome_Master & "\Network\Reporting and NEL-journal"
		Public Shared Chrome_Cache22 As String = Chrome_Master & "Favicons-journal"

		Public Shared Chrome_History As String = Chrome_Master & "Visited Links"
		Public Shared Chrome_History2 As String = Chrome_Master & "History"
		Public Shared Chrome_History3 As String = Chrome_Master & "Network Action Predictor"
		Public Shared Chrome_History4 As String = Chrome_Master & "Shortcuts"
		Public Shared Chrome_History5 As String = Chrome_Master & "Top Sites"
		Public Shared Chrome_History6 As String = Chrome_Master & "Trusted Vault"
		Public Shared Chrome_History7 As String = Chrome_Master & "Visited Links"
		Public Shared Chrome_History8 As String = Chrome_Master & "Web Data"
		Public Shared Chrome_History9 As String = "C:\Users\" & username & "\AppData\Local\Google\Chrome\User Data\Default\JumpListIconsRecentClosed"

		Public Shared Chrome_Cookies As String = "C:\Users\" & username & "\AppData\Local\Google\Chrome\User Data\Default\IndexedDB"
		Public Shared Chrome_Cookies2 As String = Chrome_Master & "\Network\Cookies"

		Public Shared Chrome_Download As String = Chrome_Master & "DownloadMetadata"

		Public Shared Chrome_Metrics As String = "C:\Users\" & username & "\AppData\Local\Google\Chrome\User Data\BrowserMetrics" 'pma files

		Public Shared Chrome_Session As String = "C:\Users\" & username & "\AppData\Local\Google\Chrome\User Data\Default\Session Storage"
		Public Shared Chrome_Session2 As String = "C:\Users\" & username & "\AppData\Local\Google\Chrome\User Data\Default\Extension State"
		Public Shared Chrome_Session3 As String = "C:\Users\" & username & "\AppData\Local\Google\Chrome\User Data\Default\Sessions"

		Public Shared Chrome_Passwords As String = Chrome_Master & "Login Data"
		#End Region

		#Region "Firefox"
		Public Shared Firefox_Cache As String = "C:\Users\" & username & "\AppData\Local\Mozilla\Firefox\Profiles\" & My.Settings.Default.FirefoxPath & "\cache2"
		Public Shared Firefox_Cache2 As String = "C:\Users\" & username & "\AppData\Local\Mozilla\Firefox\Profiles\" & My.Settings.Default.FirefoxPath & "\cache2\doomed"
		Public Shared Firefox_Cache3 As String = "C:\Users\" & username & "\AppData\Local\Mozilla\Firefox\Profiles\" & My.Settings.Default.FirefoxPath & "\cache2\entries"
		Public Shared Firefox_Cache4 As String = "C:\Users\" & username & "\AppData\Local\Mozilla\Firefox\Profiles\" & My.Settings.Default.FirefoxPath & "\jumpListCache"
		Public Shared Firefox_Cache5 As String = "C:\Users\" & username & "\AppData\Local\Mozilla\Firefox\Profiles\" & My.Settings.Default.FirefoxPath & "\startupCache"

		Public Shared Firefox_History As String = "C:\Users\" & username & "\AppData\Local\Mozilla\Firefox\Profiles\" & My.Settings.Default.FirefoxPath & "\thumbnails"

		Public Shared Firefox_Cookies As String = "C:\Users\" & username & "\AppData\Roaming\Mozilla\Firefox\Profiles\" & My.Settings.Default.FirefoxPath & "\storage\default"

		Public Shared Firefox_Session As String = "C:\Users\" & username & "\AppData\Roaming\Mozilla\Firefox\Profiles\" & My.Settings.Default.FirefoxPath & "\sessionstore-backups"
		Public Shared Firefox_Session2 As String = "C:\Users\" & username & "\AppData\Roaming\Mozilla\Firefox\Profiles\" & My.Settings.Default.FirefoxPath & "\sessionCheckpoints.json"

		Public Shared Firefox_Site_Pref As String = "C:\Users\" & username & "\AppData\Roaming\Mozilla\Firefox\Profiles\" & My.Settings.Default.FirefoxPath & "\SiteSecurityServiceState.txt"

		Public Shared Firefox_Saved_Form As String = "C:\Users\" & username & "\AppData\Roaming\Mozilla\Firefox\Profiles\" & My.Settings.Default.FirefoxPath & "\formhistory.sqlite"

		Public Shared Firefox_Login As String = "C:\Users\" & username & "\AppData\Roaming\Mozilla\Firefox\Profiles\" & My.Settings.Default.FirefoxPath & "\logins.json"
		Public Shared Firefox_Login2 As String = "C:\Users\" & username & "\AppData\Roaming\Mozilla\Firefox\Profiles\" & My.Settings.Default.FirefoxPath & "\logins-backup.json"
		#End Region
	End Class
End Namespace
