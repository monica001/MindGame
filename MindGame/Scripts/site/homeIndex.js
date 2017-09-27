$(document).ready(function () {
    // 取得quiz背景色
    QuizBoxColor();
    // quiz動畫
    Quizhover();
    // 每5種換題
    setInterval(changeQuizPer5, 6000);
   
  }
);
function changeQuizPer5() {
    var url = '/Home/changeQuiz';
    $.post(url, {}, function (resp) {
        // parse String to Array
        var quiz = JSON.parse(resp);
        $('.col-md-4').each(function (idx,elem) {
            var _title = quiz[idx].title;
            var _des = quiz[idx].description;
            var _ID = quiz[idx].ID;

           
            $(this).find('h2').text(_title);
            $(this).find('p:first').text(_des);

            var href = $(this).find('a').attr('href');
            var newhref = href.substring(0, href.indexOf('=') + 1) + _ID;
            $(this).find('a').attr('href',newhref);           
        });

    });
   
};

var color = ['antiquewhite',
'aquamarine',
'cadetblue',
'chartreuse',
'orchid',
'cornflowerblue',
'#abffad'];
function QuizBoxColor() {
    var ran =Math.round(Math.random()*10%7); // 1~7的亂數
    $('.col-md-4 div').each(function (idx, elemt) {
        $(this).css('backgroundColor', color[ran%7]);
        ran++;
    });
};

function Quizhover() {
    //$('.col-md-4 div').mouseover(function () {
    //    $(this).find('h2').animate({ color:'gray' },1000);
    //}).mouseout(function () {
    //    $(this).find('h2').animate({ color:'gray' },1000);
     
    //});

    //$('.col-md-4 div').mouseover(function () {
    //    $(this).css({'backgroundColor': 'white','border':'2px solid orange' });
    //})
};