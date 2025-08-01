﻿using Microsoft.EntityFrameworkCore;

namespace TestService.Models
{
    public class QuestionContext:DbContext
    {
        public DbSet<Question> Questions { get; set; } = null!;

        public QuestionContext(DbContextOptions<QuestionContext> options) : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().HasData(
                    new Question
                    {
                        QuestionId = 1,
                        TextQuestion = "Укажите ответ, в котором в обоих словах одного ряда пропущена одна и та же буква.",
                        Answer1 = "усидч..вый, переменч..вый",
                        Answer2 = "отстёг..вавший, глянц..вый",
                        Answer3 = "щегол..ватый, находч..вый",
                        Answer4 = "прислуш..ваться, гор..вать",
                        AnswerRight = 0
                    },
                    new Question
                    {
                        QuestionId = 2,
                        TextQuestion = "Укажите ответ, в котором в обоих словах одного ряда пропущена одна и та же буква.",
                        Answer1 = " неразборч..вый, овлад..вать",
                        Answer2 = "высме..вающий, отапл..вать",
                        Answer3 = "запечатл..вать, милост..вый",
                        Answer4 = "завистл..вый, коч..вать",
                        AnswerRight = 1
                    },
                    new Question
                    {
                        QuestionId = 3,
                        TextQuestion = "Укажите ответ, в котором в обоих словах одного ряда пропущена одна и та же буква.",
                        Answer1 = "претерп..вающий, замш..вый",
                        Answer2 = "леле..вший, извил..на",
                        Answer3 = "милост..вый, измуч..нный",
                        Answer4 = "разбрызг..вая, тюл..вый",
                        AnswerRight = 0
                    },
                    new Question
                    {
                        QuestionId = 4,
                        TextQuestion = "Укажите ответ, в котором в обоих словах одного ряда пропущена одна и та же буква.",
                        Answer1 = "податл..вый; нул..вой",
                        Answer2 = "се..вший, перекле..вать",
                        Answer3 = "кро..тся (тайна), потч..вать",
                        Answer4 = " выздоров..ть, смекал..стый",
                        AnswerRight = 2
                    },
                    new Question
                    {
                        QuestionId = 5,
                        TextQuestion = "Укажите ответ, в котором в обоих словах одного ряда пропущена одна и та же буква.",
                        Answer1 = "отво..вав, плать..це",
                        Answer2 = " локт..вой, ключ..к",
                        Answer3 = "угр..ватый, досто..н",
                        Answer4 = "дешев..нький, баш..нка",
                        AnswerRight = 3
                    },
                    new Question
                    {
                        QuestionId = 6,
                        TextQuestion = "Укажите ответ, в котором в обоих словах одного ряда пропущена одна и та же буква.",
                        Answer1 = "усидч..вый, зелён..нький",
                        Answer2 = "отстёг..вавший, сем..ни",
                        Answer3 = "находч..вый, страдал..ц",
                        Answer4 = "щегол..ватый, тёт..нька",
                        AnswerRight = 3
                    },
                    new Question
                    {
                        QuestionId = 7,
                        TextQuestion = "Укажите ответ, в котором в обоих словах одного ряда пропущена одна и та же буква.",
                        Answer1 = "отта..в, ореш..к",
                        Answer2 = "вкрадч..вый, меньш..нство",
                        Answer3 = "алюмини..вый, пород..стый",
                        Answer4 = " задумч..вый, гир..вой (спорт)",
                        AnswerRight = 1
                    },
                    new Question
                    {
                        QuestionId = 8,
                        TextQuestion = "Укажите ответ, в котором в обоих словах одного ряда пропущена одна и та же буква.",
                        Answer1 = "устра..вать, бараш..к",
                        Answer2 = "приукраш..вать, письм..цо",
                        Answer3 = "догадл..вость, крас..вый",
                        Answer4 = "подразум..вающий, луж..ца",
                        AnswerRight = 2
                    },
                    new Question
                    {
                        QuestionId = 9,
                        TextQuestion = "Укажите ответ, в котором в обоих словах одного ряда пропущена одна и та же буква.",
                        Answer1 = "з..подозрить, нед..выполнить, п..молчать",
                        Answer2 = "и..быточный, во..хождение, ни..вергнуть",
                        Answer3 = "по..бросить, о..пилить, о..крыть",
                        Answer4 = "пр..мудрый, пр..красный, пр..возмочь",
                        AnswerRight = 3
                    },
                    new Question
                    {
                        QuestionId = 10,
                        TextQuestion = "Укажите ответ, в котором в обоих словах одного ряда пропущена одна и та же буква.",
                        Answer1 = " беспр..страстный, пр..вышение (скорости), пр..града",
                        Answer2 = "бе..грамотный, чре..мерный, во..звание",
                        Answer3 = "с..ехидничать, уст..е, в..юга",
                        Answer4 = "неп..ладки, н..вьючить, п..лагать",
                        AnswerRight = 1
                    },
                    new Question
                    {
                        QuestionId = 11,
                        TextQuestion = "Укажите ответ, в котором в обоих словах одного ряда пропущена одна и та же буква.",
                        Answer1 = "бе..крайний, ни..вергать, чере..чур",
                        Answer2 = "пр..одолевать, пр..даточный, (негде) пр..моститься",
                        Answer3 = "вз..браться, пр..махнуться, п..ложиться",
                        Answer4 = "в..юнок, в..едливый, двух..ярусный",
                        AnswerRight = 2
                    },
                    new Question
                    {
                        QuestionId = 12,
                        TextQuestion = "Укажите ответ, в котором в обоих словах одного ряда пропущена одна и та же буква.",
                        Answer1 = "пр..обрёл, пр..образователь, сверх..нтересный",
                        Answer2 = "п..дсказывать, п..никнуть, д..ехать",
                        Answer3 = "и..древле, не..держанный, не..добровать",
                        Answer4 = "оп..знание, нер..створимый, п..йдём",
                        AnswerRight = 1
                    },
                    new Question
                    {
                        QuestionId = 13,
                        TextQuestion = "Укажите ответ, в котором в обоих словах одного ряда пропущена одна и та же буква.",
                        Answer1 = "пр..общиться, пр..школьный, пр..встать",
                        Answer2 = "вз..браться, п..забавить, р..ссказ",
                        Answer3 = "ни..вергать, и..черпать, в..дрогнуть",
                        Answer4 = "об..явить, с..ёмка, суб..ект",
                        AnswerRight = 0
                    },
                    new Question
                    {
                        QuestionId = 14,
                        TextQuestion = "Укажите ответ, в котором в обоих словах одного ряда пропущена одна и та же буква.",
                        Answer1 = "п..иск, неп..ддающийся, от..двинуть",
                        Answer2 = "ра..бросать, и..пуганный, бе..вольный",
                        Answer3 = "с..еденный, сер..ёзный, ад..ютант",
                        Answer4 = "нап..следок, н..слаждаться, д..браться",
                        AnswerRight = 0
                    },
                    new Question
                    {
                        QuestionId = 15,
                        TextQuestion = "Укажите ответ, в котором в обоих словах одного ряда пропущена одна и та же буква.",
                        Answer1 = "пр..бинтовать, пр..морский, пр..бывать (на станцию)",
                        Answer2 = "по..цепленный (вагон), о..гадать, на..кусить",
                        Answer3 = "ра..сеять, в..балтывать, бе..голосый",
                        Answer4 = "без..ндукционный, меж..гровой, с..мпровизировать",
                        AnswerRight = 0
                    },
                    new Question
                    {
                        QuestionId = 16,
                        TextQuestion = "Укажите ответ, в котором НЕ с выделенным словом пишется РАЗДЕЛЬНО.",
                        Answer1 = "Это был (НЕ)КТО иной, как мой друг Борька.",
                        Answer2 = "Щёки у неё были круглые и красные, а губы (НЕ)ЕСТЕСТВЕННО алые.",
                        Answer3 = "Было совершенно (НЕ)ЯСНО, почему они так долго смотрят на этот простой рисунок.",
                        Answer4 = "Почему-то нас он сразу (НЕ)ВЗЛЮБИЛ.",
                        AnswerRight = 0
                    },
                    new Question
                    {
                        QuestionId = 17,
                        TextQuestion = "Укажите ответ, в котором НЕ с выделенным словом пишется РАЗДЕЛЬНО.",
                        Answer1 = "Всё это свидетельствует о чрезвычайной доброте его тихого и ничуть (НЕ)ЗЛОПАМЯТНОГО сердца.",
                        Answer2 = "Оставив чай (НЕ)ДОПИТЫМ, Макар быстро собрался и пошёл в тайгу.",
                        Answer3 = "Оля что-то всё время (НЕ)ДОГОВАРИВАЛА нам, скрывала.",
                        Answer4 = "Он был человеком самостоятельным, абсолютно ни от кого (НЕ)ЗАВИСЯЩИМ.",
                        AnswerRight = 0
                    },
                    new Question
                    {
                        QuestionId = 18,
                        TextQuestion = "Укажите ответ, в котором все выделенные слова пишутся СЛИТНО.",
                        Answer1 = "(НА)ВЕРХУ великолепных палат сидел Атлант и держал на плечах небо (В)ВИДЕ шара, который был осыпан рубинами.",
                        Answer2 = "Снег под напором ветра летел (НА)ВСТРЕЧУ (В)ДОЛЬ улицы.",
                        Answer3 = "«Поезжай к князю Петру Ивановичу и подробно узнай, что и как»,  — сказал он одному из адъютантов и (В)СЛЕД (ЗА)ТЕМ обратился к принцу Виртембергскому.",
                        Answer4 = "(НА)ПРОТЯЖЕНИИ всего дня дети играли на лужайке, взрослые ТАК(ЖЕ) были во дворе.",
                        AnswerRight = 1
                    },
                    new Question
                    {
                        QuestionId = 19,
                        TextQuestion = "Укажите ответ, в котором все выделенные слова пишутся СЛИТНО.",
                        Answer1 = "Катя (С)НАЧАЛА решила посоветоваться с мамой и спросила, ЧТО(БЫ) та сделала на месте Кати.",
                        Answer2 = "Ночью полил такой сильный дождь, что мы все промокли (НА)СКВОЗЬ, но пробраться в деревню (ПО)ПРЕЖНЕМУ было невозможно.",
                        Answer3 = "Я был согласен с мнением Люси лишь (ОТ)ЧАСТИ, но спорить не стал, потому что (ПО)ПРОСТУ не хотел ссоры.",
                        Answer4 = "(ПО)СРЕДИ комнаты (В)ТЕЧЕНИЕ двадцати лет стоял один и тот же стол, покрытый всё той же кружевной скатертью.",
                        AnswerRight = 2
                    },
                    new Question
                    {
                        QuestionId = 20,
                        TextQuestion = "Укажите ответ, в котором все выделенные слова пишутся СЛИТНО.",
                        Answer1 = "В ТОТ(ЖЕ) день, когда Базаров в саду объяснял Аркадию, (ПО)ЧЕМУ не принялись молодые дубки, он познакомился с Фенечкой.",
                        Answer2 = "Но мне ТАК(ЖЕ) кажется, что Лежнёв не стал бы говорить (ПО)ПУСТУ, не взвесив то, что говорит.",
                        Answer3 = "Мы (ПО)ДОЛГУ сидели на берегу (В)ОБНИМКУ, молчали и слушали прибой.",
                        Answer4 = "Перед выездом Олег решил ВСЁ(ТАКИ) сообщить родителям о своём скором прибытии, дабы не застать их (В)РАСПЛОХ.",
                        AnswerRight = 1
                    }
            ) ;
        }
    }
}
