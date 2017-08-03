<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadPic.aspx.cs" Inherits="SJD.Web.Test.UploadPic" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="renderer" content="webkit" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1" />
    <link href="../Layui/layui/css/layui.css" rel="stylesheet" />
    <script src="../js/jquery-3.2.1.min.js"></script>
    <title></title>
</head>
<body>
    <%--<form action="UploadPic.aspx" method="post" enctype="multipart/form-data">--%>
    <fieldset class="layui-elem-field layui-field-title" style="margin-top: 20px;">
        <legend>设定上传文件的格式</legend>
    </fieldset>
        <%--</form>--%>
    <input name="file" class="layui-upload-file" type="file" />
    <script src="../Layui/layui/layui.js"></script>
    <!-- 注意：如果你直接复制所有代码到本地，上述js路径需要改成你本地的 -->
   <script>
       layui.use('upload', function () {
           layui.upload({
               url: 'upload.ashx' //上传接口
               , success: function (res) { //上传成功后的回调
                   console.log(res)
               }
           });

           layui.upload({
               url: 'upload.ashx'
               , elem: '#test' //指定原始元素，默认直接查找class="layui-upload-file"
               , method: 'post' //上传接口的http类型
               , success: function (res) {
                   LAY_demo_upload.src = res.url;
               }
           });
       });
       </script>
</body>
</html>
