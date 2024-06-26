# WhoWantsToBeAMillionaire
Реализованная программа предстваляет собой настольное приложение по мотивам телевизионного шоу «Кто хочет стать миллионером?» в соответствии с приведенными ниже правилами. Для хранения таблицы рекордов используется база данных SQLite. В таблице отображается 10 лучших результатов. 

# Правила игры
Для победы в игре игроку необходимо верно ответить на 15 вопросов из различных областей знаний. Каждый вопрос имеет 4 варианта ответа, из которых только один является верным. Сложность вопросов постоянно возрастает. Время на раздумье над каждым вопросом у игрока не ограничено.
Каждый из пятнадцати вопросов имеет конкретную денежную стоимость: 3 000 000, 1 500 000, 800 000, 400 000, 200 000, 100 000, 50 000, 25 000, 15 000, 10 000, 5 000, 3 000, 2 000, 1 000, 500.
Все суммы являются заменяемыми, то есть, ответив на следующий вопрос не суммируются с суммой за ответ на предыдущий. 
Игроку предлагаются 5 подсказок. Участники могут использовать только три из пяти подсказок по ходу игры.
1.	«Помощь зала» – каждый зритель в студии голосует за правильный, на его взгляд, ответ, а игроку предоставляется статистика голосования. 
2.	«50 на 50» – компьютер убирает два неправильных ответа. 
3.	«Звонок другу» – в течение 30 секунд игрок может посоветоваться с одним из пяти друзей, заявленных заранее.
4.	«Право на ошибку» – Игрок может дать два ответа на заданный вопрос. Если первый ответ игрока оказался правильным, подсказка всё равно считается использованной. 
5.	«Замена вопроса» – игрок может заменить вопрос на другой того же уровня и той же стоимости.
