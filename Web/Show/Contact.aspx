<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="SJD.Web.Show.Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../css/global.css" rel="stylesheet" />
    <link href="../css/layout.css" rel="stylesheet" />
    <script src="../js/jquery-3.2.1.min.js"></script>
    <title></title>
</head>
<body>
   <div id="top">
        <div class="nav_all nav_all_in">
            <div class="nav_in">
                <div id="logo" style="text-align: center; line-height: 95px">
                    <p style="font-size: 15px">
                        <a href="Index.aspx" style="display: block">晋城市思及达商贸有限公司</a>
                    </p>
                </div>
                <!--end of logo-->
                <div class="nav_wd">
                    <div class="h_navlist1" id="a">
                        <ul>
                            <li><a href="Index.aspx">首 页</a></li>
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
                          
                             <li style="position:relative;">
                                <a href="Recruit.aspx">招贤纳士</a>
                            </li>
                            <li style="position:relative;">
                                <a href="Contact.aspx" class="hover_menu">联系我们</a>
                               
                            </li>
                            <li style="background: none !important; position: relative;"><a  href="Info.aspx">关于公司</a>
                                <div class="hidden_nav-s">
                                    <div class="hidden_top"></div>
                                    <dl>

                                        <dd>
                                            <a href="Info.aspx" >公司介绍</a>
                                        </dd>
                                        <dd>
                                            <a href="News.aspx" >新闻快讯</a>
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
        <img src="../images/banner-page3.jpg" />
        </div>
    </div>
    <!--end of banner-->

    <div class="content-in">


        <div class="list-l">
            <div class="l-tit">
                <img src="../images/logo.jpg" style="width:50px;height:50px"/>
                <p class="en">About Enterprise</p>
                <p class="zh">关于公司</p>
            </div>
            <div class="mc">
                <ul>
                    <li>
                        <a href="Info.aspx">公司介绍</a>
                    </li>

                    <li>
                        <a href="News.aspx">新闻快讯</a>
                    </li>
                  

                </ul>
            </div>
            <!--end of mc-->
            <div class="mb10px">
                <a href="Recruit.aspx">
                    <img src="../images/link-pic1.jpg" /></a>
            </div>
            <a href="Contact.aspx">
                <img src="../images/link-pic2.jpg" /></a>
        </div>
        <!--end of list-l-->
        <div class="list-r">
            <div class="list-rtit mb10px">
                <a href="Index.aspx">首 页</a>
                &nbsp;>&nbsp;
                    <a href="Info.aspx">关于公司</a>
                &nbsp;>&nbsp;
                    <a href="News.aspx">联系我们</a>
                
            </div>
            <!--end of list-rtit-->
            <div class="detail">

                	<div class="case-tit">晋城市思及达商贸有限公司</div>
			    		<div class="addr-mod">
                            <p><strong>地址：</strong>晋城市城区富达大厦1116</p>
                            <p><strong>电话：</strong>0356-2023943</p>
                            <p><strong>传真：</strong>www.sjd.com</p>
                            <p><strong>邮编：</strong>048000</p>
                            
                        </div>
             
            </div>
            <!--end of detail-->


        </div>
        <!--end of list-r-->
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
    <!--end of foot-->
</body>
</html>
