<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="super-production.aspx.cs" Inherits="SJD.Web.Admin.super_production" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link href="../css/bootstrap.css" rel="stylesheet" />
    <link href="../css/site.css" rel="stylesheet" />
    <link href="../css/bootstrap-responsive.css" rel="stylesheet" />

    <script src="../js/jquery-3.2.1.min.js"></script>
</head>
<body>
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
                    <a class="btn" href="Login.aspx"><i class="icon-user"></i>退出</a>
                    <a class="btn dropdown-toggle" data-toggle="dropdown" href="#">
                        <span class="caret"></span>
                    </a>
                </div>
                <div class="nav-collapse">
                    <ul class="nav">
                        <li><a href="../../Show/Index.aspx">主页</a></li>
                       
                        <li class="dropdown"><a href="Super-UserManager.aspx" class="dropdown-toggle" data-toggle="dropdown">人员<b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li><a href="add-user.aspx">添加</a></li>
                                <li class="divider"></li>
                                <li><a href="Super-UserManager.aspx">管理</a></li>
                            </ul>
                        </li>

                        <li class="dropdown"><a href="#" class="dropdown-toggle" data-toggle="dropdown">新闻 <b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li><a href="add-news.aspx">添加</a></li>
                                <li class="divider"></li>
                                <li><a href="roles.html">管理</a></li>
                            </ul>
                        </li>
                          <li class="dropdown"><a href="production.aspx" class="dropdown-toggle" data-toggle="dropdown">产品 <b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li><a href="super-add-pro.aspx">添加</a></li>
                                <li class="divider"></li>
                                <li><a href="super-production.aspx">管理</a></li>
                            </ul>
                        </li>
                         <li class="dropdown"><a href="solution.aspx" class="dropdown-toggle" data-toggle="dropdown">解决方案 <b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li><a href="super-add-solution.aspx">添加</a></li>
                                <li class="divider"></li>
                                <li><a href="super-solution.aspx">管理</a></li>
                            </ul>
                        </li>
                           <li class="dropdown"><a href="solution.aspx" class="dropdown-toggle" data-toggle="dropdown">招贤纳士 <b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li><a href="super-add-recruit.aspx">添加</a></li>
                                <li class="divider"></li>
                                <li><a href="super-recruit.aspx">管理</a></li>
                                </ul>
                               </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>

    <div class="container-fluid">
        <div class="row-fluid">
            <div class="span3">
                <div class="well sidebar-nav">
                    <ul class="nav nav-list">
                         <li class="nav-header"><i class="icon-wrench"></i>用户管理</li>
                            
                            <li ><a href="super-add-news.aspx">添加</a></li>
                            <li ><a href="Super-UserManager.aspx">管理</a></li>

                            <li class="nav-header"><i class="icon-signal"></i>公司新闻</li>
                            
                            <li><a href="super-add-news.aspx">添加</a></li>
                            <li><a href="super-news.aspx">管理</a></li>

                            <li class="nav-header"><i class="icon-user"></i>公司产品</li>
                            
                            <li><a href="super-add-pro.aspx">添加</a></li>
                            <li class="active"><a href="super-production.aspx">管理</a></li>

                            <li class="nav-header"><i class="icon-user"></i>解决方案</li>
                            
                            <li><a href="super-add-solution.aspx">添加</a></li>
                            <li><a href="super-solution.aspx">管理</a></li>

                            <li class="nav-header"><i class="icon-user"></i>招贤纳士</li>
                            
                            <li><a href="super-add-recruit.aspx">添加</a></li>
                            <li><a href="super-recruit.aspx">管理</a></li>
                    </ul>
                </div>
            </div>

            <div class="span9">
                <div class="row-fluid">
                    <div class="page-header">
                        <h1>产品列表 <small>所有产品</small></h1>
                    </div>

                    <table class="table table-striped table-bordered table-condensed">
                        <thead>
                            <tr style="align-content: center">
                                <th style="text-align: center">编号</th>
                                <th style="text-align: center">产品名称</th>
                                <th style="text-align: center">产品图片</th>

                                <th style="text-align: center" colspan="2">管理</th>
                            </tr>
                        </thead>
                        <tbody>
                            <%=strHtml %>
                           
                        </tbody>
                    </table>
                 <br/>
                    
                    <div class="pagination">
                        <ul>
                            <%=pageBar %>
                        </ul>
                    </div>
                    <%--<a href="new-user.aspx" class="btn btn-success">添加</a>--%>
                </div>
            </div>

        </div>

        <hr />

        <footer class="well">
            &copy; Admin
        </footer>

    </div>


    <script src="../js/jquery.flot.js"></script>
    <script src="../js/jquery.flot.resize.js"></script>
    <script src="../js/bootstrap.min.js"></script>
    <script>
        $(function () {
            var data = [
                {
                    label: 'Page Views',
                    data: [[0, 19000], [1, 15500], [2, 11100], [3, 15500]]
                }];
            var dataVisits = [
                {
                    label: 'Visits',
                    data: [[0, 1980], [1, 1198], [2, 830], [3, 1550]]
                }];
            var options = {
                legend: {
                    show: true,
                    margin: 10,
                    backgroundOpacity: 0.5
                },
                points: {
                    show: true,
                    radius: 3
                },
                lines: {
                    show: true
                },
                grid: {
                    borderWidth: 1,
                    hoverable: true
                },
                xaxis: {
                    axisLabel: 'Month',
                    ticks: [[0, 'Jan'], [1, 'Feb'], [2, 'Mar'], [3, 'Apr'], [4, 'May'], [5, 'Jun'], [6, 'Jul'], [7, 'Aug'], [8, 'Sep'], [9, 'Oct'], [10, 'Nov'], [11, 'Dec']],
                    tickDecimals: 0
                },
                yaxis: {
                    tickSize: 1000,
                    tickDecimals: 0
                }
            };
            var optionsVisits = {
                legend: {
                    show: true,
                    margin: 10,
                    backgroundOpacity: 0.5
                },
                bars: {
                    show: true,
                    barWidth: 0.5,
                    align: 'center'
                },
                grid: {
                    borderWidth: 1,
                    hoverable: true
                },
                xaxis: {
                    axisLabel: 'Month',
                    ticks: [[0, 'Jan'], [1, 'Feb'], [2, 'Mar'], [3, 'Apr'], [4, 'May'], [5, 'Jun'], [6, 'Jul'], [7, 'Aug'], [8, 'Sep'], [9, 'Oct'], [10, 'Nov'], [11, 'Dec']],
                    tickDecimals: 0
                },
                yaxis: {
                    tickSize: 1000,
                    tickDecimals: 0
                }
            };
            function showTooltip(x, y, contents) {
                $('<div id="tooltip">' + contents + '</div>').css({
                    position: 'absolute',
                    display: 'none',
                    top: y + 5,
                    left: x + 5,
                    border: '1px solid #D6E9C6',
                    padding: '2px',
                    'background-color': '#DFF0D8',
                    opacity: 0.80
                }).appendTo("body").fadeIn(200);
            }
            var previousPoint = null;
            $("#placeholder, #visits").bind("plothover", function (event, pos, item) {
                if (item) {
                    if (previousPoint != item.dataIndex) {
                        previousPoint = item.dataIndex;

                        $("#tooltip").remove();
                        showTooltip(item.pageX, item.pageY, item.series.label + ": " + item.datapoint[1]);
                    }
                }
                else {
                    $("#tooltip").remove();
                    previousPoint = null;
                }
            });
            $.plot($("#placeholder"), data, options);
            $.plot($("#visits"), dataVisits, optionsVisits);
        });
    </script>
    <script>
        function DeleteConfirm(id) {
            if (confirm("确定要删除吗？")) {
                $.post(
                    "delete-pro.ashx",
                    {
                        id: id
                    },
                    function (msg) {
                        if (msg == 1) {
                            window.location.reload();
                        }
                        else {
                            alert("删除失败");
                        }
                    }
                )
            }
        }
    </script>
</body>
</html>
