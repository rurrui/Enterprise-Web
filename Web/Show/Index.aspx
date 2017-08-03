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
                    <p style="font-size:20px">
                    <a href="Index.html" style="display:block">思及达</a>
                        </p>
                </div>
                <!--end of logo-->
                <div class="nav_wd">
                    <div class="h_navlist" id="a">
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
                            <!--li style="position:relative;"><a href="/koal_main/case.php">用户案例</a>
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
                            <li style="position:relative;">
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
                            <li style="position:relative;">
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
                            <li style="background: none !important;position:relative;">
                                <a href="Introduction.html">关于公司</a>
                                <div class="hidden_nav-s">
                                    <div class="hidden_top"></div>
                                    <dl>

                                        <dd>
                                            <a href="Introduction.html">公司介绍</a>
                                        </dd>
                                        <dd>
                                            <a href="news-list.php.htm">新闻快讯</a>
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
        <div class="flexslider">
            <ul class="slides">
                <li style="background: url(/images/banner5.jpg) 50% 0 no-repeat;"><div class="rm-position"><a href="product.php-id=12.htm"  class="read-more1"><img src="images/know-more.jpg" /></a></div></li>
                <li style="background: url(zz/images/banner3.jpg) 50% 0 no-repeat;"><div class="rm-position"><a href="product.php-id=6.htm" class="read-more"><img src="images/know-more.jpg"/></a></div></li>
                <li style="background: url(zz/images/banner4.jpg) 50% 0 no-repeat;"><div class="rm-position"><a href="product.php-id=7.htm" class="read-more"><img src="images/know-more.jpg"/></a></div></li>
                <li style="background: url(zz/images/banner6.jpg) 50% 0 no-repeat;"><div class="rm-position"><a href="product.php-id=13.htm" class="read-more"><img src="images/know-more.jpg"/></a></div></li>
            </ul>
            <div class="banner_show">
                <img src="images/banner_show.png" />
            </div>
        </div>
        <!--end of slides-->
    </div>
    <!--end of top-->
    <div class="content">
        <div class="main_lft">
            <div class="title">
                <a href="news-list.php.htm" tppabs="http://www.koal.com/koal_main/news-list.php">
                    <h3>
                        公司新闻
                    </h3>
                    <h4>
                        NEWS
                    </h4>
                </a>
                <div class="more">
                    <a href="news-list.php.htm" tppabs="http://www.koal.com/koal_main/news-list.php"></a>
                </div>
            </div>
            <!--end of title-->
            <div class="news_mod">
                <div class="imp_news">
                    <div class="imp_img" style="padding:0px">
                        <img src="images/pro/u=668680298,2777004528&fm=26&gp=0[1].jpg" style="width:170px;height:110px"/>
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
                            <a href="news-detail.php-id=68.htm"></a>
                        </div>
                        <!--end of news_all-->
                    </div>
                    <!--end of imp_news_wd-->
                </div>
                <!--end of imp_news-->
                <div class="news_list">
                    <ul>
                        <li><a href="news-detail.php-id=68.htm" tppabs="http://www.koal.com/koal_main/news-detail.php?id=68"><cite>2017-06-05</cite><h4>晋城思及达商贸有限公司</h4></a></li>
                        <li><a href="news-detail.php-id=67.htm" tppabs="http://www.koal.com/koal_main/news-detail.php?id=67"><cite>2017-03-20</cite><h4>晋城思及达商贸有限公司</h4></a></li>
                        <li><a href="news-detail.php-id=66.htm" tppabs="http://www.koal.com/koal_main/news-detail.php?id=66"><cite>2017-02-05</cite><h4>晋城思及达商贸有限公司</h4></a></li>
                        <li><a href="news-detail.php-id=63.htm" tppabs="http://www.koal.com/koal_main/news-detail.php?id=63"><cite>2016-12-05</cite><h4>晋城思及达商贸有限公司</h4></a></li>
                        <li><a href="news-detail.php-id=62.htm" tppabs="http://www.koal.com/koal_main/news-detail.php?id=62"><cite>2016-09-12</cite><h4>晋城思及达商贸有限公司</h4></a></li>
                    </ul>

                    <!--<ul>
                        <li><a href=""><cite>2014-01-10</cite><h4>
                            春节期间客户服务安排</h4>
                        </a></li>
                        <li><a href=""><cite>2014-01-10</cite><h4>
                            格尔软件荣获"2013年度上海市明星软件企业（创新型）（领先型）"</h4>
                        </a></li>
                        <li><a href=""><cite>2014-01-10</cite><h4>
                            "格尔ECC证书认证软件"、"格尔安全认证网关软件"和"格尔网络保险箱软件"被…</h4>
                        </a></li>
                        <li><a href=""><cite>2014-01-10</cite><h4>
                            2013年8月，格尔IPV6互联网审计系统被上海市经济和信息化委员会评为"上海市第…</h4>
                        </a></li>
                        <li><a href=""><cite>2014-01-10</cite><h4>
                            "格尔软件2013年中销售工作会议及销售培训活动"在浙江嘉兴南湖之畔举行</h4>
                        </a></li>
                    </ul>
                    -->
                </div>
                <!--end of news_list-->
            </div>
            <!--end of news_mod-->
        </div>
        <!--end of main_lft-->
        <div class="main_rgt">
            <div class="title">
                <a href="com-contact.php.htm" tppabs="http://www.koal.com/koal_main/com-contact.php">
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


                    <!--
                    <h5>
                        客服&nbsp;QQ：2323763944（24小时在线）</h5>
                        -->
                </div>
                <!--end of contact_add-->
            </div>
            <!--end of contact_mod-->
        </div>
        <!--end of main_rgt-->
        <div class="product_mod">
            <div class="title">
                <a href="product.php.htm">
                    <h3>
                        我们的产品
                    </h3>
                    <h4>
                        OUR PRODUCTS
                    </h4>
                </a>
                <div class="more">
                    <a href="product.php.htm"></a>
                </div>
            </div>
            <!--end of title-->
            <div id="demo" class="move-pro">
                <div id="indemo">
                    <div id="demo1" class="scroll-img">
                        <ul id="items">
                            <li>
                                <a href="product.php-id=5.htm"><img src="images/pro-szzs.jpg" /></a>
                            </li>
                            <li>
                                <a href="product.php-id=6.htm">
                                    <img src="images/pro/u=556168183,918852872&fm=26&gp=0[1].jpg" />
                                </a>
                            </li>
                            <li>
                                <a href="product.php-id=7.htm">
                                    <img src="images/pro/u=668680298,2777004528&fm=26&gp=0[1].jpg" />
                                </a>
                            </li>
                            <li>
                                <a href="product.php-id=8.htm">
                                    <img src="images/pro/u=478852985,2862147369&fm=26&gp=0[1].jpg" />
                                </a>
                            </li>
                            <li>
                                <a href="product.php-id=11.htm">
                                    <img src="images/pro/u=3700433576,2035469455&fm=26&gp=0[1].jpg" />
                                </a>
                            </li>
                            <li>
                                <a href="product.php-id=12.htm">
                                    <img src="images/pro/u=2635313940,3525771136&fm=26&gp=0[1].jpg" />
                                </a>
                            </li>
                            <li>
                                <a href="product.php-id=13.htm">
                                    <img src="images/pro/u=2452472926,1601084148&fm=26&gp=0[1].jpg" />
                                </a>
                            </li>
                            <li>
                                <a href="product.php-id=17.htm">
                                    <img src="images/pro/u=1755941896,1233195438&fm=26&gp=0[1].jpg" />
                                </a>
                            </li>
                            <li>
                                <a href="product.php-id=18.htm">
                                    <img src="images/pro/u=1133343197,1114476719&fm=26&gp=0[1].jpg" />
                                </a>
                            </li>
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