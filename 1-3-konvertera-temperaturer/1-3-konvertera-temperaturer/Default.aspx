<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_1_3_konvertera_temperaturer.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Konvertera temperaturer</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Konvertera temperaturer</h1>
    <div>
        <asp:Label ID="startTemp" runat="server" Text="Starttemp"></asp:Label>
        <br />
        <asp:TextBox ID="startTempBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Starttemp får inte vara tom" ControlToValidate="startTempBox" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="StartTemp måste vara ett heltal" ControlToValidate="startTempBox" Type="Integer" Operator="DataTypeCheck" Display="Dynamic" Text="*"></asp:CompareValidator>
        <br />
        <asp:Label ID="endTemp" runat="server" Text="Sluttemp"></asp:Label>
        <br />
        <asp:TextBox ID="endTempBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Sluttemp får inte vara tom" ControlToValidate="endTempBox" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Sluttemp måste vara ett heltal större än starttemp" ControlToValidate="endTempBox" Operator="GreaterThan" Type="Integer" ControlToCompare="startTempBox" Text="*" Display="Dynamic"></asp:CompareValidator>
        <br />
        <asp:Label ID="increaseTemp" runat="server" Text="Tempeartursteg"></asp:Label>
        <br />
        <asp:TextBox ID="increaseTempBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Temperatursteg får inte vara tom" ControlToValidate="increaseTempBox" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Temperatursteg måste vara ett heltal mellan 1 och 100" ControlToValidate="increaseTempBox" MaximumValue="100" MinimumValue="1" Type="Integer" Text="*" Display="Dynamic"></asp:RangeValidator>
        <br />
        <asp:Label ID="convert" runat="server" Text="Typ av konvertering"></asp:Label>
        <br />
        <asp:RadioButton ID="celsiusRadio" runat="server" GroupName="convertRadio" Text="Celsius till Fahrenheit" Checked="True" />
        <br />
        <asp:RadioButton ID="fahrenheitRadio" runat="server" GroupName="convertRadio" Text="Fahrenheit till Celsius" />
        <br />
        <asp:Button ID="ConvertButton" runat="server" Text="Konvertera" OnClick="ConvertButton_Click" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Fel inträffade. Åtgärda felen och försök igen." />
    </div>
    <div>
        <!--här generas tabellen med konverterade temperaturer-->
    </div>
    </form>
</body>
</html>
