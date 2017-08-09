<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SJD.Web.Show.Index" %>

<!DOCTYPE html>
<html>
<head>
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
                <div id="logo" style="text-align:center;line-height:95px">
                    <!--<img src="images/logo_img.png" style="width: 220px; height: 55px; margin-left: 25px;
                             margin-top: 18px;" />-->
                    <p style="font-size:15px">
                    <a href="Index.html" style="display:block">晋城市思及达商贸有限公司思及达</a>
                        </p>
                </div>
                <!--end of logo-->
                <div class="nav_wd">
                    <div class="h_navlist" id="a">
                        <ul>
                            <li><a class="hover_menu" href="Index.aspx">首 页</a></li>
                            <li style="position:relative;">
                                <a href="Production.aspx">产品中心</a>
                                <div class="hidden_nav">
                                    <div class="hidden_top"></div>
                                    <dl>
                                       <%=strPTitle %>
                                    </dl>
                                    <div class="hidden_bottom"></div>
                                </div>
                            </li>
                            <li style="position:relative;">
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
                                <a href="Contact.aspx">联系我们</a>
                               
                            </li>
                            <li style="background: none !important;position:relative;">
                                <a href="Info.aspx">关于公司</a>
                                <div class="hidden_nav-s">
                                    <div class="hidden_top"></div>
                                    <dl>

                                        <dd>
                                            <a href="Info.aspx">公司介绍</a>
                                        </dd>
                                        <dd>
                                            <a href="News.aspx">新闻快讯</a>
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
        <div class="flexslider">
            <ul class="slides">
                <li style="background: url(/images/banner5.jpg) 50% 0 no-repeat;"><div class="rm-position"><a href="product.php-id=12.htm"  class="read-more1"></a></div></li>
                <li style="background: url(/images/1.png) 50% 0 no-repeat;"><div class="rm-position"><a href="product.php-id=6.htm" class="read-more"></a></div></li>
                <li style="background: url(/images/2.png) 50% 0 no-repeat;"><div class="rm-position"><a href="product.php-id=7.htm" class="read-more"></a></div></li>
                <li style="background: url(/images/3.png) 50% 0 no-repeat;"><div class="rm-position"><a href="product.php-id=13.htm" class="read-more"></a></div></li>
            </ul>
          <%--  <div class="banner_show">
                <img src="images/banner_show.png" />
            </div>--%>
        </div>
        <!--end of slides-->
    </div>
    <!--end of top-->
    <div class="content">
        <div class="main_lft">
            <div class="title">
                <a href="News.aspx">
                    <h3>
                        公司新闻
                    </h3>
                    <h4>
                        NEWS
                    </h4>
                </a>
                <div class="more">
                    <a href="News.aspx"></a>
                </div>
            </div>
            <!--end of title-->
            <div class="news_mod">
                <div class="imp_news">
                    <div class="imp_img" style="padding:0px">
                        <img src="../images/xhd.jpg" style="width:170px;height:110px"/>
                    </div>
                    <!--end of imp_img-->
                    <div class="imp_news_wd">
                        <div class="imp_new_title">
                            晋城思及达商贸有限公司
                        </div>
                        <!--end of imp_news_title-->
                        <div class="imp_news_textarea">
                            公司..........
                        </div>
                        <!--end of imp_news_textarea-->
                        <div class="news_all">
                            <a href="News.aspx"></a>
                        </div>
                        <!--end of news_all-->
                    </div>
                    <!--end of imp_news_wd-->
                </div>
                <!--end of imp_news-->
                <div class="news_list">
                    <ul>
                        <%=strNew %>
                       
                    </ul>

                 
                </div>
                <!--end of news_list-->
            </div>
            <!--end of news_mod-->
        </div>
        <!--end of main_lft-->
        <div class="main_rgt">
            <div class="title">
                <a href="Contact.aspx">
                    <h3>
                        联系我们
                    </h3>
                    <h4>
                        CONTACT
                    </h4>
                </a>
            </div>
            <!--end of title-->
            <div class="contact_mod">
                <div class="contact_add">
                    <p>
                        <h5>
                            地址：晋城市城区富达大厦1116
                        </h5>
                    </p>
                    <p>
                        <h5>
                            邮编：048000
                        </h5>
                    </p>
                    <p>
                        <h5>
                            电话：0356-2023843
                        </h5>
                    </p>
                    <p>
                        <h5>
                            网址：www.sjd.com
                        </h5>
                    </p>
                    <p>
                    </p>


                  
                </div>
                <!--end of contact_add-->
            </div>
            <!--end of contact_mod-->
        </div>
        <!--end of main_rgt-->
        <div class="product_mod">
            <div class="title">
                <a href="Production.aspx">
                    <h3>
                        我们的产品
                    </h3>
                    <h4>
                        OUR PRODUCTS
                    </h4>
                </a>
                <div class="more">
                    <a href="Production.aspx"></a>
                </div>
            </div>
            <!--end of title-->
            <div id="demo" class="move-pro">
                <div id="indemo">
                    <div id="demo1" class="scroll-img">
                        <ul id="items">
                           <%=PicSrc %>
                           
                        </ul>
                    </div>
                    <div id="demo2" class="scroll-img"></div>
                </div>
            </div>
            <!--end of move-pro-->
        </div>
        <!--end of product_mod-->
    </div>
    <!--end of content-->
    <div class="foot">
        <div class="foot-content">
            <div class="fr-link">
                <h4>
                    LINK
                </h4>
                <h3>
                    友情链接
                </h3>
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