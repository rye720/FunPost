<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fun Post</title>
</head>
<body>
    <form id="form1" runat="server">

        <div>

            <asp:Button runat="server" Text="New Post" onserverclick="newpostbtn_click"></asp:Button>

            </div>
            
        <!-- Create Post Section -->
            
            <asp:PlaceHolder runat="server" ID="newPost" Visible ="false">

            <div style="border: 2px">

                <asp:TextBox runat="server"></asp:TextBox>

                <asp:Button runat="server" Text="Submit" onserverclick="submitbtn_click"></asp:Button>

            </div>

                </asp:PlaceHolder>

        
    </form>
</body>
</html>
