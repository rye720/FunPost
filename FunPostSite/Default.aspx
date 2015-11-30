<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default"  %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fun Post</title>
</head>
<body>
     <script>
          function validword(evt) {
               var charCode = (evt.which) ? evt.which : event.keyCode
               if ((charCode >= 32 && charCode <= 57) || (charCode >= 65 && charCode <= 90) || (charCode >= 97 && charCode <= 122))
                    return true;
               return false;
          }
     </script>
    <form id="form1" runat="server">

        <div>

            <asp:Button runat="server" ID="unhide" Text="New Post" onclick="newpostbtn_click"></asp:Button>

            </div>
            
        <!-- Create Post Section -->
            <label id="info" runat="server"></label>
            <asp:PlaceHolder runat="server" id="newPost" Visible ="false">

            <div style="border: 2px">
                <h3>Please enter a title for your post in the text box below</h3><input type="text" runat="server" id="ti" required="required" maxlength="64"  onkeypress="return validword(event)"/>
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
