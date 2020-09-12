Public Class eventhandlingEx
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Write("Page_Load")
    End Sub

    Private Sub eventhandlingEx_PreInit(sender As Object, e As EventArgs) Handles Me.PreInit
        Response.Write("Page_Preinit")
    End Sub

    Private Sub eventhandlingEx_Init(sender As Object, e As EventArgs) Handles Me.Init
        Response.Write("Page_Init")
    End Sub

    Private Sub eventhandlingEx_InitComplete(sender As Object, e As EventArgs) Handles Me.InitComplete
        Response.Write("Page_InitComplete")
    End Sub

    Private Sub eventhandlingEx_PreLoad(sender As Object, e As EventArgs) Handles Me.PreLoad
        Response.Write("Page_PreLoad")
    End Sub

    Private Sub eventhandlingEx_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
        Response.Write("Page_Prerender")
    End Sub

    Private Sub eventhandlingEx_PreRenderComplete(sender As Object, e As EventArgs) Handles Me.PreRenderComplete
        Response.Write("Page_PrerenderComplete")
    End Sub

    Private Sub eventhandlingEx_LoadComplete(sender As Object, e As EventArgs) Handles Me.LoadComplete
        Response.Write("Page_LoadComplete")
    End Sub

    Private Sub eventhandlingEx_Unload(sender As Object, e As EventArgs) Handles Me.Unload
        ' Response.Write("Page_UnLoad")
    End Sub

    Private Sub Button1_Init(sender As Object, e As EventArgs) Handles Button1.Init
        Response.Write("Button_Init")
    End Sub

    Private Sub Button1_Load(sender As Object, e As EventArgs) Handles Button1.Load
        Response.Write("Button_Load")
    End Sub

    Private Sub Button1_PreRender(sender As Object, e As EventArgs) Handles Button1.PreRender
        Response.Write("Button_PreRender")
    End Sub

    Private Sub Button1_Unload(sender As Object, e As EventArgs) Handles Button1.Unload
        'Response.Write("Button_Unload")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Write("Button_Click")
    End Sub

    Private Sub Button1_Command(sender As Object, e As CommandEventArgs) Handles Button1.Command
        Response.Write("Button_Command")
    End Sub

    Private Sub Button1_DataBinding(sender As Object, e As EventArgs) Handles Button1.DataBinding
        Response.Write("Button_DataBinding")
    End Sub

    Private Sub Button1_Disposed(sender As Object, e As EventArgs) Handles Button1.Disposed
        Response.Write("Button_Disposed")
    End Sub

End Class