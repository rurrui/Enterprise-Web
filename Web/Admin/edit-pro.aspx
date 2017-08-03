<%@ Page Language="C#" ValidateRequest="false" AutoEventWireup="true" CodeBehind="edit-pro.aspx.cs" Inherits="SJD.Web.Admin.edit_pro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../css/bootstrap.css" rel="stylesheet" />
    <link href="../css/site.css" rel="stylesheet" />
    <link href="../css/bootstrap-responsive.css" rel="stylesheet" />
    <link href="../Layui/layui/css/layui.css" rel="stylesheet" />
    <script src="../js/jquery-3.2.1.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>
    <script src="../Layui/layui/layui.js"></script>
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
                    <div class="well sidebar-nav" style="margin-top: 50px">
                        <ul class="nav nav-list">
                            <li class="nav-header"><i class="icon-wrench"></i>用户管理</li>
                            <li><a href="users.html">管理员</a></li>
                            <li><a href="roles.html">游客</a></li>
                            <li class="nav-header"><i class="icon-signal"></i>公司新闻</li>
                            <li><a href="Index.aspx">管理</a></li>
                            <li><a href="add-news.aspx">添加</a></li>

                            <li class="nav-header"><i class="icon-user"></i>公司产品</li>
                            <li class="active"><a href="add-pro.aspx">添加</a></li>
                            <li><a href="production.aspx">管理</a></li>

                        </ul>
                    </div>
                </div>
                <div class="span9">
                    <div class="row-fluid">
                        <div class="page-header" style="margin-top: 60px">
                            <h1>添加 <small>添加产品</small></h1>
                        </div>
                        <form class="form-horizontal">
                            <fieldset>
                                <div class="control-group">
                                    <label class="control-label" for="name">产品名</label>
                                    <div class="controls">
                                        <input type="text" class="input-xlarge" value="<%=Model.ProTitle %>"" id="name" name="eptitle" style="height: 30px"/>
                                    </div>
                                </div>
                                <div class="control-group">
                                    <label class="control-label" for="name">产品图片</label>
                                    <div class="controls">
                                        <input name="file" class="layui-upload-file" type="file" />
                                    </div>
                                </div>
                                <div class="control-group">
                                    <textarea class="layui-textarea" id="LAY_demo1" style="display: none" name="eparticle">  
                                        <%=Model.ProContent %>
                                    </textarea>
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
        <script>
            layui.use('upload', function () {
                layui.upload({
                    url: 'add-upload-pro.ashx' //上传接口
                    , success: function (res) { //上传成功后的回调
                        console.log(res)
                    }
                });

                layui.upload({
                    url: 'add-upload-pro.ashx'
                    , elem: '#test' //指定原始元素，默认直接查找class="layui-upload-file"
                    , method: 'post' //上传接口的http类型
                    , success: function (res) {
                        LAY_demo_upload.src = res.url;
                    }
                });
            });
        </script>

        <script>
            layui.use('layedit', function () {
                var layedit = layui.layedit
                    , $ = layui.jquery;
                layedit.set({
                    uploadImage: {
                        url: 'add-upload.ashx' //接口url
                        , type: 'post' //默认post
                    }
                });

                //构建一个默认的编辑器
                var index = layedit.build('LAY_demo1');
            });
        </script>
    </form>
</body>
</html>
