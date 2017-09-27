$(document).ready(function () {
    // 取得分析說明
    $('.quizList li').click(function () {
        var id=$(this).find('a').attr('anaID');
        var url='/Home/ReadAnswer';
        $.post(url, { anaId: id }, function (resp) {
            if (typeof resp === "string") {
                $('.answer').text(resp);
            }
        });
    });
    // 回首頁
    $('.backIndex button').click(function () {
        window.history.back();
    });
  }
);