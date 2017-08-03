﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="SJD.Web.Show.News" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../css/global.css" rel="stylesheet" />
    <link href="../css/layout.css" rel="stylesheet" />
    <script src="../js/jquery-3.2.1.min.js"></script>
    <title>晋城思及达商贸有限公司</title>
</head>
<body>
    <div id="top">
        <div class="nav_all nav_all_in">
            <div class="nav_in">
                <div id="logo" style="text-align:center;line-height:95px">
                    <p style="font-size: 30px">
                        <a href="News.aspx" style="display: block">思及达</a>
                    </p>
                </div>
                <!--end of logo-->
                <div class="nav_wd">
                    <div class="h_navlist1" id="a">
                        <ul>
                             <li><a class="hover_menu" href="index.php.htm">首 页</a></li>
                            <li style="position:relative;">
                                <a href="product.php.htm">产品中心</a>
                                <div class="hidden_nav">
                                    <div class="hidden_top"></div>
                                    <dl>
                                        <dd>
                                            <a href="product.php-id=5.htm">产品一</a>
                                        </dd>
                                        <dd>
                                            <a href="product.php-id=6.htm">产品二</a>
                                        </dd>
                                        <dd>
                                            <a href="product.php-id=7.htm">产品三</a>
                                        </dd>
                                        <dd>
                                            <a href="product.php-id=8.htm">产品四</a>
                                        </dd>
                                        <dd>
                                            <a href="product.php-id=11.htm">产品五</a>
                                        </dd>
                                        <dd>
                                            <a href="product.php-id=12.htm">产品六</a>
                                        </dd>
                                        <dd>
                                            <a href="product.php-id=13.htm">产品七</a>
                                        </dd>
                                        <dd>
                                            <a href="product.php-id=17.htm">产品八</a>
                                        </dd>
                                        <dd>
                                            <a href="product.php-id=18.htm">产品九</a>
                                        </dd>
                                    </dl>
                                    <div class="hidden_bottom"></div>
                                </div>
                            </li>
                            <li style="position:relative;">
                                <a href="solution.php.htm">解决方案</a>
                                <div class="hidden_nav">
                                    <div class="hidden_top"></div>
                                    <dl>
                                        <dd>
                                            <a href="solution.php-id=5.htm">方案一</a>
                                        </dd>
                                        <dd>
                                            <a href="solution.php-id=6.htm">方案二</a>
                                        </dd>
                                        <dd>
                                            <a href="solution.php-id=8.htm">方案三</a>
                                        </dd>
                                        <dd>
                                            <a href="solution.php-id=9.htm">方案四</a>
                                        </dd>
                                        <dd>
                                            <a href="solution.php-id=10.htm">方案五</a>
                                        </dd>
                                        <dd>
                                            <a href="solution.php-id=11.htm">方案六</a>
                                        </dd>
                                    </dl>
                                    <div class="hidden_bottom"></div>
                                </div>
                            </li>
                            <!--li style="position:relative;"><a href="/koal_main/case.php" class=''>用户案例</a>
                            <div class="hidden_nav">
                                <div class="hidden_top"></div>
                                                                        <dl>
                                                                                            <dd>
                                                    <a href="/koal_main/case.php?id=5">国家统计局CA项目</a>
                                                </dd>
                                                                                                <dd>
                                                    <a href="/koal_main/case.php?id=9">国家重要部委安全体系建设</a>
                                                </dd>
                                                                                                <dd>
                                                    <a href="/koal_main/case.php?id=12">发改委金宏工程CA认证系统</a>
                                                </dd>
                                                                                                <dd>
                                                    <a href="/koal_main/case.php?id=13">浙江数字证书认证系统</a>
                                                </dd>
                                                                                                <dd>
                                                    <a href="/koal_main/case.php?id=14">湖南数字证书认证系统</a>
                                                </dd>
                                                                                                <dd>
                                                    <a href="/koal_main/case.php?id=15"> 航空一集团安全集成项目</a>
                                                </dd>
                                                                                        </dl>
                                                                        <div class="hidden_bottom"></div>
                            </div>
                        </li-->
                            <li style="position: relative;"><a href="channel.php.htm" class=''>渠道合作</a>
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
                            <li style="position: relative;"><a href="support.php.htm" class=''>技术支持</a>
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
                            <li style="background: none !important; position: relative;"><a class='hover_menu' href="com-contact.php.htm">关于公司</a>
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
                                        <dd>
                                            <a href="com-union.php.htm">工会活动</a>
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
        <div class="banner-pagepic1">
        </div>
    </div>
    <!--end of banner-->

    <div class="content-in">


        <div class="list-l">
            <div class="l-tit">
                <img src="../images/ptico1.png"/>
                <p class="en">About Enterprise</p>
                <p class="zh">关于公司</p>
            </div>
            <div class="mc">
                <ul>
                    <li>
                        <a href="Introduction.html">公司介绍</a>
                    </li>

                    <li>
                        <a class="act" href="News.aspx">新闻快讯</a>
                    </li>
                    <li>
                        <a href="com-meeting.php.htm">公司公告</a>
                    </li>
                    <li>
                        <a href="com-honer.php.htm">资质荣誉</a>
                    </li>
                    <li>
                        <a href="com-union.php.htm">工会活动</a>
                    </li>

                </ul>
            </div>
            <!--end of mc-->
            <div class="mb10px">
                <a href="zhaopin.php.htm">
                    <img src="../images/link-pic1.jpg" /></a>
            </div>
            <a href="com-contact.php.htm">
                <img src="../images/link-pic2.jpg" /></a>
        </div>
        <!--end of list-l-->
        <div class="list-r">
            <div class="list-rtit mb10px">
                <a href="index.php.htm">首 页</a>
                &nbsp;>&nbsp;
                    <a href="com-contact.php.htm">关于公司</a>
                &nbsp;>&nbsp;新闻列表
            </div>
            <!--end of list-rtit-->
            <ul>
                
               
                <%=strHtml %>
            </ul>
            <div class="pagination">
                <ul>
                   <%=pageBar %>
                </ul>
            </div>
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
    <!--end of foot-->
</body>
</html>