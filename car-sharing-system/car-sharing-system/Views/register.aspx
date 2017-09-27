﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs"  Inherits="car_sharing_system.Admin_Theme.pages.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="DashboardPageHolder" runat="server">

<div class="row">
    <div class="col-lg-8">
        <div class="panel panel-default">
            <div class="panel-heading">
                <i class="fa fa-user fa-fw"></i> Login
                <div class="pull-right">
                    <div class="btn-group"></div>
                </div>        
            </div>
            
            <!-- /.panel-heading -->
            <div class="panel-body">
                <div class="form-group">      
                <form id="form1" runat="server">  
                    <asp:ScriptManager ID="sm" runat="server"></asp:ScriptManager>
                    <div class="row">
                    </div>
                    <div class="col-lg-6">
                        <div class="form-group">

                            <!-- Email Label -->
                            <label>Email</label>
                            <br />
                            <asp:TextBox Type="email" ID="emailRego" runat="server"></asp:TextBox> 
                            <br />
                            <asp:RegularExpressionValidator runat="server" Display="Dynamic" 
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                ControlToValidate="emailRego" ForeColor="Red" ErrorMessage="Invalid email address." />
                            <br />

                            <!-- Password Label -->
                            <label>Password</label> 
                            <br />
                            <asp:TextBox ID="passwordRego" runat="server" Type="password"></asp:TextBox> 
                            <br />
                            <asp:RequiredFieldValidator  runat="server" ControlToValidate="passwordRego"
                                ValidationExpression="[0-9]{1,}[a-z]{1,}[A-Z]{1,}"
                                ErrorMessage="Password Requires a capital letter, a lower case letter and a number"   
                                ForeColor="Red"></asp:RequiredFieldValidator>
                            <br />

                            <!-- License Label -->
                            <label>License Number</label> 
                            <br />
                            <asp:TextBox ID="licenseRego" runat="server"></asp:TextBox> 
                            <br />
                            <asp:RegularExpressionValidator runat="server" 
                                ValidationExpression="^[0-9]{1,9}$"
                                ControlToValidate="licenseRego" ForeColor="Red" ErrorMessage="Invalid license number." />
                            <br />

                            <!-- First Name Label -->
                            <label>First Name</label> 
                            <br />
                            <asp:TextBox ID="firstRego" runat="server"></asp:TextBox> 
                            <br />
                            <asp:RequiredFieldValidator  runat="server" ControlToValidate="firstRego"
                                ValidationExpression="^[a-zA-zZ]"
                                ErrorMessage="Please enter your first name"   
                                ForeColor="Red"></asp:RequiredFieldValidator>
                            <br />

                            <!-- Last Name Label -->
                            <label>Last Name</label>
                            <br />
                            <asp:TextBox ID="lastNameRego" runat="server"></asp:TextBox> 
                            <br />
                            <asp:RequiredFieldValidator  runat="server"   
                                ControlToValidate="lastNameRego" ErrorMessage="Please enter your last name"   
                                ValidationExpression="^[a-zA-zZ]"
                                ForeColor="Red"></asp:RequiredFieldValidator>
                            <br />

                            <!-- Gender Label -->
                            <label>Gender</label> 
                            <br />
                            <asp:RadioButtonList id=RadioButtonList1 runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                            </asp:RadioButtonList>
                            <br />

                            <!-- Birth date Label -->
                            <label>Birth</label> 
                            <br />
                            <asp:TextBox ID="birthRego" runat="server" placeholder="dd/mm/yy"></asp:TextBox> 
                            <br />
                            <asp:RegularExpressionValidator ValidationExpression="^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$"
                                runat="server" Display="Dynamic" 
                                ControlToValidate="birthRego" ForeColor="Red" ErrorMessage="Enter birth." />
                            <br />

                            <!-- Phone Label -->
                            <label>Phone Number</label>
                            <br />
                            <asp:TextBox ID="phoneNoRego" runat="server"></asp:TextBox> 
                            <br />
                            <asp:RegularExpressionValidator runat="server" Display="Dynamic" 
                                ValidationExpression="^[0-9]{10}$"
                                ControlToValidate="phoneNoRego" ForeColor="Red" ErrorMessage="Invalid phone number." />          
                            <br />

                            <!-- Address Label -->
                            <label>Street address</label>
                            <br />
                            <asp:TextBox ID="streetRego" runat="server"></asp:TextBox> 
                            <br />
                            <asp:RegularExpressionValidator runat="server" Display="Dynamic"
                                ValidationExpression="^[A-Za-z0-9_.]+$"
                                ControlToValidate="streetRego" ForeColor="Red" ErrorMessage="Enter street address." />             
                            <br />

                            <!-- Suburb Label -->
                            <label>Suburb</label> 
                            <br />
                            <asp:TextBox ID="suburbRego" runat="server"></asp:TextBox> 
                            <br />
                            <asp:RequiredFieldValidator  runat="server" ControlToValidate="suburbRego"
                                ValidationExpression="^[a-zA-zZ]"
                                ErrorMessage="Please enter your suburb"   
                                ForeColor="Red"></asp:RequiredFieldValidator>     
                            <br />

                            <!-- Postcode Label -->
                            <label>Post code</label>
                            <br />
                            <asp:TextBox ID="postRego" runat="server"></asp:TextBox> 
                            <br />
                            <asp:RegularExpressionValidator runat="server" Display="Dynamic" 
                                ValidationExpression="^[0-9]{4}$"
                                ControlToValidate="postRego" ForeColor="Red" ErrorMessage="Enter postcode." />           
                            <br />

                            <!-- Territory Label -->
                            <label>Territory</label> 
                            <br />
                            <asp:TextBox ID="terrRego" runat="server"></asp:TextBox> 
                            <br />
                            <asp:RequiredFieldValidator  runat="server" ControlToValidate="terrRego"
                                ValidationExpression="^[a-zA-zZ]"
                                ErrorMessage="Please enter your territory"   
                                ForeColor="Red"></asp:RequiredFieldValidator>
                            <br>

                            <!-- City Label -->
                           <label>City</label> 
                            <br />
                            <asp:TextBox ID="cityRego" runat="server"></asp:TextBox> 
                            <br />
                            <asp:RequiredFieldValidator  runat="server" ControlToValidate="cityRego"
                                ValidationExpression="^[a-zA-zZ]"
                                ErrorMessage="Please enter city"   
                                ForeColor="Red"></asp:RequiredFieldValidator>
                            <br>

                            <!-- Country Label -->
                            <label>Country</label> 
                            <br />
                            <asp:TextBox ID="countryRego" runat="server"></asp:TextBox> 
                            <br />
                            <asp:RequiredFieldValidator  runat="server" ControlToValidate="countryRego"
                                ValidationExpression="^[a-zA-zZ]"
                                ErrorMessage="Please enter your country"   
                                ForeColor="Red"></asp:RequiredFieldValidator>
                            <br />
                         
                            <p>Confirmation button</p>
                            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click"  href="/successIssue.aspx"></asp:Button>                   
                            <span id="regFail" runat="server"></span>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>
</div>      
</asp:Content>
