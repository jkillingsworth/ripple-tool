module Program

open System
open System.Windows.Forms

//-------------------------------------------------------------------------------------------------

[<STAThread>]
Application.EnableVisualStyles()
Application.SetCompatibleTextRenderingDefault(false)
Application.Run(new RippleTool.UI.MainForm())
