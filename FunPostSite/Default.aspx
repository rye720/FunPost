<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fun Post</title>
</head>
<body>
    <form id="form1" runat="server">

        <div>

            <asp:Button runat="server" ID="unhide" Text="New Post" onclick="newpostbtn_click"></asp:Button>

            </div>
            
        <!-- Create Post Section -->
            
            <asp:PlaceHolder runat="server" id="newPost" Visible ="false">

            <div style="border: 2px">
                <h3>Please enter a title for your post in the text box below</h3><input type="text" runat="server" id="title" required="required" />
                 <br />
                 <h3>Please select an image to upload<img src ="../need/question.jpg" width="20" height="20"  title="You may currently only upload an image of these types: .jpg, .gif, .tif" />
</h3>
                 <input type="file" runat="server" id="pic" accept=".gif,.jpg,.tif" required="required" />
                 <br />
                 <br />
                <asp:button runat="server" Text="submit" onclick="submitbtn_click" />

            </div>

            </asp:PlaceHolder>
         <div id="post" runat="server"></div>

        
    </form>
</body>
</html>
