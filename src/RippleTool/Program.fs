module Program

open System.Windows.Forms

//-------------------------------------------------------------------------------------------------

Application.EnableVisualStyles()
Application.SetCompatibleTextRenderingDefault(false)
Application.Run(new RippleTool.UI.MainForm())
