# KasperskyIntroTest

1. Надо сделать очередь с операциями push(T) и pop(T). Операции должны поддерживать обращение с разных потоков. Операция push всегда вставляет и выходит. Операция pop ждет пока не появится новый элемент. В качестве контейнера внутри можно использовать только стандартную очередь (Queue).
Очередь реализована в классе ConcurrentQueue

2. Есть коллекция чисел и отдельное число Х. Надо вывести все пары чисел, которые в сумме равны заданному Х.    
Реализовано отдельным классом Collection. Требуемая функция - FindAllPairs