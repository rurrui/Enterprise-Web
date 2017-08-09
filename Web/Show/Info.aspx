<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Info.aspx.cs" Inherits="SJD.Web.Show.Info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../css/layout.css" rel="stylesheet" />
    <link href="../css/global.css" rel="stylesheet" />
    <script src="../js/jquery-3.2.1.min.js"></script>
    <title>晋城思及达商贸有限公司</title>
</head>
<body>
    <div id="top">
        <div class="nav_all nav_all_in">
            <div class="nav_in">
                <div id="logo" style="text-align:center;line-height:95px">
                    <p style="font-size: 15px">
                        <a href="News.aspx" style="display: block">晋城市思及达商贸有限公司</a>
                    </p>
                </div>
                <!--end of logo-->
                <div class="nav_wd">
                    <div class="h_navlist1" id="a">
                        <ul>
                            <li><a href="Index.aspx">首 页</a></li>
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
                            <li style="background: none !important; position: relative;">
                                <a class='hover_menu' href="Info.aspx">关于公司</a>
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
        <div class="banner-pagepic3">

        </div>
    </div><!--end of banner-->

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
                        <a class="act" href="Info.aspx">公司介绍</a>
                    </li>

                    <li>
                        <a href="News.aspx">新闻快讯</a>
                    </li>
                  

                </ul>
            </div><!--end of mc-->
            <div class="mb10px">
                <a href="Recruit.aspx">
                    <img src="../images/link-pic1.jpg" />
                </a>
            </div>
            <a href="Contact.aspx">
                <img src="../images/link-pic2.jpg" />
            </a>
        </div>
        <!--end of list-l-->
        <div class="list-r">
            <div class="list-rtit mb10px">
                <a href="Index.aspx">首 页</a>
                &nbsp;>&nbsp;
                <a href="Info.aspx">关于公司</a>
                &nbsp;>&nbsp;公司介绍
            </div>

        <!--end of list-rtit-->
            <div class="detail">
                <h2>晋城思及达商贸有限公司</h2>

                <div class="detail-cont" style="font-size:20px">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;晋城市思及达商贸有限公司是一家以数据处理、软件开发为主的技术型企业，1999年创建于晋城，为企事业提供全系列信息化管理系统及数据采集、汇总、分析相关服务。拥有强大的自主研发能力，通过多年的各种项目实践自主开发了《小蝴蝶财务》、《小蝴蝶材质化检验管理系统》《小蝴蝶煤炭产供销一体化》等系列软件，积累了大量的企业信息化管理所需的经验和方法，尤其是极强的数据处理能力和有特色的统计报表设计能力，助力企业管理各个方面，包括：ERP、OA、HR、CRM等。<br /><br />
                    <img src="../images/xhd.jpg" />

                    


                </div><!--end of detail-cont-->
            </div><!--end of detail-->


        </div><!--end of list-r-->


    </div>
    <!--end of content-->
    <div class="foot-in">
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
</body>
</html>
