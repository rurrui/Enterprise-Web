<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Solution.aspx.cs" Inherits="SJD.Web.Show.Solution" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>晋城思及达商贸有限公司</title>
    <link href="../css/global.css" rel="stylesheet" />
    <link href="../css/layout.css" rel="stylesheet" />


    <script src="../js/jquery-3.2.1.min.js"></script>
    <script src="../js/jquery.flexslider-min.js"></script>
    <script src="../js/js-person.js"></script>

</head>
<body>
     <div id="top">
        <div class="nav_all">
            <div class="nav">
                <div id="logo" style="text-align: center; line-height: 95px">
                    <!--<img src="images/logo_img.png" style="width: 220px; height: 55px; margin-left: 25px;
                             margin-top: 18px;" />-->
                    <p style="font-size: 20px">
                        <a href="Index.aspx" style="display: block">思及达</a>
                    </p>
                </div>
                <!--end of logo-->
                <div class="nav_wd">
                    <div class="h_navlist" id="a">
                        <ul>
                            <li><a class="hover_menu" href="Index.aspx">首 页</a></li>
                            <li style="position: relative;">
                                <a href="Production.aspx">产品中心</a>
                                <div class="hidden_nav">
                                    <div class="hidden_top"></div>
                                    <dl>
                                         <%=strPTitle %>
                                    </dl>
                                    <div class="hidden_bottom"></div>
                                </div>
                            </li>
                            <li style="position: relative;">
                                <a href="Solution.aspx">解决方案</a>
                                <div class="hidden_nav">
                                    <div class="hidden_top"></div>
                                    <dl>
                                        <%=strTopSoTitle %>
                                        
                                    </dl>
                                    <div class="hidden_bottom"></div>
                                </div>
                            </li>
                         
                            <li style="position: relative;">
                                <a href="channel.php.htm">渠道合作</a>
                                <div class="hidden_nav-s">
                                    <div class="hidden_top"></div>
                                    <dl>

                                        <dd>
                                            <a href="channel.php.htm">渠道与合作</a>
                                        </dd>
                                        <dd>
                                            <a href="channel2.php.htm">渠道部联系方式</a>
                                        </dd>

                                    </dl>
                                    <div class="hidden_bottom"></div>
                                </div>
                            </li>
                            <li style="position: relative;">
                                <a href="support.php.htm">技术支持</a>
                                <div class="hidden_nav-s">
                                    <div class="hidden_top"></div>
                                    <dl>

                                        <dd>
                                            <a href="support.php.htm">技术问答</a>
                                        </dd>
                                        <dd>
                                            <a href="service.php.htm">客服中心</a>
                                        </dd>

                                    </dl>
                                    <div class="hidden_bottom"></div>
                                </div>
                            </li>
                            <li style="background: none !important; position: relative;">
                                <a href="Introduction.html">关于公司</a>
                                <div class="hidden_nav-s">
                                    <div class="hidden_top"></div>
                                    <dl>

                                        <dd>
                                            <a href="Introduction.html">公司介绍</a>
                                        </dd>
                                        <dd>
                                            <a href="News.aspx">新闻快讯</a>
                                        </dd>
                                        <dd>
                                            <a href="com-meeting.php.htm">公司公告</a>
                                        </dd>
                                        <dd>
                                            <a href="com-honer.php.htm">资质荣誉</a>
                                        </dd>
                                    </dl>
                                    <div class="hidden_bottom"></div>
                                </div>
                            </li>
                        </ul>
                    </div>
                    <!--end of h_navlist-->
                </div>
                <!--end of nav_wd-->
            </div>
            <!--end of nav-->
        </div>
        <!--end of nav_all-->

        <!--end of slides-->
    </div>
    <!--end of top-->

    <script type="text/javascript">

        //alert($(document));
        jQuery(document).ready(function () {

            jQuery("#a li").mouseover(function () {

                jQuery(this).children(".hidden_nav").show();
                //$('.hidden_nav').show(); 
            })
            jQuery("#a li").mouseout(function () {

                jQuery('.hidden_nav').hide();
            })
            jQuery(".hidden_nav").mouseover(function () {

                jQuery(this).prev("a").addClass("hover_menu");

            })

            jQuery(".hidden_nav").mouseout(function () {

                jQuery(this).prev("a").removeClass("hover_menu");
            })



            jQuery("#a li").mouseover(function () {

                jQuery(this).children(".hidden_nav-s").show();
                //jQuery('.hidden_nav').show(); 
            })
            jQuery("#a li").mouseout(function () {

                jQuery('.hidden_nav-s').hide();
            })
            jQuery(".hidden_nav-s").mouseover(function () {

                jQuery(this).prev("a").addClass("hover_menu");

            })

            jQuery(".hidden_nav-s").mouseout(function () {

                jQuery(this).prev("a").removeClass("hover_menu");
            })

        });




    </script>

    <div class="banner-page">
        <div class="banner-pagepic5">
        </div>
    </div>
    <!--end of banner-->

    <div class="content-in">


        <div class="list-l">
            <div class="l-tit">
                <img src="../images/logo.jpg" style="width: 50px; height: 50px" />
                <p class="en">SOLUTION</p>
                <p class="zh">解决方案</p>
            </div>
            <div class="mc">
                <ul>
                 
                    <%=strSoTitle %>
                </ul>


            </div>
            <!--end of mc-->
            <div class="mb10px">
                <a href="zhaopin.php.htm">
                    <img src="../images/link-pic1.jpg" />
                </a>
            </div>
            <a href="com-contact.php.htm">
                 <img src="../images/link-pic2.jpg" />
            </a>
        </div>
        <!--end of list-l-->
        <div class="list-r">
            <div class="list-rtit mb10px">
                <a href="Index.aspx">首 页</a>
                &nbsp;>&nbsp;
                    <a href="Solution.aspx">解决方案</a>
                &nbsp;>&nbsp;<%=Model.SolutionTitle %>
            </div>
            <!--end of list-rtit-->
            <div class="detail">
               <%=strHtml %>
            </div>
            <!--end of detail-->


        </div>
        <!--end of list-r-->


    </div>
    <!--end of content-->
    <div class="foot-in">
        <div class="foot-content">
            <div class="fr-link">
                <h4>LINK</h4>
                <h3>友情链接</h3>
              <div class="link-mod">
                    <a target="_blank" href="http://www.baidu.com">连接3</a>
                    <a target="_blank" href="http://www.baidu.com">链接2</a>
                    <a target="_blank" href="http://www.baidu.com">连接1</a>
                    <br />

                    <a target="_blank" href="http://www.baidu.com">链接4</a>
                    <a target="_blank" href="http://www.baidu.com">链接5</a>

                </div>
                <!--end of link-mod-->
            </div>
            <!--end of fr-link-->
            <div class="type-right">
                Copyright © 晋城市思及达商贸有限公司 All Rights Reserved
            </div>
            <!--end of type-right-->
        </div>
        <!--end of foot-content-->
    </div>
</body>
</html>
