﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit-user.aspx.cs" Inherits="SJD.Web.Admin.edit_user" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../css/bootstrap.css" rel="stylesheet" />
    <link href="../css/site.css" rel="stylesheet" />
    <link href="../css/bootstrap-responsive.css" rel="stylesheet" />

    <script src="../js/jquery-3.2.1.min.js"></script>
    <title></title>
</head>
<body>
    <form method="post" runat="server">
        <div class="navbar navbar-fixed-top">
            <div class="navbar-inner">
                <div class="container-fluid">
                    <a class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </a>
                    <a class="brand" href="#">管理员</a>
                    <div class="btn-group pull-right">
                        <a class="btn" href="my-profile.html"><i class="icon-user"></i>管理员</a>
                        <a class="btn dropdown-toggle" data-toggle="dropdown" href="#">
                            <span class="caret"></span>
                        </a>
                        <ul class="dropdown-menu">
                            <li><a href="my-profile.html">Profile</a></li>
                            <li class="divider"></li>
                            <li><a href="#">Logout</a></li>
                        </ul>
                    </div>
                    <div class="nav-collapse">
                        <ul class="nav">
                            <li><a href="Index.aspx">主页</a></li>
                            <li class="dropdown"><a href="Users.aspx" class="dropdown-toggle" data-toggle="dropdown">人员<b class="caret"></b></a>
                                <ul class="dropdown-menu">
                                    <li><a href="new-user.aspx">添加</a></li>
                                    <li class="divider"></li>
                                    <li><a href="Users.aspx">管理</a></li>
                                </ul>
                            </li>
                            <li class="dropdown"><a href="#" class="dropdown-toggle" data-toggle="dropdown">新闻<b class="caret"></b></a>
                                <ul class="dropdown-menu">
                                    <li><a href="add-news.aspx">添加</a></li>
                                    <li class="divider"></li>
                                    <li><a href="Index.aspx">管理</a></li>
                                </ul>
                            </li>
                            <li><a href="stats.html">票务</a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>

        <div class="container-fluid">
            <div class="row-fluid">
                <div class="span3">
                    <div class="well sidebar-nav" style="margin-top: 10px">
                        <ul class="nav nav-list">
                            <li class="nav-header"><i class="icon-wrench"></i>用户管理</li>
                            <li><a href="Super-UserManager.aspx">管理员</a></li>
                            <li class="active"><a href="add-user.aspx">添加</a></li>
                            <li class="nav-header"><i class="icon-signal"></i>公司新闻</li>
                            <li><a href="Index.aspx">管理</a></li>
                            <li><a href="add-news.aspx">添加</a></li>

                            <li class="nav-header"><i class="icon-user"></i>公司产品</li>
                            <li><a href="production.aspx">管理</a></li>
                            <li><a href="add-pro.aspx">添加</a></li>

                        </ul>
                    </div>
                </div>
                <div class="span9">
                    <div class="row-fluid">
                        <div class="page-header">
                            <h1>添加 <small>添加管理员</small></h1>
                        </div>
                        <form class="form-horizontal">
                            <fieldset>
                                <div class="control-group">
                                    <label class="control-label" for="name">姓名</label>
                                    <div class="controls">
                                        <input type="text" class="input-xlarge" id="name" name="username" style="height: 30px" value="<%=Model.ManagerName %>""/>
                                    </div>
                                </div>

                                <div class="control-group">
                                    <label class="control-label" for="name">权限</label>
                                    <div class="controls">
                                        <select name="interest" onchange="OptionValue()" id="sel">
                                            <option></option>
                                            <option value="1">超级管理员</option>
                                            <option value="2">管理员</option>
                                        </select>
                                        <input type="hidden" name="hidden" id="hidden" />
                                    </div>
                                </div>
                                <div class="control-group">
                                    <label class="control-label" for="name">密码</label>
                                    <div class="controls">
                                        <input type="password" class="input-xlarge" id="upwd" name="upwd"  value="<%=Model.ManagerPwd %>""/>
                                    </div>
                                </div>
                                <div class="control-group">
                                    <label class="control-label" for="name">请重新输入密码</label>
                                    <div class="controls">
                                        <input type="password" class="input-xlarge" id="againpwd" name="againpwd" onkeyup="ValidatePwd()" />
                                    </div>
                                </div>
                                <div class="control-group">
                                    <label class="control-label" id="show" style="color: red"></label>
                                </div>
                                <div class="form-actions">
                                    <input type="submit" class="btn btn-success btn-large" value="修改" />
                                    <a class="btn" href="users.html">取消</a>
                                </div>
                                <br />

                            </fieldset>
                        </form>
                    </div>
                </div>
            </div>

            <hr />

            <footer class="well">
                &copy; Admin
            </footer>

        </div>


        <script src="../js/bootstrap.min.js"></script>
        <script src="../Layui/layui/layui.js"></script>
        <script>
            function OptionValue() {
                var value = $("#sel").find("option:selected").attr("value");
                $("#hidden").val(value);
            }
            function ValidatePwd() {
                var pwd1 = $("#upwd").val();
                var pwd2 = $("#againpwd").val();

                if (pwd1 == pwd2) {
                    document.getElementById("show").innerText = "";
                }
                else {
                    document.getElementById("show").innerText = "两次密码不符";
                }
            }

        </script>
    </form>
</body>
</html>
