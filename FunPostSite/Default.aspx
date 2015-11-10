<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fun Post</title>
</head>
<body>
    <form id="form1" runat="server">

        <div>

            <asp:Button runat="server" Text="New Post" onclick="newpostbtn_click"></asp:Button>

            </div>
            
        <!-- Create Post Section -->
            
            <asp:PlaceHolder runat="server" id="newPost" Visible ="false">

            <div style="border: 2px">
                <input type="text" runat="server" id="title" />
                 <input type="file" runat="server" id="pic" accept=".gif,.jpg,.tif" required="required" />
                <asp:button runat="server" Text="submit" onclick="submitbtn_click" />

            </div>

            </asp:PlaceHolder>
         <div id="post" runat="server"></div>

        
    </form>
</body>
</html>
