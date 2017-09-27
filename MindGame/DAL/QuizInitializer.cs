﻿using MindGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MindGame.DAL
{
    public class QuizInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<QuizContext>
    {
        protected override void Seed(QuizContext context)
        {
            //var Quizs = new List<Quiz>
            //{
            //new Quiz{ title="口頭禪暴露你的個性",
            //    description ="經常掛在嘴邊的口頭禪可以暴露個性，這可是有心理根據的，不信你測測看吧。下面這些口頭禪，你一般會說哪一句呢？",
            //    imagePath ="01.jpg" },
            //new Quiz{ title="性格的顏色",
            //    description ="依據顏色喜好做性格判斷，始於德國心理學家魯米艾爾，之後，這種研究風行世界。以下測驗可以從體驗顏色的絕妙中審視自已隱藏的心理。請問，你是最喜歡下列哪一種顏色的窗簾呢？",
            //    imagePath ="02.jpg" },
            //new Quiz{ title="自卑的癥結",
            //    description ="如果你是一位考古學家，來到一座古墓前探險。陵墓裡有一扇石門，上面刻有美麗的雕塑，你會對哪種圖案感興趣呢？",
            //    imagePath ="03.jpg" },
            //new Quiz{ title="找出你的交際弱點",
            //    description ="你覺得在老闆身上最不能讓你忍容的是什麼？",
            //    imagePath ="04.jpg" },
            //new Quiz{ title="蒙娜麗莎",
            //    description ="如果蒙娜麗莎赤裸著身體站在你的面前，你認為她的雙手會放在哪兒呢？",
            //    imagePath ="05.jpg" },
            //  new Quiz{ title="一邊是愛情，一邊是友情",
            //    description ="你與閨中好友一起到新加坡旅遊，回來的時候想購買一枚戒指留做紀念。來到珠寶店，你會選擇哪一種款式呢？",
            //    imagePath ="06.jpg" },
            //new Quiz{ title="愛情EQ",
            //    description ="你有一段刻骨銘心的舊戀情，但是最終兩個人還是沒有走在一起。這時，你擁有了新的情人，而且彼此的感情越來越好。面對手上新、舊情人的照片，你會如何擺放呢？",
            //    imagePath ="07.jpg" },
            //new Quiz{ title="你是怎樣的父母？",
            //    description ="現代生育率越來越低了，因為人的自我意識越來越高漲了，想不想知道你會是怎樣的父母呢？就來回答下面這個問題吧！請問：在平時，你的孩子是怎樣稱呼你的？",
            //    imagePath ="08.jpg" },
            //new Quiz{ title="高官、小吏還是平民？",
            //    description ="有一天在路上，你遇到分別很久的舊情人，你們相約到附近的酒吧去坐坐，除了聊聊目前的生活之外，不免也會談起往昔的時光，這時，你最怕舊情人提起什麼？",
            //    imagePath ="09.jpg" },
            //};

            //Quizs.ForEach(s => context.Quizs.Add(s));
            //context.SaveChanges();
            //var QuizAnalyzes = new List<QuizAnalyze>
            //{
            // new QuizAnalyze { QuizID=1 , Option="啊、呀、這個、那個、嗯",
            //     Explanation ="常是辭彙少，或是思維慢，在說話時利用做為休息的方法而形成的口頭禪的習慣。因此，這種口頭禪的人，反應是較遲鈍或是比較有城府的。也會有驕傲的公務員愛用這種口頭禪，因怕說錯話，需要時間來思考。這種人的內心也常常是很孤獨的。"},
            // new QuizAnalyze { QuizID=1 , Option="可能是吧、或許是吧、大概是吧",
            //     Explanation ="說這種口頭禪的人，自我防衛本能甚強，不會將內心的想法完全暴露出來。在待人處事方面很冷靜，所以工作和人際關係都不錯，此類口語也有以退為進的含義。事情一旦明朗，他們會說「我早想到這一點」，從事政治的人多有這類口頭禪，這類口頭禪隱藏了自已的真心。"},
            // new QuizAnalyze { QuizID=1 , Option="說真的、老實說、的確、不騙你",
            //     Explanation ="此人有一種擔心對方誤解自已的心理，因此性格有些急躁，內心常有不平。他會十分在意對方對自已所陳述事件的評價，所以一再強調事情的真實性，只希望自已在團體中可以被認可，並得到很多朋友的信賴。"},
            // new QuizAnalyze { QuizID=1 , Option="但是、不過",
            //     Explanation ="此人有些任性，因此總是提出一個「但是」來為自已辦解，「但是」是為了保護自已而使用的。也顯示了其溫和的特點，它顯得委婉、沒有斷然的意味。從事公共關係的人常有這類口頭禪，因為它的委婉意味，不致令人有冷淡感。"},
            // new QuizAnalyze { QuizID=1 , Option="聽說、據說、聽人講",
            //     Explanation ="此人所以用此類口頭禪，是給自已留有餘地的心理形成的。這種人的見識雖廣，決斷力不夠。很多處事圓滑的人，易用此類語言。在辦事過程中，他們會為自已時刻準備著台階，有時也會被很衝突的心理困擾。"},
            // new QuizAnalyze { QuizID=1 , Option="應該、必須、必定會、一定要",
            //     Explanation ="此人自信心極強，做事情顯得很理智，為人冷靜，自認為能夠將對方說服，令對方相信。另一方面，「應該」說得過多時，反而表現出其有「動搖」的心理，長期擔任領導的人，易有此類口頭禪。"},

            //  new QuizAnalyze { QuizID=2 , Option="紅色",
            //      Explanation ="紅色性格，說穿了，紅色性格就是要我行我素。如果他們從小被帶大的環境容許他們可以操縱父母和兄弟姊妹，長大後就會變得桀驁不馴；如果被從容得太久了，紅色性格的人幾乎不可能放棄他們的權力和自由。紅色性格的人喜歡工作，大多是工作狂，然而，如果工作不符合他的興趣時，就會抗拒強加於身上的任務。紅色性格對於眼淚和其它「示弱」的「表演」，是無動於衷的。"},
            //  new QuizAnalyze { QuizID=2 , Option="黃色",
            //      Explanation ="黃色性格黃，色性格認為人生是一場派對，而且他們正好是主人。黃色性格喜歡引人注目。想改善與一位黃色性格的關係，很少有比褒獎更好的法球。黃色性格的人喜歡站在舞台中央，社會性的接納對他們是極為重要的，如果能夠深孚眾望，就滿足了他們的基本需要－－被公眾接受的需要。黃色性格很能成為大夥閒聊時最引人注目的閒聊專家。"},
            //  new QuizAnalyze { QuizID=2 , Option="藍色",
            //      Explanation ="藍色性格，藍色性格喜歡施惠於人，他們尋找施捨的機會，只為了帶給他人快樂，他們信奉的哲學是「出於無我，勝過出於自私」。許多藍色性格會對所做的事情只有益於自身而感到不安，他們經常為人敞開大門，主動搭載車子拋錨的人，捐獻給慈善機構，甚至把一生奉獻在為他人服務上。真正的藍色性格，會為了改善一份重要的個人情誼，而犧牲一個成功的事業，這一度被視為是女性的特質，但其實這是藍色性格的特徵－－無關男或女。在所有性格本色中，藍色性格是天生最誠實的，一位藍色性格寧可認輸，也不願意偷雞摸狗，藍色性格是值得信任的。"},
            //  new QuizAnalyze { QuizID=2 , Option="白色",
            //      Explanation ="白色性格，白色性格寧願付出任何代價，以避免一切正面衝突，他們不希望在人生旅途上遭遇大風大浪。「感覺到善」對他們而言，比成為「善的化身」更具意義。白色性格碰上不講理的對待時，沉默而強烈的抵抗就會冒出頭。白色性格喜歡自已一個人安靜。有的人會以為白色性格的「安靜」是 無言的絕望」，但真實那是白色性格的「牛脾氣」。"},

            //  new QuizAnalyze { QuizID=3 , Option="女神的雕刻",
            //      Explanation ="你對自已的外表感到自卑，自認為長得不漂亮又不懂得穿衣打扮。其實穿衣只要穿出自已的個性和感覺就好，你何必自卑呢？"},
            //  new QuizAnalyze { QuizID=3 , Option="大力士的雕刻",
            //      Explanation ="大力士象徵運動，你對自已的運動表現感到自卑，其實沒關係的，又不是叫你去參加奧運會，只要身體健康就好啦！"},
            //  new QuizAnalyze { QuizID=3 , Option="荊棘的雕刻",
            //      Explanation ="荊棘代表你對自已的性格感到自卑，你認為自已的性格充滿弱點，既然知道自已有缺點，知錯能改就行了，從現在開始改變自已吧！"},
            //  new QuizAnalyze { QuizID=3 , Option="咒文的雕刻",
            //      Explanation ="咒文代表知識與學識。你認為自已讀的書少又缺乏常識，建議你不妨利用空閒時間進修一下，充實自已。"},

            //  new QuizAnalyze { QuizID=4, Option="情緒不穩定，容易「歇斯底里」，對員工實行精神壓迫",
            //  Explanation="這個選擇其實就是自我缺陷的自然暴露。你一有什麼不如意的事就會「歇斯底里」，不是四處大聲叫嚷，就是突然大聲哭泣。你這種自我表現的方式也許太過幼稚，而且很容易引起別人的情緒疲勞。為了使人際關係更加融洽，你必須對周圍的人多一份愛心，同時要注意克制自已的情緒。"},
            //   new QuizAnalyze { QuizID=4, Option="專制，不聽取下屬的意見",
            //  Explanation="你具有領導才能，在團體中往往起著決定性的作用。但是你需要多聽取一些周圍人意見的謙虛態度，否則，最終有可能誰也不會再順從你。你的缺點就是很少聽取他人的意見和建議。"},
            //   new QuizAnalyze { QuizID=4, Option="不公平，偏袒部份人，打擊部份人",
            //  Explanation="你可能有一些心理恐慌症的表現。你的交際範圍容易往縱向深入，但是很難橫向橫展，你往往把自已討厭的人徹底排除在外，似乎只願意與某一些特定的人建立更好的關係，所以，你屬於不善廣大交際圈的這類人。你甚至會要求與你關係親近的友人「不要與不喜歡的人交往」。你應該要懂得博愛的內涵。"},
            //   new QuizAnalyze { QuizID=4, Option="有暴力傾向",
            //  Explanation="你這樣的處理方式是很危險的。你的缺點是動輒變得粗暴無禮。你的問題不僅表閱在行為上，而且語言暴力也很激烈。假如是因為對方態度導致你正當防禦還情有可原，而妳敔往往是稍不如意就出手或出口傷人。你一定要注意掏制自已的情緒，否則你會很容易和不了解你的人發生激烈的衝突。"},

            //       new QuizAnalyze { QuizID=5, Option="放在胸口",
            //  Explanation="把雙手放在胸口前往往給人一種害羞、緊張、自我保護的感覺。選擇這個姿勢的男性就是喜歡含羞答答、在緊張時不自覺的手足無措、稍具氣質及矜持的女性。"},
            //   new QuizAnalyze { QuizID=5, Option="兩手下垂",
            //  Explanation="兩手下垂給人一種自然、順從的感覺。選擇這個姿勢的男性喜歡自然、不造作、不刻意掩飾自已缺點以及帶點天真的女性。"},
            //   new QuizAnalyze { QuizID=5, Option="張開呈V字型",
            //  Explanation="兩手張長給人一種接納、包容的感覺。選擇這個姿勢的男性比較傾向於年長女性，或者是能給予他母親般溫暖的女性。"},


            //       new QuizAnalyze { QuizID=6, Option="做工精巧細緻的戒指",
            //  Explanation="你富有體貼之心，處處替別人著想。即使有了情人，依舊珍惜友情；理智，不輕易行動，以誠意溝通，化解三角難題。"},
            //   new QuizAnalyze { QuizID=6, Option="價格高昂的寶石戒指",
            //  Explanation="你是個愛情至上的人，在危急關頭，一定會捨友情而取愛情。一有談戀愛的機會，就棄親友如敝履，口頭上雖說友情不渝，但到時候，不能保證不惜背叛長久友情。"},
            //   new QuizAnalyze { QuizID=6, Option="鑲有鑽石的小型戒指",
            //  Explanation="誠實明理，本身不想傷害親友，但容易為愛情所困，易陷入情網。"},
            //   new QuizAnalyze { QuizID=6, Option="引人注目的暑華大鑽戒",
            //  Explanation="選大戒指的人，是以自我為中心、唯我獨尊的類型。善妒，對親友的戀情，毫無慶辛與祝福的雅量，卻把自已的戀情和婚姻置於友情之上。"},

            //        new QuizAnalyze { QuizID=7, Option="一起擺在床頭",
            //  Explanation="你有中度的愛情EQ指數！雖有三心二意的傾向，但是不會推卸責任。"},
            //   new QuizAnalyze { QuizID=7, Option="擺在不同的地方",
            //  Explanation="你的愛情EQ有底度的傾向，當心新戀人會吃悉醋，就此一走了之。"},
            //   new QuizAnalyze { QuizID=7, Option="將新感情留下，把舊回穩收起來。擺放新情人的照片，將舊情人的照片夾在日記本裡",
            //  Explanation="你有高度的愛情EQ指數，有適應未來、珍惜過去的能力。"},
            //   new QuizAnalyze { QuizID=7, Option="統統鎖進抽屜裡，等結婚後再說",
            //  Explanation="哎！你的愛情EQ實在太低，失去舊戀人對你是一種打擊，要趕走快走出去唷！"},


            //    new QuizAnalyze { QuizID=8, Option="爸爸或媽媽",
            //  Explanation="你無時無刻都會掛念著你的孩子，希望給小孩創造出更好的成長環境。把全部的心思放在孩子身上，常常忘記自已的存在。"},
            //   new QuizAnalyze { QuizID=8, Option="爹地或媽咪",
            //  Explanation="只要給你機會，你很快就會變成一個完美的合格父母。你常常以自我為中心，工作是你的全部。你將百之一百二十的精力都放在工作上，甚至常常忘記自已已經結婚生小孩了，只有假日閒下來才會搖身一變成為爸爸或媽媽。"},
            //   new QuizAnalyze { QuizID=8, Option="各種親密的外號",
            //  Explanation="肯子裡還是個大孩子，恨不得自已當小孩就好。在你內心深處還很孩子氣，不希望自已長大，即使有小孩也希望把你當成好朋友。"},


            //    new QuizAnalyze { QuizID=9, Option="分手時的感覺",
            //  Explanation="你在團體中一般是一個幫大家做事的角色，你的生活哲學是「平生無大志，只求有飯吃」，隨遇而安的個性，讓你完全沒有名利之心，覺得照顧好自已最實在。"},
            //   new QuizAnalyze { QuizID=9, Option="初次相識的甜蜜回憶",
            //  Explanation="你的領導才能在小團體有用武之地，一旦人多了、關係變得複雜了，你就會掌控不了局面，甚至招致民怨，「寧為雞首、不為牛後」這句古話應該最能說明你的領導能力了。"},
            //   new QuizAnalyze { QuizID=9, Option="有一次出國遊玩的經歷",
            //  Explanation="你是天生的領導者，有指揮群眾的天份和魅力。你並不會刻意表現出自已的野心和企圖心，但是大家自然就會找你解決問題，喜歡和你在一起，可能就是你有一股王者的風範吧！"},
            //   new QuizAnalyze { QuizID=9, Option="當初介入你們之間的第三者",
            //  Explanation="你有領導的才能，可惜卻沒有領導的氣度。想要讓一群人對你服從，可不是很有才華就可以的，你必須懂得唯才是用、能屈能伸、善用智謀，如果只有勇氣和衝勁是不夠的。"},
            //};
            //QuizAnalyzes.ForEach(s => context.QuizAnalyzes.Add(s));
            //context.SaveChanges();
        }
    
    }
}