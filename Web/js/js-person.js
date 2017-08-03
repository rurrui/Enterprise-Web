// JavaScript Document

            $(document).ready(function() {

                $('.flexslider').flexslider({
                    directionNav: true,
                    pauseOnAction: false
                });

var speed=20;
var tab=document.getElementById("demo");
var tab1=document.getElementById("demo1");
var tab2=document.getElementById("demo2");
tab2.innerHTML=tab1.innerHTML;
var wid = tab1.offsetWidth;
function Marquee(){
    if(wid-tab.scrollLeft<=0){
    tab.scrollLeft-=tab1.offsetWidth;
    }
    else{
    tab.scrollLeft++;
    }
}
var MyMar=setInterval(Marquee,speed);
tab.onmouseover=function() {clearInterval(MyMar)};
tab.onmouseout=function() {MyMar=setInterval(Marquee,speed)};

                /**
                $('#demo4').scrollbox({
                    direction: 'h',
                    switchItems: 1,
                    distance: 194,
                    delay: 0.1
                });

                 */
                



                $("#a li").mouseover(function() {



                    $(this).children(".hidden_nav").show();
                    //$('.hidden_nav').show(); 
                })
                $("#a li").mouseout(function() {

                    $('.hidden_nav').hide();
                })
                $(".hidden_nav").mouseover(function() {

                    $(this).prev("a").addClass("hover_menu");

                })

                $(".hidden_nav").mouseout(function() {

                    $(this).prev("a").removeClass("hover_menu");
                })






  $("#a li").mouseover(function() {

				$(this).children(".hidden_nav-s").show();
                //$('.hidden_nav').show(); 
            })
            $("#a li").mouseout(function() {

                $('.hidden_nav-s').hide();
            })
            $(".hidden_nav-s").mouseover(function() {

                $(this).prev("a").addClass("hover_menu");

            })

            $(".hidden_nav-s").mouseout(function() {

                $(this).prev("a").removeClass("hover_menu");
             })



            });
