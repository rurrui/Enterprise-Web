<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SJD.Web.Admin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../css/Login/H-ui.min.css" rel="stylesheet" />
    <link href="../css/Login/H-ui.login.css" rel="stylesheet" />
    <link href="../css/Login/style.css" rel="stylesheet" />
    <link href="../css/Login/iconfont.css" rel="stylesheet" />
    <title>登录界面</title>
</head>
<body>
     <form id="form1" runat="server">
    <input type="hidden" id="TenantId" name="TenantId" value="" />
    <div class="header"></div>
    <div class="loginWraper">
        <div id="loginform" class="loginBox">
            <form class="form form-horizontal" action="index.html" method="post">
                <div class="row cl">
                    <label class="form-label col-3"><i class="Hui-iconfont"></i></label>
                    <div class="formControls col-8">
                        <input id="" name="uname" type="text" placeholder="账户" class="input-text size-L"/>
                    </div>
                </div>
                <div class="row cl">
                    <label class="form-label col-3"><i class="Hui-iconfont"></i></label>
                    <div class="formControls col-8">
                        <input id="" name="upwd" type="password" placeholder="密码" class="input-text size-L"/>
                    </div>
                </div>
                <div class="row cl">
                    <div class="formControls col-8 col-offset-3">
                        <input class="input-text size-L" name="vcode" type="text" placeholder="验证码" onblur="if(this.value==''){this.value='验证码:'}" onclick="if (this.value == '验证码:') { this.value = ''; }" value="验证码:" style="width: 150px;"/>      
                        <img src="../VCode.ashx"/>
                        <br/>
                        <p></p>
                        
                    </div>
                </div>
           
                <div class="row">
                    <div class="formControls col-8 col-offset-3">
                        <input name="" type="submit" class="btn btn-success radius size-L" value="&nbsp;登&nbsp;&nbsp;&nbsp;&nbsp;录&nbsp;"/>
                        <input name="" type="reset" class="btn btn-default radius size-L" value="&nbsp;取&nbsp;&nbsp;&nbsp;&nbsp;消&nbsp;"/>
                    </div>
                </div>
            </form>
        </div>
    </div>
    <div class="footer">Copyright 巨硬科技有限公司 by rurui</div>
    <script src="../js/jquery-3.2.1.min.js"></script>
    <script type="text/javascript" src="js/H-ui.js"></script>
    <script>
        var _hmt = _hmt || [];
        (function () {
            var hm = document.createElement("script");
            hm.src = "//hm.baidu.com/hm.js?080836300300be57b7f34f4b3e97d911";
            var s = document.getElementsByTagName("script")[0];
            s.parentNode.insertBefore(hm, s);
        })();
        var _bdhmProtocol = (("https:" == document.location.protocol) ? " https://" : " http://");
        document.write(unescape("%3Cscript src='" + _bdhmProtocol + "hm.baidu.com/h.js%3F080836300300be57b7f34f4b3e97d911' type='text/javascript'%3E%3C/script%3E"));
</script>
        </form>
</body>
</html>
